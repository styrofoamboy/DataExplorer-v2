namespace DataExplorer
{
    partial class UniVarControl
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
            this.lstUniVars = new RainstormStudios.Controls.FixedColumnListView();
            this.panLblVars = new System.Windows.Forms.Panel();
            this.cmdNewVar = new RainstormStudios.Controls.AdvancedButton();
            this.lblUniVars = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panLblVars.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUniVars
            // 
            this.lstUniVars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUniVars.FullRowSelect = true;
            this.lstUniVars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstUniVars.Location = new System.Drawing.Point(0, 0);
            this.lstUniVars.Name = "lstUniVars";
            this.lstUniVars.Size = new System.Drawing.Size(214, 96);
            this.lstUniVars.TabIndex = 4;
            this.lstUniVars.UseCompatibleStateImageBehavior = false;
            this.lstUniVars.View = System.Windows.Forms.View.Details;
            // 
            // panLblVars
            // 
            this.panLblVars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panLblVars.BackgroundImage = global::DataExplorer.Properties.Resources.GradBg;
            this.panLblVars.Controls.Add(this.cmdNewVar);
            this.panLblVars.Controls.Add(this.lblUniVars);
            this.panLblVars.Location = new System.Drawing.Point(3, 3);
            this.panLblVars.Name = "panLblVars";
            this.panLblVars.Size = new System.Drawing.Size(208, 20);
            this.panLblVars.TabIndex = 3;
            // 
            // cmdNewVar
            // 
            this.cmdNewVar.AllowWordWrap = false;
            this.cmdNewVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNewVar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdNewVar.BackgroundRotationDegrees = 0F;
            this.cmdNewVar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdNewVar.BorderWidth = 1;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdNewVar.ButtonShape = graphicsPath1;
            this.cmdNewVar.CornerFeather = 2;
            this.cmdNewVar.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdNewVar.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdNewVar.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.Popup;
            this.cmdNewVar.HighlightMultiplier = 2F;
            this.cmdNewVar.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdNewVar.HoverHighlightOpacity = 200;
            this.cmdNewVar.HoverImage = null;
            this.cmdNewVar.ImagePadding = 0;
            this.cmdNewVar.Location = new System.Drawing.Point(185, 0);
            this.cmdNewVar.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdNewVar.MouseDownImage = null;
            this.cmdNewVar.MultiSample = true;
            this.cmdNewVar.Name = "cmdNewVar";
            this.cmdNewVar.Size = new System.Drawing.Size(20, 19);
            this.cmdNewVar.TabIndex = 2;
            this.cmdNewVar.Text = "+";
            this.cmdNewVar.TextOutline = false;
            this.cmdNewVar.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdNewVar.TextOutlineOpacity = 255;
            this.cmdNewVar.TextOutlineWeight = 2F;
            this.cmdNewVar.TextRotationDegrees = 0F;
            this.cmdNewVar.TextShadow = false;
            this.cmdNewVar.TextShadowOffset = 1F;
            this.cmdNewVar.TextShadowOpacity = 80;
            this.cmdNewVar.TextVeritcal = false;
            this.cmdNewVar.ThreeDEffectDepth = 50;
            this.cmdNewVar.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdNewVar.UseVisualStyleBackColor = true;
            // 
            // lblUniVars
            // 
            this.lblUniVars.BackColor = System.Drawing.Color.Transparent;
            this.lblUniVars.Location = new System.Drawing.Point(3, 1);
            this.lblUniVars.Name = "lblUniVars";
            this.lblUniVars.Size = new System.Drawing.Size(160, 18);
            this.lblUniVars.TabIndex = 1;
            this.lblUniVars.Text = "Universal Variables";
            this.lblUniVars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panLblVars);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstUniVars);
            this.splitContainer1.Size = new System.Drawing.Size(214, 122);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 5;
            // 
            // UniVarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UniVarControl";
            this.Size = new System.Drawing.Size(214, 122);
            this.panLblVars.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RainstormStudios.Controls.FixedColumnListView lstUniVars;
        private System.Windows.Forms.Panel panLblVars;
        private RainstormStudios.Controls.AdvancedButton cmdNewVar;
        private System.Windows.Forms.Label lblUniVars;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
