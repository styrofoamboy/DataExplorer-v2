namespace DataExplorer.ImportWizard_Controls
{
    partial class ctrlSqlConfig
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
            System.Drawing.Drawing2D.GraphicsPath graphicsPath3 = new System.Drawing.Drawing2D.GraphicsPath();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSqlServerName = new System.Windows.Forms.ComboBox();
            this.grpAuth = new System.Windows.Forms.GroupBox();
            this.panSqlAuth = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSqlAuthPass = new System.Windows.Forms.TextBox();
            this.txtSqlAuthUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoSqlAuth = new System.Windows.Forms.RadioButton();
            this.rdoWinAuth = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.sqlDatabaseList = new RainstormStudios.Controls.SqlDatabaseList();
            this.cmdRefreshSqlDbList = new RainstormStudios.Controls.AdvancedButton();
            this.grpAuth.SuspendLayout();
            this.panSqlAuth.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name:";
            // 
            // cboSqlServerName
            // 
            this.cboSqlServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSqlServerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboSqlServerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.cboSqlServerName.FormattingEnabled = true;
            this.cboSqlServerName.Location = new System.Drawing.Point(161, 3);
            this.cboSqlServerName.Name = "cboSqlServerName";
            this.cboSqlServerName.Size = new System.Drawing.Size(339, 21);
            this.cboSqlServerName.TabIndex = 1;
            this.cboSqlServerName.TextUpdate += new System.EventHandler(this.cboSqlServerName_TextUpdate);
            // 
            // grpAuth
            // 
            this.grpAuth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAuth.Controls.Add(this.panSqlAuth);
            this.grpAuth.Controls.Add(this.rdoSqlAuth);
            this.grpAuth.Controls.Add(this.rdoWinAuth);
            this.grpAuth.Location = new System.Drawing.Point(0, 42);
            this.grpAuth.Name = "grpAuth";
            this.grpAuth.Size = new System.Drawing.Size(500, 126);
            this.grpAuth.TabIndex = 2;
            this.grpAuth.TabStop = false;
            this.grpAuth.Text = "Authentication";
            // 
            // panSqlAuth
            // 
            this.panSqlAuth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panSqlAuth.Controls.Add(this.label3);
            this.panSqlAuth.Controls.Add(this.txtSqlAuthPass);
            this.panSqlAuth.Controls.Add(this.txtSqlAuthUser);
            this.panSqlAuth.Controls.Add(this.label2);
            this.panSqlAuth.Enabled = false;
            this.panSqlAuth.Location = new System.Drawing.Point(39, 65);
            this.panSqlAuth.Name = "panSqlAuth";
            this.panSqlAuth.Size = new System.Drawing.Size(444, 53);
            this.panSqlAuth.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // txtSqlAuthPass
            // 
            this.txtSqlAuthPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSqlAuthPass.Location = new System.Drawing.Point(122, 29);
            this.txtSqlAuthPass.Name = "txtSqlAuthPass";
            this.txtSqlAuthPass.Size = new System.Drawing.Size(319, 20);
            this.txtSqlAuthPass.TabIndex = 2;
            this.txtSqlAuthPass.TextChanged += new System.EventHandler(this.txtSqlAuth_TextChanged);
            // 
            // txtSqlAuthUser
            // 
            this.txtSqlAuthUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSqlAuthUser.Location = new System.Drawing.Point(122, 3);
            this.txtSqlAuthUser.Name = "txtSqlAuthUser";
            this.txtSqlAuthUser.Size = new System.Drawing.Size(319, 20);
            this.txtSqlAuthUser.TabIndex = 1;
            this.txtSqlAuthUser.TextChanged += new System.EventHandler(this.txtSqlAuth_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "User name:";
            // 
            // rdoSqlAuth
            // 
            this.rdoSqlAuth.AutoSize = true;
            this.rdoSqlAuth.Location = new System.Drawing.Point(20, 42);
            this.rdoSqlAuth.Name = "rdoSqlAuth";
            this.rdoSqlAuth.Size = new System.Drawing.Size(173, 17);
            this.rdoSqlAuth.TabIndex = 1;
            this.rdoSqlAuth.Text = "Use SQL Server Authentication";
            this.rdoSqlAuth.UseVisualStyleBackColor = true;
            this.rdoSqlAuth.CheckedChanged += new System.EventHandler(this.rdoSqlAuth_CheckedChanged);
            // 
            // rdoWinAuth
            // 
            this.rdoWinAuth.AutoSize = true;
            this.rdoWinAuth.Checked = true;
            this.rdoWinAuth.Location = new System.Drawing.Point(20, 19);
            this.rdoWinAuth.Name = "rdoWinAuth";
            this.rdoWinAuth.Size = new System.Drawing.Size(162, 17);
            this.rdoWinAuth.TabIndex = 0;
            this.rdoWinAuth.TabStop = true;
            this.rdoWinAuth.Text = "Use Windows Authentication";
            this.rdoWinAuth.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database:";
            // 
            // sqlDatabaseList
            // 
            this.sqlDatabaseList.ConnectionString = null;
            this.sqlDatabaseList.FormattingEnabled = true;
            this.sqlDatabaseList.Location = new System.Drawing.Point(161, 194);
            this.sqlDatabaseList.MaximumSize = new System.Drawing.Size(215, 0);
            this.sqlDatabaseList.Name = "sqlDatabaseList";
            this.sqlDatabaseList.Size = new System.Drawing.Size(215, 21);
            this.sqlDatabaseList.TabIndex = 6;
            // 
            // cmdRefreshSqlDbList
            // 
            this.cmdRefreshSqlDbList.AllowWordWrap = false;
            this.cmdRefreshSqlDbList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdRefreshSqlDbList.BackgroundRotationDegrees = 0F;
            this.cmdRefreshSqlDbList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdRefreshSqlDbList.BorderWidth = 1;
            graphicsPath3.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdRefreshSqlDbList.ButtonShape = graphicsPath3;
            this.cmdRefreshSqlDbList.CornerFeather = 3;
            this.cmdRefreshSqlDbList.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdRefreshSqlDbList.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdRefreshSqlDbList.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdRefreshSqlDbList.HighlightMultiplier = 2F;
            this.cmdRefreshSqlDbList.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdRefreshSqlDbList.HoverHighlightOpacity = 200;
            this.cmdRefreshSqlDbList.HoverImage = null;
            this.cmdRefreshSqlDbList.ImagePadding = 0;
            this.cmdRefreshSqlDbList.Location = new System.Drawing.Point(382, 193);
            this.cmdRefreshSqlDbList.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdRefreshSqlDbList.MouseDownImage = null;
            this.cmdRefreshSqlDbList.MultiSample = true;
            this.cmdRefreshSqlDbList.Name = "cmdRefreshSqlDbList";
            this.cmdRefreshSqlDbList.Size = new System.Drawing.Size(75, 21);
            this.cmdRefreshSqlDbList.TabIndex = 5;
            this.cmdRefreshSqlDbList.Text = "Refresh";
            this.cmdRefreshSqlDbList.TextOutline = false;
            this.cmdRefreshSqlDbList.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdRefreshSqlDbList.TextOutlineOpacity = 255;
            this.cmdRefreshSqlDbList.TextOutlineWeight = 2F;
            this.cmdRefreshSqlDbList.TextRotationDegrees = 0F;
            this.cmdRefreshSqlDbList.TextShadow = false;
            this.cmdRefreshSqlDbList.TextShadowOffset = 1F;
            this.cmdRefreshSqlDbList.TextShadowOpacity = 80;
            this.cmdRefreshSqlDbList.TextVeritcal = false;
            this.cmdRefreshSqlDbList.ThreeDEffectDepth = 50;
            this.cmdRefreshSqlDbList.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdRefreshSqlDbList.UseVisualStyleBackColor = true;
            this.cmdRefreshSqlDbList.Click += new System.EventHandler(this.cmdRefreshSqlDatabaseList_onClick);
            // 
            // ctrlSqlConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sqlDatabaseList);
            this.Controls.Add(this.cmdRefreshSqlDbList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpAuth);
            this.Controls.Add(this.cboSqlServerName);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(5000, 220);
            this.MinimumSize = new System.Drawing.Size(500, 220);
            this.Name = "ctrlSqlConfig";
            this.Size = new System.Drawing.Size(500, 220);
            this.grpAuth.ResumeLayout(false);
            this.grpAuth.PerformLayout();
            this.panSqlAuth.ResumeLayout(false);
            this.panSqlAuth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSqlServerName;
        private System.Windows.Forms.GroupBox grpAuth;
        private System.Windows.Forms.Panel panSqlAuth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSqlAuthPass;
        private System.Windows.Forms.TextBox txtSqlAuthUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoSqlAuth;
        private System.Windows.Forms.RadioButton rdoWinAuth;
        private System.Windows.Forms.Label label4;
        private RainstormStudios.Controls.AdvancedButton cmdRefreshSqlDbList;
        private RainstormStudios.Controls.SqlDatabaseList sqlDatabaseList;
    }
}
