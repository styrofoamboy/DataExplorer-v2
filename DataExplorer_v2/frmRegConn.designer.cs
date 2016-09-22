namespace DataExplorer
{
    partial class frmRegConn
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
            this.connectionStringBox1 = new RainstormStudios.Controls.ConnectionStringBox();
            this.grpConnName = new System.Windows.Forms.GroupBox();
            this.txtConnName = new System.Windows.Forms.TextBox();
            this.cmdOK = new RainstormStudios.Controls.AdvancedButton();
            this.cmdCancel = new RainstormStudios.Controls.AdvancedButton();
            this.grpConnName.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionStringBox1
            // 
            this.connectionStringBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionStringBox1.ConnectionString = "";
            this.connectionStringBox1.ControlBackColor = System.Drawing.SystemColors.Window;
            this.connectionStringBox1.Location = new System.Drawing.Point(12, 62);
            this.connectionStringBox1.MinimumSize = new System.Drawing.Size(312, 72);
            this.connectionStringBox1.Name = "connectionStringBox1";
            this.connectionStringBox1.ProviderID = RainstormStudios.Data.AdoProviderType.SqlProvider;
            this.connectionStringBox1.Size = new System.Drawing.Size(386, 72);
            this.connectionStringBox1.TabIndex = 0;
            // 
            // grpConnName
            // 
            this.grpConnName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConnName.Controls.Add(this.txtConnName);
            this.grpConnName.Location = new System.Drawing.Point(12, 12);
            this.grpConnName.Name = "grpConnName";
            this.grpConnName.Size = new System.Drawing.Size(386, 44);
            this.grpConnName.TabIndex = 1;
            this.grpConnName.TabStop = false;
            this.grpConnName.Text = "Connection Name";
            // 
            // txtConnName
            // 
            this.txtConnName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnName.Location = new System.Drawing.Point(6, 18);
            this.txtConnName.Name = "txtConnName";
            this.txtConnName.Size = new System.Drawing.Size(374, 20);
            this.txtConnName.TabIndex = 0;
            // 
            // cmdOK
            // 
            this.cmdOK.AllowWordWrap = false;
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdOK.BackgroundRotationDegrees = 0F;
            this.cmdOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdOK.BorderWidth = 1;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdOK.ButtonShape = graphicsPath1;
            this.cmdOK.CornerFeather = 3;
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdOK.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdOK.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.Standard;
            this.cmdOK.HighlightMultiplier = 2F;
            this.cmdOK.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdOK.HoverHighlightOpacity = 200;
            this.cmdOK.HoverImage = null;
            this.cmdOK.ImagePadding = 0;
            this.cmdOK.Location = new System.Drawing.Point(236, 144);
            this.cmdOK.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdOK.MouseDownImage = null;
            this.cmdOK.MultiSample = true;
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 2;
            this.cmdOK.Text = "Save";
            this.cmdOK.TextOutline = false;
            this.cmdOK.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdOK.TextOutlineOpacity = 255;
            this.cmdOK.TextOutlineWeight = 2F;
            this.cmdOK.TextRotationDegrees = 0F;
            this.cmdOK.TextShadow = false;
            this.cmdOK.TextShadowOffset = 1F;
            this.cmdOK.TextShadowOpacity = 80;
            this.cmdOK.TextVeritcal = false;
            this.cmdOK.ThreeDEffectDepth = 50;
            this.cmdOK.UseVisualStyleBackColor = true;
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
            this.cmdCancel.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.Standard;
            this.cmdCancel.HighlightMultiplier = 2F;
            this.cmdCancel.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdCancel.HoverHighlightOpacity = 200;
            this.cmdCancel.HoverImage = null;
            this.cmdCancel.ImagePadding = 0;
            this.cmdCancel.Location = new System.Drawing.Point(317, 144);
            this.cmdCancel.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdCancel.MouseDownImage = null;
            this.cmdCancel.MultiSample = true;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 3;
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
            // frmRegConn
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(410, 179);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.grpConnName);
            this.Controls.Add(this.connectionStringBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(5000, 205);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(8, 205);
            this.Name = "frmRegConn";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registered Connection String";
            this.grpConnName.ResumeLayout(false);
            this.grpConnName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RainstormStudios.Controls.ConnectionStringBox connectionStringBox1;
        private System.Windows.Forms.GroupBox grpConnName;
        private System.Windows.Forms.TextBox txtConnName;
        private RainstormStudios.Controls.AdvancedButton cmdOK;
        private RainstormStudios.Controls.AdvancedButton cmdCancel;
    }
}