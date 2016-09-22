using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer.ImportWizard_Controls
{
    public partial class ctrlFlatFileSelect : UserControl
    {
        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        private bool
            _saveMode;
        private FlatFileFormat
            _fmt;
        private RainstormStudios.Collections.Int32Collection
            _cultsCol,
            _cdpgCol;
        //***************************************************************************
        // Event Definitions
        // 
        public event EventHandler FilenameChanged;
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        [Browsable(false)]
        public string Filename
        {
            get
            {
                string fn = this.txtFilename.Text;
                if (!System.IO.Path.IsPathRooted(fn) && !this.DesignMode)
                    fn = System.IO.Path.Combine(Environment.CurrentDirectory, fn);
                return fn;
            }
            set { this.txtFilename.Text = value; }
        }
        public bool SaveMode
        {
            get { return this._saveMode; }
            set { this._saveMode = value; }
        }
        [Browsable(false)]
        public FlatFileFormat FileFormat
        {
            get { return this._fmt; }
            set { this._fmt = value; }
        }
        [Browsable(false)]
        public CultureInfo Locale
        {
            get { return CultureInfo.GetCultureInfo(this._cultsCol[this.drpLocale.SelectedItem.ToString()]); }
            set
            {
                // Try and find the specified culture in our collection.
                int idx = this._cultsCol.IndexOfKey(value.DisplayName);

                // If we don't find it, then just force-select the current default culture.
                if (idx < 0 || idx > this.drpLocale.Items.Count)
                    idx = this._cultsCol.IndexOfKey(CultureInfo.CurrentUICulture.DisplayName);

                // Move the DropDownList selection.
                this.drpLocale.SelectedIndex = idx;
            }
        }
        [Browsable(false)]
        public Encoding CodePage
        {
            get
            {
                return (this.chkUnicode.Checked)
                            ? Encoding.Unicode
                            : Encoding.GetEncoding(this._cdpgCol[this.drpCodepage.SelectedItem.ToString()]);
            }
            set
            {
                // Try and find the specified codepage in our collection.
                int idx = this._cdpgCol.IndexOfKey(value.EncodingName);

                // If we don't find it, then just force-select the default system codepage.
                if (idx < 0 || idx > this.drpCodepage.Items.Count)
                    idx = this._cdpgCol.IndexOfKey(System.Text.Encoding.Default.EncodingName);

                // Move the DropDownList selection.
                this.drpCodepage.SelectedIndex = idx;
            }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public ctrlFlatFileSelect()
        {
            InitializeComponent();
            this._saveMode = false;
            this._fmt = FlatFileFormat.Delimited;

            this._cultsCol = new RainstormStudios.Collections.Int32Collection();
            CultureInfo[] cults = CultureInfo.GetCultures(System.Globalization.CultureTypes.InstalledWin32Cultures);
            for (int i = 0; i < cults.Length; i++)
            {
                try
                {
                    this._cultsCol.Add(cults[i].LCID, cults[i].DisplayName);
                    this.drpLocale.Items.Add(cults[i].DisplayName);

                    // Set the DropDownList to the system's default culture.
                    if (CultureInfo.CurrentUICulture.DisplayName == cults[i].DisplayName)
                        this.drpLocale.SelectedIndex = i;
                }
                catch { }
            }

            this._cdpgCol = new RainstormStudios.Collections.Int32Collection();
            System.Text.EncodingInfo[] encs = System.Text.Encoding.GetEncodings();
            for (int i = 0; i < encs.Length; i++)
            {
                try
                {
                    this._cdpgCol.Add(encs[i].CodePage, encs[i].DisplayName);
                    this.drpCodepage.Items.Add(encs[i].DisplayName);

                    // Set the DropDownList to the system's default codepage.
                    if (System.Text.Encoding.Default.CodePage == encs[i].CodePage)
                        this.drpCodepage.SelectedIndex = i;
                }
                catch { }
            }
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Protected Methods
        // 
        protected void OnFilenameChanged(EventArgs e)
        {
            if (this.FilenameChanged != null)
                this.FilenameChanged.Invoke(this, e);
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void txtFilename_onTextChanged(object sender, EventHandler e)
        {
            this.OnFilenameChanged(EventArgs.Empty);
        }
        private void chkUnicode_onCheckedChanged(object sender, EventArgs e)
        {
            this.drpCodepage.Enabled = !this.chkUnicode.Checked;
        }
        private void cmdBrowse_onClick(object sender, EventArgs e)
        {
            if (this._saveMode)
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.SupportMultiDottedExtensions = true;
                    dlg.OverwritePrompt = true;
                    dlg.Title = "Select file to save...";
                    dlg.ValidateNames = true;
                    dlg.Filter = "Comma Seperated Values|*.csv|Text Files|*.txt|All Files|*.*";
                    dlg.FilterIndex = (this._fmt == FlatFileFormat.Delimited) ? 0 : 1;
                    dlg.AddExtension = true;
                    if (dlg.ShowDialog(this.FindForm()) == DialogResult.OK)
                        this.txtFilename.Text = dlg.FileName;
                }
            else
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.CheckFileExists = true;
                    dlg.CheckPathExists = true;
                    dlg.AddExtension = true;
                    dlg.Filter = "Comma Seperated Values|*.csv|Text Files|*.txt|All Files|*.*";
                    dlg.FilterIndex = (this._fmt == FlatFileFormat.Delimited) ? 0 : 1;
                    dlg.Multiselect = true;
                    dlg.ValidateNames = true;
                    dlg.Title = "Select file to import...";
                    dlg.DereferenceLinks = true;
                    if (dlg.ShowDialog(this.FindForm()) == DialogResult.OK)
                        this.txtFilename.Text = dlg.FileName;
                }
        }
        #endregion
    }
}
