namespace DataExplorer.ImportWizard_Controls
{
    partial class ctrlFlatFileSourceColumnConfig
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
            this.grpDelim = new System.Windows.Forms.GroupBox();
            this.cboRowDelim = new System.Windows.Forms.ComboBox();
            this.cboColDelim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrevRowNums = new System.Windows.Forms.Label();
            this.dgPreview = new System.Windows.Forms.DataGridView();
            this.grpDelim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDelim
            // 
            this.grpDelim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDelim.Controls.Add(this.label2);
            this.grpDelim.Controls.Add(this.label1);
            this.grpDelim.Controls.Add(this.cboColDelim);
            this.grpDelim.Controls.Add(this.cboRowDelim);
            this.grpDelim.Location = new System.Drawing.Point(3, 3);
            this.grpDelim.Name = "grpDelim";
            this.grpDelim.Size = new System.Drawing.Size(389, 76);
            this.grpDelim.TabIndex = 0;
            this.grpDelim.TabStop = false;
            this.grpDelim.Text = "Specify the characters that delimit the source file";
            // 
            // cboRowDelim
            // 
            this.cboRowDelim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRowDelim.FormattingEnabled = true;
            this.cboRowDelim.Items.AddRange(new object[] {
            "{CR}{LF}",
            "{CR}",
            "{LF}",
            "Semicolon {;}",
            "Colon {:}",
            "Comma {,}",
            "Tab {t}",
            "Vertical Bar {|}"});
            this.cboRowDelim.Location = new System.Drawing.Point(190, 19);
            this.cboRowDelim.Name = "cboRowDelim";
            this.cboRowDelim.Size = new System.Drawing.Size(193, 21);
            this.cboRowDelim.TabIndex = 5;
            // 
            // cboColDelim
            // 
            this.cboColDelim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColDelim.FormattingEnabled = true;
            this.cboColDelim.Items.AddRange(new object[] {
            "{CR}{LF}",
            "{CR}",
            "{LF}",
            "Semicolon {;}",
            "Colon {:}",
            "Comma {,}",
            "Tab {t}",
            "Vertical Bar {|}"});
            this.cboColDelim.Location = new System.Drawing.Point(190, 46);
            this.cboColDelim.Name = "cboColDelim";
            this.cboColDelim.Size = new System.Drawing.Size(193, 21);
            this.cboColDelim.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Row delimiter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Column delimiter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Preview rows:";
            // 
            // lblPrevRowNums
            // 
            this.lblPrevRowNums.AutoSize = true;
            this.lblPrevRowNums.Location = new System.Drawing.Point(91, 89);
            this.lblPrevRowNums.Name = "lblPrevRowNums";
            this.lblPrevRowNums.Size = new System.Drawing.Size(22, 13);
            this.lblPrevRowNums.TabIndex = 2;
            this.lblPrevRowNums.Text = "1-1";
            // 
            // dgPreview
            // 
            this.dgPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPreview.Location = new System.Drawing.Point(3, 105);
            this.dgPreview.Name = "dgPreview";
            this.dgPreview.Size = new System.Drawing.Size(389, 170);
            this.dgPreview.TabIndex = 3;
            // 
            // ctrlFlatFileSourceColumnConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgPreview);
            this.Controls.Add(this.lblPrevRowNums);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpDelim);
            this.Name = "ctrlFlatFileSourceColumnConfig";
            this.Size = new System.Drawing.Size(395, 275);
            this.grpDelim.ResumeLayout(false);
            this.grpDelim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRowDelim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboColDelim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrevRowNums;
        private System.Windows.Forms.DataGridView dgPreview;
        private System.Windows.Forms.GroupBox grpDelim;
    }
}
