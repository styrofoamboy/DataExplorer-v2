namespace DataExplorer
{
    partial class DataTarget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Drawing.Drawing2D.GraphicsPath graphicsPath5 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath6 = new System.Drawing.Drawing2D.GraphicsPath();
            this.pan02drpDataSource = new System.Windows.Forms.ComboBox();
            this.pan02lblDataSource = new System.Windows.Forms.Label();
            this.pan02panFlatSrcSettings = new System.Windows.Forms.Panel();
            this.pan02lstFlatSrcSettings = new System.Windows.Forms.ListBox();
            this.pan02panFlatSrcFile = new System.Windows.Forms.Panel();
            this.pan02cmdFlatSrcFileBrowse = new RainstormStudios.Controls.AdvancedButton();
            this.pan02txtFlatSrcFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pan02FlatSrcFilePanFormat = new System.Windows.Forms.Panel();
            this.pan02chkFlatSrcColNameFirstRow = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pan02numFlatSrc = new System.Windows.Forms.NumericUpDown();
            this.pan02cboFlatSrcHdrRowQual = new System.Windows.Forms.ComboBox();
            this.pan02txtFlatSrcTextQual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pan02drpFlatSrcFormat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pan02drpFlatSrcCodePage = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pan02panFlatSrcPreview = new System.Windows.Forms.Panel();
            this.pan02panFlatSrcPreviewLnkRefresh = new System.Windows.Forms.LinkLabel();
            this.pan02panFlatSrcPreviewDg = new System.Windows.Forms.DataGrid();
            this.pan02lblFlatSrcPrevRowNums = new System.Windows.Forms.Label();
            this.pan02panFlatSrcPreviewNumRowSkip = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pan02panFlatSrcColConfig = new System.Windows.Forms.Panel();
            this.pan02cmdFlatSrcResetCol = new RainstormStudios.Controls.AdvancedButton();
            this.pan02lstFlatSrcColPrev = new System.Windows.Forms.ListView();
            this.colColumnName = new System.Windows.Forms.ColumnHeader();
            this.colDataType = new System.Windows.Forms.ColumnHeader();
            this.colFieldSize = new System.Windows.Forms.ColumnHeader();
            this.pan02grpFlatSrcDelim = new System.Windows.Forms.GroupBox();
            this.pan02lblFlatSrcColDelim = new System.Windows.Forms.Label();
            this.pan02lblFlatSrcRowDelim = new System.Windows.Forms.Label();
            this.pan02cboFlatSrcColDelim = new System.Windows.Forms.ComboBox();
            this.pan02cboFlatSrcRowDelim = new System.Windows.Forms.ComboBox();
            this.pan02panSqlSrc = new System.Windows.Forms.Panel();
            this.pan02cboSqlSrcDb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pan02panSqlSrcgrpSqlAuth = new System.Windows.Forms.GroupBox();
            this.pan02panSqlSrcAuth = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pan02rdoSqlSrcSqlAuth = new System.Windows.Forms.RadioButton();
            this.pan02rdoSqlSrcWinAuth = new System.Windows.Forms.RadioButton();
            this.cboServerName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pan02panFlatSrcSettings.SuspendLayout();
            this.pan02panFlatSrcFile.SuspendLayout();
            this.pan02FlatSrcFilePanFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pan02numFlatSrc)).BeginInit();
            this.pan02panFlatSrcPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pan02panFlatSrcPreviewDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan02panFlatSrcPreviewNumRowSkip)).BeginInit();
            this.pan02panFlatSrcColConfig.SuspendLayout();
            this.pan02grpFlatSrcDelim.SuspendLayout();
            this.pan02panSqlSrc.SuspendLayout();
            this.pan02panSqlSrcgrpSqlAuth.SuspendLayout();
            this.pan02panSqlSrcAuth.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan02drpDataSource
            // 
            this.pan02drpDataSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pan02drpDataSource.FormattingEnabled = true;
            this.pan02drpDataSource.Location = new System.Drawing.Point(166, 4);
            this.pan02drpDataSource.Name = "pan02drpDataSource";
            this.pan02drpDataSource.Size = new System.Drawing.Size(344, 21);
            this.pan02drpDataSource.TabIndex = 8;
            this.pan02drpDataSource.SelectedIndexChanged += new System.EventHandler(this.pan02drpDataSource_onSelectedChanged);
            // 
            // pan02lblDataSource
            // 
            this.pan02lblDataSource.AutoSize = true;
            this.pan02lblDataSource.Location = new System.Drawing.Point(35, 7);
            this.pan02lblDataSource.Name = "pan02lblDataSource";
            this.pan02lblDataSource.Size = new System.Drawing.Size(70, 13);
            this.pan02lblDataSource.TabIndex = 7;
            this.pan02lblDataSource.Text = "Data Source:";
            // 
            // pan02panFlatSrcSettings
            // 
            this.pan02panFlatSrcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02panFlatSrcSettings.Controls.Add(this.pan02lstFlatSrcSettings);
            this.pan02panFlatSrcSettings.Controls.Add(this.pan02panFlatSrcColConfig);
            this.pan02panFlatSrcSettings.Controls.Add(this.pan02panFlatSrcFile);
            this.pan02panFlatSrcSettings.Controls.Add(this.pan02panFlatSrcPreview);
            this.pan02panFlatSrcSettings.Location = new System.Drawing.Point(3, 31);
            this.pan02panFlatSrcSettings.Name = "pan02panFlatSrcSettings";
            this.pan02panFlatSrcSettings.Size = new System.Drawing.Size(574, 270);
            this.pan02panFlatSrcSettings.TabIndex = 10;
            // 
            // pan02lstFlatSrcSettings
            // 
            this.pan02lstFlatSrcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pan02lstFlatSrcSettings.Enabled = false;
            this.pan02lstFlatSrcSettings.FormattingEnabled = true;
            this.pan02lstFlatSrcSettings.IntegralHeight = false;
            this.pan02lstFlatSrcSettings.Items.AddRange(new object[] {
            "General",
            "Columns",
            "Advanced",
            "Preview"});
            this.pan02lstFlatSrcSettings.Location = new System.Drawing.Point(0, 0);
            this.pan02lstFlatSrcSettings.Name = "pan02lstFlatSrcSettings";
            this.pan02lstFlatSrcSettings.Size = new System.Drawing.Size(103, 266);
            this.pan02lstFlatSrcSettings.TabIndex = 0;
            this.pan02lstFlatSrcSettings.SelectedIndexChanged += new System.EventHandler(this.pan02lstFlatSrcSettings_onSelectedChanged);
            // 
            // pan02panFlatSrcFile
            // 
            this.pan02panFlatSrcFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02panFlatSrcFile.Controls.Add(this.pan02cmdFlatSrcFileBrowse);
            this.pan02panFlatSrcFile.Controls.Add(this.pan02txtFlatSrcFileName);
            this.pan02panFlatSrcFile.Controls.Add(this.label3);
            this.pan02panFlatSrcFile.Controls.Add(this.pan02FlatSrcFilePanFormat);
            this.pan02panFlatSrcFile.Location = new System.Drawing.Point(106, 2);
            this.pan02panFlatSrcFile.Name = "pan02panFlatSrcFile";
            this.pan02panFlatSrcFile.Size = new System.Drawing.Size(465, 264);
            this.pan02panFlatSrcFile.TabIndex = 4;
            // 
            // pan02cmdFlatSrcFileBrowse
            // 
            this.pan02cmdFlatSrcFileBrowse.AllowWordWrap = false;
            this.pan02cmdFlatSrcFileBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02cmdFlatSrcFileBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.pan02cmdFlatSrcFileBrowse.BackgroundRotationDegrees = 0F;
            this.pan02cmdFlatSrcFileBrowse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.pan02cmdFlatSrcFileBrowse.BorderWidth = 1;
            graphicsPath5.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.pan02cmdFlatSrcFileBrowse.ButtonShape = graphicsPath5;
            this.pan02cmdFlatSrcFileBrowse.CornerFeather = 3;
            this.pan02cmdFlatSrcFileBrowse.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.pan02cmdFlatSrcFileBrowse.DisabledForeColor = System.Drawing.Color.Gray;
            this.pan02cmdFlatSrcFileBrowse.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.pan02cmdFlatSrcFileBrowse.HighlightMultiplier = 2F;
            this.pan02cmdFlatSrcFileBrowse.HoverHighlightColor = System.Drawing.Color.Orange;
            this.pan02cmdFlatSrcFileBrowse.HoverHighlightOpacity = 200;
            this.pan02cmdFlatSrcFileBrowse.HoverImage = null;
            this.pan02cmdFlatSrcFileBrowse.ImagePadding = 0;
            this.pan02cmdFlatSrcFileBrowse.Location = new System.Drawing.Point(382, 13);
            this.pan02cmdFlatSrcFileBrowse.MinimumSize = new System.Drawing.Size(8, 8);
            this.pan02cmdFlatSrcFileBrowse.MouseDownImage = null;
            this.pan02cmdFlatSrcFileBrowse.MultiSample = true;
            this.pan02cmdFlatSrcFileBrowse.Name = "pan02cmdFlatSrcFileBrowse";
            this.pan02cmdFlatSrcFileBrowse.Size = new System.Drawing.Size(66, 20);
            this.pan02cmdFlatSrcFileBrowse.TabIndex = 2;
            this.pan02cmdFlatSrcFileBrowse.Text = "Browse";
            this.pan02cmdFlatSrcFileBrowse.TextOutline = false;
            this.pan02cmdFlatSrcFileBrowse.TextOutlineColor = System.Drawing.Color.Empty;
            this.pan02cmdFlatSrcFileBrowse.TextOutlineOpacity = 255;
            this.pan02cmdFlatSrcFileBrowse.TextOutlineWeight = 2F;
            this.pan02cmdFlatSrcFileBrowse.TextRotationDegrees = 0F;
            this.pan02cmdFlatSrcFileBrowse.TextShadow = false;
            this.pan02cmdFlatSrcFileBrowse.TextShadowOffset = 1F;
            this.pan02cmdFlatSrcFileBrowse.TextShadowOpacity = 100;
            this.pan02cmdFlatSrcFileBrowse.TextVeritcal = false;
            this.pan02cmdFlatSrcFileBrowse.ThreeDEffectDepth = 50;
            this.pan02cmdFlatSrcFileBrowse.ToggleActiveColor = System.Drawing.Color.Empty;
            this.pan02cmdFlatSrcFileBrowse.UseVisualStyleBackColor = true;
            this.pan02cmdFlatSrcFileBrowse.Click += new System.EventHandler(this.cmdBrowse_onClick);
            // 
            // pan02txtFlatSrcFileName
            // 
            this.pan02txtFlatSrcFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02txtFlatSrcFileName.Location = new System.Drawing.Point(79, 13);
            this.pan02txtFlatSrcFileName.Name = "pan02txtFlatSrcFileName";
            this.pan02txtFlatSrcFileName.Size = new System.Drawing.Size(297, 20);
            this.pan02txtFlatSrcFileName.TabIndex = 1;
            this.pan02txtFlatSrcFileName.TextChanged += new System.EventHandler(this.pan02txtFlatSrcFileName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "File name:";
            // 
            // pan02FlatSrcFilePanFormat
            // 
            this.pan02FlatSrcFilePanFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02FlatSrcFilePanFormat.Controls.Add(this.pan02chkFlatSrcColNameFirstRow);
            this.pan02FlatSrcFilePanFormat.Controls.Add(this.label8);
            this.pan02FlatSrcFilePanFormat.Controls.Add(this.label7);
            this.pan02FlatSrcFilePanFormat.Controls.Add(this.pan02numFlatSrc);
            this.pan02FlatSrcFilePanFormat.Controls.Add(this.pan02cboFlatSrcHdrRowQual);
            this.pan02FlatSrcFilePanFormat.Controls.Add(this.pan02txtFlatSrcTextQual);
            this.pan02FlatSrcFilePanFormat.Controls.Add(this.label6);
            this.pan02FlatSrcFilePanFormat.Controls.Add(this.pan02drpFlatSrcFormat);
            this.pan02FlatSrcFilePanFormat.Controls.Add(this.label5);
            this.pan02FlatSrcFilePanFormat.Controls.Add(this.panel2);
            this.pan02FlatSrcFilePanFormat.Controls.Add(this.pan02drpFlatSrcCodePage);
            this.pan02FlatSrcFilePanFormat.Controls.Add(this.label4);
            this.pan02FlatSrcFilePanFormat.Enabled = false;
            this.pan02FlatSrcFilePanFormat.Location = new System.Drawing.Point(1, 36);
            this.pan02FlatSrcFilePanFormat.Name = "pan02FlatSrcFilePanFormat";
            this.pan02FlatSrcFilePanFormat.Size = new System.Drawing.Size(460, 222);
            this.pan02FlatSrcFilePanFormat.TabIndex = 15;
            // 
            // pan02chkFlatSrcColNameFirstRow
            // 
            this.pan02chkFlatSrcColNameFirstRow.AutoSize = true;
            this.pan02chkFlatSrcColNameFirstRow.Location = new System.Drawing.Point(7, 161);
            this.pan02chkFlatSrcColNameFirstRow.Name = "pan02chkFlatSrcColNameFirstRow";
            this.pan02chkFlatSrcColNameFirstRow.Size = new System.Drawing.Size(187, 17);
            this.pan02chkFlatSrcColNameFirstRow.TabIndex = 14;
            this.pan02chkFlatSrcColNameFirstRow.Text = "Column names in the first data row";
            this.pan02chkFlatSrcColNameFirstRow.UseVisualStyleBackColor = true;
            this.pan02chkFlatSrcColNameFirstRow.CheckedChanged += new System.EventHandler(this.pan02chkFlatSrcColNameFirstRow_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Header rows to skip:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Header row qualifier:";
            // 
            // pan02numFlatSrc
            // 
            this.pan02numFlatSrc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02numFlatSrc.Location = new System.Drawing.Point(176, 135);
            this.pan02numFlatSrc.Name = "pan02numFlatSrc";
            this.pan02numFlatSrc.Size = new System.Drawing.Size(271, 20);
            this.pan02numFlatSrc.TabIndex = 11;
            this.pan02numFlatSrc.ValueChanged += new System.EventHandler(this.pan02numFlatSrc_ValueChanged);
            // 
            // pan02cboFlatSrcHdrRowQual
            // 
            this.pan02cboFlatSrcHdrRowQual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02cboFlatSrcHdrRowQual.FormattingEnabled = true;
            this.pan02cboFlatSrcHdrRowQual.Items.AddRange(new object[] {
            "{CR}{LF}",
            "{CR}",
            "{LF}",
            "Semicolon {;}",
            "Colon {:}",
            "Comma {,}",
            "Tab {t}",
            "Vertical Bar {|}"});
            this.pan02cboFlatSrcHdrRowQual.Location = new System.Drawing.Point(176, 108);
            this.pan02cboFlatSrcHdrRowQual.Name = "pan02cboFlatSrcHdrRowQual";
            this.pan02cboFlatSrcHdrRowQual.Size = new System.Drawing.Size(271, 21);
            this.pan02cboFlatSrcHdrRowQual.TabIndex = 10;
            this.pan02cboFlatSrcHdrRowQual.TextUpdate += new System.EventHandler(this.pan02cboFlatSrcHdrRowQual_TextUpdate);
            // 
            // pan02txtFlatSrcTextQual
            // 
            this.pan02txtFlatSrcTextQual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02txtFlatSrcTextQual.Location = new System.Drawing.Point(176, 82);
            this.pan02txtFlatSrcTextQual.Name = "pan02txtFlatSrcTextQual";
            this.pan02txtFlatSrcTextQual.Size = new System.Drawing.Size(271, 20);
            this.pan02txtFlatSrcTextQual.TabIndex = 9;
            this.pan02txtFlatSrcTextQual.Text = "<none>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Text qualifier:";
            // 
            // pan02drpFlatSrcFormat
            // 
            this.pan02drpFlatSrcFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pan02drpFlatSrcFormat.FormattingEnabled = true;
            this.pan02drpFlatSrcFormat.Items.AddRange(new object[] {
            "Delimited",
            "Fixed Width",
            "Ragged Right"});
            this.pan02drpFlatSrcFormat.Location = new System.Drawing.Point(78, 45);
            this.pan02drpFlatSrcFormat.Name = "pan02drpFlatSrcFormat";
            this.pan02drpFlatSrcFormat.Size = new System.Drawing.Size(179, 21);
            this.pan02drpFlatSrcFormat.TabIndex = 7;
            this.pan02drpFlatSrcFormat.SelectedIndexChanged += new System.EventHandler(this.pan02drpFlatSrcFormat_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Format:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(2, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 4);
            this.panel2.TabIndex = 5;
            // 
            // pan02drpFlatSrcCodePage
            // 
            this.pan02drpFlatSrcCodePage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02drpFlatSrcCodePage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pan02drpFlatSrcCodePage.FormattingEnabled = true;
            this.pan02drpFlatSrcCodePage.Location = new System.Drawing.Point(78, 7);
            this.pan02drpFlatSrcCodePage.Name = "pan02drpFlatSrcCodePage";
            this.pan02drpFlatSrcCodePage.Size = new System.Drawing.Size(369, 21);
            this.pan02drpFlatSrcCodePage.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Code page:";
            // 
            // pan02panFlatSrcPreview
            // 
            this.pan02panFlatSrcPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02panFlatSrcPreview.Controls.Add(this.pan02panFlatSrcPreviewLnkRefresh);
            this.pan02panFlatSrcPreview.Controls.Add(this.pan02panFlatSrcPreviewDg);
            this.pan02panFlatSrcPreview.Controls.Add(this.pan02lblFlatSrcPrevRowNums);
            this.pan02panFlatSrcPreview.Controls.Add(this.pan02panFlatSrcPreviewNumRowSkip);
            this.pan02panFlatSrcPreview.Controls.Add(this.label14);
            this.pan02panFlatSrcPreview.Controls.Add(this.label13);
            this.pan02panFlatSrcPreview.Location = new System.Drawing.Point(106, 2);
            this.pan02panFlatSrcPreview.Name = "pan02panFlatSrcPreview";
            this.pan02panFlatSrcPreview.Size = new System.Drawing.Size(465, 264);
            this.pan02panFlatSrcPreview.TabIndex = 7;
            this.pan02panFlatSrcPreview.Visible = false;
            this.pan02panFlatSrcPreview.VisibleChanged += new System.EventHandler(this.pan02panFlatSrcPreview_VisibleChanged);
            // 
            // pan02panFlatSrcPreviewLnkRefresh
            // 
            this.pan02panFlatSrcPreviewLnkRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02panFlatSrcPreviewLnkRefresh.AutoSize = true;
            this.pan02panFlatSrcPreviewLnkRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan02panFlatSrcPreviewLnkRefresh.Location = new System.Drawing.Point(410, 54);
            this.pan02panFlatSrcPreviewLnkRefresh.Name = "pan02panFlatSrcPreviewLnkRefresh";
            this.pan02panFlatSrcPreviewLnkRefresh.Size = new System.Drawing.Size(44, 13);
            this.pan02panFlatSrcPreviewLnkRefresh.TabIndex = 6;
            this.pan02panFlatSrcPreviewLnkRefresh.TabStop = true;
            this.pan02panFlatSrcPreviewLnkRefresh.Text = "Refresh";
            this.pan02panFlatSrcPreviewLnkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pan02panFlatSrcPreviewLnkRefresh_onLinkClicked);
            // 
            // pan02panFlatSrcPreviewDg
            // 
            this.pan02panFlatSrcPreviewDg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02panFlatSrcPreviewDg.CaptionVisible = false;
            this.pan02panFlatSrcPreviewDg.DataMember = "";
            this.pan02panFlatSrcPreviewDg.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.pan02panFlatSrcPreviewDg.Location = new System.Drawing.Point(6, 68);
            this.pan02panFlatSrcPreviewDg.Name = "pan02panFlatSrcPreviewDg";
            this.pan02panFlatSrcPreviewDg.Size = new System.Drawing.Size(453, 193);
            this.pan02panFlatSrcPreviewDg.TabIndex = 4;
            // 
            // pan02lblFlatSrcPrevRowNums
            // 
            this.pan02lblFlatSrcPrevRowNums.AutoSize = true;
            this.pan02lblFlatSrcPrevRowNums.Location = new System.Drawing.Point(3, 52);
            this.pan02lblFlatSrcPrevRowNums.Name = "pan02lblFlatSrcPrevRowNums";
            this.pan02lblFlatSrcPrevRowNums.Size = new System.Drawing.Size(95, 13);
            this.pan02lblFlatSrcPrevRowNums.TabIndex = 3;
            this.pan02lblFlatSrcPrevRowNums.Text = "Preview rows x - y:";
            // 
            // pan02panFlatSrcPreviewNumRowSkip
            // 
            this.pan02panFlatSrcPreviewNumRowSkip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02panFlatSrcPreviewNumRowSkip.Location = new System.Drawing.Point(102, 22);
            this.pan02panFlatSrcPreviewNumRowSkip.Name = "pan02panFlatSrcPreviewNumRowSkip";
            this.pan02panFlatSrcPreviewNumRowSkip.Size = new System.Drawing.Size(357, 20);
            this.pan02panFlatSrcPreviewNumRowSkip.TabIndex = 2;
            this.pan02panFlatSrcPreviewNumRowSkip.ValueChanged += new System.EventHandler(this.pan02panFlatSrcPreviewNumRowSkip_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Data rows to skip:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(333, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "The preview shows the source file divided into the specified columns.";
            // 
            // pan02panFlatSrcColConfig
            // 
            this.pan02panFlatSrcColConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02panFlatSrcColConfig.Controls.Add(this.pan02cmdFlatSrcResetCol);
            this.pan02panFlatSrcColConfig.Controls.Add(this.pan02lstFlatSrcColPrev);
            this.pan02panFlatSrcColConfig.Controls.Add(this.pan02grpFlatSrcDelim);
            this.pan02panFlatSrcColConfig.Location = new System.Drawing.Point(106, 2);
            this.pan02panFlatSrcColConfig.Name = "pan02panFlatSrcColConfig";
            this.pan02panFlatSrcColConfig.Size = new System.Drawing.Size(465, 264);
            this.pan02panFlatSrcColConfig.TabIndex = 0;
            this.pan02panFlatSrcColConfig.Visible = false;
            // 
            // pan02cmdFlatSrcResetCol
            // 
            this.pan02cmdFlatSrcResetCol.AllowWordWrap = false;
            this.pan02cmdFlatSrcResetCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02cmdFlatSrcResetCol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.pan02cmdFlatSrcResetCol.BackgroundRotationDegrees = 0F;
            this.pan02cmdFlatSrcResetCol.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.pan02cmdFlatSrcResetCol.BorderWidth = 1;
            graphicsPath6.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.pan02cmdFlatSrcResetCol.ButtonShape = graphicsPath6;
            this.pan02cmdFlatSrcResetCol.CornerFeather = 5;
            this.pan02cmdFlatSrcResetCol.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.pan02cmdFlatSrcResetCol.DisabledForeColor = System.Drawing.Color.Gray;
            this.pan02cmdFlatSrcResetCol.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.pan02cmdFlatSrcResetCol.HighlightMultiplier = 2F;
            this.pan02cmdFlatSrcResetCol.HoverHighlightColor = System.Drawing.Color.Orange;
            this.pan02cmdFlatSrcResetCol.HoverHighlightOpacity = 200;
            this.pan02cmdFlatSrcResetCol.HoverImage = null;
            this.pan02cmdFlatSrcResetCol.ImagePadding = 0;
            this.pan02cmdFlatSrcResetCol.Location = new System.Drawing.Point(368, 238);
            this.pan02cmdFlatSrcResetCol.MinimumSize = new System.Drawing.Size(8, 8);
            this.pan02cmdFlatSrcResetCol.MouseDownImage = null;
            this.pan02cmdFlatSrcResetCol.MultiSample = true;
            this.pan02cmdFlatSrcResetCol.Name = "pan02cmdFlatSrcResetCol";
            this.pan02cmdFlatSrcResetCol.Size = new System.Drawing.Size(94, 23);
            this.pan02cmdFlatSrcResetCol.TabIndex = 2;
            this.pan02cmdFlatSrcResetCol.Text = "Reset Columns";
            this.pan02cmdFlatSrcResetCol.TextOutline = false;
            this.pan02cmdFlatSrcResetCol.TextOutlineColor = System.Drawing.Color.Empty;
            this.pan02cmdFlatSrcResetCol.TextOutlineOpacity = 255;
            this.pan02cmdFlatSrcResetCol.TextOutlineWeight = 2F;
            this.pan02cmdFlatSrcResetCol.TextRotationDegrees = 0F;
            this.pan02cmdFlatSrcResetCol.TextShadow = false;
            this.pan02cmdFlatSrcResetCol.TextShadowOffset = 1F;
            this.pan02cmdFlatSrcResetCol.TextShadowOpacity = 100;
            this.pan02cmdFlatSrcResetCol.TextVeritcal = false;
            this.pan02cmdFlatSrcResetCol.ThreeDEffectDepth = 50;
            this.pan02cmdFlatSrcResetCol.ToggleActiveColor = System.Drawing.Color.Empty;
            this.pan02cmdFlatSrcResetCol.UseVisualStyleBackColor = true;
            this.pan02cmdFlatSrcResetCol.Click += new System.EventHandler(this.pan02cmdFlatSrcResetCol_Click);
            // 
            // pan02lstFlatSrcColPrev
            // 
            this.pan02lstFlatSrcColPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02lstFlatSrcColPrev.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colColumnName,
            this.colDataType,
            this.colFieldSize});
            this.pan02lstFlatSrcColPrev.FullRowSelect = true;
            this.pan02lstFlatSrcColPrev.GridLines = true;
            this.pan02lstFlatSrcColPrev.Location = new System.Drawing.Point(3, 82);
            this.pan02lstFlatSrcColPrev.Name = "pan02lstFlatSrcColPrev";
            this.pan02lstFlatSrcColPrev.Size = new System.Drawing.Size(456, 150);
            this.pan02lstFlatSrcColPrev.TabIndex = 1;
            this.pan02lstFlatSrcColPrev.UseCompatibleStateImageBehavior = false;
            this.pan02lstFlatSrcColPrev.View = System.Windows.Forms.View.Details;
            // 
            // colColumnName
            // 
            this.colColumnName.Text = "Column Name";
            this.colColumnName.Width = 260;
            // 
            // colDataType
            // 
            this.colDataType.Text = "Data Type";
            this.colDataType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDataType.Width = 90;
            // 
            // colFieldSize
            // 
            this.colFieldSize.Text = "Field Size";
            this.colFieldSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colFieldSize.Width = 80;
            // 
            // pan02grpFlatSrcDelim
            // 
            this.pan02grpFlatSrcDelim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02grpFlatSrcDelim.Controls.Add(this.pan02lblFlatSrcColDelim);
            this.pan02grpFlatSrcDelim.Controls.Add(this.pan02lblFlatSrcRowDelim);
            this.pan02grpFlatSrcDelim.Controls.Add(this.pan02cboFlatSrcColDelim);
            this.pan02grpFlatSrcDelim.Controls.Add(this.pan02cboFlatSrcRowDelim);
            this.pan02grpFlatSrcDelim.Location = new System.Drawing.Point(3, 3);
            this.pan02grpFlatSrcDelim.Name = "pan02grpFlatSrcDelim";
            this.pan02grpFlatSrcDelim.Size = new System.Drawing.Size(456, 76);
            this.pan02grpFlatSrcDelim.TabIndex = 0;
            this.pan02grpFlatSrcDelim.TabStop = false;
            this.pan02grpFlatSrcDelim.Text = "Specify the characters that delimit the source file:";
            // 
            // pan02lblFlatSrcColDelim
            // 
            this.pan02lblFlatSrcColDelim.AutoSize = true;
            this.pan02lblFlatSrcColDelim.Location = new System.Drawing.Point(17, 49);
            this.pan02lblFlatSrcColDelim.Name = "pan02lblFlatSrcColDelim";
            this.pan02lblFlatSrcColDelim.Size = new System.Drawing.Size(86, 13);
            this.pan02lblFlatSrcColDelim.TabIndex = 3;
            this.pan02lblFlatSrcColDelim.Text = "Column delimiter:";
            // 
            // pan02lblFlatSrcRowDelim
            // 
            this.pan02lblFlatSrcRowDelim.AutoSize = true;
            this.pan02lblFlatSrcRowDelim.Location = new System.Drawing.Point(17, 22);
            this.pan02lblFlatSrcRowDelim.Name = "pan02lblFlatSrcRowDelim";
            this.pan02lblFlatSrcRowDelim.Size = new System.Drawing.Size(73, 13);
            this.pan02lblFlatSrcRowDelim.TabIndex = 2;
            this.pan02lblFlatSrcRowDelim.Text = "Row delimiter:";
            // 
            // pan02cboFlatSrcColDelim
            // 
            this.pan02cboFlatSrcColDelim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02cboFlatSrcColDelim.FormattingEnabled = true;
            this.pan02cboFlatSrcColDelim.Items.AddRange(new object[] {
            "{CR}{LF}",
            "{CR}",
            "{LF}",
            "Semicolon {;}",
            "Colon {:}",
            "Comma {,}",
            "Tab {t}",
            "Vertical Bar {|}"});
            this.pan02cboFlatSrcColDelim.Location = new System.Drawing.Point(134, 46);
            this.pan02cboFlatSrcColDelim.Name = "pan02cboFlatSrcColDelim";
            this.pan02cboFlatSrcColDelim.Size = new System.Drawing.Size(313, 21);
            this.pan02cboFlatSrcColDelim.TabIndex = 1;
            this.pan02cboFlatSrcColDelim.SelectedIndexChanged += new System.EventHandler(this.pan02cboFlatSrcColDelim_SelectedIndexChanged);
            // 
            // pan02cboFlatSrcRowDelim
            // 
            this.pan02cboFlatSrcRowDelim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02cboFlatSrcRowDelim.FormattingEnabled = true;
            this.pan02cboFlatSrcRowDelim.Items.AddRange(new object[] {
            "{CR}{LF}",
            "{CR}",
            "{LF}",
            "Semicolon {;}",
            "Colon {:}",
            "Comma {,}",
            "Tab {t}",
            "Vertical Bar {|}"});
            this.pan02cboFlatSrcRowDelim.Location = new System.Drawing.Point(134, 19);
            this.pan02cboFlatSrcRowDelim.Name = "pan02cboFlatSrcRowDelim";
            this.pan02cboFlatSrcRowDelim.Size = new System.Drawing.Size(313, 21);
            this.pan02cboFlatSrcRowDelim.TabIndex = 0;
            this.pan02cboFlatSrcRowDelim.SelectedIndexChanged += new System.EventHandler(this.pan02cboFlatSrcRowDelim_SelectedIndexChanged);
            // 
            // pan02panSqlSrc
            // 
            this.pan02panSqlSrc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02panSqlSrc.Controls.Add(this.pan02cboSqlSrcDb);
            this.pan02panSqlSrc.Controls.Add(this.label12);
            this.pan02panSqlSrc.Controls.Add(this.pan02panSqlSrcgrpSqlAuth);
            this.pan02panSqlSrc.Controls.Add(this.cboServerName);
            this.pan02panSqlSrc.Controls.Add(this.label9);
            this.pan02panSqlSrc.Location = new System.Drawing.Point(3, 31);
            this.pan02panSqlSrc.Name = "pan02panSqlSrc";
            this.pan02panSqlSrc.Size = new System.Drawing.Size(574, 231);
            this.pan02panSqlSrc.TabIndex = 9;
            this.pan02panSqlSrc.Visible = false;
            // 
            // pan02cboSqlSrcDb
            // 
            this.pan02cboSqlSrcDb.FormattingEnabled = true;
            this.pan02cboSqlSrcDb.Location = new System.Drawing.Point(155, 183);
            this.pan02cboSqlSrcDb.Name = "pan02cboSqlSrcDb";
            this.pan02cboSqlSrcDb.Size = new System.Drawing.Size(194, 21);
            this.pan02cboSqlSrcDb.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Database:";
            // 
            // pan02panSqlSrcgrpSqlAuth
            // 
            this.pan02panSqlSrcgrpSqlAuth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02panSqlSrcgrpSqlAuth.Controls.Add(this.pan02panSqlSrcAuth);
            this.pan02panSqlSrcgrpSqlAuth.Controls.Add(this.pan02rdoSqlSrcSqlAuth);
            this.pan02panSqlSrcgrpSqlAuth.Controls.Add(this.pan02rdoSqlSrcWinAuth);
            this.pan02panSqlSrcgrpSqlAuth.Location = new System.Drawing.Point(3, 48);
            this.pan02panSqlSrcgrpSqlAuth.Name = "pan02panSqlSrcgrpSqlAuth";
            this.pan02panSqlSrcgrpSqlAuth.Size = new System.Drawing.Size(565, 129);
            this.pan02panSqlSrcgrpSqlAuth.TabIndex = 2;
            this.pan02panSqlSrcgrpSqlAuth.TabStop = false;
            this.pan02panSqlSrcgrpSqlAuth.Text = "Authentication";
            // 
            // pan02panSqlSrcAuth
            // 
            this.pan02panSqlSrcAuth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pan02panSqlSrcAuth.Controls.Add(this.label11);
            this.pan02panSqlSrcAuth.Controls.Add(this.textBox3);
            this.pan02panSqlSrcAuth.Controls.Add(this.label10);
            this.pan02panSqlSrcAuth.Controls.Add(this.textBox2);
            this.pan02panSqlSrcAuth.Enabled = false;
            this.pan02panSqlSrcAuth.Location = new System.Drawing.Point(22, 65);
            this.pan02panSqlSrcAuth.Name = "pan02panSqlSrcAuth";
            this.pan02panSqlSrcAuth.Size = new System.Drawing.Size(534, 57);
            this.pan02panSqlSrcAuth.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Password:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(130, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(398, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "User name:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(130, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(398, 20);
            this.textBox2.TabIndex = 0;
            // 
            // pan02rdoSqlSrcSqlAuth
            // 
            this.pan02rdoSqlSrcSqlAuth.AutoSize = true;
            this.pan02rdoSqlSrcSqlAuth.Location = new System.Drawing.Point(19, 42);
            this.pan02rdoSqlSrcSqlAuth.Name = "pan02rdoSqlSrcSqlAuth";
            this.pan02rdoSqlSrcSqlAuth.Size = new System.Drawing.Size(173, 17);
            this.pan02rdoSqlSrcSqlAuth.TabIndex = 1;
            this.pan02rdoSqlSrcSqlAuth.TabStop = true;
            this.pan02rdoSqlSrcSqlAuth.Text = "Use SQL Server Authentication";
            this.pan02rdoSqlSrcSqlAuth.UseVisualStyleBackColor = true;
            // 
            // pan02rdoSqlSrcWinAuth
            // 
            this.pan02rdoSqlSrcWinAuth.AutoSize = true;
            this.pan02rdoSqlSrcWinAuth.Checked = true;
            this.pan02rdoSqlSrcWinAuth.Location = new System.Drawing.Point(19, 19);
            this.pan02rdoSqlSrcWinAuth.Name = "pan02rdoSqlSrcWinAuth";
            this.pan02rdoSqlSrcWinAuth.Size = new System.Drawing.Size(162, 17);
            this.pan02rdoSqlSrcWinAuth.TabIndex = 0;
            this.pan02rdoSqlSrcWinAuth.TabStop = true;
            this.pan02rdoSqlSrcWinAuth.Text = "Use Windows Authentication";
            this.pan02rdoSqlSrcWinAuth.UseVisualStyleBackColor = true;
            // 
            // cboServerName
            // 
            this.cboServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboServerName.FormattingEnabled = true;
            this.cboServerName.Location = new System.Drawing.Point(128, 6);
            this.cboServerName.Name = "cboServerName";
            this.cboServerName.Size = new System.Drawing.Size(399, 21);
            this.cboServerName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Server Name:";
            // 
            // DataTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pan02drpDataSource);
            this.Controls.Add(this.pan02lblDataSource);
            this.Controls.Add(this.pan02panSqlSrc);
            this.Controls.Add(this.pan02panFlatSrcSettings);
            this.MinimumSize = new System.Drawing.Size(560, 300);
            this.Name = "DataTarget";
            this.Size = new System.Drawing.Size(577, 301);
            this.pan02panFlatSrcSettings.ResumeLayout(false);
            this.pan02panFlatSrcFile.ResumeLayout(false);
            this.pan02panFlatSrcFile.PerformLayout();
            this.pan02FlatSrcFilePanFormat.ResumeLayout(false);
            this.pan02FlatSrcFilePanFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pan02numFlatSrc)).EndInit();
            this.pan02panFlatSrcPreview.ResumeLayout(false);
            this.pan02panFlatSrcPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pan02panFlatSrcPreviewDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan02panFlatSrcPreviewNumRowSkip)).EndInit();
            this.pan02panFlatSrcColConfig.ResumeLayout(false);
            this.pan02grpFlatSrcDelim.ResumeLayout(false);
            this.pan02grpFlatSrcDelim.PerformLayout();
            this.pan02panSqlSrc.ResumeLayout(false);
            this.pan02panSqlSrc.PerformLayout();
            this.pan02panSqlSrcgrpSqlAuth.ResumeLayout(false);
            this.pan02panSqlSrcgrpSqlAuth.PerformLayout();
            this.pan02panSqlSrcAuth.ResumeLayout(false);
            this.pan02panSqlSrcAuth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pan02drpDataSource;
        private System.Windows.Forms.Label pan02lblDataSource;
        private System.Windows.Forms.Panel pan02panFlatSrcSettings;
        private System.Windows.Forms.Panel pan02panFlatSrcPreview;
        private System.Windows.Forms.DataGrid pan02panFlatSrcPreviewDg;
        private System.Windows.Forms.Label pan02lblFlatSrcPrevRowNums;
        private System.Windows.Forms.NumericUpDown pan02panFlatSrcPreviewNumRowSkip;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pan02panFlatSrcColConfig;
        private RainstormStudios.Controls.AdvancedButton pan02cmdFlatSrcResetCol;
        private System.Windows.Forms.ListView pan02lstFlatSrcColPrev;
        private System.Windows.Forms.GroupBox pan02grpFlatSrcDelim;
        private System.Windows.Forms.Label pan02lblFlatSrcColDelim;
        private System.Windows.Forms.Label pan02lblFlatSrcRowDelim;
        private System.Windows.Forms.ComboBox pan02cboFlatSrcColDelim;
        private System.Windows.Forms.ComboBox pan02cboFlatSrcRowDelim;
        private System.Windows.Forms.Panel pan02panFlatSrcFile;
        private System.Windows.Forms.CheckBox pan02chkFlatSrcColNameFirstRow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown pan02numFlatSrc;
        private System.Windows.Forms.ComboBox pan02cboFlatSrcHdrRowQual;
        private System.Windows.Forms.TextBox pan02txtFlatSrcTextQual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox pan02drpFlatSrcFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox pan02drpFlatSrcCodePage;
        private System.Windows.Forms.Label label4;
        private RainstormStudios.Controls.AdvancedButton pan02cmdFlatSrcFileBrowse;
        private System.Windows.Forms.TextBox pan02txtFlatSrcFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox pan02lstFlatSrcSettings;
        private System.Windows.Forms.Panel pan02panSqlSrc;
        private System.Windows.Forms.ComboBox pan02cboSqlSrcDb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox pan02panSqlSrcgrpSqlAuth;
        private System.Windows.Forms.Panel pan02panSqlSrcAuth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton pan02rdoSqlSrcSqlAuth;
        private System.Windows.Forms.RadioButton pan02rdoSqlSrcWinAuth;
        private System.Windows.Forms.ComboBox cboServerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel pan02panFlatSrcPreviewLnkRefresh;
        private System.Windows.Forms.Panel pan02FlatSrcFilePanFormat;
        private System.Windows.Forms.ColumnHeader colColumnName;
        private System.Windows.Forms.ColumnHeader colDataType;
        private System.Windows.Forms.ColumnHeader colFieldSize;
    }
}
