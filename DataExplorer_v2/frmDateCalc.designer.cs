namespace DataExplorer
{
    partial class frmDateCalc
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
            this.dtN2DBase = new System.Windows.Forms.DateTimePicker();
            this.grpN2DBaseDate = new System.Windows.Forms.GroupBox();
            this.grpAddTime = new System.Windows.Forms.GroupBox();
            this.rdoN2DmSeconds = new System.Windows.Forms.RadioButton();
            this.rdoN2DSeconds = new System.Windows.Forms.RadioButton();
            this.numAddTime = new System.Windows.Forms.NumericUpDown();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmdCalc = new System.Windows.Forms.Button();
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.tpgSec2Date = new System.Windows.Forms.TabPage();
            this.tpgDate2Sec = new System.Windows.Forms.TabPage();
            this.rdoD2NmSeconds = new System.Windows.Forms.RadioButton();
            this.rdoD2NSeconds = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grpN2DOutput = new System.Windows.Forms.GroupBox();
            this.chkMonths = new System.Windows.Forms.CheckBox();
            this.chkDays = new System.Windows.Forms.CheckBox();
            this.chkYears = new System.Windows.Forms.CheckBox();
            this.chkWeeks = new System.Windows.Forms.CheckBox();
            this.chkMinutes = new System.Windows.Forms.CheckBox();
            this.chkHours = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grpD2NEndDate = new System.Windows.Forms.GroupBox();
            this.dtD2NEnd = new System.Windows.Forms.DateTimePicker();
            this.grpD2NBaseDate = new System.Windows.Forms.GroupBox();
            this.dtD2NBase = new System.Windows.Forms.DateTimePicker();
            this.grpN2DBaseDate.SuspendLayout();
            this.grpAddTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddTime)).BeginInit();
            this.grpResult.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.tpgSec2Date.SuspendLayout();
            this.tpgDate2Sec.SuspendLayout();
            this.grpN2DOutput.SuspendLayout();
            this.grpD2NEndDate.SuspendLayout();
            this.grpD2NBaseDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtN2DBase
            // 
            this.dtN2DBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtN2DBase.CustomFormat = "dddd, MMMM dd, yyyy        hh:mm:ss tt";
            this.dtN2DBase.Location = new System.Drawing.Point(8, 16);
            this.dtN2DBase.Name = "dtN2DBase";
            this.dtN2DBase.Size = new System.Drawing.Size(240, 20);
            this.dtN2DBase.TabIndex = 0;
            this.dtN2DBase.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtN2DBase.ValueChanged += new System.EventHandler(this.userCtrl_onCritialValueChanged);
            // 
            // grpN2DBaseDate
            // 
            this.grpN2DBaseDate.Controls.Add(this.dtN2DBase);
            this.grpN2DBaseDate.Location = new System.Drawing.Point(0, 8);
            this.grpN2DBaseDate.Name = "grpN2DBaseDate";
            this.grpN2DBaseDate.Size = new System.Drawing.Size(256, 40);
            this.grpN2DBaseDate.TabIndex = 1;
            this.grpN2DBaseDate.TabStop = false;
            this.grpN2DBaseDate.Text = "Base Date";
            // 
            // grpAddTime
            // 
            this.grpAddTime.Controls.Add(this.rdoN2DmSeconds);
            this.grpAddTime.Controls.Add(this.rdoN2DSeconds);
            this.grpAddTime.Controls.Add(this.numAddTime);
            this.grpAddTime.Location = new System.Drawing.Point(0, 56);
            this.grpAddTime.Name = "grpAddTime";
            this.grpAddTime.Size = new System.Drawing.Size(256, 64);
            this.grpAddTime.TabIndex = 2;
            this.grpAddTime.TabStop = false;
            this.grpAddTime.Text = "Add Time";
            // 
            // rdoN2DmSeconds
            // 
            this.rdoN2DmSeconds.AutoSize = true;
            this.rdoN2DmSeconds.Location = new System.Drawing.Point(104, 40);
            this.rdoN2DmSeconds.Name = "rdoN2DmSeconds";
            this.rdoN2DmSeconds.Size = new System.Drawing.Size(78, 17);
            this.rdoN2DmSeconds.TabIndex = 2;
            this.rdoN2DmSeconds.TabStop = false;
            this.rdoN2DmSeconds.Text = "Milliseconds";
            this.rdoN2DmSeconds.CheckedChanged += new System.EventHandler(this.userCtrl_onCritialValueChanged);
            // 
            // rdoN2DSeconds
            // 
            this.rdoN2DSeconds.AutoSize = true;
            this.rdoN2DSeconds.Checked = true;
            this.rdoN2DSeconds.Location = new System.Drawing.Point(24, 40);
            this.rdoN2DSeconds.Name = "rdoN2DSeconds";
            this.rdoN2DSeconds.Size = new System.Drawing.Size(63, 17);
            this.rdoN2DSeconds.TabIndex = 1;
            this.rdoN2DSeconds.Text = "Seconds";
            this.rdoN2DSeconds.CheckedChanged += new System.EventHandler(this.userCtrl_onCritialValueChanged);
            // 
            // numAddTime
            // 
            this.numAddTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numAddTime.Location = new System.Drawing.Point(8, 16);
            this.numAddTime.Name = "numAddTime";
            this.numAddTime.Size = new System.Drawing.Size(240, 20);
            this.numAddTime.TabIndex = 0;
            this.numAddTime.ThousandsSeparator = true;
            this.numAddTime.ValueChanged += new System.EventHandler(this.userCtrl_onCritialValueChanged);
            // 
            // grpResult
            // 
            this.grpResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResult.Controls.Add(this.txtResult);
            this.grpResult.Location = new System.Drawing.Point(16, 168);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(200, 40);
            this.grpResult.TabIndex = 3;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BackColor = System.Drawing.SystemColors.Window;
            this.txtResult.Location = new System.Drawing.Point(8, 16);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(184, 20);
            this.txtResult.TabIndex = 4;
            // 
            // cmdCalc
            // 
            this.cmdCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCalc.Location = new System.Drawing.Point(224, 184);
            this.cmdCalc.Name = "cmdCalc";
            this.cmdCalc.Size = new System.Drawing.Size(40, 23);
            this.cmdCalc.TabIndex = 5;
            this.cmdCalc.Text = "Calc";
            this.cmdCalc.Click += new System.EventHandler(this.cmdCalc_onClick);
            // 
            // tabPanel
            // 
            this.tabPanel.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPanel.Controls.Add(this.tpgSec2Date);
            this.tabPanel.Controls.Add(this.tpgDate2Sec);
            this.tabPanel.HotTrack = true;
            this.tabPanel.Location = new System.Drawing.Point(8, 8);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(264, 160);
            this.tabPanel.TabIndex = 6;
            this.tabPanel.SelectedIndexChanged += new System.EventHandler(this.userCtrl_onCritialValueChanged);
            // 
            // tpgSec2Date
            // 
            this.tpgSec2Date.Controls.Add(this.grpN2DBaseDate);
            this.tpgSec2Date.Controls.Add(this.grpAddTime);
            this.tpgSec2Date.Location = new System.Drawing.Point(4, 25);
            this.tpgSec2Date.Name = "tpgSec2Date";
            this.tpgSec2Date.Padding = new System.Windows.Forms.Padding(3);
            this.tpgSec2Date.Size = new System.Drawing.Size(256, 131);
            this.tpgSec2Date.TabIndex = 0;
            this.tpgSec2Date.Text = "Date From Numeric";
            // 
            // tpgDate2Sec
            // 
            this.tpgDate2Sec.Controls.Add(this.rdoD2NmSeconds);
            this.tpgDate2Sec.Controls.Add(this.rdoD2NSeconds);
            this.tpgDate2Sec.Controls.Add(this.label1);
            this.tpgDate2Sec.Controls.Add(this.grpN2DOutput);
            this.tpgDate2Sec.Controls.Add(this.grpD2NEndDate);
            this.tpgDate2Sec.Controls.Add(this.grpD2NBaseDate);
            this.tpgDate2Sec.Location = new System.Drawing.Point(4, 25);
            this.tpgDate2Sec.Name = "tpgDate2Sec";
            this.tpgDate2Sec.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDate2Sec.Size = new System.Drawing.Size(256, 131);
            this.tpgDate2Sec.TabIndex = 1;
            this.tpgDate2Sec.Text = "Numeric From Date";
            // 
            // rdoD2NmSeconds
            // 
            this.rdoD2NmSeconds.AutoSize = true;
            this.rdoD2NmSeconds.Location = new System.Drawing.Point(136, 104);
            this.rdoD2NmSeconds.Name = "rdoD2NmSeconds";
            this.rdoD2NmSeconds.Size = new System.Drawing.Size(76, 17);
            this.rdoD2NmSeconds.TabIndex = 5;
            this.rdoD2NmSeconds.TabStop = false;
            this.rdoD2NmSeconds.Text = "Miliseconds";
            this.rdoD2NmSeconds.CheckedChanged += new System.EventHandler(this.userCtrl_onCritialValueChanged);
            // 
            // rdoD2NSeconds
            // 
            this.rdoD2NSeconds.AutoSize = true;
            this.rdoD2NSeconds.Checked = true;
            this.rdoD2NSeconds.Location = new System.Drawing.Point(56, 104);
            this.rdoD2NSeconds.Name = "rdoD2NSeconds";
            this.rdoD2NSeconds.Size = new System.Drawing.Size(63, 17);
            this.rdoD2NSeconds.TabIndex = 4;
            this.rdoD2NSeconds.Text = "Seconds";
            this.rdoD2NSeconds.CheckedChanged += new System.EventHandler(this.userCtrl_onCritialValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calc:";
            // 
            // grpN2DOutput
            // 
            this.grpN2DOutput.Controls.Add(this.chkMonths);
            this.grpN2DOutput.Controls.Add(this.chkDays);
            this.grpN2DOutput.Controls.Add(this.chkYears);
            this.grpN2DOutput.Controls.Add(this.chkWeeks);
            this.grpN2DOutput.Controls.Add(this.chkMinutes);
            this.grpN2DOutput.Controls.Add(this.chkHours);
            this.grpN2DOutput.Controls.Add(this.checkBox1);
            this.grpN2DOutput.Location = new System.Drawing.Point(336, 16);
            this.grpN2DOutput.Name = "grpN2DOutput";
            this.grpN2DOutput.Size = new System.Drawing.Size(240, 88);
            this.grpN2DOutput.TabIndex = 2;
            this.grpN2DOutput.TabStop = false;
            this.grpN2DOutput.Text = "Output";
            this.grpN2DOutput.Visible = false;
            // 
            // chkMonths
            // 
            this.chkMonths.AutoSize = true;
            this.chkMonths.Location = new System.Drawing.Point(96, 64);
            this.chkMonths.Name = "chkMonths";
            this.chkMonths.Size = new System.Drawing.Size(57, 17);
            this.chkMonths.TabIndex = 6;
            this.chkMonths.Text = "Months";
            // 
            // chkDays
            // 
            this.chkDays.AutoSize = true;
            this.chkDays.Location = new System.Drawing.Point(96, 16);
            this.chkDays.Name = "chkDays";
            this.chkDays.Size = new System.Drawing.Size(46, 17);
            this.chkDays.TabIndex = 5;
            this.chkDays.Text = "Days";
            // 
            // chkYears
            // 
            this.chkYears.AutoSize = true;
            this.chkYears.Location = new System.Drawing.Point(176, 16);
            this.chkYears.Name = "chkYears";
            this.chkYears.Size = new System.Drawing.Size(49, 17);
            this.chkYears.TabIndex = 4;
            this.chkYears.Text = "Years";
            // 
            // chkWeeks
            // 
            this.chkWeeks.AutoSize = true;
            this.chkWeeks.Location = new System.Drawing.Point(96, 40);
            this.chkWeeks.Name = "chkWeeks";
            this.chkWeeks.Size = new System.Drawing.Size(56, 17);
            this.chkWeeks.TabIndex = 3;
            this.chkWeeks.Text = "Weeks";
            // 
            // chkMinutes
            // 
            this.chkMinutes.AutoSize = true;
            this.chkMinutes.Location = new System.Drawing.Point(8, 40);
            this.chkMinutes.Name = "chkMinutes";
            this.chkMinutes.Size = new System.Drawing.Size(59, 17);
            this.chkMinutes.TabIndex = 2;
            this.chkMinutes.Text = "Minutes";
            // 
            // chkHours
            // 
            this.chkHours.AutoSize = true;
            this.chkHours.Location = new System.Drawing.Point(8, 64);
            this.chkHours.Name = "chkHours";
            this.chkHours.Size = new System.Drawing.Size(50, 17);
            this.chkHours.TabIndex = 1;
            this.chkHours.Text = "Hours";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Seconds";
            // 
            // grpD2NEndDate
            // 
            this.grpD2NEndDate.Controls.Add(this.dtD2NEnd);
            this.grpD2NEndDate.Location = new System.Drawing.Point(0, 56);
            this.grpD2NEndDate.Name = "grpD2NEndDate";
            this.grpD2NEndDate.Size = new System.Drawing.Size(256, 40);
            this.grpD2NEndDate.TabIndex = 1;
            this.grpD2NEndDate.TabStop = false;
            this.grpD2NEndDate.Text = "End Date";
            // 
            // dtD2NEnd
            // 
            this.dtD2NEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtD2NEnd.Location = new System.Drawing.Point(8, 16);
            this.dtD2NEnd.Name = "dtD2NEnd";
            this.dtD2NEnd.Size = new System.Drawing.Size(240, 20);
            this.dtD2NEnd.TabIndex = 0;
            this.dtD2NEnd.ValueChanged += new System.EventHandler(this.userCtrl_onCritialValueChanged);
            // 
            // grpD2NBaseDate
            // 
            this.grpD2NBaseDate.Controls.Add(this.dtD2NBase);
            this.grpD2NBaseDate.Location = new System.Drawing.Point(0, 8);
            this.grpD2NBaseDate.Name = "grpD2NBaseDate";
            this.grpD2NBaseDate.Size = new System.Drawing.Size(256, 40);
            this.grpD2NBaseDate.TabIndex = 0;
            this.grpD2NBaseDate.TabStop = false;
            this.grpD2NBaseDate.Text = "Base Date";
            // 
            // dtD2NBase
            // 
            this.dtD2NBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtD2NBase.Location = new System.Drawing.Point(8, 16);
            this.dtD2NBase.Name = "dtD2NBase";
            this.dtD2NBase.Size = new System.Drawing.Size(240, 20);
            this.dtD2NBase.TabIndex = 0;
            this.dtD2NBase.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtD2NBase.ValueChanged += new System.EventHandler(this.userCtrl_onCritialValueChanged);
            // 
            // frmDateCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 217);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.cmdCalc);
            this.Controls.Add(this.grpResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDateCalc";
            this.Text = "Date Calculator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmDateCalc_onLoad);
            this.grpN2DBaseDate.ResumeLayout(false);
            this.grpAddTime.ResumeLayout(false);
            this.grpAddTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddTime)).EndInit();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.tabPanel.ResumeLayout(false);
            this.tpgSec2Date.ResumeLayout(false);
            this.tpgDate2Sec.ResumeLayout(false);
            this.tpgDate2Sec.PerformLayout();
            this.grpN2DOutput.ResumeLayout(false);
            this.grpN2DOutput.PerformLayout();
            this.grpD2NEndDate.ResumeLayout(false);
            this.grpD2NBaseDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtN2DBase;
        private System.Windows.Forms.GroupBox grpN2DBaseDate;
        private System.Windows.Forms.GroupBox grpAddTime;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.NumericUpDown numAddTime;
        private System.Windows.Forms.RadioButton rdoN2DmSeconds;
        private System.Windows.Forms.RadioButton rdoN2DSeconds;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button cmdCalc;
        private System.Windows.Forms.TabControl tabPanel;
        private System.Windows.Forms.TabPage tpgSec2Date;
        private System.Windows.Forms.TabPage tpgDate2Sec;
        private System.Windows.Forms.GroupBox grpD2NEndDate;
        private System.Windows.Forms.GroupBox grpD2NBaseDate;
        private System.Windows.Forms.DateTimePicker dtD2NBase;
        private System.Windows.Forms.DateTimePicker dtD2NEnd;
        private System.Windows.Forms.GroupBox grpN2DOutput;
        private System.Windows.Forms.CheckBox chkDays;
        private System.Windows.Forms.CheckBox chkYears;
        private System.Windows.Forms.CheckBox chkWeeks;
        private System.Windows.Forms.CheckBox chkMinutes;
        private System.Windows.Forms.CheckBox chkHours;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkMonths;
        private System.Windows.Forms.RadioButton rdoD2NmSeconds;
        private System.Windows.Forms.RadioButton rdoD2NSeconds;
        private System.Windows.Forms.Label label1;
    }
}