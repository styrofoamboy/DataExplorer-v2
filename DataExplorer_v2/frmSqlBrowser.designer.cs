namespace DataExplorer
{
    partial class frmSqlBrowser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSqlBrowser));
            System.Drawing.Drawing2D.GraphicsPath graphicsPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Table Results", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("View Results", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Stored Proceedure Results", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Function Results", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Columns", System.Windows.Forms.HorizontalAlignment.Left);
            System.Drawing.Drawing2D.GraphicsPath graphicsPath2 = new System.Drawing.Drawing2D.GraphicsPath();
            this.trvImgList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmdSearch = new RainstormStudios.Controls.AdvancedButton();
            this.lstSearchResults = new RainstormStudios.Controls.FixedColumnListView();
            this.cmdSearchCol = new RainstormStudios.Controls.AdvancedButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvImgList
            // 
            this.trvImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("trvImgList.ImageStream")));
            this.trvImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.trvImgList.Images.SetKeyName(0, "Folder");
            this.trvImgList.Images.SetKeyName(1, "DBEngine");
            this.trvImgList.Images.SetKeyName(2, "Database");
            this.trvImgList.Images.SetKeyName(3, "Table");
            this.trvImgList.Images.SetKeyName(4, "View");
            this.trvImgList.Images.SetKeyName(5, "Column");
            this.trvImgList.Images.SetKeyName(6, "Key");
            this.trvImgList.Images.SetKeyName(7, "Index");
            this.trvImgList.Images.SetKeyName(8, "Trigger");
            this.trvImgList.Images.SetKeyName(9, "Constraint");
            this.trvImgList.Images.SetKeyName(10, "StoredProc");
            this.trvImgList.Images.SetKeyName(11, "Function");
            this.trvImgList.Images.SetKeyName(12, "User");
            this.trvImgList.Images.SetKeyName(13, "SecurityGroup");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstSearchResults);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(268, 372);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DataExplorer.Properties.Resources.GradBg;
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 20);
            this.panel1.TabIndex = 4;
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSearch.Location = new System.Drawing.Point(0, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(265, 20);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search Results";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_onClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(12, 392);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(136, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_onKeyDown);
            // 
            // cmdSearch
            // 
            this.cmdSearch.AllowWordWrap = false;
            this.cmdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdSearch.BackgroundRotationDegrees = 0F;
            this.cmdSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdSearch.BorderWidth = 1;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdSearch.ButtonShape = graphicsPath1;
            this.cmdSearch.CornerFeather = 3;
            this.cmdSearch.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdSearch.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdSearch.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.Standard;
            this.cmdSearch.HighlightMultiplier = 2F;
            this.cmdSearch.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdSearch.HoverHighlightOpacity = 200;
            this.cmdSearch.HoverImage = null;
            this.cmdSearch.ImagePadding = 0;
            this.cmdSearch.Location = new System.Drawing.Point(154, 390);
            this.cmdSearch.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdSearch.MouseDownImage = null;
            this.cmdSearch.MultiSample = true;
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(51, 23);
            this.cmdSearch.TabIndex = 5;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.TextOutline = false;
            this.cmdSearch.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdSearch.TextOutlineOpacity = 255;
            this.cmdSearch.TextOutlineWeight = 2F;
            this.cmdSearch.TextRotationDegrees = 0F;
            this.cmdSearch.TextShadow = false;
            this.cmdSearch.TextShadowOffset = 1F;
            this.cmdSearch.TextShadowOpacity = 80;
            this.cmdSearch.TextVeritcal = false;
            this.cmdSearch.ThreeDEffectDepth = 50;
            this.cmdSearch.ToggleActiveColor = System.Drawing.Color.Empty;
            this.toolTip1.SetToolTip(this.cmdSearch, "Search for specified text in Table, Function, Proceedure and View names.");
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_onClick);
            // 
            // lstSearchResults
            // 
            this.lstSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            listViewGroup1.Header = "Table Results";
            listViewGroup1.Name = "grpTables";
            listViewGroup2.Header = "View Results";
            listViewGroup2.Name = "grpViews";
            listViewGroup3.Header = "Stored Proceedure Results";
            listViewGroup3.Name = "grpStoredProcs";
            listViewGroup4.Header = "Function Results";
            listViewGroup4.Name = "grpFuncs";
            listViewGroup5.Header = "Columns";
            listViewGroup5.Name = "grpCols";
            this.lstSearchResults.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.lstSearchResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstSearchResults.HideSelection = false;
            this.lstSearchResults.Location = new System.Drawing.Point(0, 23);
            this.lstSearchResults.Name = "lstSearchResults";
            this.lstSearchResults.Size = new System.Drawing.Size(268, 135);
            this.lstSearchResults.SmallImageList = this.trvImgList;
            this.lstSearchResults.TabIndex = 6;
            this.lstSearchResults.UseCompatibleStateImageBehavior = false;
            this.lstSearchResults.View = System.Windows.Forms.View.Details;
            this.lstSearchResults.DoubleClick += new System.EventHandler(this.lstSearchResults_onDoubleClick);
            // 
            // cmdSearchCol
            // 
            this.cmdSearchCol.AllowWordWrap = false;
            this.cmdSearchCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSearchCol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdSearchCol.BackgroundRotationDegrees = 0F;
            this.cmdSearchCol.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdSearchCol.BorderWidth = 1;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdSearchCol.ButtonShape = graphicsPath2;
            this.cmdSearchCol.CornerFeather = 3;
            this.cmdSearchCol.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdSearchCol.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdSearchCol.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.Standard;
            this.cmdSearchCol.HighlightMultiplier = 2F;
            this.cmdSearchCol.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdSearchCol.HoverHighlightOpacity = 200;
            this.cmdSearchCol.HoverImage = null;
            this.cmdSearchCol.ImagePadding = 0;
            this.cmdSearchCol.Location = new System.Drawing.Point(211, 390);
            this.cmdSearchCol.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdSearchCol.MouseDownImage = null;
            this.cmdSearchCol.MultiSample = true;
            this.cmdSearchCol.Name = "cmdSearchCol";
            this.cmdSearchCol.Size = new System.Drawing.Size(69, 23);
            this.cmdSearchCol.TabIndex = 6;
            this.cmdSearchCol.Text = "w/Columns";
            this.cmdSearchCol.TextOutline = false;
            this.cmdSearchCol.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdSearchCol.TextOutlineOpacity = 255;
            this.cmdSearchCol.TextOutlineWeight = 2F;
            this.cmdSearchCol.TextRotationDegrees = 0F;
            this.cmdSearchCol.TextShadow = false;
            this.cmdSearchCol.TextShadowOffset = 1F;
            this.cmdSearchCol.TextShadowOpacity = 80;
            this.cmdSearchCol.TextVeritcal = false;
            this.cmdSearchCol.ThreeDEffectDepth = 50;
            this.cmdSearchCol.ToggleActiveColor = System.Drawing.Color.Empty;
            this.toolTip1.SetToolTip(this.cmdSearchCol, "Search on all objects, including columns. NOTE:  This search might take a conside" +
                    "rable amount of time!");
            this.cmdSearchCol.UseVisualStyleBackColor = true;
            this.cmdSearchCol.Click += new System.EventHandler(this.cmdSearchCol_onClick);
            // 
            // frmSqlBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 425);
            this.Controls.Add(this.cmdSearchCol);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 428);
            this.Name = "frmSqlBrowser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SQL Browser";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList trvImgList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private RainstormStudios.Controls.AdvancedButton cmdSearch;
        private RainstormStudios.Controls.FixedColumnListView lstSearchResults;
        private RainstormStudios.Controls.AdvancedButton cmdSearchCol;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}