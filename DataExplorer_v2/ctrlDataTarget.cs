using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RainstormStudios;
using RainstormStudios.Data;
using RainstormStudios.Collections;

namespace DataExplorer
{
    public enum DataTargetDirection : int
    {
        Source,
        Destination
    }
    public enum DataTargetType : int
    {
        SQL_Native_Client,
        Microsoft_OLE_DB_Provider,
        Flat_File,
        Microsoft_Excel_97_ISAM
    }
    public enum FlatFileFormat : int
    {
        Delimited,
        Fixed_Width,
        Ragged_Right
    }
    public partial class ctrlDataTarget : UserControl
    {
        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        private ColumnParamsCollection
            _cols;
        private DataTargetDirection
            _tgtDir;
        //***************************************************************************
        // Event Handlers
        // 
        public event ExceptionEventHandler ExceptionThrown;
        public event EventHandler FlatFileSelected;
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public DataTargetDirection TargetDirection
        {
            get { return this._tgtDir; }
            set { this._tgtDir = value; }
        }
        public DataTargetType DataTargetType
        {
            get { return (DataTargetType)this.pan02drpDataSource.SelectedIndex; }
            set { this.pan02drpDataSource.SelectedIndex = (int)value; }
        }
        public FlatFileFormat FlatDataSelectedFlatFileFormat
        {
            get { return (FlatFileFormat)this.pan02drpFlatSrcFormat.SelectedIndex; }
            set { this.pan02drpFlatSrcFormat.SelectedIndex = (int)value; }
        }
        public string FlatDataHeaderRowQualifier
        {
            get { return this.pan02cboFlatSrcHdrRowQual.Text; }
            set { this.pan02cboFlatSrcHdrRowQual.Text = value; }
        }
        public string FlatDataTextQualifier
        {
            get { return this.pan02txtFlatSrcTextQual.Text; }
            set { this.pan02txtFlatSrcTextQual.Text = value; }
        }
        public bool FlatDataTopRowContainsHeaders
        {
            get { return this.pan02chkFlatSrcColNameFirstRow.Checked; }
            set { this.pan02chkFlatSrcColNameFirstRow.Checked = value; }
        }
        //***************************************************************************
        // Private Properties
        // 
        internal ColumnParamsCollection Columns
        {
            get
            {
                if (this._cols == null || this._cols.Count < 1)
                {
                    this.PopulateColumns();
                }
                return this._cols;
            }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public ctrlDataTarget()
        {
            InitializeComponent();
            this.InitDropMenus();
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Protected Methods
        // 
        protected void OnExceptionThrown(ExceptionEventArgs e)
        {
            if (this.ExceptionThrown != null)
                this.ExceptionThrown.Invoke(this, e);
        }
        protected void OnFlatFileSelected(EventArgs e)
        {
            if (this.FlatFileSelected != null)
                this.FlatFileSelected.Invoke(this, e);
        }
        //***************************************************************************
        // Private Methods
        // 
        private void InitDropMenus()
        {
            this.pan02drpDataSource.Items.Clear();
            foreach (string val in Enum.GetNames(typeof(DataTargetType)))
                this.pan02drpDataSource.Items.Add(val.Replace('_', ' '));

            this.pan02drpFlatSrcFormat.Items.Clear();
            foreach (string val in Enum.GetNames(typeof(FlatFileFormat)))
                this.pan02drpFlatSrcFormat.Items.Add(val.Replace('_', ' '));

            this.pan02drpDataSource.SelectedIndex = 0;
            this.pan02drpFlatSrcFormat.SelectedIndex = 0;
            this.pan02lstFlatSrcSettings.SelectedIndex = 0;
            this.pan02cboFlatSrcColDelim.SelectedIndex = 5;
            this.pan02cboFlatSrcRowDelim.SelectedIndex=0;
        }
        private void PopulateColumns()
        {
            if (this._cols == null)
                this._cols = new ColumnParamsCollection();
            else
                this._cols.Clear();

            if (this.TargetDirection == DataTargetDirection.Source)
            {
                if (this.DataTargetType == DataTargetType.Flat_File)
                {
                    if (string.IsNullOrEmpty(this.pan02cboFlatSrcColDelim.Text) || string.IsNullOrEmpty(this.pan02cboFlatSrcRowDelim.Text) || !File.Exists(this.pan02txtFlatSrcFileName.Text))
                        return;

                    string[] pcs = null;
                    switch (this.pan02drpFlatSrcFormat.SelectedIndex)
                    {
                        case 0:     // Delimited
                            string
                                cDelim = string.Empty,
                                rDelim = string.Empty;
                            switch (this.pan02cboFlatSrcColDelim.Text)
                            {
                                case "{CR}{LF}": cDelim = "\r\n"; break;
                                case "{CR}": cDelim = "\r"; break;
                                case "{LF}": cDelim = "\n"; break;
                                case "Semicolon {;}": cDelim = "\n"; break;
                                case "Colon {:}": cDelim = ":"; break;
                                case "Comma {,}": cDelim = ","; break;
                                case "Tab {t}": cDelim = "\t"; break;
                                case "Vertical Bar {|}": cDelim = "|"; break;
                                default: cDelim = this.pan02lblFlatSrcColDelim.Text; break;
                            }
                            switch (this.pan02cboFlatSrcRowDelim.Text)
                            {
                                case "{CR}{LF}": rDelim = "\r\n"; break;
                                case "{CR}": rDelim = "\r"; break;
                                case "{LF}": rDelim = "\n"; break;
                                case "Semicolon {;}": rDelim = "\n"; break;
                                case "Colon {:}": rDelim = ":"; break;
                                case "Comma {,}": rDelim = ","; break;
                                case "Tab {t}": rDelim = "\t"; break;
                                case "Vertical Bar {|}": rDelim = "|"; break;
                                default: rDelim = this.pan02lblFlatSrcColDelim.Text; break;
                            }

                            string sTxtQual = this.pan02txtFlatSrcTextQual.Text;
                            if (sTxtQual.ToLower() == "<none>")
                                sTxtQual = string.Empty;

                            using (FileStream fs = new FileStream(this.pan02txtFlatSrcFileName.Text, FileMode.Open, FileAccess.Read))
                            using (RainstormStudios.IO.DelimitedTextReader rdr = new RainstormStudios.IO.DelimitedTextReader(fs, rDelim, cDelim, sTxtQual, Encoding.Default))
                                for (int i = 0; i < this.pan02numFlatSrc.Value + 1; i++)
                                    pcs = rdr.ReadRow();
                            break;
                        case 1:     // Fixed width
                            break;
                        case 2:     // Ragged right
                            break;
                    }

                    // If the first row doesn't contain the column names, then
                    //   just populate the array with generic "ColumnXXX" values.
                    if (!this.pan02chkFlatSrcColNameFirstRow.Checked)
                        for (int i = 0; i < pcs.Length; i++)
                            pcs[i] = "Column" + i.ToString().PadLeft(pcs.Length.ToString().Length, '0');

                    // Create the entries in the ColumnParams collection.
                    for (int i = 0; i < pcs.Length; i++)
                        this._cols.Add(new RainstormStudios.Data.ColumnParams(pcs[i], typeof(System.String), 0, i));

                    if (pcs == null)
                        return;
                }
                else
                {
                    string sqlQry = "SELECT TOP 1 * FROM " + this.pan02drpSqlDatabaseList.Text;
                    using (rsDb db = rsDb.GetDbObject(AdoProviderType.Auto, this.GetConnectionString(), sqlQry))
                    {
                        using (DataSet ds = db.GetData())
                        {
                            if (ds.Tables.Count > 0)
                                foreach (DataColumn dc in ds.Tables[0].Columns)
                                    this._cols.Add(new ColumnParams(dc.ColumnName, dc.DataType, dc.MaxLength, dc.Ordinal));
                        }
                    }
                }
            }
            else
            {
                if (this.DataTargetType == DataTargetType.Flat_File && File.Exists(this.pan02txtFlatSrcFileName.Text))
                {
                }
                else if (this.DataTargetType == DataTargetType.SQL_Native_Client)
                {
                }
            }

            // If we're working with a flat data type, then populate the columns in the wizard.
            if (this.DataTargetType == DataTargetType.Flat_File)
            {
                this.pan02lstFlatSrcColPrev.BeginUpdate();
                this.pan02lstFlatSrcColPrev.Items.Clear();
                for (int c = 0; c < this._cols.Count; c++)
                    this.pan02lstFlatSrcColPrev.Items.Add(new ListViewItem(new string[] { this._cols[c].ColumnName, this._cols[c].DataType.ToString(), this._cols[c].FieldSize.ToString() }));
                this.pan02lstFlatSrcColPrev.EndUpdate();
            }
        }
        private void PopulatePreivew()
        {
            if (!File.Exists(this.pan02txtFlatSrcFileName.Text))
                return;

            using (DataTable dt = new DataTable())
            {
                foreach (RainstormStudios.Data.ColumnParams cPrms in this._cols)
                    dt.Columns.Add(new DataColumn(cPrms.ColumnName));

                string colDelim = "";
                switch (this.pan02cboFlatSrcColDelim.Text)
                {
                    case "{CR}{LF}": colDelim = "\r\n"; break;
                    case "{CR}": colDelim = "\r"; break;
                    case "{LF}": colDelim = "\n"; break;
                    case "Semicolon {;}": colDelim = "\n"; break;
                    case "Colon {:}": colDelim = ":"; break;
                    case "Comma {,}": colDelim = ","; break;
                    case "Tab {t}": colDelim = "\t"; break;
                    case "Vertical Bar {|}": colDelim = "|"; break;
                    default: colDelim = this.pan02lblFlatSrcColDelim.Text; break;
                }

                string rowDelim = "";
                switch (this.pan02cboFlatSrcRowDelim.Text)
                {
                    case "{CR}{LF}": rowDelim = "\r\n"; break;
                    case "{CR}": rowDelim = "\r"; break;
                    case "{LF}": rowDelim = "\n"; break;
                    case "Semicolon {;}": rowDelim = "\n"; break;
                    case "Colon {:}": rowDelim = ":"; break;
                    case "Comma {,}": rowDelim = ","; break;
                    case "Tab {t}": rowDelim = "\t"; break;
                    case "Vertical Bar {|}": rowDelim = "|"; break;
                    default: rowDelim = this.pan02lblFlatSrcRowDelim.Text; break;
                }

                using (RainstormStudios.IO.DelimitedTextReader dtRdr = new RainstormStudios.IO.DelimitedTextReader(this.pan02txtFlatSrcFileName.Text, rowDelim, colDelim, this.pan02txtFlatSrcTextQual.Text, Encoding.Default))
                {
                    int i = 0,
                        stNum = (int)this.pan02panFlatSrcPreviewNumRowSkip.Value + ((this.pan02chkFlatSrcColNameFirstRow.Checked) ? 1 : 0);
                    for (i = 0; i < 99 + stNum; i++)
                    {
                        DataRow dr = dt.NewRow();
                        dr.ItemArray = dtRdr.ReadRow();
                        if (i > stNum)
                            dt.Rows.Add(dr);
                    }
                    this.pan02lblFlatSrcPrevRowNums.Text = string.Format("Preview Rows {0} - {1}", stNum, i);
                }

                this.pan02panFlatSrcPreviewDg.DataSource = dt;
            }
        }
        private void SetDatabaseListCbo()
        {
            string connStr = "";
            if (this.pan02drpDataSource.SelectedIndex == 1)
                connStr += "Provider=SQLOLEDB;";
            connStr += "Data Source=" + this.cboServerName.Text.Trim() + ";";
            connStr += "Initial Catalog=master;";
            if (this.pan02rdoSqlSrcSqlAuth.Checked)
            {
                connStr += "User ID=" + this.pan02txtSqlAuthUser.Text + ";";
                connStr += "Password=" + this.pan02txtSqlAuthPass.Text + ";";
            }
            else
            {
                connStr += "Integrated Security=SSPI;";
            }
            this.pan02drpSqlDatabaseList.ConnectionString = connStr;
        }
        private string GetConnectionString()
        {
            string sqlConn = string.Format("Data Source={0};Initial Catalog={1};",
                                this.pan02drpDataSource.Text,
                                this.pan02drpSqlDatabaseList.Text);
            if (this.pan02rdoSqlSrcSqlAuth.Checked)
            {
                sqlConn += string.Format("User ID={0};Password={1};",
                                this.pan02txtSqlAuthUser.Text,
                                this.pan02txtSqlAuthPass.Text);
            }
            else
            {
                sqlConn += "Integrated Security=SSPI;";
            }
            return sqlConn;
        }
        private void PopulateColsFromSrc()
        {
            RainstormStudios.Data.ColumnParamsCollection srcCols = ((frmDataImport)this.FindForm()).DataSource.DataTarget._cols;
            foreach (RainstormStudios.Data.ColumnParams col in srcCols)
                this._cols.Add((RainstormStudios.Data.ColumnParams)col.Clone());
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void cmdBrowse_onClick(object sender, EventArgs e)
        {
            if (this.TargetDirection == DataTargetDirection.Source)
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.ValidateNames = true;
                    dlg.Title = "Select Flat Data File";
                    dlg.SupportMultiDottedExtensions = true;
                    dlg.Multiselect = false;
                    dlg.Filter = "Flat Data Files|*.txt;*.csv|Text Files|*.txt|Comma Seperated Values Files|*.csv|All Files|*.*";
                    dlg.FilterIndex = 0;
                    dlg.CheckPathExists = true;
                    dlg.CheckFileExists = true;
                    dlg.AddExtension = true;
                    dlg.DefaultExt = ".txt";
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                        this.pan02txtFlatSrcFileName.Text = dlg.FileName;
                }
            }
            else
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.ValidateNames = true;
                    dlg.Title = "Select a Destination File";
                    dlg.SupportMultiDottedExtensions = true;
                    string
                        dlgFilter = "|All Files (*.*)|*.*",
                        defExt = ".";
                    switch (this.DataTargetType)
                    {
                        case DataTargetType.Flat_File:
                            dlgFilter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv" + dlgFilter;
                            //defExt += (this.FlatDataSelectedFlatFileFormat == FlatFileFormat.Delimited) ? "csv" : "txt";
                            break;
                        case DataTargetType.Microsoft_Excel_97_ISAM:
                            dlgFilter = "Excel Files (*.xls)|*.xls" + dlgFilter;
                            //defExt += "xls";
                            break;
                    }
                    dlg.Filter = dlgFilter;
                    dlg.FilterIndex = (this.DataTargetType == DataTargetType.Flat_File && this.FlatDataSelectedFlatFileFormat == FlatFileFormat.Delimited) ? 1 : 0;
                    dlg.OverwritePrompt = true;
                    dlg.AddExtension = true;
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                        this.pan02txtFlatSrcFileName.Text = dlg.FileName;
                }
            }
        }
        private void pan02rdoSqlSrcSqlAuth_onCheckedChanged(object sender, EventArgs e)
        {
            this.pan02panSqlSrcAuth.Enabled = (this.pan02rdoSqlSrcSqlAuth.Checked);
        }
        private void pan02panSqlSrcAuth_EnabledChanged(object sender, EventArgs e)
        {
            if (this.pan02panSqlSrcAuth.Enabled)
                this.pan02txtSqlAuthUser.Focus();
        }
        private void pan02drpDataSource_onSelectedChanged(object sender, EventArgs e)
        {
            this.pan02panFlatSrcSettings.Visible = (this.pan02drpDataSource.SelectedIndex == (int)DataTargetType.Flat_File);
            this.pan02panSqlSrc.Visible = (this.pan02drpDataSource.SelectedIndex == (int)DataTargetType.SQL_Native_Client || this.pan02drpDataSource.SelectedIndex == (int)DataTargetType.Microsoft_OLE_DB_Provider);
        }
        private void pan02lstFlatSrcSettings_onSelectedChanged(object sender, EventArgs e)
        {
            this.pan02panFlatSrcFile.Visible = (this.pan02lstFlatSrcSettings.SelectedIndex == 0);
            this.pan02panFlatSrcColConfig.Visible = (this.pan02lstFlatSrcSettings.SelectedIndex == 1);
            this.pan02panFlatSrcPreview.Visible = (this.pan02lstFlatSrcSettings.SelectedIndex == 3);
        }
        private void pan02panFlatSrcPreviewNumRowSkip_ValueChanged(object sender, EventArgs e)
        {
            this.pan02panFlatSrcPreviewLnkRefresh.Visible = true;
        }
        private void pan02panFlatSrcPreviewLnkRefresh_onLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.PopulatePreivew();
            this.pan02panFlatSrcPreviewLnkRefresh.Visible = false;
            this.pan02numFlatSrc.Focus();
        }
        private void pan02txtFlatSrcFileName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.pan02txtFlatSrcFileName.Text) && (System.IO.File.Exists(this.pan02txtFlatSrcFileName.Text) || this._tgtDir == DataTargetDirection.Destination))
            {
                // TODO:: Parse specified text file and attempt to determine format.
                this.pan02FlatSrcFilePanFormat.Enabled =
                    this.pan02lstFlatSrcSettings.Enabled = true;
                this.PopulateColumns();
            }
            else
            {
                this.pan02FlatSrcFilePanFormat.Enabled =
                    this.pan02lstFlatSrcSettings.Enabled = false;
            }
        }
        private void pan02drpFlatSrcFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pan02grpFlatSrcDelim.Visible = (this.pan02drpFlatSrcFormat.SelectedIndex == 0);
        }
        private void pan02cboFlatSrcRowDelim_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateColumns();
        }
        private void pan02cboFlatSrcColDelim_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateColumns();
        }
        private void pan02panFlatSrcPreview_VisibleChanged(object sender, EventArgs e)
        {
            if (pan02panFlatSrcPreview.Visible)
            {
            }
        }
        private void pan02cmdFlatSrcResetCol_Click(object sender, EventArgs e)
        {
            this.PopulateColumns();
        }
        private void pan02cboFlatSrcHdrRowQual_TextUpdate(object sender, EventArgs e)
        {
            this.PopulateColumns();
        }
        private void pan02chkFlatSrcColNameFirstRow_CheckedChanged(object sender, EventArgs e)
        {
            this.PopulateColumns();
        }
        private void pan02numFlatSrc_ValueChanged(object sender, EventArgs e)
        {
            this.PopulateColumns();
        }
        private void cboServerName_TextChanged(object sender, EventArgs e)
        {
            this.SetDatabaseListCbo();
        }
        private void pan02rdoSqlSrcSqlAuth_CheckedChanged(object sender, EventArgs e)
        {
            this.SetDatabaseListCbo();
        }
        private void pan02txtSqlAuthUser_TextChanged(object sender, EventArgs e)
        {
            this.SetDatabaseListCbo();
        }
        private void pan02txtSqlAuthPass_TextChanged(object sender, EventArgs e)
        {
            this.SetDatabaseListCbo();
        }
        //***************************************************************************
        // Event Overrides
        // 
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        #endregion
    }
}
