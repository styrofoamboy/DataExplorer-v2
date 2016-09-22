namespace DataExplorer.ImportWizard_Controls
{
    partial class ctrlFlatFileSourcePreview
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSkipRows = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.threeDLine1 = new RainstormStudios.Controls.ThreeDLine();
            this.lblPrevRows = new System.Windows.Forms.Label();
            this.dgPrev = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numSkipRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrev)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This shows the source file divided into the specified columns.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data rows to skip:";
            // 
            // numSkipRows
            // 
            this.numSkipRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSkipRows.Location = new System.Drawing.Point(240, 25);
            this.numSkipRows.Name = "numSkipRows";
            this.numSkipRows.Size = new System.Drawing.Size(152, 20);
            this.numSkipRows.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preview rows:";
            // 
            // threeDLine1
            // 
            this.threeDLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.threeDLine1.Location = new System.Drawing.Point(3, 43);
            this.threeDLine1.Name = "threeDLine1";
            this.threeDLine1.Size = new System.Drawing.Size(389, 16);
            this.threeDLine1.TabIndex = 4;
            this.threeDLine1.Text = "threeDLine1";
            // 
            // lblPrevRows
            // 
            this.lblPrevRows.AutoSize = true;
            this.lblPrevRows.Location = new System.Drawing.Point(82, 62);
            this.lblPrevRows.Name = "lblPrevRows";
            this.lblPrevRows.Size = new System.Drawing.Size(22, 13);
            this.lblPrevRows.TabIndex = 5;
            this.lblPrevRows.Text = "1-1";
            // 
            // dgPrev
            // 
            this.dgPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPrev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrev.Location = new System.Drawing.Point(3, 78);
            this.dgPrev.Name = "dgPrev";
            this.dgPrev.Size = new System.Drawing.Size(389, 197);
            this.dgPrev.TabIndex = 6;
            // 
            // ctrlFlatFileSourcePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgPrev);
            this.Controls.Add(this.lblPrevRows);
            this.Controls.Add(this.threeDLine1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numSkipRows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ctrlFlatFileSourcePreview";
            this.Size = new System.Drawing.Size(395, 275);
            ((System.ComponentModel.ISupportInitialize)(this.numSkipRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSkipRows;
        private System.Windows.Forms.Label label3;
        private RainstormStudios.Controls.ThreeDLine threeDLine1;
        private System.Windows.Forms.Label lblPrevRows;
        private System.Windows.Forms.DataGridView dgPrev;
    }
}
