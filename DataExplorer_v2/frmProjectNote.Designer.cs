namespace DataExplorer
{
    partial class frmProjectNote
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
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.panSubject = new System.Windows.Forms.Panel();
            this.panNote = new System.Windows.Forms.Panel();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new RainstormStudios.Controls.AdvRichTextBox();
            this.cmdSave = new RainstormStudios.Controls.AdvancedButton();
            this.cmdCancel = new RainstormStudios.Controls.AdvancedButton();
            this.panSubject.SuspendLayout();
            this.panNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(3, 6);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Subject:";
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.Location = new System.Drawing.Point(55, 3);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(304, 20);
            this.txtSubject.TabIndex = 1;
            // 
            // panSubject
            // 
            this.panSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panSubject.Controls.Add(this.txtSubject);
            this.panSubject.Controls.Add(this.lblSubject);
            this.panSubject.Location = new System.Drawing.Point(12, 12);
            this.panSubject.Name = "panSubject";
            this.panSubject.Size = new System.Drawing.Size(362, 27);
            this.panSubject.TabIndex = 2;
            // 
            // panNote
            // 
            this.panNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panNote.Controls.Add(this.txtNote);
            this.panNote.Controls.Add(this.lblNote);
            this.panNote.Location = new System.Drawing.Point(12, 45);
            this.panNote.Name = "panNote";
            this.panNote.Size = new System.Drawing.Size(362, 144);
            this.panNote.TabIndex = 3;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(16, 6);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(33, 13);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "Note:";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.HideCaretWhenReadOnly = false;
            this.txtNote.HorizontalScrollPos = 0;
            this.txtNote.Location = new System.Drawing.Point(55, 3);
            this.txtNote.MaxUndoLevel = 100;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(304, 138);
            this.txtNote.TabIndex = 1;
            this.txtNote.Text = "";
            this.txtNote.VerticalScrollPos = 0;
            // 
            // cmdSave
            // 
            this.cmdSave.AllowWordWrap = false;
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdSave.BackgroundRotationDegrees = 0F;
            this.cmdSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdSave.BorderWidth = 1;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdSave.ButtonShape = graphicsPath1;
            this.cmdSave.CornerFeather = 3;
            this.cmdSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdSave.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdSave.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdSave.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdSave.HighlightMultiplier = 2F;
            this.cmdSave.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdSave.HoverHighlightOpacity = 200;
            this.cmdSave.HoverImage = null;
            this.cmdSave.ImagePadding = 0;
            this.cmdSave.Location = new System.Drawing.Point(276, 195);
            this.cmdSave.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdSave.MouseDownImage = null;
            this.cmdSave.MultiSample = true;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(95, 23);
            this.cmdSave.TabIndex = 4;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextOutline = false;
            this.cmdSave.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdSave.TextOutlineOpacity = 255;
            this.cmdSave.TextOutlineWeight = 2F;
            this.cmdSave.TextRotationDegrees = 0F;
            this.cmdSave.TextShadow = false;
            this.cmdSave.TextShadowOffset = 1F;
            this.cmdSave.TextShadowOpacity = 80;
            this.cmdSave.TextVeritcal = false;
            this.cmdSave.ThreeDEffectDepth = 50;
            this.cmdSave.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.AllowWordWrap = false;
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdCancel.BackgroundRotationDegrees = 0F;
            this.cmdCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdCancel.BorderWidth = 1;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdCancel.ButtonShape = graphicsPath2;
            this.cmdCancel.CornerFeather = 3;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdCancel.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdCancel.HighlightMultiplier = 2F;
            this.cmdCancel.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdCancel.HoverHighlightOpacity = 200;
            this.cmdCancel.HoverImage = null;
            this.cmdCancel.ImagePadding = 0;
            this.cmdCancel.Location = new System.Drawing.Point(175, 195);
            this.cmdCancel.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdCancel.MouseDownImage = null;
            this.cmdCancel.MultiSample = true;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(95, 23);
            this.cmdCancel.TabIndex = 5;
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
            this.cmdCancel.ThreeDEffectDepth = 50;
            this.cmdCancel.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // frmProjectNote
            // 
            this.AcceptButton = this.cmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(386, 230);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.panNote);
            this.Controls.Add(this.panSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmProjectNote";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Project Note";
            this.panSubject.ResumeLayout(false);
            this.panSubject.PerformLayout();
            this.panNote.ResumeLayout(false);
            this.panNote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Panel panSubject;
        private System.Windows.Forms.Panel panNote;
        private System.Windows.Forms.Label lblNote;
        private RainstormStudios.Controls.AdvancedButton cmdSave;
        private RainstormStudios.Controls.AdvancedButton cmdCancel;
        private RainstormStudios.Controls.AdvRichTextBox txtNote;
    }
}