using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using ExcelDataReader;

namespace SheetSwiper;

public static class Converter
{
  public static readonly Dictionary<string, string> ConverterErrors = new()
  {
      { "missing_header", @"SheetSwiper requires that the first row contain at least one sfm marker (e.g. \lx)." },
  };

  public static string Convert(string path)
  {
    StringBuilder builder = new();
    using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
    {
      using var reader = ExcelReaderFactory.CreateReader(stream);
      var result = reader.AsDataSet();
      var sheet = result.Tables[0];
      if (!CheckForSfmMarkerHeader(sheet))
      {
        Console.WriteLine("");
        return ConverterErrors["missing_header"];
      }

      for (int row = 1; row < sheet.Rows.Count; row++)
      {
        for (int col = 0; col < sheet.Columns.Count; col++)
        {
          var marker = sheet.Rows[0][col];
          if (marker is null or DBNull)
            continue;

          var cell = sheet.Rows[row][col];
          if (cell != null)
          {
            builder.AppendFormat("{0} {1}\r\n", marker, cell);
          }
        }
        builder.AppendLine();
      }
    }

    return builder.ToString();
  }

  private static bool CheckForSfmMarkerHeader(DataTable sheet)
  {
    for (int col = 0; col <= sheet.Columns.Count; col++)
    {
      var markerCell = sheet.Rows[0][col] as string;
      string marker = markerCell ?? string.Empty;
      if (marker.Trim().Length > 0 && marker.Trim()[0] == '\\')
      {
        return true; // found one
      }
    }
    return false;
  }
}