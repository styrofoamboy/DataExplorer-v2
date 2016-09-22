using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer.ImportWizard_Controls
{
    public partial class ctrlFlatFileSourceFileSelect : UserControl
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        [Browsable(false)]
        public string Filename
        { get { return this.ctrlFlatFileSelect1.Filename; } }
        [Browsable(false)]
        public FlatFileFormat FileFormat
        {
            get { return (FlatFileFormat)this.drpFormat.SelectedIndex; }
            set { this.drpFormat.SelectedIndex = (int)value; }
        }
        [Browsable(false)]
        public string HeaderRowDelim
        {
            get { return this.cboHdrRowDelim.Text; }
            set
            {
                for (int i = 0; i < this.cboHdrRowDelim.Items.Count; i++)
                    if (this.cboHdrRowDelim.Items[i].ToString() == value)
                    {
                        this.cboHdrRowDelim.SelectedIndex = i;
                        break;
                    }
            }
        }
        [Browsable(false)]
        public int HeaderRowSkip
        {
            get { return (int)this.numHdrSkip.Value; }
            set { this.numHdrSkip.Value = (decimal)value; }
        }
        [Browsable(false)]
        public bool ColumnHeaderNames
        {
            get { return this.chkColNames.Checked; }
            set { this.chkColNames.Checked = value; }
        }
        [Browsable(false)]
        public string TextQualifier
        {
            get { return this.txtQual.Text; }
            set { this.txtQual.Text = value; }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public ctrlFlatFileSourceFileSelect()
        {
            InitializeComponent();
            this.drpFormat.SelectedIndex = 0;
            this.cboHdrRowDelim.SelectedIndex = 0;
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void ctrlFlatFileSelect1_onFilenameChanged(object sender, EventArgs e)
        {
            this.panFormat.Enabled = System.IO.File.Exists(this.ctrlFlatFileSelect1.Filename);
        }
        private void drpFormat_onSelectedIndexChanged(object sender, EventArgs e)
        {
            this.ctrlFlatFileSelect1.FileFormat = (FlatFileFormat)this.drpFormat.SelectedIndex;
        }
        #endregion
    }
}
