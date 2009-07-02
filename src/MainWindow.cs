using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ExcelLibrary.SpreadSheet;
using SheetSwiper;

namespace SheetSwipe
{
    public partial class MainWindow : Form
    {
        private const string _busyMessage = "That file appears to already be open, probably in Excel. First close it, then drag it here.";
        private bool _fileLoaded=false;

        public MainWindow()
        {
            InitializeComponent();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Settings1.Default.Save();
            base.OnClosing(e);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OnDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
                return;

            string path = GetPathFromDropEvent(e);
            if (string.IsNullOrEmpty(path))
                return;
                
            if (IsAlreadyOpenElsewhere(path))
            {

                _dragStatus.Text = _busyMessage;
                _dragStatus.Visible = true;
                return;
            }

            this.BackColor = Color.Cornsilk;
            //this._dragStatus.BackColor = this.BackColor;
            e.Effect = DragDropEffects.Copy;
            
        }

        private bool IsAlreadyOpenElsewhere(string path)
        {
            try
            {
                using (FileStream strm = File.OpenRead(path))
                {
                    strm.Close();
                    return false;
                }
            }
            catch (Exception e)
            {
                return true;
            }
        }

        private void OnDragLeave(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            this.BackColor = SystemColors.Control;
            UpdateConvertTabDisplay();
            UpdateReviewTapDisplay();
        }

        private void UpdateConvertTabDisplay()
        {
            _dragStatus.Visible = false;
           // _linkChooseFile.Enabled = false;           
            UpdateLinkForConvertingPrevious();
            UpdateLinkForConvertAndSave();
            _dragStatus.MaximumSize = new Size(_convertPage.Width - 70, _dragStatus.MaximumSize.Height);
        }

        private void UpdateLinkForConvertAndSave()
        {
            _labelDone.Visible = false;
            _linkConvertAndSave.Visible = _linkConvertPrevious.Visible 
                                          && !string.IsNullOrEmpty(Settings1.Default.PreviousSavePath)
                                          && Directory.Exists(Path.GetDirectoryName(Settings1.Default.PreviousSheetPath));

            if (_linkConvertAndSave.Visible)
            {
                _linkConvertAndSave.Text =
                    String.Format("Convert {0} to {1} without asking any questions.", Path.GetFileName(Settings1.Default.PreviousSheetPath), Path.GetFileName(Settings1.Default.PreviousSavePath));
            }
            _labelOrForConvertAndSave.Visible = _linkConvertAndSave.Visible;
        }

        private void UpdateLinkForConvertingPrevious()
        {
            bool doShowIt = !string.IsNullOrEmpty(Settings1.Default.PreviousSheetPath)
                            && File.Exists(Settings1.Default.PreviousSheetPath);
            
            //nb: this doesn't work if the tab that holds this link isn't the selected one
            //when this code runs
            _linkConvertPrevious.Visible = doShowIt;
            if (doShowIt)
            {
                _linkConvertPrevious.Text =
                    String.Format("Convert {0}", Path.GetFileName(Settings1.Default.PreviousSheetPath));
            }
            _labelOrForConvert.Visible = _linkConvertPrevious.Visible;
        }

        private void UpdateReviewTapDisplay()
        {
            _output.Visible = _fileLoaded;
            _labelFont.Enabled = _fileLoaded;
            _saveButton.Enabled = _fileLoaded;
            _fontChooser.Enabled = _fileLoaded;
        }

