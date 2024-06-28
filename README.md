Sheet Swiper converts spreadsheets containing linguistic data to Standard Format (for use with Linguist's Toolbox, Phonology Assistant, Lexique Pro, FLex, WeSay, etc.). The rules for how to do the conversion come from the first rows of the spreadsheet itself, so subsequent, repeated conversions are easy for non-computer savvy users to do.

## How to use

In your spreadsheet, insert a row at the beginnning. For each column, fill this first row with the sfm markers you want to use for the data in that column. Omit markers from columns you don't want to include in the sfm. The first marker (usually in column A) will be used as the record marker.

Save the XLSX file and close it.

Now run Sheet Swiper and use one of its options to locate the file, convert it, and save it. I like to just drag files onto the Sheet Swiper window.

Sheetswiper has been tested with Microsoft Excel and Libre Office.

## Downloads
https://github.com/sillsdev/sheetswiper/releases

## Changelog

v2.0 - Requires Windows 10 or greater (.NET 8). Can read both xlsx and xls files.
v1.x - Works on any Windows with .Net 3.5.  Can only read xls files.

## Screenshots

Given this spreadsheet:

![image](https://cloud.githubusercontent.com/assets/8448/25486409/47d68692-2b1e-11e7-9b57-1094f0ed3ad4.png)

We drag that file in and convert:

![image](https://cloud.githubusercontent.com/assets/8448/25486359/2403ef7a-2b1e-11e7-9ca0-6edb77903279.png)

Then "review" tab shows what we'll get:

![image](https://cloud.githubusercontent.com/assets/8448/25486338/11e5b08a-2b1e-11e7-91cb-a84e49613852.png)

## Developers

This project is built using the .Net 8 SDK

```
dotnet build src\SheetSwiper.sln
```

```
dotnet run --project src\SheetSwiper.csproj
```

### Run tests
```
dotnet test src\SheetSwiper.sln
```