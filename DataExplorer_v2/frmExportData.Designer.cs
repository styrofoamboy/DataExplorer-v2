namespace DataExplorer
{
    partial class frmExportData
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
            System.Drawing.Drawing2D.GraphicsPath graphicsPath3 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath2 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpgWelcome = new System.Windows.Forms.TabPage();
            this.tpgDest = new System.Windows.Forms.TabPage();
            this.cmdExport = new RainstormStudios.Controls.AdvancedButton();
            this.drpDstFormatType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpgSrc = new System.Windows.Forms.TabPage();
            this.tpgSrcDetail = new System.Windows.Forms.TabPage();
            this.tpgMappings = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panHdr = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lstSrcTables = new System.Windows.Forms.CheckedListBox();
            this.cmdSelAll = new RainstormStudios.Controls.AdvancedButton();
            this.cmdSelNone = new RainstormStudios.Controls.AdvancedButton();
            this.fsbDest = new RainstormStudios.Controls.FolderSelectBox();
            this.tabControl1.SuspendLayout();
            this.tpgWelcome.SuspendLayout();
            this.tpgDest.SuspendLayout();
            this.tpgSrcDetail.SuspendLayout();
            this.panHdr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tpgWelcome);
            this.tabControl1.Controls.Add(this.tpgSrc);
            this.tabControl1.Controls.Add(this.tpgSrcDetail);
            this.tabControl1.Controls.Add(this.tpgDest);
            this.tabControl1.Controls.Add(this.tpgMappings);
            this.tabControl1.Location = new System.Drawing.Point(12, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 361);
            this.tabControl1.TabIndex = 0;
            // 
            // tpgWelcome
            // 
            this.tpgWelcome.BackColor = System.Drawing.Color.White;
            this.tpgWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpgWelcome.Controls.Add(this.pictureBox1);
            this.tpgWelcome.Controls.Add(this.label2);
            this.tpgWelcome.Location = new System.Drawing.Point(4, 25);
            this.tpgWelcome.Name = "tpgWelcome";
            this.tpgWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tpgWelcome.Size = new System.Drawing.Size(583, 332);
            this.tpgWelcome.TabIndex = 0;
            this.tpgWelcome.Text = "Welcome";
            // 
            // tpgDest
            // 
            this.tpgDest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpgDest.Controls.Add(this.fsbDest);
            this.tpgDest.Controls.Add(this.label1);
            this.tpgDest.Controls.Add(this.drpDstFormatType);
            this.tpgDest.Location = new System.Drawing.Point(4, 25);
            this.tpgDest.Name = "tpgDest";
            this.tpgDest.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDest.Size = new System.Drawing.Size(583, 332);
            this.tpgDest.TabIndex = 1;
            this.tpgDest.Text = "Destination";
            this.tpgDest.UseVisualStyleBackColor = true;
            // 
            // cmdExport
            // 
            this.cmdExport.AllowWordWrap = false;
            this.cmdExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdExport.BackgroundRotationDegrees = 0F;
            this.cmdExport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdExport.BorderWidth = 1;
            graphicsPath3.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdExport.ButtonShape = graphicsPath3;
            this.cmdExport.CornerFeather = 3;
            this.cmdExport.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdExport.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdExport.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdExport.HighlightMultiplier = 2F;
            this.cmdExport.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdExport.HoverHighlightOpacity = 200;
            this.cmdExport.HoverImage = null;
            this.cmdExport.ImagePadding = 0;
            this.cmdExport.Location = new System.Drawing.Point(496, 435);
            this.cmdExport.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdExport.MouseDownImage = null;
            this.cmdExport.MultiSample = true;
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(103, 23);
            this.cmdExport.TabIndex = 1;
            this.cmdExport.Text = "Finished";
            this.cmdExport.TextOutline = false;
            this.cmdExport.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdExport.TextOutlineOpacity = 255;
            this.cmdExport.TextOutlineWeight = 2F;
            this.cmdExport.TextRotationDegrees = 0F;
            this.cmdExport.TextShadow = false;
            this.cmdExport.TextShadowOffset = 1F;
            this.cmdExport.TextShadowOpacity = 80;
            this.cmdExport.TextVeritcal = false;
            this.cmdExport.ThreeDEffectDepth = 50;
            this.cmdExport.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdExport.UseVisualStyleBackColor = true;
            this.cmdExport.Click += new System.EventHandler(this.cmdFinished_onClick);
            // 
            // drpDstFormatType
            // 
            this.drpDstFormatType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drpDstFormatType.Enabled = false;
            this.drpDstFormatType.FormattingEnabled = true;
            this.drpDstFormatType.Items.AddRange(new object[] {
            "Delimited",
            "Fixed",
            "Ragged Right"});
            this.drpDstFormatType.Location = new System.Drawing.Point(323, 76);
            this.drpDstFormatType.Name = "drpDstFormatType";
            this.drpDstFormatType.Size = new System.Drawing.Size(152, 21);
            this.drpDstFormatType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Format";
            // 
            // tpgSrc
            // 
            this.tpgSrc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpgSrc.Location = new System.Drawing.Point(4, 25);
            this.tpgSrc.Name = "tpgSrc";
            this.tpgSrc.Padding = new System.Windows.Forms.Padding(3);
            this.tpgSrc.Size = new System.Drawing.Size(583, 332);
            this.tpgSrc.TabIndex = 2;
            this.tpgSrc.Text = "Source";
            this.tpgSrc.UseVisualStyleBackColor = true;
            // 
            // tpgSrcDetail
            // 
            this.tpgSrcDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpgSrcDetail.Controls.Add(this.cmdSelNone);
            this.tpgSrcDetail.Controls.Add(this.cmdSelAll);
            this.tpgSrcDetail.Controls.Add(this.lstSrcTables);
            this.tpgSrcDetail.Location = new System.Drawing.Point(4, 25);
            this.tpgSrcDetail.Name = "tpgSrcDetail";
            this.tpgSrcDetail.Size = new System.Drawing.Size(583, 332);
            this.tpgSrcDetail.TabIndex = 3;
            this.tpgSrcDetail.Text = "Source Data";
            this.tpgSrcDetail.UseVisualStyleBackColor = true;
            // 
            // tpgMappings
            // 
            this.tpgMappings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpgMappings.Location = new System.Drawing.Point(4, 25);
            this.tpgMappings.Name = "tpgMappings";
            this.tpgMappings.Size = new System.Drawing.Size(583, 332);
            this.tpgMappings.TabIndex = 4;
            this.tpgMappings.Text = "Mappings";
            this.tpgMappings.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to my imcomplete data export wizard!";
            // 
            // panHdr
            // 
            this.panHdr.BackColor = System.Drawing.Color.White;
            this.panHdr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panHdr.Controls.Add(this.pictureBox2);
            this.panHdr.Controls.Add(this.label3);
            this.panHdr.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHdr.Location = new System.Drawing.Point(0, 0);
            this.panHdr.Name = "panHdr";
            this.panHdr.Size = new System.Drawing.Size(615, 62);
            this.panHdr.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Incomplete Data Exporter Wizard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataExplorer.Properties.Resources.Final_Composite02_11_23_071;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::DataExplorer.Properties.Resources.Thumb_11_23_072;
            this.pictureBox2.Location = new System.Drawing.Point(547, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lstSrcTables
            // 
            this.lstSrcTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstSrcTables.CheckOnClick = true;
            this.lstSrcTables.FormattingEnabled = true;
            this.lstSrcTables.IntegralHeight = false;
            this.lstSrcTables.Location = new System.Drawing.Point(3, 3);
            this.lstSrcTables.Name = "lstSrcTables";
            this.lstSrcTables.ScrollAlwaysVisible = true;
            this.lstSrcTables.Size = new System.Drawing.Size(270, 300);
            this.lstSrcTables.TabIndex = 0;
            // 
            // cmdSelAll
            // 
            this.cmdSelAll.AllowWordWrap = false;
            this.cmdSelAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdSelAll.BackgroundRotationDegrees = 0F;
            this.cmdSelAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdSelAll.BorderWidth = 1;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdSelAll.ButtonShape = graphicsPath2;
            this.cmdSelAll.CornerFeather = 6;
            this.cmdSelAll.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdSelAll.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdSelAll.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdSelAll.HighlightMultiplier = 2F;
            this.cmdSelAll.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdSelAll.HoverHighlightOpacity = 200;
            this.cmdSelAll.HoverImage = null;
            this.cmdSelAll.ImagePadding = 0;
            this.cmdSelAll.Location = new System.Drawing.Point(3, 309);
            this.cmdSelAll.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdSelAll.MouseDownImage = null;
            this.cmdSelAll.MultiSample = true;
            this.cmdSelAll.Name = "cmdSelAll";
            this.cmdSelAll.Size = new System.Drawing.Size(75, 16);
            this.cmdSelAll.TabIndex = 1;
            this.cmdSelAll.Text = "Select All";
            this.cmdSelAll.TextOutline = false;
            this.cmdSelAll.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdSelAll.TextOutlineOpacity = 255;
            this.cmdSelAll.TextOutlineWeight = 2F;
            this.cmdSelAll.TextRotationDegrees = 0F;
            this.cmdSelAll.TextShadow = false;
            this.cmdSelAll.TextShadowOffset = 1F;
            this.cmdSelAll.TextShadowOpacity = 80;
            this.cmdSelAll.TextVeritcal = false;
            this.cmdSelAll.ThreeDEffectDepth = 50;
            this.cmdSelAll.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdSelAll.UseVisualStyleBackColor = true;
            this.cmdSelAll.Click += new System.EventHandler(this.cmdSelAll_Click);
            // 
            // cmdSelNone
            // 
            this.cmdSelNone.AllowWordWrap = false;
            this.cmdSelNone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdSelNone.BackgroundRotationDegrees = 0F;
            this.cmdSelNone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdSelNone.BorderWidth = 1;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdSelNone.ButtonShape = graphicsPath1;
            this.cmdSelNone.CornerFeather = 6;
            this.cmdSelNone.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdSelNone.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdSelNone.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdSelNone.HighlightMultiplier = 2F;
            this.cmdSelNone.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdSelNone.HoverHighlightOpacity = 200;
            this.cmdSelNone.HoverImage = null;
            this.cmdSelNone.ImagePadding = 0;
            this.cmdSelNone.Location = new System.Drawing.Point(84, 309);
            this.cmdSelNone.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdSelNone.MouseDownImage = null;
            this.cmdSelNone.MultiSample = true;
            this.cmdSelNone.Name = "cmdSelNone";
            this.cmdSelNone.Size = new System.Drawing.Size(75, 16);
            this.cmdSelNone.TabIndex = 2;
            this.cmdSelNone.Text = "Select None";
            this.cmdSelNone.TextOutline = false;
            this.cmdSelNone.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdSelNone.TextOutlineOpacity = 255;
            this.cmdSelNone.TextOutlineWeight = 2F;
            this.cmdSelNone.TextRotationDegrees = 0F;
            this.cmdSelNone.TextShadow = false;
            this.cmdSelNone.TextShadowOffset = 1F;
            this.cmdSelNone.TextShadowOpacity = 80;
            this.cmdSelNone.TextVeritcal = false;
            this.cmdSelNone.ThreeDEffectDepth = 50;
            this.cmdSelNone.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdSelNone.UseVisualStyleBackColor = true;
            this.cmdSelNone.Click += new System.EventHandler(this.cmdSelNone_Click);
            // 
            // fsbDest
            // 
            this.fsbDest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fsbDest.CreateNewFolderButton = true;
            this.fsbDest.DialogTitle = "Select Destination Folder";
            this.fsbDest.GlobalBackgroundColor = System.Drawing.SystemColors.Window;
            this.fsbDest.GlobalFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.fsbDest.GlobalForegroundColor = System.Drawing.SystemColors.WindowText;
            this.fsbDest.Location = new System.Drawing.Point(45, 30);
            this.fsbDest.MinimumSize = new System.Drawing.Size(280, 40);
            this.fsbDest.Name = "fsbDest";
            this.fsbDest.RootFolder = System.Environment.SpecialFolder.Desktop;
            this.fsbDest.SelectedPath = "";
            this.fsbDest.Size = new System.Drawing.Size(472, 40);
            this.fsbDest.TabIndex = 3;
            // 
            // frmExportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(615, 470);
            this.Controls.Add(this.panHdr);
            this.Controls.Add(this.cmdExport);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmExportData";
            this.Text = "Data Export Wizard";
            this.tabControl1.ResumeLayout(false);
            this.tpgWelcome.ResumeLayout(false);
            this.tpgWelcome.PerformLayout();
            this.tpgDest.ResumeLayout(false);
            this.tpgDest.PerformLayout();
            this.tpgSrcDetail.ResumeLayout(false);
            this.panHdr.ResumeLayout(false);
            this.panHdr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpgWelcome;
        private System.Windows.Forms.TabPage tpgDest;
        private RainstormStudios.Controls.AdvancedButton cmdExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpDstFormatType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpgSrc;
        private System.Windows.Forms.TabPage tpgSrcDetail;
        private System.Windows.Forms.TabPage tpgMappings;
        private System.Windows.Forms.Panel panHdr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckedListBox lstSrcTables;
        private RainstormStudios.Controls.AdvancedButton cmdSelNone;
        private RainstormStudios.Controls.AdvancedButton cmdSelAll;
        private RainstormStudios.Controls.FolderSelectBox fsbDest;
    }
}