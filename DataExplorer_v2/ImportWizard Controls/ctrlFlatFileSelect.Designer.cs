namespace DataExplorer.ImportWizard_Controls
{
    partial class ctrlFlatFileSelect
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
            System.Drawing.Drawing2D.GraphicsPath graphicsPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            this.panCulture = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.drpCodepage = new System.Windows.Forms.ComboBox();
            this.chkUnicode = new System.Windows.Forms.CheckBox();
            this.drpLocale = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdBrowse = new RainstormStudios.Controls.AdvancedButton();
            this.panCulture.SuspendLayout();
            this.SuspendLayout();
            // 
            // panCulture
            // 
            this.panCulture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panCulture.Controls.Add(this.label4);
            this.panCulture.Controls.Add(this.drpCodepage);
            this.panCulture.Controls.Add(this.chkUnicode);
            this.panCulture.Controls.Add(this.drpLocale);
            this.panCulture.Controls.Add(this.label3);
            this.panCulture.Enabled = false;
            this.panCulture.Location = new System.Drawing.Point(12, 26);
            this.panCulture.Name = "panCulture";
            this.panCulture.Size = new System.Drawing.Size(388, 54);
            this.panCulture.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Code page:";
            // 
            // drpCodepage
            // 
            this.drpCodepage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.drpCodepage.FormattingEnabled = true;
            this.drpCodepage.Location = new System.Drawing.Point(117, 27);
            this.drpCodepage.Name = "drpCodepage";
            this.drpCodepage.Size = new System.Drawing.Size(263, 21);
            this.drpCodepage.TabIndex = 7;
            // 
            // chkUnicode
            // 
            this.chkUnicode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUnicode.AutoSize = true;
            this.chkUnicode.Location = new System.Drawing.Point(287, 2);
            this.chkUnicode.Name = "chkUnicode";
            this.chkUnicode.Size = new System.Drawing.Size(66, 17);
            this.chkUnicode.TabIndex = 6;
            this.chkUnicode.Text = "Unicode";
            this.chkUnicode.UseVisualStyleBackColor = true;
            // 
            // drpLocale
            // 
            this.drpLocale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.drpLocale.FormattingEnabled = true;
            this.drpLocale.Location = new System.Drawing.Point(117, 0);
            this.drpLocale.Name = "drpLocale";
            this.drpLocale.Size = new System.Drawing.Size(164, 21);
            this.drpLocale.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Locale:";
            // 
            // txtFilename
            // 
            this.txtFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilename.Location = new System.Drawing.Point(129, 0);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(185, 20);
            this.txtFilename.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "File name:";
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.AllowWordWrap = false;
            this.cmdBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdBrowse.BackgroundRotationDegrees = 0F;
            this.cmdBrowse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdBrowse.BorderWidth = 1;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdBrowse.ButtonShape = graphicsPath1;
            this.cmdBrowse.CornerFeather = 3;
            this.cmdBrowse.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdBrowse.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdBrowse.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdBrowse.HighlightMultiplier = 2F;
            this.cmdBrowse.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdBrowse.HoverHighlightOpacity = 200;
            this.cmdBrowse.HoverImage = null;
            this.cmdBrowse.ImagePadding = 0;
            this.cmdBrowse.Location = new System.Drawing.Point(320, 0);
            this.cmdBrowse.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdBrowse.MouseDownImage = null;
            this.cmdBrowse.MultiSample = true;
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(72, 20);
            this.cmdBrowse.TabIndex = 19;
            this.cmdBrowse.Text = "Browse...";
            this.cmdBrowse.TextOutline = false;
            this.cmdBrowse.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdBrowse.TextOutlineOpacity = 255;
            this.cmdBrowse.TextOutlineWeight = 2F;
            this.cmdBrowse.TextRotationDegrees = 0F;
            this.cmdBrowse.TextShadow = false;
            this.cmdBrowse.TextShadowOffset = 1F;
            this.cmdBrowse.TextShadowOpacity = 80;
            this.cmdBrowse.TextVeritcal = false;
            this.cmdBrowse.ThreeDEffectDepth = 50;
            this.cmdBrowse.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_onClick);
            // 
            // ctrlFlatFileSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panCulture);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(5000, 82);
            this.MinimumSize = new System.Drawing.Size(350, 82);
            this.Name = "ctrlFlatFileSelect";
            this.Size = new System.Drawing.Size(403, 82);
            this.panCulture.ResumeLayout(false);
            this.panCulture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panCulture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox drpCodepage;
        private System.Windows.Forms.CheckBox chkUnicode;
        private System.Windows.Forms.ComboBox drpLocale;
        private System.Windows.Forms.Label label3;
        private RainstormStudios.Controls.AdvancedButton cmdBrowse;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label2;
    }
}
