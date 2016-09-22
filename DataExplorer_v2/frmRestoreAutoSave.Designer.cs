namespace DataExplorer
{
    partial class frmRestoreAutoSave
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
            System.Drawing.Drawing2D.GraphicsPath graphicsPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath2 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath3 = new System.Drawing.Drawing2D.GraphicsPath();
            this.btnCancel = new RainstormStudios.Controls.AdvancedButton();
            this.btnRestore = new RainstormStudios.Controls.AdvancedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAll = new RainstormStudios.Controls.AdvancedButton();
            this.lstFiles = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.btnCancel.BorderWidth = 1;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnCancel.ButtonShape = graphicsPath1;
            this.btnCancel.CornerFeather = 5;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.btnCancel.HighlightMultiplier = 2F;
            this.btnCancel.HoverHighlightColor = System.Drawing.Color.Orange;
            this.btnCancel.HoverHighlightOpacity = 200;
            this.btnCancel.HoverImage = null;
            this.btnCancel.ImagePadding = 0;
            this.btnCancel.Location = new System.Drawing.Point(391, 235);
            this.btnCancel.MinimumSize = new System.Drawing.Size(8, 8);
            this.btnCancel.MouseDownImage = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextOutline = false;
            this.btnCancel.TextOutlineColor = System.Drawing.Color.Empty;
            this.btnCancel.TextOutlineOpacity = 255;
            this.btnCancel.TextOutlineWeight = 2F;
            this.btnCancel.ThreeDEffectDepth = 50;
            this.btnCancel.ToggleActiveColor = System.Drawing.Color.Empty;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.btnRestore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.btnRestore.BorderWidth = 1;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnRestore.ButtonShape = graphicsPath2;
            this.btnRestore.CornerFeather = 5;
            this.btnRestore.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRestore.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRestore.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnRestore.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.btnRestore.HighlightMultiplier = 2F;
            this.btnRestore.HoverHighlightColor = System.Drawing.Color.Orange;
            this.btnRestore.HoverHighlightOpacity = 200;
            this.btnRestore.HoverImage = null;
            this.btnRestore.ImagePadding = 0;
            this.btnRestore.Location = new System.Drawing.Point(310, 235);
            this.btnRestore.MinimumSize = new System.Drawing.Size(8, 8);
            this.btnRestore.MouseDownImage = null;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Restore";
            this.btnRestore.TextOutline = false;
            this.btnRestore.TextOutlineColor = System.Drawing.Color.Empty;
            this.btnRestore.TextOutlineOpacity = 255;
            this.btnRestore.TextOutlineWeight = 2F;
            this.btnRestore.ThreeDEffectDepth = 50;
            this.btnRestore.ToggleActiveColor = System.Drawing.Color.Empty;
            this.btnRestore.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "The following auto-saved files were detected on the system.  Would you like to re" +
    "store one of these files?";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.btnDeleteAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.btnDeleteAll.BorderWidth = 1;
            graphicsPath3.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnDeleteAll.ButtonShape = graphicsPath3;
            this.btnDeleteAll.CornerFeather = 5;
            this.btnDeleteAll.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteAll.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDeleteAll.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.btnDeleteAll.HighlightMultiplier = 2F;
            this.btnDeleteAll.HoverHighlightColor = System.Drawing.Color.Crimson;
            this.btnDeleteAll.HoverHighlightOpacity = 200;
            this.btnDeleteAll.HoverImage = null;
            this.btnDeleteAll.ImagePadding = 0;
            this.btnDeleteAll.Location = new System.Drawing.Point(12, 235);
            this.btnDeleteAll.MinimumSize = new System.Drawing.Size(8, 8);
            this.btnDeleteAll.MouseDownImage = null;
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAll.TabIndex = 4;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.TextOutline = false;
            this.btnDeleteAll.TextOutlineColor = System.Drawing.Color.Empty;
            this.btnDeleteAll.TextOutlineOpacity = 255;
            this.btnDeleteAll.TextOutlineWeight = 2F;
            this.btnDeleteAll.ThreeDEffectDepth = 50;
            this.btnDeleteAll.ToggleActiveColor = System.Drawing.Color.Empty;
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.AutoScroll = true;
            this.lstFiles.BackColor = System.Drawing.SystemColors.Window;
            this.lstFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFiles.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.lstFiles.Location = new System.Drawing.Point(12, 42);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(454, 187);
            this.lstFiles.TabIndex = 5;
            this.lstFiles.WrapContents = false;
            // 
            // frmRestoreAutoSave
            // 
            this.AcceptButton = this.btnRestore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(478, 270);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmRestoreAutoSave";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Restore Auto-Saved File";
            this.ResumeLayout(false);

        }

        #endregion

        private RainstormStudios.Controls.AdvancedButton btnCancel;
        private RainstormStudios.Controls.AdvancedButton btnRestore;
        private System.Windows.Forms.Label label1;
        private RainstormStudios.Controls.AdvancedButton btnDeleteAll;
        private System.Windows.Forms.FlowLayoutPanel lstFiles;
    }
}