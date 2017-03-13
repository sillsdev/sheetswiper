namespace SheetSwipe
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this._tabControl = new System.Windows.Forms.TabControl();
            this._convertPage = new System.Windows.Forms.TabPage();
            this._labelDone = new System.Windows.Forms.Label();
            this._linkChooseFile = new System.Windows.Forms.LinkLabel();
            this._linkConvertAndSave = new System.Windows.Forms.LinkLabel();
            this._labelOrForConvertAndSave = new System.Windows.Forms.Label();
            this._linkConvertPrevious = new System.Windows.Forms.LinkLabel();
            this._labelOrForConvert = new System.Windows.Forms.Label();
            this._dragStatus = new System.Windows.Forms.Label();
            this._labelDragDirections = new System.Windows.Forms.Label();
            this._reviewPage = new System.Windows.Forms.TabPage();
            this._saveButton = new System.Windows.Forms.Button();
            this._fontChooser = new System.Windows.Forms.ComboBox();
            this._labelFont = new System.Windows.Forms.Label();
            this._output = new System.Windows.Forms.TextBox();
            this._tabControl.SuspendLayout();
            this._convertPage.SuspendLayout();
            this._reviewPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(21, 308);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(110, 13);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "About Sheet Swiper...";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // _tabControl
            // 
            this._tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tabControl.Controls.Add(this._convertPage);
            this._tabControl.Controls.Add(this._reviewPage);
            this._tabControl.Location = new System.Drawing.Point(8, 9);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(477, 288);
            this._tabControl.TabIndex = 7;
            this._tabControl.SelectedIndexChanged += new System.EventHandler(this._tabControl_SelectedIndexChanged);
            // 
            // _convertPage
            // 
            this._convertPage.Controls.Add(this._labelDone);
            this._convertPage.Controls.Add(this._linkChooseFile);
            this._convertPage.Controls.Add(this._linkConvertAndSave);
            this._convertPage.Controls.Add(this._labelOrForConvertAndSave);
            this._convertPage.Controls.Add(this._linkConvertPrevious);
            this._convertPage.Controls.Add(this._labelOrForConvert);
            this._convertPage.Controls.Add(this._dragStatus);
            this._convertPage.Controls.Add(this._labelDragDirections);
            this._convertPage.Location = new System.Drawing.Point(4, 22);
            this._convertPage.Name = "_convertPage";
            this._convertPage.Padding = new System.Windows.Forms.Padding(3);
            this._convertPage.Size = new System.Drawing.Size(469, 262);
            this._convertPage.TabIndex = 0;
            this._convertPage.Text = "Convert";
            this._convertPage.UseVisualStyleBackColor = true;
            this._convertPage.Resize += new System.EventHandler(this.tabPage1_Resize);
            // 
            // _labelDone
            // 
            this._labelDone.AutoSize = true;
            this._labelDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelDone.Location = new System.Drawing.Point(56, 162);
            this._labelDone.Name = "_labelDone";
            this._labelDone.Size = new System.Drawing.Size(57, 20);
            this._labelDone.TabIndex = 11;
            this._labelDone.Text = "Done.";
            // 
            // _linkChooseFile
            // 
            this._linkChooseFile.AutoSize = true;
            this._linkChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._linkChooseFile.Location = new System.Drawing.Point(42, 37);
            this._linkChooseFile.Name = "_linkChooseFile";
            this._linkChooseFile.Size = new System.Drawing.Size(292, 17);
            this._linkChooseFile.TabIndex = 0;
            this._linkChooseFile.TabStop = true;
            this._linkChooseFile.Text = "Choose an excel spreadsheet file to convert, ";
            this._linkChooseFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._linkChooseFile_LinkClicked);
            // 
            // _linkConvertAndSave
            // 
            this._linkConvertAndSave.AutoSize = true;
            this._linkConvertAndSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._linkConvertAndSave.Location = new System.Drawing.Point(58, 136);
            this._linkConvertAndSave.Name = "_linkConvertAndSave";
            this._linkConvertAndSave.Size = new System.Drawing.Size(306, 17);
            this._linkConvertAndSave.TabIndex = 3;
            this._linkConvertAndSave.TabStop = true;
            this._linkConvertAndSave.Text = "Convert {0} to {1} without asking any questions.";
            this._linkConvertAndSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._linkConvertAndSave_LinkClicked);
            // 
            // _labelOrForConvertAndSave
            // 
            this._labelOrForConvertAndSave.AutoSize = true;
            this._labelOrForConvertAndSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelOrForConvertAndSave.Location = new System.Drawing.Point(42, 136);
            this._labelOrForConvertAndSave.Name = "_labelOrForConvertAndSave";
            this._labelOrForConvertAndSave.Size = new System.Drawing.Size(21, 17);
            this._labelOrForConvertAndSave.TabIndex = 6;
            this._labelOrForConvertAndSave.Text = "or";
            // 
            // _linkConvertPrevious
            // 
            this._linkConvertPrevious.AutoSize = true;
            this._linkConvertPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._linkConvertPrevious.Location = new System.Drawing.Point(58, 99);
            this._linkConvertPrevious.Name = "_linkConvertPrevious";
            this._linkConvertPrevious.Size = new System.Drawing.Size(79, 17);
            this._linkConvertPrevious.TabIndex = 2;
            this._linkConvertPrevious.TabStop = true;
            this._linkConvertPrevious.Text = "Convert {0}";
            this._linkConvertPrevious.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._linkConvertPrevious_LinkClicked);
            // 
            // _labelOrForConvert
            // 
            this._labelOrForConvert.AutoSize = true;
            this._labelOrForConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelOrForConvert.Location = new System.Drawing.Point(42, 99);
            this._labelOrForConvert.Name = "_labelOrForConvert";
            this._labelOrForConvert.Size = new System.Drawing.Size(21, 17);
            this._labelOrForConvert.TabIndex = 6;
            this._labelOrForConvert.Text = "or";
            // 
            // _dragStatus
            // 
            this._dragStatus.AutoSize = true;
            this._dragStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dragStatus.Location = new System.Drawing.Point(41, 192);
            this._dragStatus.Name = "_dragStatus";
            this._dragStatus.Size = new System.Drawing.Size(125, 20);
            this._dragStatus.TabIndex = 7;
            this._dragStatus.Text = "Drag Message";
            // 
            // _labelDragDirections
            // 
            this._labelDragDirections.AutoSize = true;
            this._labelDragDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelDragDirections.Location = new System.Drawing.Point(42, 68);
            this._labelDragDirections.Name = "_labelDragDirections";
            this._labelDragDirections.Size = new System.Drawing.Size(326, 17);
            this._labelDragDirections.TabIndex = 1;
            this._labelDragDirections.Text = "or drag an excel spreadsheet file onto this window.";
            // 
            // _reviewPage
            // 
            this._reviewPage.Controls.Add(this._saveButton);
            this._reviewPage.Controls.Add(this._fontChooser);
            this._reviewPage.Controls.Add(this._labelFont);
            this._reviewPage.Controls.Add(this._output);
            this._reviewPage.Location = new System.Drawing.Point(4, 22);
            this._reviewPage.Name = "_reviewPage";
            this._reviewPage.Padding = new System.Windows.Forms.Padding(3);
            this._reviewPage.Size = new System.Drawing.Size(469, 262);
            this._reviewPage.TabIndex = 1;
            this._reviewPage.Text = "Review";
            this._reviewPage.UseVisualStyleBackColor = true;
            // 
            // _saveButton
            // 
            this._saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._saveButton.Location = new System.Drawing.Point(368, 233);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(98, 23);
            this._saveButton.TabIndex = 0;
            this._saveButton.Text = "Save SFM...";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.OnSave_Click);
            // 
            // _fontChooser
            // 
            this._fontChooser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._fontChooser.FormattingEnabled = true;
            this._fontChooser.Location = new System.Drawing.Point(49, 13);
            this._fontChooser.Name = "_fontChooser";
            this._fontChooser.Size = new System.Drawing.Size(158, 21);
            this._fontChooser.Sorted = true;
            this._fontChooser.TabIndex = 1;
            this._fontChooser.SelectedIndexChanged += new System.EventHandler(this.OnFontChooser_SelectedIndexChanged);
            // 
            // _labelFont
            // 
            this._labelFont.AutoSize = true;
            this._labelFont.Location = new System.Drawing.Point(3, 16);
            this._labelFont.Name = "_labelFont";
            this._labelFont.Size = new System.Drawing.Size(31, 13);
            this._labelFont.TabIndex = 8;
            this._labelFont.Text = "Font:";
            // 
            // _output
            // 
            this._output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._output.BackColor = System.Drawing.Color.White;
            this._output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._output.Location = new System.Drawing.Point(6, 43);
            this._output.Multiline = true;
            this._output.Name = "_output";
            this._output.ReadOnly = true;
            this._output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._output.Size = new System.Drawing.Size(457, 184);
            this._output.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 330);
            this.Controls.Add(this._tabControl);
            this.Controls.Add(this.linkLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Sheet Swiper";
            this.Deactivate += new System.EventHandler(this.MainWindow_Deactivate);
            this.Load += new System.EventHandler(this.OnLoad);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            this.DragLeave += new System.EventHandler(this.OnDragLeave);
            this._tabControl.ResumeLayout(false);
            this._convertPage.ResumeLayout(false);
            this._convertPage.PerformLayout();
            this._reviewPage.ResumeLayout(false);
            this._reviewPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _convertPage;
        private System.Windows.Forms.LinkLabel _linkChooseFile;
        private System.Windows.Forms.LinkLabel _linkConvertPrevious;
        private System.Windows.Forms.Label _labelOrForConvert;
        private System.Windows.Forms.Label _labelDragDirections;
        private System.Windows.Forms.TabPage _reviewPage;
        private System.Windows.Forms.ComboBox _fontChooser;
        private System.Windows.Forms.Label _labelFont;
        private System.Windows.Forms.TextBox _output;
        private System.Windows.Forms.Label _dragStatus;
        private System.Windows.Forms.LinkLabel _linkConvertAndSave;
        private System.Windows.Forms.Label _labelOrForConvertAndSave;
        private System.Windows.Forms.Label _labelDone;
        private System.Windows.Forms.Button _saveButton;
    }
}