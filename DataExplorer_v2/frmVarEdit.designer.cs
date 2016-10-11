namespace DataExplorer
{
    partial class frmVarEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVarName = new System.Windows.Forms.TextBox();
            this.txtVarValue = new System.Windows.Forms.TextBox();
            this.cmdOK = new RainstormStudios.Controls.AdvancedButton();
            this.cmdCancel = new RainstormStudios.Controls.AdvancedButton();
            this.sqlDataTypeList1 = new RainstormStudios.Controls.SqlDataTypeList();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Variable Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Variable Value:";
            // 
            // txtVarName
            // 
            this.txtVarName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVarName.Location = new System.Drawing.Point(12, 25);
            this.txtVarName.Name = "txtVarName";
            this.txtVarName.Size = new System.Drawing.Size(243, 20);
            this.txtVarName.TabIndex = 2;
            // 
            // txtVarValue
            // 
            this.txtVarValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVarValue.Location = new System.Drawing.Point(12, 80);
            this.txtVarValue.Name = "txtVarValue";
            this.txtVarValue.Size = new System.Drawing.Size(366, 20);
            this.txtVarValue.TabIndex = 3;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdOK.BorderWidth = 1;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdOK.ButtonShape = graphicsPath1;
            this.cmdOK.CornerFeather = 5;
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdOK.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdOK.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdOK.HighlightMultiplier = 2F;
            this.cmdOK.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdOK.HoverHighlightOpacity = 200;
            this.cmdOK.HoverImage = null;
            this.cmdOK.ImagePadding = 0;
            this.cmdOK.Location = new System.Drawing.Point(222, 128);
            this.cmdOK.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdOK.MouseDownImage = null;
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 5;
            this.cmdOK.Text = "Save";
            this.cmdOK.TextOutline = false;
            this.cmdOK.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdOK.TextOutlineOpacity = 255;
            this.cmdOK.TextOutlineWeight = 2F;
            this.cmdOK.ThreeDEffectDepth = 50;
            this.cmdOK.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdOK.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdCancel.BorderWidth = 1;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdCancel.ButtonShape = graphicsPath2;
            this.cmdCancel.CornerFeather = 5;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdCancel.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdCancel.HighlightMultiplier = 2F;
            this.cmdCancel.HoverHighlightColor = System.Drawing.Color.Crimson;
            this.cmdCancel.HoverHighlightOpacity = 200;
            this.cmdCancel.HoverImage = null;
            this.cmdCancel.ImagePadding = 0;
            this.cmdCancel.Location = new System.Drawing.Point(303, 128);
            this.cmdCancel.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdCancel.MouseDownImage = null;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.TextOutline = false;
            this.cmdCancel.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdCancel.TextOutlineOpacity = 255;
            this.cmdCancel.TextOutlineWeight = 2F;
            this.cmdCancel.ThreeDEffectDepth = 50;
            this.cmdCancel.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // sqlDataTypeList1
            // 
            this.sqlDataTypeList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlDataTypeList1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sqlDataTypeList1.FormattingEnabled = true;
            this.sqlDataTypeList1.Items.AddRange(new object[] {
            "BigInt",
            "Binary",
            "Bit",
            "Char",
            "DateTime",
            "Decimal",
            "Float",
            "Image",
            "Int",
            "Money",
            "NChar",
            "NText",
            "NVarChar",
            "Real",
            "UniqueIdentifier",
            "SmallDateTime",
            "SmallInt",
            "SmallMoney",
            "Text",
            "Timestamp",
            "TinyInt",
            "VarBinary",
            "VarChar",
            "Variant",
            "Xml",
            "Udt",
            "Structured",
            "Date",
            "Time",
            "DateTime2",
            "DateTimeOffset",
            "BigInt",
            "Binary",
            "Bit",
            "Char",
            "DateTime",
            "Decimal",
            "Float",
            "Image",
            "Int",
            "Money",
            "NChar",
            "NText",
            "NVarChar",
            "Real",
            "UniqueIdentifier",
            "SmallDateTime",
            "SmallInt",
            "SmallMoney",
            "Text",
            "Timestamp",
            "TinyInt",
            "VarBinary",
            "VarChar",
            "Variant",
            "Xml",
            "Udt",
            "Structured",
            "Date",
            "Time",
            "DateTime2",
            "DateTimeOffset",
            "BigInt",
            "Binary",
            "Bit",
            "Char",
            "DateTime",
            "Decimal",
            "Float",
            "Image",
            "Int",
            "Money",
            "NChar",
            "NText",
            "NVarChar",
            "Real",
            "UniqueIdentifier",
            "SmallDateTime",
            "SmallInt",
            "SmallMoney",
            "Text",
            "Timestamp",
            "TinyInt",
            "VarBinary",
            "VarChar",
            "Variant",
            "Xml",
            "Udt",
            "Structured",
            "Date",
            "Time",
            "DateTime2",
            "DateTimeOffset",
            "BigInt",
            "Binary",
            "Bit",
            "Char",
            "DateTime",
            "Decimal",
            "Float",
            "Image",
            "Int",
            "Money",
            "NChar",
            "NText",
            "NVarChar",
            "Real",
            "UniqueIdentifier",
            "SmallDateTime",
            "SmallInt",
            "SmallMoney",
            "Text",
            "Timestamp",
            "TinyInt",
            "VarBinary",
            "VarChar",
            "Variant",
            "Xml",
            "Udt"});
            this.sqlDataTypeList1.Location = new System.Drawing.Point(261, 25);
            this.sqlDataTypeList1.Name = "sqlDataTypeList1";
            this.sqlDataTypeList1.SelectedType = System.Data.SqlDbType.Variant;
            this.sqlDataTypeList1.Size = new System.Drawing.Size(117, 21);
            this.sqlDataTypeList1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Type:";
            // 
            // frmVarEdit
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(390, 143);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sqlDataTypeList1);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.txtVarValue);
            this.Controls.Add(this.txtVarName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(5000, 177);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 177);
            this.Name = "frmVarEdit";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Global Variable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVarName;
        private System.Windows.Forms.TextBox txtVarValue;
        private RainstormStudios.Controls.AdvancedButton cmdCancel;
        private RainstormStudios.Controls.AdvancedButton cmdOK;
        private RainstormStudios.Controls.SqlDataTypeList sqlDataTypeList1;
        private System.Windows.Forms.Label label3;
    }
}