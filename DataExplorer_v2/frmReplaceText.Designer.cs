namespace DataExplorer
{
    partial class frmReplaceText
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.chkWholeWord = new System.Windows.Forms.CheckBox();
            this.chkUseRegEx = new System.Windows.Forms.CheckBox();
            this.cmdReplaceAll = new RainstormStudios.Controls.AdvancedButton();
            this.cmdReplace = new RainstormStudios.Controls.AdvancedButton();
            this.cmdFindNext = new RainstormStudios.Controls.AdvancedButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find what:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(453, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Replace with:";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(453, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Look in:";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 125);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(453, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUseRegEx);
            this.groupBox1.Controls.Add(this.chkWholeWord);
            this.groupBox1.Controls.Add(this.chkMatchCase);
            this.groupBox1.Location = new System.Drawing.Point(12, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Options";
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(6, 19);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(83, 17);
            this.chkMatchCase.TabIndex = 0;
            this.chkMatchCase.Text = "Match Case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // chkWholeWord
            // 
            this.chkWholeWord.AutoSize = true;
            this.chkWholeWord.Location = new System.Drawing.Point(6, 42);
            this.chkWholeWord.Name = "chkWholeWord";
            this.chkWholeWord.Size = new System.Drawing.Size(119, 17);
            this.chkWholeWord.TabIndex = 1;
            this.chkWholeWord.Text = "Match Whole Word";
            this.chkWholeWord.UseVisualStyleBackColor = true;
            // 
            // chkUseRegEx
            // 
            this.chkUseRegEx.AutoSize = true;
            this.chkUseRegEx.Location = new System.Drawing.Point(6, 65);
            this.chkUseRegEx.Name = "chkUseRegEx";
            this.chkUseRegEx.Size = new System.Drawing.Size(144, 17);
            this.chkUseRegEx.TabIndex = 2;
            this.chkUseRegEx.Text = "Use Regular Expressions";
            this.chkUseRegEx.UseVisualStyleBackColor = true;
            // 
            // cmdReplaceAll
            // 
            this.cmdReplaceAll.AllowWordWrap = false;
            this.cmdReplaceAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdReplaceAll.BackgroundRotationDegrees = 0F;
            this.cmdReplaceAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdReplaceAll.BorderWidth = 1;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdReplaceAll.ButtonShape = graphicsPath1;
            this.cmdReplaceAll.CornerFeather = 5;
            this.cmdReplaceAll.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdReplaceAll.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdReplaceAll.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdReplaceAll.HighlightMultiplier = 2F;
            this.cmdReplaceAll.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdReplaceAll.HoverHighlightOpacity = 200;
            this.cmdReplaceAll.HoverImage = null;
            this.cmdReplaceAll.ImagePadding = 0;
            this.cmdReplaceAll.Location = new System.Drawing.Point(363, 230);
            this.cmdReplaceAll.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdReplaceAll.MouseDownImage = null;
            this.cmdReplaceAll.MultiSample = true;
            this.cmdReplaceAll.Name = "cmdReplaceAll";
            this.cmdReplaceAll.Size = new System.Drawing.Size(102, 23);
            this.cmdReplaceAll.TabIndex = 7;
            this.cmdReplaceAll.Text = "Replace All";
            this.cmdReplaceAll.TextOutline = false;
            this.cmdReplaceAll.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdReplaceAll.TextOutlineOpacity = 255;
            this.cmdReplaceAll.TextOutlineWeight = 2F;
            this.cmdReplaceAll.TextRotationDegrees = 0F;
            this.cmdReplaceAll.TextShadow = false;
            this.cmdReplaceAll.TextShadowOffset = 1F;
            this.cmdReplaceAll.TextShadowOpacity = 80;
            this.cmdReplaceAll.TextVeritcal = false;
            this.cmdReplaceAll.ThreeDEffectDepth = 50;
            this.cmdReplaceAll.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdReplaceAll.UseVisualStyleBackColor = true;
            // 
            // cmdReplace
            // 
            this.cmdReplace.AllowWordWrap = false;
            this.cmdReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdReplace.BackgroundRotationDegrees = 0F;
            this.cmdReplace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdReplace.BorderWidth = 1;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdReplace.ButtonShape = graphicsPath2;
            this.cmdReplace.CornerFeather = 5;
            this.cmdReplace.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdReplace.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdReplace.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdReplace.HighlightMultiplier = 2F;
            this.cmdReplace.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdReplace.HoverHighlightOpacity = 200;
            this.cmdReplace.HoverImage = null;
            this.cmdReplace.ImagePadding = 0;
            this.cmdReplace.Location = new System.Drawing.Point(363, 201);
            this.cmdReplace.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdReplace.MouseDownImage = null;
            this.cmdReplace.MultiSample = true;
            this.cmdReplace.Name = "cmdReplace";
            this.cmdReplace.Size = new System.Drawing.Size(102, 23);
            this.cmdReplace.TabIndex = 8;
            this.cmdReplace.Text = "Replace";
            this.cmdReplace.TextOutline = false;
            this.cmdReplace.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdReplace.TextOutlineOpacity = 255;
            this.cmdReplace.TextOutlineWeight = 2F;
            this.cmdReplace.TextRotationDegrees = 0F;
            this.cmdReplace.TextShadow = false;
            this.cmdReplace.TextShadowOffset = 1F;
            this.cmdReplace.TextShadowOpacity = 80;
            this.cmdReplace.TextVeritcal = false;
            this.cmdReplace.ThreeDEffectDepth = 50;
            this.cmdReplace.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdReplace.UseVisualStyleBackColor = true;
            // 
            // cmdFindNext
            // 
            this.cmdFindNext.AllowWordWrap = false;
            this.cmdFindNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdFindNext.BackgroundRotationDegrees = 0F;
            this.cmdFindNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdFindNext.BorderWidth = 1;
            graphicsPath3.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdFindNext.ButtonShape = graphicsPath3;
            this.cmdFindNext.CornerFeather = 5;
            this.cmdFindNext.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdFindNext.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdFindNext.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdFindNext.HighlightMultiplier = 2F;
            this.cmdFindNext.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdFindNext.HoverHighlightOpacity = 200;
            this.cmdFindNext.HoverImage = null;
            this.cmdFindNext.ImagePadding = 0;
            this.cmdFindNext.Location = new System.Drawing.Point(255, 201);
            this.cmdFindNext.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdFindNext.MouseDownImage = null;
            this.cmdFindNext.MultiSample = true;
            this.cmdFindNext.Name = "cmdFindNext";
            this.cmdFindNext.Size = new System.Drawing.Size(102, 23);
            this.cmdFindNext.TabIndex = 9;
            this.cmdFindNext.Text = "Find Next";
            this.cmdFindNext.TextOutline = false;
            this.cmdFindNext.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdFindNext.TextOutlineOpacity = 255;
            this.cmdFindNext.TextOutlineWeight = 2F;
            this.cmdFindNext.TextRotationDegrees = 0F;
            this.cmdFindNext.TextShadow = false;
            this.cmdFindNext.TextShadowOffset = 1F;
            this.cmdFindNext.TextShadowOpacity = 80;
            this.cmdFindNext.TextVeritcal = false;
            this.cmdFindNext.ThreeDEffectDepth = 50;
            this.cmdFindNext.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdFindNext.UseVisualStyleBackColor = true;
            // 
            // frmReplaceText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 265);
            this.Controls.Add(this.cmdFindNext);
            this.Controls.Add(this.cmdReplace);
            this.Controls.Add(this.cmdReplaceAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReplaceText";
            this.Text = "Find/Replace";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkUseRegEx;
        private System.Windows.Forms.CheckBox chkWholeWord;
        private System.Windows.Forms.CheckBox chkMatchCase;
        private RainstormStudios.Controls.AdvancedButton cmdReplaceAll;
        private RainstormStudios.Controls.AdvancedButton cmdReplace;
        private RainstormStudios.Controls.AdvancedButton cmdFindNext;
    }
}