namespace DataExplorer.ImportWizard_Controls
{
    partial class ctrlFlatFileDestination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlFlatFileDestination));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.drpFormat = new System.Windows.Forms.ComboBox();
            this.txtQualifier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkColNames = new System.Windows.Forms.CheckBox();
            this.panFormat = new System.Windows.Forms.Panel();
            this.threeDLine1 = new RainstormStudios.Controls.ThreeDLine();
            this.ctrlFlatFileSelect = new DataExplorer.ImportWizard_Controls.ctrlFlatFileSelect();
            this.panFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a file and specify file properties and file format.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Format:";
            // 
            // drpFormat
            // 
            this.drpFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.drpFormat.FormattingEnabled = true;
            this.drpFormat.Items.AddRange(new object[] {
            "Delimited",
            "Fixed Width",
            "Ragged Right"});
            this.drpFormat.Location = new System.Drawing.Point(135, 1);
            this.drpFormat.Name = "drpFormat";
            this.drpFormat.Size = new System.Drawing.Size(263, 21);
            this.drpFormat.TabIndex = 11;
            // 
            // txtQualifier
            // 
            this.txtQualifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQualifier.Location = new System.Drawing.Point(135, 28);
            this.txtQualifier.Name = "txtQualifier";
            this.txtQualifier.Size = new System.Drawing.Size(263, 20);
            this.txtQualifier.TabIndex = 12;
            this.txtQualifier.Text = "<none>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Text qualifier:";
            // 
            // chkColNames
            // 
            this.chkColNames.AutoSize = true;
            this.chkColNames.Location = new System.Drawing.Point(27, 54);
            this.chkColNames.Name = "chkColNames";
            this.chkColNames.Size = new System.Drawing.Size(163, 17);
            this.chkColNames.TabIndex = 14;
            this.chkColNames.Text = "Column names in the first row";
            this.chkColNames.UseVisualStyleBackColor = true;
            // 
            // panFormat
            // 
            this.panFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panFormat.Controls.Add(this.chkColNames);
            this.panFormat.Controls.Add(this.label6);
            this.panFormat.Controls.Add(this.txtQualifier);
            this.panFormat.Controls.Add(this.drpFormat);
            this.panFormat.Controls.Add(this.label5);
            this.panFormat.Enabled = false;
            this.panFormat.Location = new System.Drawing.Point(24, 155);
            this.panFormat.Name = "panFormat";
            this.panFormat.Size = new System.Drawing.Size(407, 72);
            this.panFormat.TabIndex = 15;
            // 
            // threeDLine1
            // 
            this.threeDLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.threeDLine1.Location = new System.Drawing.Point(3, 122);
            this.threeDLine1.Name = "threeDLine1";
            this.threeDLine1.Size = new System.Drawing.Size(444, 27);
            this.threeDLine1.TabIndex = 9;
            this.threeDLine1.Text = "threeDLine1";
            // 
            // ctrlFlatFileSelect
            // 
            this.ctrlFlatFileSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlFlatFileSelect.CodePage = ((System.Text.Encoding)(resources.GetObject("ctrlFlatFileSelect.CodePage")));
            this.ctrlFlatFileSelect.FileFormat = DataExplorer.ImportWizard_Controls.FlatFileFormat.Delimited;
            this.ctrlFlatFileSelect.Locale = new System.Globalization.CultureInfo("en-US");
            this.ctrlFlatFileSelect.Location = new System.Drawing.Point(28, 45);
            this.ctrlFlatFileSelect.MaximumSize = new System.Drawing.Size(5000, 82);
            this.ctrlFlatFileSelect.MinimumSize = new System.Drawing.Size(350, 82);
            this.ctrlFlatFileSelect.Name = "ctrlFlatFileSelect";
            this.ctrlFlatFileSelect.SaveMode = true;
            this.ctrlFlatFileSelect.Size = new System.Drawing.Size(403, 82);
            this.ctrlFlatFileSelect.TabIndex = 16;
            // 
            // ctrlFlatFileDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlFlatFileSelect);
            this.Controls.Add(this.panFormat);
            this.Controls.Add(this.threeDLine1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(5000, 230);
            this.MinimumSize = new System.Drawing.Size(400, 230);
            this.Name = "ctrlFlatFileDestination";
            this.Size = new System.Drawing.Size(450, 230);
            this.panFormat.ResumeLayout(false);
            this.panFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RainstormStudios.Controls.ThreeDLine threeDLine1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox drpFormat;
        private System.Windows.Forms.TextBox txtQualifier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkColNames;
        private System.Windows.Forms.Panel panFormat;
        private ctrlFlatFileSelect ctrlFlatFileSelect;
    }
}
