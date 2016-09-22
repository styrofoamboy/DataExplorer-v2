namespace DataExplorer.ImportWizard_Controls
{
    partial class ctrlFlatFileSourceFileSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlFlatFileSourceFileSelect));
            this.panFormat = new System.Windows.Forms.Panel();
            this.chkColNames = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numHdrSkip = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cboHdrRowDelim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQual = new System.Windows.Forms.TextBox();
            this.drpFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.threeDLine1 = new RainstormStudios.Controls.ThreeDLine();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlFlatFileSelect1 = new DataExplorer.ImportWizard_Controls.ctrlFlatFileSelect();
            this.panFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHdrSkip)).BeginInit();
            this.SuspendLayout();
            // 
            // panFormat
            // 
            this.panFormat.Controls.Add(this.chkColNames);
            this.panFormat.Controls.Add(this.label5);
            this.panFormat.Controls.Add(this.numHdrSkip);
            this.panFormat.Controls.Add(this.label4);
            this.panFormat.Controls.Add(this.cboHdrRowDelim);
            this.panFormat.Controls.Add(this.label3);
            this.panFormat.Controls.Add(this.txtQual);
            this.panFormat.Controls.Add(this.drpFormat);
            this.panFormat.Controls.Add(this.label2);
            this.panFormat.Enabled = false;
            this.panFormat.Location = new System.Drawing.Point(3, 142);
            this.panFormat.Name = "panFormat";
            this.panFormat.Size = new System.Drawing.Size(378, 130);
            this.panFormat.TabIndex = 9;
            // 
            // chkColNames
            // 
            this.chkColNames.AutoSize = true;
            this.chkColNames.Location = new System.Drawing.Point(27, 110);
            this.chkColNames.Name = "chkColNames";
            this.chkColNames.Size = new System.Drawing.Size(187, 17);
            this.chkColNames.TabIndex = 8;
            this.chkColNames.Text = "Column names in the first data row";
            this.chkColNames.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Header rows to skip:";
            // 
            // numHdrSkip
            // 
            this.numHdrSkip.Location = new System.Drawing.Point(222, 83);
            this.numHdrSkip.Name = "numHdrSkip";
            this.numHdrSkip.Size = new System.Drawing.Size(153, 20);
            this.numHdrSkip.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Header row delimiter:";
            // 
            // cboHdrRowDelim
            // 
            this.cboHdrRowDelim.FormattingEnabled = true;
            this.cboHdrRowDelim.Items.AddRange(new object[] {
            "{CR}{LF}",
            "{CR}",
            "{LF}",
            "Semicolon {;}",
            "Colon {:}",
            "Comma {,}",
            "Tab {t}",
            "Vertical Bar {|}"});
            this.cboHdrRowDelim.Location = new System.Drawing.Point(222, 56);
            this.cboHdrRowDelim.Name = "cboHdrRowDelim";
            this.cboHdrRowDelim.Size = new System.Drawing.Size(153, 21);
            this.cboHdrRowDelim.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Text qualifier:";
            // 
            // txtQual
            // 
            this.txtQual.Location = new System.Drawing.Point(222, 30);
            this.txtQual.Name = "txtQual";
            this.txtQual.Size = new System.Drawing.Size(153, 20);
            this.txtQual.TabIndex = 2;
            this.txtQual.Text = "<none>";
            // 
            // drpFormat
            // 
            this.drpFormat.FormattingEnabled = true;
            this.drpFormat.Items.AddRange(new object[] {
            "Delimited",
            "Fixed Width",
            "Ragged Right"});
            this.drpFormat.Location = new System.Drawing.Point(131, 3);
            this.drpFormat.Name = "drpFormat";
            this.drpFormat.Size = new System.Drawing.Size(167, 21);
            this.drpFormat.TabIndex = 1;
            this.drpFormat.SelectedIndexChanged += new System.EventHandler(this.drpFormat_onSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Format:";
            // 
            // threeDLine1
            // 
            this.threeDLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.threeDLine1.Location = new System.Drawing.Point(6, 125);
            this.threeDLine1.Name = "threeDLine1";
            this.threeDLine1.Size = new System.Drawing.Size(375, 11);
            this.threeDLine1.TabIndex = 8;
            this.threeDLine1.Text = "threeDLine1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select a file and specify file properties and file format.";
            // 
            // ctrlFlatFileSelect1
            // 
            this.ctrlFlatFileSelect1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlFlatFileSelect1.CodePage = ((System.Text.Encoding)(resources.GetObject("ctrlFlatFileSelect1.CodePage")));
            this.ctrlFlatFileSelect1.FileFormat = DataExplorer.ImportWizard_Controls.FlatFileFormat.Delimited;
            this.ctrlFlatFileSelect1.Filename = "";
            this.ctrlFlatFileSelect1.Locale = new System.Globalization.CultureInfo("en-US");
            this.ctrlFlatFileSelect1.Location = new System.Drawing.Point(3, 43);
            this.ctrlFlatFileSelect1.MaximumSize = new System.Drawing.Size(5000, 82);
            this.ctrlFlatFileSelect1.MinimumSize = new System.Drawing.Size(350, 82);
            this.ctrlFlatFileSelect1.Name = "ctrlFlatFileSelect1";
            this.ctrlFlatFileSelect1.SaveMode = false;
            this.ctrlFlatFileSelect1.Size = new System.Drawing.Size(392, 82);
            this.ctrlFlatFileSelect1.TabIndex = 10;
            this.ctrlFlatFileSelect1.FilenameChanged += new System.EventHandler(this.ctrlFlatFileSelect1_onFilenameChanged);
            // 
            // ctrlFlatFileSourceFileSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlFlatFileSelect1);
            this.Controls.Add(this.panFormat);
            this.Controls.Add(this.threeDLine1);
            this.Controls.Add(this.label1);
            this.Name = "ctrlFlatFileSourceFileSelect";
            this.Size = new System.Drawing.Size(395, 275);
            this.panFormat.ResumeLayout(false);
            this.panFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHdrSkip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panFormat;
        private System.Windows.Forms.CheckBox chkColNames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numHdrSkip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboHdrRowDelim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQual;
        private System.Windows.Forms.ComboBox drpFormat;
        private System.Windows.Forms.Label label2;
        private RainstormStudios.Controls.ThreeDLine threeDLine1;
        private System.Windows.Forms.Label label1;
        private ctrlFlatFileSelect ctrlFlatFileSelect1;
    }
}
