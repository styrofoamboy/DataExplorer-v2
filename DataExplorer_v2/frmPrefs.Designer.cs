namespace DataExplorer
{
    partial class frmPrefs
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
            this.components = new System.ComponentModel.Container();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath7 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath8 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath2 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath3 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath4 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath5 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath6 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            this.grpDgOpts = new System.Windows.Forms.GroupBox();
            this.chkFillNull = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpQryOpts = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdSave = new RainstormStudios.Controls.AdvancedButton();
            this.cmdCancel = new RainstormStudios.Controls.AdvancedButton();
            this.clrBtnGlobalVar = new DataExplorer.ColorButton();
            this.clrBtnAlias = new DataExplorer.ColorButton();
            this.clrBtnLiteral = new DataExplorer.ColorButton();
            this.clrBtnFunction = new DataExplorer.ColorButton();
            this.clrBtnKeyword = new DataExplorer.ColorButton();
            this.label6 = new System.Windows.Forms.Label();
            this.clrBtnComment = new DataExplorer.ColorButton();
            this.grpDgOpts.SuspendLayout();
            this.grpQryOpts.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDgOpts
            // 
            this.grpDgOpts.Controls.Add(this.chkFillNull);
            this.grpDgOpts.Location = new System.Drawing.Point(12, 131);
            this.grpDgOpts.Name = "grpDgOpts";
            this.grpDgOpts.Size = new System.Drawing.Size(407, 49);
            this.grpDgOpts.TabIndex = 0;
            this.grpDgOpts.TabStop = false;
            this.grpDgOpts.Text = "DataGrid View Options";
            // 
            // chkFillNull
            // 
            this.chkFillNull.AutoSize = true;
            this.chkFillNull.Location = new System.Drawing.Point(19, 19);
            this.chkFillNull.Name = "chkFillNull";
            this.chkFillNull.Size = new System.Drawing.Size(84, 17);
            this.chkFillNull.TabIndex = 0;
            this.chkFillNull.Text = "Fill Null Cells";
            this.toolTip1.SetToolTip(this.chkFillNull, "Fills cells containing no data with \"NULL\" in italics.");
            this.chkFillNull.UseVisualStyleBackColor = true;
            // 
            // grpQryOpts
            // 
            this.grpQryOpts.Controls.Add(this.clrBtnComment);
            this.grpQryOpts.Controls.Add(this.label6);
            this.grpQryOpts.Controls.Add(this.label5);
            this.grpQryOpts.Controls.Add(this.label4);
            this.grpQryOpts.Controls.Add(this.label3);
            this.grpQryOpts.Controls.Add(this.label2);
            this.grpQryOpts.Controls.Add(this.clrBtnGlobalVar);
            this.grpQryOpts.Controls.Add(this.clrBtnAlias);
            this.grpQryOpts.Controls.Add(this.clrBtnLiteral);
            this.grpQryOpts.Controls.Add(this.clrBtnFunction);
            this.grpQryOpts.Controls.Add(this.clrBtnKeyword);
            this.grpQryOpts.Controls.Add(this.label1);
            this.grpQryOpts.Location = new System.Drawing.Point(12, 12);
            this.grpQryOpts.Name = "grpQryOpts";
            this.grpQryOpts.Size = new System.Drawing.Size(407, 113);
            this.grpQryOpts.TabIndex = 1;
            this.grpQryOpts.TabStop = false;
            this.grpQryOpts.Text = "SQL Query Editor Colors";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keyword:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(212, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Global Variable:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(212, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Table Alias:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Function:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Literal:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdSave
            // 
            this.cmdSave.AllowWordWrap = false;
            this.cmdSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdSave.BackgroundRotationDegrees = 0F;
            this.cmdSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdSave.BorderWidth = 1;
            graphicsPath7.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdSave.ButtonShape = graphicsPath7;
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
            this.cmdSave.Location = new System.Drawing.Point(330, 186);
            this.cmdSave.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdSave.MouseDownImage = null;
            this.cmdSave.MultiSample = true;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 2;
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
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdCancel.BackgroundRotationDegrees = 0F;
            this.cmdCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdCancel.BorderWidth = 1;
            graphicsPath8.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdCancel.ButtonShape = graphicsPath8;
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
            this.cmdCancel.Location = new System.Drawing.Point(249, 186);
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
            this.cmdCancel.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // clrBtnGlobalVar
            // 
            this.clrBtnGlobalVar.AllowWordWrap = false;
            this.clrBtnGlobalVar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.clrBtnGlobalVar.BackgroundRotationDegrees = 0F;
            this.clrBtnGlobalVar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.clrBtnGlobalVar.BorderWidth = 1;
            this.clrBtnGlobalVar.ButtonColor = System.Drawing.Color.Empty;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.clrBtnGlobalVar.ButtonShape = graphicsPath2;
            this.clrBtnGlobalVar.CornerFeather = 3;
            this.clrBtnGlobalVar.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.clrBtnGlobalVar.DisabledForeColor = System.Drawing.Color.Gray;
            this.clrBtnGlobalVar.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.clrBtnGlobalVar.HighlightMultiplier = 2F;
            this.clrBtnGlobalVar.HoverHighlightColor = System.Drawing.Color.Orange;
            this.clrBtnGlobalVar.HoverHighlightOpacity = 200;
            this.clrBtnGlobalVar.HoverImage = null;
            this.clrBtnGlobalVar.ImagePadding = 0;
            this.clrBtnGlobalVar.Location = new System.Drawing.Point(318, 50);
            this.clrBtnGlobalVar.MinimumSize = new System.Drawing.Size(8, 8);
            this.clrBtnGlobalVar.MouseDownImage = null;
            this.clrBtnGlobalVar.MultiSample = true;
            this.clrBtnGlobalVar.Name = "clrBtnGlobalVar";
            this.clrBtnGlobalVar.Size = new System.Drawing.Size(75, 23);
            this.clrBtnGlobalVar.TabIndex = 8;
            this.clrBtnGlobalVar.TextOutline = false;
            this.clrBtnGlobalVar.TextOutlineColor = System.Drawing.Color.Empty;
            this.clrBtnGlobalVar.TextOutlineOpacity = 255;
            this.clrBtnGlobalVar.TextOutlineWeight = 2F;
            this.clrBtnGlobalVar.TextRotationDegrees = 0F;
            this.clrBtnGlobalVar.TextShadow = false;
            this.clrBtnGlobalVar.TextShadowOffset = 1F;
            this.clrBtnGlobalVar.TextShadowOpacity = 80;
            this.clrBtnGlobalVar.TextVeritcal = false;
            this.clrBtnGlobalVar.ThreeDEffectDepth = 50;
            this.clrBtnGlobalVar.ToggleActiveColor = System.Drawing.Color.Empty;
            this.clrBtnGlobalVar.UseVisualStyleBackColor = true;
            // 
            // clrBtnAlias
            // 
            this.clrBtnAlias.AllowWordWrap = false;
            this.clrBtnAlias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.clrBtnAlias.BackgroundRotationDegrees = 0F;
            this.clrBtnAlias.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.clrBtnAlias.BorderWidth = 1;
            this.clrBtnAlias.ButtonColor = System.Drawing.Color.Empty;
            graphicsPath3.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.clrBtnAlias.ButtonShape = graphicsPath3;
            this.clrBtnAlias.CornerFeather = 3;
            this.clrBtnAlias.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.clrBtnAlias.DisabledForeColor = System.Drawing.Color.Gray;
            this.clrBtnAlias.Enabled = false;
            this.clrBtnAlias.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.clrBtnAlias.HighlightMultiplier = 2F;
            this.clrBtnAlias.HoverHighlightColor = System.Drawing.Color.Orange;
            this.clrBtnAlias.HoverHighlightOpacity = 200;
            this.clrBtnAlias.HoverImage = null;
            this.clrBtnAlias.ImagePadding = 0;
            this.clrBtnAlias.Location = new System.Drawing.Point(318, 21);
            this.clrBtnAlias.MinimumSize = new System.Drawing.Size(8, 8);
            this.clrBtnAlias.MouseDownImage = null;
            this.clrBtnAlias.MultiSample = true;
            this.clrBtnAlias.Name = "clrBtnAlias";
            this.clrBtnAlias.Size = new System.Drawing.Size(75, 23);
            this.clrBtnAlias.TabIndex = 6;
            this.clrBtnAlias.TextOutline = false;
            this.clrBtnAlias.TextOutlineColor = System.Drawing.Color.Empty;
            this.clrBtnAlias.TextOutlineOpacity = 255;
            this.clrBtnAlias.TextOutlineWeight = 2F;
            this.clrBtnAlias.TextRotationDegrees = 0F;
            this.clrBtnAlias.TextShadow = false;
            this.clrBtnAlias.TextShadowOffset = 1F;
            this.clrBtnAlias.TextShadowOpacity = 80;
            this.clrBtnAlias.TextVeritcal = false;
            this.clrBtnAlias.ThreeDEffectDepth = 50;
            this.clrBtnAlias.ToggleActiveColor = System.Drawing.Color.Empty;
            this.clrBtnAlias.UseVisualStyleBackColor = true;
            // 
            // clrBtnLiteral
            // 
            this.clrBtnLiteral.AllowWordWrap = false;
            this.clrBtnLiteral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.clrBtnLiteral.BackgroundRotationDegrees = 0F;
            this.clrBtnLiteral.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.clrBtnLiteral.BorderWidth = 1;
            this.clrBtnLiteral.ButtonColor = System.Drawing.Color.Empty;
            graphicsPath4.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.clrBtnLiteral.ButtonShape = graphicsPath4;
            this.clrBtnLiteral.CornerFeather = 3;
            this.clrBtnLiteral.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.clrBtnLiteral.DisabledForeColor = System.Drawing.Color.Gray;
            this.clrBtnLiteral.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.clrBtnLiteral.HighlightMultiplier = 2F;
            this.clrBtnLiteral.HoverHighlightColor = System.Drawing.Color.Orange;
            this.clrBtnLiteral.HoverHighlightOpacity = 200;
            this.clrBtnLiteral.HoverImage = null;
            this.clrBtnLiteral.ImagePadding = 0;
            this.clrBtnLiteral.Location = new System.Drawing.Point(122, 79);
            this.clrBtnLiteral.MinimumSize = new System.Drawing.Size(8, 8);
            this.clrBtnLiteral.MouseDownImage = null;
            this.clrBtnLiteral.MultiSample = true;
            this.clrBtnLiteral.Name = "clrBtnLiteral";
            this.clrBtnLiteral.Size = new System.Drawing.Size(75, 23);
            this.clrBtnLiteral.TabIndex = 5;
            this.clrBtnLiteral.TextOutline = false;
            this.clrBtnLiteral.TextOutlineColor = System.Drawing.Color.Empty;
            this.clrBtnLiteral.TextOutlineOpacity = 255;
            this.clrBtnLiteral.TextOutlineWeight = 2F;
            this.clrBtnLiteral.TextRotationDegrees = 0F;
            this.clrBtnLiteral.TextShadow = false;
            this.clrBtnLiteral.TextShadowOffset = 1F;
            this.clrBtnLiteral.TextShadowOpacity = 80;
            this.clrBtnLiteral.TextVeritcal = false;
            this.clrBtnLiteral.ThreeDEffectDepth = 50;
            this.clrBtnLiteral.ToggleActiveColor = System.Drawing.Color.Empty;
            this.clrBtnLiteral.UseVisualStyleBackColor = true;
            // 
            // clrBtnFunction
            // 
            this.clrBtnFunction.AllowWordWrap = false;
            this.clrBtnFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.clrBtnFunction.BackgroundRotationDegrees = 0F;
            this.clrBtnFunction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.clrBtnFunction.BorderWidth = 1;
            this.clrBtnFunction.ButtonColor = System.Drawing.Color.Empty;
            graphicsPath5.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.clrBtnFunction.ButtonShape = graphicsPath5;
            this.clrBtnFunction.CornerFeather = 3;
            this.clrBtnFunction.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.clrBtnFunction.DisabledForeColor = System.Drawing.Color.Gray;
            this.clrBtnFunction.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.clrBtnFunction.HighlightMultiplier = 2F;
            this.clrBtnFunction.HoverHighlightColor = System.Drawing.Color.Orange;
            this.clrBtnFunction.HoverHighlightOpacity = 200;
            this.clrBtnFunction.HoverImage = null;
            this.clrBtnFunction.ImagePadding = 0;
            this.clrBtnFunction.Location = new System.Drawing.Point(122, 50);
            this.clrBtnFunction.MinimumSize = new System.Drawing.Size(8, 8);
            this.clrBtnFunction.MouseDownImage = null;
            this.clrBtnFunction.MultiSample = true;
            this.clrBtnFunction.Name = "clrBtnFunction";
            this.clrBtnFunction.Size = new System.Drawing.Size(75, 23);
            this.clrBtnFunction.TabIndex = 4;
            this.clrBtnFunction.TextOutline = false;
            this.clrBtnFunction.TextOutlineColor = System.Drawing.Color.Empty;
            this.clrBtnFunction.TextOutlineOpacity = 255;
            this.clrBtnFunction.TextOutlineWeight = 2F;
            this.clrBtnFunction.TextRotationDegrees = 0F;
            this.clrBtnFunction.TextShadow = false;
            this.clrBtnFunction.TextShadowOffset = 1F;
            this.clrBtnFunction.TextShadowOpacity = 80;
            this.clrBtnFunction.TextVeritcal = false;
            this.clrBtnFunction.ThreeDEffectDepth = 50;
            this.clrBtnFunction.ToggleActiveColor = System.Drawing.Color.Empty;
            this.clrBtnFunction.UseVisualStyleBackColor = true;
            // 
            // clrBtnKeyword
            // 
            this.clrBtnKeyword.AllowWordWrap = false;
            this.clrBtnKeyword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.clrBtnKeyword.BackgroundRotationDegrees = 0F;
            this.clrBtnKeyword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.clrBtnKeyword.BorderWidth = 1;
            this.clrBtnKeyword.ButtonColor = System.Drawing.Color.Empty;
            graphicsPath6.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.clrBtnKeyword.ButtonShape = graphicsPath6;
            this.clrBtnKeyword.CornerFeather = 3;
            this.clrBtnKeyword.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.clrBtnKeyword.DisabledForeColor = System.Drawing.Color.Gray;
            this.clrBtnKeyword.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.clrBtnKeyword.HighlightMultiplier = 2F;
            this.clrBtnKeyword.HoverHighlightColor = System.Drawing.Color.Orange;
            this.clrBtnKeyword.HoverHighlightOpacity = 200;
            this.clrBtnKeyword.HoverImage = null;
            this.clrBtnKeyword.ImagePadding = 0;
            this.clrBtnKeyword.Location = new System.Drawing.Point(122, 21);
            this.clrBtnKeyword.MinimumSize = new System.Drawing.Size(8, 8);
            this.clrBtnKeyword.MouseDownImage = null;
            this.clrBtnKeyword.MultiSample = true;
            this.clrBtnKeyword.Name = "clrBtnKeyword";
            this.clrBtnKeyword.Size = new System.Drawing.Size(75, 23);
            this.clrBtnKeyword.TabIndex = 3;
            this.clrBtnKeyword.TextOutline = false;
            this.clrBtnKeyword.TextOutlineColor = System.Drawing.Color.Empty;
            this.clrBtnKeyword.TextOutlineOpacity = 255;
            this.clrBtnKeyword.TextOutlineWeight = 2F;
            this.clrBtnKeyword.TextRotationDegrees = 0F;
            this.clrBtnKeyword.TextShadow = false;
            this.clrBtnKeyword.TextShadowOffset = 1F;
            this.clrBtnKeyword.TextShadowOpacity = 80;
            this.clrBtnKeyword.TextVeritcal = false;
            this.clrBtnKeyword.ThreeDEffectDepth = 50;
            this.clrBtnKeyword.ToggleActiveColor = System.Drawing.Color.Empty;
            this.clrBtnKeyword.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(212, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Comment:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clrBtnComment
            // 
            this.clrBtnComment.AllowWordWrap = false;
            this.clrBtnComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.clrBtnComment.BackgroundRotationDegrees = 0F;
            this.clrBtnComment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.clrBtnComment.BorderWidth = 1;
            this.clrBtnComment.ButtonColor = System.Drawing.Color.Empty;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.clrBtnComment.ButtonShape = graphicsPath1;
            this.clrBtnComment.CornerFeather = 3;
            this.clrBtnComment.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.clrBtnComment.DisabledForeColor = System.Drawing.Color.Gray;
            this.clrBtnComment.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.clrBtnComment.HighlightMultiplier = 2F;
            this.clrBtnComment.HoverHighlightColor = System.Drawing.Color.Orange;
            this.clrBtnComment.HoverHighlightOpacity = 200;
            this.clrBtnComment.HoverImage = null;
            this.clrBtnComment.ImagePadding = 0;
            this.clrBtnComment.Location = new System.Drawing.Point(318, 79);
            this.clrBtnComment.MinimumSize = new System.Drawing.Size(8, 8);
            this.clrBtnComment.MouseDownImage = null;
            this.clrBtnComment.MultiSample = true;
            this.clrBtnComment.Name = "clrBtnComment";
            this.clrBtnComment.Size = new System.Drawing.Size(75, 23);
            this.clrBtnComment.TabIndex = 14;
            this.clrBtnComment.TextOutline = false;
            this.clrBtnComment.TextOutlineColor = System.Drawing.Color.Empty;
            this.clrBtnComment.TextOutlineOpacity = 255;
            this.clrBtnComment.TextOutlineWeight = 2F;
            this.clrBtnComment.TextRotationDegrees = 0F;
            this.clrBtnComment.TextShadow = false;
            this.clrBtnComment.TextShadowOffset = 1F;
            this.clrBtnComment.TextShadowOpacity = 80;
            this.clrBtnComment.TextVeritcal = false;
            this.clrBtnComment.ThreeDEffectDepth = 50;
            this.clrBtnComment.ToggleActiveColor = System.Drawing.Color.Empty;
            this.clrBtnComment.UseVisualStyleBackColor = true;
            // 
            // frmPrefs
            // 
            this.AcceptButton = this.cmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(432, 219);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.grpQryOpts);
            this.Controls.Add(this.grpDgOpts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrefs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.grpDgOpts.ResumeLayout(false);
            this.grpDgOpts.PerformLayout();
            this.grpQryOpts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDgOpts;
        private System.Windows.Forms.CheckBox chkFillNull;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox grpQryOpts;
        private System.Windows.Forms.Label label1;
        private ColorButton clrBtnKeyword;
        private ColorButton clrBtnLiteral;
        private ColorButton clrBtnFunction;
        private ColorButton clrBtnAlias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ColorButton clrBtnGlobalVar;
        private RainstormStudios.Controls.AdvancedButton cmdSave;
        private RainstormStudios.Controls.AdvancedButton cmdCancel;
        private ColorButton clrBtnComment;
        private System.Windows.Forms.Label label6;
    }
}