        private bool Convert(string path)
        {
            if (IsAlreadyOpenElsewhere(path))
            {
                MessageBox.Show("That file appears to be open, probably in Excel. First close it, then try again.","Whoops", MessageBoxButtons.OK);
                return false;
            }
            try
            {
                StringBuilder builder = new StringBuilder();
        //        using (Stream fileStream = File.OpenRead(path))
                {
                    Workbook book = Workbook.Open(path);
                    Worksheet sheet = book.Worksheets[0];
                    if (!CheckForSfmMarkerHeader(sheet))
                    {
                        MessageBox.Show(@"SheetSwiper requires that the first row contain at least one sfm marker (e.g. \lx).", "Whoops", MessageBoxButtons.OK);
                        return false;
                    }

                    for (int row = 1; row <= sheet.Cells.LastRowIndex; row++)
                    {
                        for (int col = 0; col <= sheet.Cells.LastColIndex; col++)
                        {
                            Cell markerCell = sheet.Cells[0, col];
                            string marker = markerCell == null ? string.Empty : markerCell.StringValue;

                            Cell cell = sheet.Cells[row, col];
                            if (!string.IsNullOrEmpty(marker) && cell != null)
                            {
                                builder.AppendFormat("{0} {1}\r\n", marker, cell.StringValue);
                            }
                        }
                        builder.AppendLine();
                    }
                  //  fileStream.Close();
                }
                _output.Text = builder.ToString();
                _output.Select(0, 0);
                _saveButton.Select();
                _fileLoaded = true;

                if (Settings1.Default.PreviousSheetPath != path)
                {
                    Settings1.Default.PreviousSheetPath = path;
                    //the source has changed, so don't assume we want to go to the same target
                    Settings1.Default.PreviousSavePath  = null;

                }
                UpdateDisplay();
            }
            catch (Exception error)
            {
                MessageBox.Show("SheetSwiper was unable to read that file.\r\n"+error.Message, "Whoops", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private bool CheckForSfmMarkerHeader(Worksheet sheet)
        {
            for (int col = 0; col <= sheet.Cells.LastColIndex; col++)
            {
                Cell markerCell = sheet.Cells[0, col];
                string marker = markerCell == null ? string.Empty : markerCell.StringValue;
                if (marker.Trim().Length > 0 && marker.Trim()[0] == '\\')
                {
                    return true; // found one
                }
            }
            return false;
        }

        private void OnDragDrop(object sender, DragEventArgs e)
        {
          string s = GetPathFromDropEvent(e);

           if (string.IsNullOrEmpty(s))
           {
               return;
           }
            _dragStatus.Text = "Converting...";
           _dragStatus.Invalidate();
           // Extract string from first array element
           // (ignore all files except first if number of files are dropped).
           if (Convert(s))
           {
               _tabControl.SelectedTab = _reviewPage;
           }
        }

        private string GetPathFromDropEvent(DragEventArgs e)
        {
           Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
           if (a == null)
           {
               return null;
           }

            return a.GetValue(0).ToString();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            _output.Visible = false;

            foreach (FontFamily family in System.Drawing.FontFamily.Families)
            {
                _fontChooser.Items.Add(family.Name);
                if(family.Name.ToLower().Contains("doulos sil"))
                {
                    _fontChooser.SelectedIndex = _fontChooser.Items.Count - 1;
                    
                }
            }
            UpdateDisplay();
            _output.Select();

        }

        private void OnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Title = "Save SFM file...";
            d.AddExtension = true;
            d.Filter = "SFM files (*.db)|*.db|All files (*.*)|*.*";
            if (!string.IsNullOrEmpty(Settings1.Default.PreviousSavePath)
                && File.Exists(Settings1.Default.PreviousSavePath))
            {
                d.FileName = Settings1.Default.PreviousSavePath;
            }
            else
            {
                d.InitialDirectory  = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
            
            if (DialogResult.OK != d.ShowDialog())
            {
                return;
            }
            //little sanity check
            if (Path.GetExtension(d.FileName) == ".xls")
            {
                MessageBox.Show("Whoa there... SheetSwiper cannot write spreadsheets, only text files. Your file has not been saved.", "Whoops", MessageBoxButtons.OK);
                return;
            }
            Save(d.FileName);
            UpdateDisplay();
        }

        private void Save( string path)
        {
            try
            {
                File.WriteAllText(path, _output.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("SheetSwiper was unable to save to '"+path+"'. \r\n"+error.Message, "Whoops", MessageBoxButtons.OK);
                return;
            }
            Settings1.Default.PreviousSavePath = path;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void OnFontChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_fontChooser.SelectedIndex < 0)
                return;

            try
            {
                _output.Font = new Font(_fontChooser.SelectedItem.ToString(), 12);
            }
            catch(Exception)
            {
            }
        }

        private void _linkConvertPrevious_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Convert(Settings1.Default.PreviousSheetPath))
            {
                _tabControl.SelectedTab = _reviewPage;
            }
        }

        private void tabPage1_Resize(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void _linkConvertAndSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Convert(Settings1.Default.PreviousSheetPath))
            {
                Save(Settings1.Default.PreviousSavePath);
                _labelDone.Visible = true;
            }
        }

        private void MainWindow_Deactivate(object sender, EventArgs e)
        {
            //clear this once they switch to another app
            _labelDone.Visible = false;
        }

        private void _tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void _linkChooseFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.CheckPathExists = true;
            dialog.CheckFileExists = true;
            dialog.AddExtension = true;
            dialog.Filter = "Excel 97-2003 Workbook (*.xls)|*.xls";

            if (!string.IsNullOrEmpty(Settings1.Default.PreviousSheetPath)
                && Directory.Exists(Path.GetDirectoryName(Settings1.Default.PreviousSheetPath)))
            {
                dialog.InitialDirectory = Path.GetDirectoryName(Settings1.Default.PreviousSheetPath);              
            }
            else
            {
                dialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
            if (DialogResult.OK != dialog.ShowDialog())
            {
                return;
            }
            if(Convert(dialog.FileName))
            {
                _tabControl.SelectedTab = _reviewPage;
            }
        }
    }
}