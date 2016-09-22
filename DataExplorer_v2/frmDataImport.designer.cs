namespace DataExplorer
{
    partial class frmDataImport
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
            System.Drawing.Drawing2D.GraphicsPath graphicsPath12 = new System.Drawing.Drawing2D.GraphicsPath();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataImport));
            System.Drawing.Drawing2D.GraphicsPath graphicsPath7 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath8 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath9 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath10 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath11 = new System.Drawing.Drawing2D.GraphicsPath();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panErrMsg = new System.Windows.Forms.Panel();
            this.panErrMsgCmdClose = new RainstormStudios.Controls.AdvancedButton();
            this.panErrMsgLbl = new System.Windows.Forms.Label();
            this.panErrMsgPic = new System.Windows.Forms.PictureBox();
            this.pan01 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picPan01Accent = new System.Windows.Forms.PictureBox();
            this.destinationPanel1 = new DataExplorer.DestinationPanel();
            this.sourcePanel1 = new DataExplorer.SourcePanel();
            this.cmdHelp = new RainstormStudios.Controls.AdvancedButton();
            this.cmdBack = new RainstormStudios.Controls.AdvancedButton();
            this.cmdNext = new RainstormStudios.Controls.AdvancedButton();
            this.cmdFinished = new RainstormStudios.Controls.AdvancedButton();
            this.cmdCancel = new RainstormStudios.Controls.AdvancedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panErrMsg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panErrMsgPic)).BeginInit();
            this.pan01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPan01Accent)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panErrMsg);
            this.splitContainer.Panel1.Controls.Add(this.destinationPanel1);
            this.splitContainer.Panel1.Controls.Add(this.sourcePanel1);
            this.splitContainer.Panel1.Controls.Add(this.pan01);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.cmdHelp);
            this.splitContainer.Panel2.Controls.Add(this.cmdBack);
            this.splitContainer.Panel2.Controls.Add(this.cmdNext);
            this.splitContainer.Panel2.Controls.Add(this.cmdFinished);
            this.splitContainer.Panel2.Controls.Add(this.cmdCancel);
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Size = new System.Drawing.Size(657, 426);
            this.splitContainer.SplitterDistance = 383;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // panErrMsg
            // 
            this.panErrMsg.BackColor = System.Drawing.Color.LemonChiffon;
            this.panErrMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panErrMsg.Controls.Add(this.panErrMsgCmdClose);
            this.panErrMsg.Controls.Add(this.panErrMsgLbl);
            this.panErrMsg.Controls.Add(this.panErrMsgPic);
            this.panErrMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panErrMsg.Location = new System.Drawing.Point(0, 320);
            this.panErrMsg.Name = "panErrMsg";
            this.panErrMsg.Size = new System.Drawing.Size(657, 63);
            this.panErrMsg.TabIndex = 5;
            this.panErrMsg.Visible = false;
            // 
            // panErrMsgCmdClose
            // 
            this.panErrMsgCmdClose.AllowWordWrap = false;
            this.panErrMsgCmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panErrMsgCmdClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.panErrMsgCmdClose.BackgroundRotationDegrees = 0F;
            this.panErrMsgCmdClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.panErrMsgCmdClose.BorderWidth = 1;
            graphicsPath12.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.panErrMsgCmdClose.ButtonShape = graphicsPath12;
            this.panErrMsgCmdClose.CornerFeather = 5;
            this.panErrMsgCmdClose.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.panErrMsgCmdClose.DisabledForeColor = System.Drawing.Color.Gray;
            this.panErrMsgCmdClose.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.panErrMsgCmdClose.HighlightMultiplier = 2F;
            this.panErrMsgCmdClose.HoverHighlightColor = System.Drawing.Color.Orange;
            this.panErrMsgCmdClose.HoverHighlightOpacity = 200;
            this.panErrMsgCmdClose.HoverImage = null;
            this.panErrMsgCmdClose.ImagePadding = 0;
            this.panErrMsgCmdClose.Location = new System.Drawing.Point(565, 30);
            this.panErrMsgCmdClose.MinimumSize = new System.Drawing.Size(8, 8);
            this.panErrMsgCmdClose.MouseDownImage = null;
            this.panErrMsgCmdClose.MultiSample = true;
            this.panErrMsgCmdClose.Name = "panErrMsgCmdClose";
            this.panErrMsgCmdClose.Size = new System.Drawing.Size(75, 23);
            this.panErrMsgCmdClose.TabIndex = 2;
            this.panErrMsgCmdClose.Text = "OK";
            this.panErrMsgCmdClose.TextOutline = false;
            this.panErrMsgCmdClose.TextOutlineColor = System.Drawing.Color.Empty;
            this.panErrMsgCmdClose.TextOutlineOpacity = 255;
            this.panErrMsgCmdClose.TextOutlineWeight = 2F;
            this.panErrMsgCmdClose.TextRotationDegrees = 0F;
            this.panErrMsgCmdClose.TextShadow = false;
            this.panErrMsgCmdClose.TextShadowOffset = 1F;
            this.panErrMsgCmdClose.TextShadowOpacity = 100;
            this.panErrMsgCmdClose.TextVeritcal = false;
            this.panErrMsgCmdClose.ThreeDEffectDepth = 50;
            this.panErrMsgCmdClose.ToggleActiveColor = System.Drawing.Color.Empty;
            this.panErrMsgCmdClose.UseVisualStyleBackColor = true;
            this.panErrMsgCmdClose.Click += new System.EventHandler(this.cmdErrMsgClose_onClick);
            // 
            // panErrMsgLbl
            // 
            this.panErrMsgLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panErrMsgLbl.Location = new System.Drawing.Point(63, 3);
            this.panErrMsgLbl.Name = "panErrMsgLbl";
            this.panErrMsgLbl.Size = new System.Drawing.Size(490, 50);
            this.panErrMsgLbl.TabIndex = 1;
            // 
            // panErrMsgPic
            // 
            this.panErrMsgPic.Location = new System.Drawing.Point(3, 3);
            this.panErrMsgPic.Name = "panErrMsgPic";
            this.panErrMsgPic.Size = new System.Drawing.Size(54, 50);
            this.panErrMsgPic.TabIndex = 0;
            this.panErrMsgPic.TabStop = false;
            // 
            // pan01
            // 
            this.pan01.BackColor = System.Drawing.Color.White;
            this.pan01.Controls.Add(this.label2);
            this.pan01.Controls.Add(this.label1);
            this.pan01.Controls.Add(this.picPan01Accent);
            this.pan01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan01.Location = new System.Drawing.Point(0, 0);
            this.pan01.Name = "pan01";
            this.pan01.Size = new System.Drawing.Size(657, 383);
            this.pan01.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(186, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 209);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(184, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Import/Export Wizard";
            // 
            // picPan01Accent
            // 
            this.picPan01Accent.Image = global::DataExplorer.Properties.Resources.Final_Composite02_11_23_071;
            this.picPan01Accent.Location = new System.Drawing.Point(3, 3);
            this.picPan01Accent.Name = "picPan01Accent";
            this.picPan01Accent.Size = new System.Drawing.Size(160, 336);
            this.picPan01Accent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPan01Accent.TabIndex = 0;
            this.picPan01Accent.TabStop = false;
            // 
            // destinationPanel1
            // 
            this.destinationPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinationPanel1.Location = new System.Drawing.Point(0, 0);
            this.destinationPanel1.Name = "destinationPanel1";
            this.destinationPanel1.Size = new System.Drawing.Size(657, 383);
            this.destinationPanel1.TabIndex = 7;
            this.destinationPanel1.Visible = false;
            // 
            // sourcePanel1
            // 
            this.sourcePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourcePanel1.Location = new System.Drawing.Point(0, 0);
            this.sourcePanel1.Name = "sourcePanel1";
            this.sourcePanel1.Size = new System.Drawing.Size(657, 383);
            this.sourcePanel1.TabIndex = 6;
            this.sourcePanel1.Visible = false;
            // 
            // cmdHelp
            // 
            this.cmdHelp.AllowWordWrap = false;
            this.cmdHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdHelp.BackgroundRotationDegrees = 0F;
            this.cmdHelp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdHelp.BorderWidth = 1;
            graphicsPath7.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdHelp.ButtonShape = graphicsPath7;
            this.cmdHelp.CornerFeather = 5;
            this.cmdHelp.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdHelp.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdHelp.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdHelp.HighlightMultiplier = 2F;
            this.cmdHelp.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdHelp.HoverHighlightOpacity = 200;
            this.cmdHelp.HoverImage = null;
            this.cmdHelp.ImagePadding = 0;
            this.cmdHelp.Location = new System.Drawing.Point(12, 10);
            this.cmdHelp.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdHelp.MouseDownImage = null;
            this.cmdHelp.MultiSample = true;
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(81, 23);
            this.cmdHelp.TabIndex = 5;
            this.cmdHelp.Text = "Help";
            this.cmdHelp.TextOutline = false;
            this.cmdHelp.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdHelp.TextOutlineOpacity = 255;
            this.cmdHelp.TextOutlineWeight = 2F;
            this.cmdHelp.TextRotationDegrees = 0F;
            this.cmdHelp.TextShadow = false;
            this.cmdHelp.TextShadowOffset = 1F;
            this.cmdHelp.TextShadowOpacity = 100;
            this.cmdHelp.TextVeritcal = false;
            this.cmdHelp.ThreeDEffectDepth = 50;
            this.cmdHelp.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdHelp.UseVisualStyleBackColor = true;
            // 
            // cmdBack
            // 
            this.cmdBack.AllowWordWrap = false;
            this.cmdBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdBack.BackgroundRotationDegrees = 0F;
            this.cmdBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdBack.BorderWidth = 1;
            graphicsPath8.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdBack.ButtonShape = graphicsPath8;
            this.cmdBack.CornerFeather = 5;
            this.cmdBack.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdBack.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdBack.Enabled = false;
            this.cmdBack.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdBack.HighlightMultiplier = 2F;
            this.cmdBack.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdBack.HoverHighlightOpacity = 200;
            this.cmdBack.HoverImage = null;
            this.cmdBack.ImagePadding = 0;
            this.cmdBack.Location = new System.Drawing.Point(300, 10);
            this.cmdBack.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdBack.MouseDownImage = null;
            this.cmdBack.MultiSample = true;
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(81, 23);
            this.cmdBack.TabIndex = 4;
            this.cmdBack.Text = "< Back";
            this.cmdBack.TextOutline = false;
            this.cmdBack.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdBack.TextOutlineOpacity = 255;
            this.cmdBack.TextOutlineWeight = 2F;
            this.cmdBack.TextRotationDegrees = 0F;
            this.cmdBack.TextShadow = false;
            this.cmdBack.TextShadowOffset = 1F;
            this.cmdBack.TextShadowOpacity = 100;
            this.cmdBack.TextVeritcal = false;
            this.cmdBack.ThreeDEffectDepth = 50;
            this.cmdBack.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_onClick);
            // 
            // cmdNext
            // 
            this.cmdNext.AllowWordWrap = false;
            this.cmdNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdNext.BackgroundRotationDegrees = 0F;
            this.cmdNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdNext.BorderWidth = 1;
            graphicsPath9.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdNext.ButtonShape = graphicsPath9;
            this.cmdNext.CornerFeather = 5;
            this.cmdNext.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdNext.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdNext.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdNext.HighlightMultiplier = 2F;
            this.cmdNext.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdNext.HoverHighlightOpacity = 200;
            this.cmdNext.HoverImage = null;
            this.cmdNext.ImagePadding = 0;
            this.cmdNext.Location = new System.Drawing.Point(387, 10);
            this.cmdNext.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdNext.MouseDownImage = null;
            this.cmdNext.MultiSample = true;
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(81, 23);
            this.cmdNext.TabIndex = 3;
            this.cmdNext.Text = "Next >";
            this.cmdNext.TextOutline = false;
            this.cmdNext.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdNext.TextOutlineOpacity = 255;
            this.cmdNext.TextOutlineWeight = 2F;
            this.cmdNext.TextRotationDegrees = 0F;
            this.cmdNext.TextShadow = false;
            this.cmdNext.TextShadowOffset = 1F;
            this.cmdNext.TextShadowOpacity = 100;
            this.cmdNext.TextVeritcal = false;
            this.cmdNext.ThreeDEffectDepth = 50;
            this.cmdNext.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdNext.UseVisualStyleBackColor = true;
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_onClick);
            // 
            // cmdFinished
            // 
            this.cmdFinished.AllowWordWrap = false;
            this.cmdFinished.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFinished.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdFinished.BackgroundRotationDegrees = 0F;
            this.cmdFinished.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdFinished.BorderWidth = 1;
            graphicsPath10.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdFinished.ButtonShape = graphicsPath10;
            this.cmdFinished.CornerFeather = 5;
            this.cmdFinished.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdFinished.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdFinished.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdFinished.Enabled = false;
            this.cmdFinished.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdFinished.HighlightMultiplier = 2F;
            this.cmdFinished.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdFinished.HoverHighlightOpacity = 200;
            this.cmdFinished.HoverImage = null;
            this.cmdFinished.ImagePadding = 0;
            this.cmdFinished.Location = new System.Drawing.Point(474, 10);
            this.cmdFinished.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdFinished.MouseDownImage = null;
            this.cmdFinished.MultiSample = true;
            this.cmdFinished.Name = "cmdFinished";
            this.cmdFinished.Size = new System.Drawing.Size(81, 23);
            this.cmdFinished.TabIndex = 2;
            this.cmdFinished.Text = "Finished >>|";
            this.cmdFinished.TextOutline = false;
            this.cmdFinished.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdFinished.TextOutlineOpacity = 255;
            this.cmdFinished.TextOutlineWeight = 2F;
            this.cmdFinished.TextRotationDegrees = 0F;
            this.cmdFinished.TextShadow = false;
            this.cmdFinished.TextShadowOffset = 1F;
            this.cmdFinished.TextShadowOpacity = 100;
            this.cmdFinished.TextVeritcal = false;
            this.cmdFinished.ThreeDEffectDepth = 50;
            this.cmdFinished.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdFinished.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.AllowWordWrap = false;
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdCancel.BackgroundRotationDegrees = 0F;
            this.cmdCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdCancel.BorderWidth = 1;
            graphicsPath11.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdCancel.ButtonShape = graphicsPath11;
            this.cmdCancel.CornerFeather = 5;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdCancel.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdCancel.HighlightMultiplier = 2F;
            this.cmdCancel.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdCancel.HoverHighlightOpacity = 200;
            this.cmdCancel.HoverImage = null;
            this.cmdCancel.ImagePadding = 0;
            this.cmdCancel.Location = new System.Drawing.Point(561, 10);
            this.cmdCancel.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdCancel.MouseDownImage = null;
            this.cmdCancel.MultiSample = true;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(81, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.TextOutline = false;
            this.cmdCancel.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdCancel.TextOutlineOpacity = 255;
            this.cmdCancel.TextOutlineWeight = 2F;
            this.cmdCancel.TextRotationDegrees = 0F;
            this.cmdCancel.TextShadow = false;
            this.cmdCancel.TextShadowOffset = 1F;
            this.cmdCancel.TextShadowOpacity = 100;
            this.cmdCancel.TextVeritcal = false;
            this.cmdCancel.ThreeDEffectDepth = 50;
            this.cmdCancel.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 4);
            this.panel1.TabIndex = 0;
            // 
            // frmDataImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 426);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(575, 400);
            this.Name = "frmDataImport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Import/Export Wizard";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.panErrMsg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panErrMsgPic)).EndInit();
            this.pan01.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPan01Accent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panel1;
        private RainstormStudios.Controls.AdvancedButton cmdHelp;
        private RainstormStudios.Controls.AdvancedButton cmdBack;
        private RainstormStudios.Controls.AdvancedButton cmdNext;
        private RainstormStudios.Controls.AdvancedButton cmdFinished;
        private RainstormStudios.Controls.AdvancedButton cmdCancel;
        private System.Windows.Forms.Panel pan01;
        private System.Windows.Forms.PictureBox picPan01Accent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DestinationPanel destinationPanel1;
        private SourcePanel sourcePanel1;
        private System.Windows.Forms.Panel panErrMsg;
        private RainstormStudios.Controls.AdvancedButton panErrMsgCmdClose;
        private System.Windows.Forms.Label panErrMsgLbl;
        private System.Windows.Forms.PictureBox panErrMsgPic;

    }
}