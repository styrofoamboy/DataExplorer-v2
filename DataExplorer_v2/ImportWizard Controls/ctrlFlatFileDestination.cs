using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer.ImportWizard_Controls
{
    public partial class ctrlFlatFileDestination : UserControl
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        [Browsable(false)]
        public FlatFileFormat FileFormat
        {
            get { return (FlatFileFormat)this.drpFormat.SelectedIndex; }
            set { this.drpFormat.SelectedIndex = (int)value; }
        }
        [Browsable(false)]
        public string TextQualifier
        {
            get { return this.txtQualifier.Text; }
            set { this.txtQualifier.Text = value; }
        }
        [Browsable(false)]
        public bool ColumnNames
        {
            get { return chkColNames.Checked; }
            set { this.chkColNames.Checked = value; }
        }
        [Browsable(false)]
        public string Filename
        {
            get { return this.ctrlFlatFileSelect.Filename; }
            set { this.ctrlFlatFileSelect.Filename = value; }
        }
        [Browsable(false)]
        public Encoding CodePage
        {
            get { return this.ctrlFlatFileSelect.CodePage; }
            set { this.ctrlFlatFileSelect.CodePage = value; }
        }
        [Browsable(false)]
        public System.Globalization.CultureInfo Locale
        {
            get { return this.ctrlFlatFileSelect.Locale; }
            set { this.ctrlFlatFileSelect.Locale = value; }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public ctrlFlatFileDestination()
        {
            InitializeComponent();
            if (!this.DesignMode && this.drpFormat.Items.Count > 0)
                this.drpFormat.SelectedIndex = 0;
        }
        #endregion
    }
}
