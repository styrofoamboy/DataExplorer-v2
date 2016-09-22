namespace DataExplorer
{
    partial class frmClrByVal
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
            this.colorButton1 = new DataExplorer.ColorButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInstr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cmdGo = new RainstormStudios.Controls.AdvancedButton();
            this.cmdCancel = new RainstormStudios.Controls.AdvancedButton();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorButton1
            // 
            this.colorButton1.AllowWordWrap = false;
            this.colorButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.colorButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.colorButton1.BackgroundRotationDegrees = 0F;
            this.colorButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.colorButton1.BorderWidth = 1;
            this.colorButton1.ButtonColor = System.Drawing.Color.Empty;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.colorButton1.ButtonShape = graphicsPath1;
            this.colorButton1.CornerFeather = 3;
            this.colorButton1.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.colorButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.colorButton1.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.Standard;
            this.colorButton1.HighlightMultiplier = 2F;
            this.colorButton1.HoverHighlightColor = System.Drawing.Color.Orange;
            this.colorButton1.HoverHighlightOpacity = 200;
            this.colorButton1.HoverImage = null;
            this.colorButton1.ImagePadding = 0;
            this.colorButton1.Location = new System.Drawing.Point(83, 3);
            this.colorButton1.MinimumSize = new System.Drawing.Size(8, 8);
            this.colorButton1.MouseDownImage = null;
            this.colorButton1.MultiSample = true;
            this.colorButton1.Name = "colorButton1";
            this.colorButton1.Size = new System.Drawing.Size(75, 23);
            this.colorButton1.TabIndex = 0;
            this.colorButton1.TextOutline = false;
            this.colorButton1.TextOutlineColor = System.Drawing.Color.Empty;
            this.colorButton1.TextOutlineOpacity = 255;
            this.colorButton1.TextOutlineWeight = 2F;
            this.colorButton1.TextRotationDegrees = 0F;
            this.colorButton1.TextShadow = false;
            this.colorButton1.TextShadowOffset = 1F;
            this.colorButton1.TextShadowOpacity = 80;
            this.colorButton1.TextVeritcal = false;
            this.colorButton1.ThreeDEffectDepth = 50;
            this.colorButton1.ToggleActiveColor = System.Drawing.Color.Empty;
            this.colorButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a color:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.colorButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(119, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 30);
            this.panel1.TabIndex = 2;
            // 
            // lblInstr
            // 
            this.lblInstr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstr.Location = new System.Drawing.Point(12, 9);
            this.lblInstr.Name = "lblInstr";
            this.lblInstr.Size = new System.Drawing.Size(268, 31);
            this.lblInstr.TabIndex = 3;
            this.lblInstr.Text = "This tool will search the given column for a specific piece of text and hightligh" +
                "t that text as it is found.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please select the value to search for:";
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.Location = new System.Drawing.Point(12, 76);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(268, 20);
            this.txtValue.TabIndex = 5;
            // 
            // cmdGo
            // 
            this.cmdGo.AllowWordWrap = false;
            this.cmdGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdGo.BackgroundRotationDegrees = 0F;
            this.cmdGo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdGo.BorderWidth = 1;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdGo.ButtonShape = graphicsPath2;
            this.cmdGo.CornerFeather = 3;
            this.cmdGo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdGo.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdGo.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdGo.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.Standard;
            this.cmdGo.HighlightMultiplier = 2F;
            this.cmdGo.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdGo.HoverHighlightOpacity = 200;
            this.cmdGo.HoverImage = null;
            this.cmdGo.ImagePadding = 0;
            this.cmdGo.Location = new System.Drawing.Point(202, 164);
            this.cmdGo.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdGo.MouseDownImage = null;
            this.cmdGo.MultiSample = true;
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(75, 23);
            this.cmdGo.TabIndex = 6;
            this.cmdGo.Text = "Search";
            this.cmdGo.TextOutline = false;
            this.cmdGo.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdGo.TextOutlineOpacity = 255;
            this.cmdGo.TextOutlineWeight = 2F;
            this.cmdGo.TextRotationDegrees = 0F;
            this.cmdGo.TextShadow = false;
            this.cmdGo.TextShadowOffset = 1F;
            this.cmdGo.TextShadowOpacity = 80;
            this.cmdGo.TextVeritcal = false;
            this.cmdGo.ThreeDEffectDepth = 50;
            this.cmdGo.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdGo.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.AllowWordWrap = false;
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdCancel.BackgroundRotationDegrees = 0F;
            this.cmdCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdCancel.BorderWidth = 1;
            graphicsPath3.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdCancel.ButtonShape = graphicsPath3;
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
            this.cmdCancel.Location = new System.Drawing.Point(119, 164);
            this.cmdCancel.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdCancel.MouseDownImage = null;
            this.cmdCancel.MultiSample = true;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 7;
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
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(12, 109);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(83, 17);
            this.chkMatchCase.TabIndex = 8;
            this.chkMatchCase.Text = "Match Case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // frmClrByVal
            // 
            this.AcceptButton = this.cmdGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(292, 199);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInstr);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmClrByVal";
            this.Text = "Highlight by Value";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorButton colorButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInstr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private RainstormStudios.Controls.AdvancedButton cmdGo;
        private RainstormStudios.Controls.AdvancedButton cmdCancel;
        private System.Windows.Forms.CheckBox chkMatchCase;
    }
}