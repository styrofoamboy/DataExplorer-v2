namespace DataExplorer
{
    partial class frmAutoHighlight
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
            this.flwColorAssign = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdCancel = new RainstormStudios.Controls.AdvancedButton();
            this.cmdOk = new RainstormStudios.Controls.AdvancedButton();
            this.SuspendLayout();
            // 
            // flwColorAssign
            // 
            this.flwColorAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flwColorAssign.AutoScroll = true;
            this.flwColorAssign.Location = new System.Drawing.Point(12, 12);
            this.flwColorAssign.Name = "flwColorAssign";
            this.flwColorAssign.Size = new System.Drawing.Size(321, 163);
            this.flwColorAssign.TabIndex = 0;
            // 
            // cmdCancel
            // 
            this.cmdCancel.AllowWordWrap = false;
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdCancel.BackgroundRotationDegrees = 0F;
            this.cmdCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdCancel.BorderWidth = 1;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdCancel.ButtonShape = graphicsPath1;
            this.cmdCancel.CornerFeather = 3;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdCancel.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.Standard;
            this.cmdCancel.HighlightMultiplier = 2F;
            this.cmdCancel.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdCancel.HoverHighlightOpacity = 200;
            this.cmdCancel.HoverImage = null;
            this.cmdCancel.ImagePadding = 0;
            this.cmdCancel.Location = new System.Drawing.Point(258, 181);
            this.cmdCancel.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdCancel.MouseDownImage = null;
            this.cmdCancel.MultiSample = true;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 1;
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
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOk
            // 
            this.cmdOk.AllowWordWrap = false;
            this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdOk.BackgroundRotationDegrees = 0F;
            this.cmdOk.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdOk.BorderWidth = 1;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdOk.ButtonShape = graphicsPath2;
            this.cmdOk.CornerFeather = 3;
            this.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOk.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdOk.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdOk.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.Standard;
            this.cmdOk.HighlightMultiplier = 2F;
            this.cmdOk.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdOk.HoverHighlightOpacity = 200;
            this.cmdOk.HoverImage = null;
            this.cmdOk.ImagePadding = 0;
            this.cmdOk.Location = new System.Drawing.Point(177, 181);
            this.cmdOk.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdOk.MouseDownImage = null;
            this.cmdOk.MultiSample = true;
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 2;
            this.cmdOk.Text = "Ok";
            this.cmdOk.TextOutline = false;
            this.cmdOk.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdOk.TextOutlineOpacity = 255;
            this.cmdOk.TextOutlineWeight = 2F;
            this.cmdOk.TextRotationDegrees = 0F;
            this.cmdOk.TextShadow = false;
            this.cmdOk.TextShadowOffset = 1F;
            this.cmdOk.TextShadowOpacity = 80;
            this.cmdOk.TextVeritcal = false;
            this.cmdOk.ThreeDEffectDepth = 50;
            this.cmdOk.UseVisualStyleBackColor = true;
            // 
            // frmAutoHighlight
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(345, 216);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.flwColorAssign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAutoHighlight";
            this.Text = "Auto-Style";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwColorAssign;
        private RainstormStudios.Controls.AdvancedButton cmdCancel;
        private RainstormStudios.Controls.AdvancedButton cmdOk;
    }
}