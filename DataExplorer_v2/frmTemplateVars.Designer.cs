namespace DataExplorer
{
    partial class frmTemplateVars
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
            System.Drawing.Drawing2D.GraphicsPath graphicsPath2 = new System.Drawing.Drawing2D.GraphicsPath();
            this.lstVars = new System.Windows.Forms.CheckedListBox();
            this.cmdSave = new RainstormStudios.Controls.AdvancedButton();
            this.SuspendLayout();
            // 
            // lstVars
            // 
            this.lstVars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVars.CheckOnClick = true;
            this.lstVars.FormattingEnabled = true;
            this.lstVars.IntegralHeight = false;
            this.lstVars.Location = new System.Drawing.Point(12, 12);
            this.lstVars.Name = "lstVars";
            this.lstVars.ScrollAlwaysVisible = true;
            this.lstVars.Size = new System.Drawing.Size(268, 213);
            this.lstVars.TabIndex = 0;
            this.lstVars.ThreeDCheckBoxes = true;
            // 
            // cmdSave
            // 
            this.cmdSave.AllowWordWrap = false;
            this.cmdSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdSave.BackgroundRotationDegrees = 0F;
            this.cmdSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdSave.BorderWidth = 1;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdSave.ButtonShape = graphicsPath2;
            this.cmdSave.CornerFeather = 3;
            this.cmdSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdSave.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdSave.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdSave.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.Standard;
            this.cmdSave.HighlightMultiplier = 2F;
            this.cmdSave.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdSave.HoverHighlightOpacity = 200;
            this.cmdSave.HoverImage = null;
            this.cmdSave.ImagePadding = 0;
            this.cmdSave.Location = new System.Drawing.Point(205, 231);
            this.cmdSave.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdSave.MouseDownImage = null;
            this.cmdSave.MultiSample = true;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 1;
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
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // frmTemplateVars
            // 
            this.AcceptButton = this.cmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.lstVars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTemplateVars";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Template Variables";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstVars;
        private RainstormStudios.Controls.AdvancedButton cmdSave;
    }
}