namespace DataExplorer.ImportWizard_Controls
{
    partial class ctrlFlatFileSource
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ctrlFlatFileSourceColumnConfig1 = new DataExplorer.ImportWizard_Controls.ctrlFlatFileSourceColumnConfig();
            this.ctrlFlatFileSourceFileSelect1 = new DataExplorer.ImportWizard_Controls.ctrlFlatFileSourceFileSelect();
            this.ctrlFlatFileSourcePreview1 = new DataExplorer.ImportWizard_Controls.ctrlFlatFileSourcePreview();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Items.AddRange(new object[] {
            "General",
            "Columns",
            "Advanced",
            "Preview"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(92, 278);
            this.listBox1.TabIndex = 2;
            // 
            // ctrlFlatFileSourceColumnConfig1
            // 
            this.ctrlFlatFileSourceColumnConfig1.Location = new System.Drawing.Point(98, 3);
            this.ctrlFlatFileSourceColumnConfig1.Name = "ctrlFlatFileSourceColumnConfig1";
            this.ctrlFlatFileSourceColumnConfig1.Size = new System.Drawing.Size(395, 275);
            this.ctrlFlatFileSourceColumnConfig1.TabIndex = 4;
            this.ctrlFlatFileSourceColumnConfig1.Visible = false;
            // 
            // ctrlFlatFileSourceFileSelect1
            // 
            this.ctrlFlatFileSourceFileSelect1.ColumnHeaderNames = false;
            this.ctrlFlatFileSourceFileSelect1.FileFormat = DataExplorer.ImportWizard_Controls.FlatFileFormat.Delimited;
            this.ctrlFlatFileSourceFileSelect1.HeaderRowDelim = "{CR}{LF}";
            this.ctrlFlatFileSourceFileSelect1.HeaderRowSkip = 0;
            this.ctrlFlatFileSourceFileSelect1.Location = new System.Drawing.Point(98, 3);
            this.ctrlFlatFileSourceFileSelect1.Name = "ctrlFlatFileSourceFileSelect1";
            this.ctrlFlatFileSourceFileSelect1.Size = new System.Drawing.Size(395, 275);
            this.ctrlFlatFileSourceFileSelect1.TabIndex = 3;
            this.ctrlFlatFileSourceFileSelect1.TextQualifier = "<none>";
            // 
            // ctrlFlatFileSourcePreview1
            // 
            this.ctrlFlatFileSourcePreview1.Location = new System.Drawing.Point(98, 3);
            this.ctrlFlatFileSourcePreview1.Name = "ctrlFlatFileSourcePreview1";
            this.ctrlFlatFileSourcePreview1.Size = new System.Drawing.Size(395, 275);
            this.ctrlFlatFileSourcePreview1.TabIndex = 5;
            this.ctrlFlatFileSourcePreview1.Visible = false;
            // 
            // ctrlFlatFileSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ctrlFlatFileSourceColumnConfig1);
            this.Controls.Add(this.ctrlFlatFileSourceFileSelect1);
            this.Controls.Add(this.ctrlFlatFileSourcePreview1);
            this.Name = "ctrlFlatFileSource";
            this.Size = new System.Drawing.Size(495, 282);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private ctrlFlatFileSourceFileSelect ctrlFlatFileSourceFileSelect1;
        private ctrlFlatFileSourceColumnConfig ctrlFlatFileSourceColumnConfig1;
        private ctrlFlatFileSourcePreview ctrlFlatFileSourcePreview1;

    }
}
