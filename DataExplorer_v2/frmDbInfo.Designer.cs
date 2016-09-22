namespace DataExplorer
{
    partial class frmDbInfo
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
            this.prgdDbInfo = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // prgdDbInfo
            // 
            this.prgdDbInfo.CommandsVisibleIfAvailable = false;
            this.prgdDbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prgdDbInfo.HelpVisible = false;
            this.prgdDbInfo.Location = new System.Drawing.Point(0, 0);
            this.prgdDbInfo.Name = "prgdDbInfo";
            this.prgdDbInfo.Size = new System.Drawing.Size(524, 321);
            this.prgdDbInfo.TabIndex = 0;
            this.prgdDbInfo.ToolbarVisible = false;
            // 
            // frmDbInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 321);
            this.Controls.Add(this.prgdDbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmDbInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid prgdDbInfo;

    }
}