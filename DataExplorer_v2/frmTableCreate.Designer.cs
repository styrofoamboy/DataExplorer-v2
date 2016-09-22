namespace DataExplorer
{
    partial class frmTableCreate
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
            System.Drawing.Drawing2D.GraphicsPath graphicsPath4 = new System.Drawing.Drawing2D.GraphicsPath();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.cmdCancel = new RainstormStudios.Controls.AdvancedButton();
            this.cmdCreate = new RainstormStudios.Controls.AdvancedButton();
            this.colFldNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFldType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colFldSz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllowNull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsIdentity = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIdIncr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdSeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFldNm,
            this.colFldType,
            this.colFldSz,
            this.colAllowNull,
            this.colIsIdentity,
            this.colIdIncr,
            this.colIdSeed,
            this.colDef});
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(713, 277);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGridView1_CellStateChanged);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(86, 13);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(201, 20);
            this.txtTableName.TabIndex = 0;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(12, 16);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(68, 13);
            this.lblTableName.TabIndex = 4;
            this.lblTableName.Text = "Table Name:";
            // 
            // cmdCancel
            // 
            this.cmdCancel.AllowWordWrap = false;
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdCancel.BackgroundRotationDegrees = 0F;
            this.cmdCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdCancel.BorderWidth = 1;
            graphicsPath3.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdCancel.ButtonShape = graphicsPath3;
            this.cmdCancel.CornerFeather = 5;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdCancel.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdCancel.HighlightMultiplier = 2F;
            this.cmdCancel.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdCancel.HoverHighlightOpacity = 200;
            this.cmdCancel.HoverImage = null;
            this.cmdCancel.ImagePadding = 0;
            this.cmdCancel.Location = new System.Drawing.Point(440, 322);
            this.cmdCancel.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdCancel.MouseDownImage = null;
            this.cmdCancel.MultiSample = true;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(131, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.TextOutline = false;
            this.cmdCancel.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdCancel.TextOutlineOpacity = 255;
            this.cmdCancel.TextOutlineWeight = 2F;
            this.cmdCancel.TextRotationDegrees = 0F;
            this.cmdCancel.TextShadow = false;
            this.cmdCancel.TextShadowOffset = 1F;
            this.cmdCancel.TextShadowOpacity = 80;
            this.cmdCancel.TextVeritcal = false;
            this.cmdCancel.ThreeDEffectDepth = 75;
            this.cmdCancel.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdCreate
            // 
            this.cmdCreate.AllowWordWrap = false;
            this.cmdCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdCreate.BackgroundRotationDegrees = 0F;
            this.cmdCreate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdCreate.BorderWidth = 1;
            graphicsPath4.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdCreate.ButtonShape = graphicsPath4;
            this.cmdCreate.CornerFeather = 5;
            this.cmdCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdCreate.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCreate.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdCreate.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdCreate.HighlightMultiplier = 2F;
            this.cmdCreate.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdCreate.HoverHighlightOpacity = 200;
            this.cmdCreate.HoverImage = null;
            this.cmdCreate.ImagePadding = 0;
            this.cmdCreate.Location = new System.Drawing.Point(577, 322);
            this.cmdCreate.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdCreate.MouseDownImage = null;
            this.cmdCreate.MultiSample = true;
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(131, 23);
            this.cmdCreate.TabIndex = 2;
            this.cmdCreate.Text = "Script Create";
            this.cmdCreate.TextOutline = false;
            this.cmdCreate.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdCreate.TextOutlineOpacity = 255;
            this.cmdCreate.TextOutlineWeight = 2F;
            this.cmdCreate.TextRotationDegrees = 0F;
            this.cmdCreate.TextShadow = false;
            this.cmdCreate.TextShadowOffset = 1F;
            this.cmdCreate.TextShadowOpacity = 80;
            this.cmdCreate.TextVeritcal = false;
            this.cmdCreate.ThreeDEffectDepth = 75;
            this.cmdCreate.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdCreate.UseVisualStyleBackColor = true;
            // 
            // colFldNm
            // 
            this.colFldNm.HeaderText = "Column Name";
            this.colFldNm.Name = "colFldNm";
            this.colFldNm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFldNm.Width = 150;
            // 
            // colFldType
            // 
            this.colFldType.HeaderText = "Data Type";
            this.colFldType.Name = "colFldType";
            // 
            // colFldSz
            // 
            this.colFldSz.HeaderText = "Size";
            this.colFldSz.Name = "colFldSz";
            this.colFldSz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFldSz.Width = 50;
            // 
            // colAllowNull
            // 
            this.colAllowNull.FalseValue = "";
            this.colAllowNull.HeaderText = "Allow Nulls";
            this.colAllowNull.Name = "colAllowNull";
            this.colAllowNull.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAllowNull.TrueValue = "";
            // 
            // colIsIdentity
            // 
            this.colIsIdentity.HeaderText = "IsIdentity";
            this.colIsIdentity.Name = "colIsIdentity";
            // 
            // colIdIncr
            // 
            this.colIdIncr.HeaderText = "Increment";
            this.colIdIncr.Name = "colIdIncr";
            this.colIdIncr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIdIncr.Width = 75;
            // 
            // colIdSeed
            // 
            this.colIdSeed.HeaderText = "Seed";
            this.colIdSeed.Name = "colIdSeed";
            this.colIdSeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIdSeed.Width = 75;
            // 
            // colDef
            // 
            this.colDef.HeaderText = "Default";
            this.colDef.Name = "colDef";
            // 
            // frmTableCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 357);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdCreate);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmTableCreate";
            this.ShowInTaskbar = false;
            this.Text = "Create Table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RainstormStudios.Controls.AdvancedButton cmdCreate;
        private RainstormStudios.Controls.AdvancedButton cmdCancel;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFldNm;
        private System.Windows.Forms.DataGridViewComboBoxColumn colFldType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFldSz;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAllowNull;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsIdentity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdIncr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdSeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDef;

    }
}