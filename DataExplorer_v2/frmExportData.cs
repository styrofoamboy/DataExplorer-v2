using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RainstormStudios;
using RainstormStudios.Data;

namespace DataExplorer
{
    public partial class frmExportData : Form
    {
        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        private rsDb
            _db;
        private string
            _dbNm;
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        private frmExportData()
        {
            InitializeComponent();
        }
        public frmExportData(string connStr, string dbName)
            : this(rsDb.GetDbObject(DbConnectionProperties.FromString(AdoProviderType.Auto, connStr)), dbName)
        { }
        public frmExportData(rsDb dbSrc, string dbName):this()
        {
            this._db = dbSrc;
            this._dbNm = dbName;
            this.PopulateTableList();
            this.drpDstFormatType.SelectedIndex = 0;
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private void PopulateTableList()
        {
            this.lstSrcTables.BeginUpdate();
            this.lstSrcTables.Items.Clear();
            try
            {
                if (this._db.GetType().Name != "rsDbSql")
                    throw new Exception("Export wizrd currently only support SQL database sources.");

                rsDbSql db = (rsDbSql)this._db;
                string[] tbls = db.GetTableList(this._dbNm);
                for (int i = 0; i < tbls.Length; i++)
                    this.lstSrcTables.Items.Add("T: " + tbls[i]);

                string[] vws = db.GetViewList(this._dbNm);
                for (int i = 0; i < vws.Length; i++)
                    this.lstSrcTables.Items.Add("V: " + vws[i]);
            }
            catch (Exception ex)
            {
                CrossThreadUI.ShowMessageBox(this, "Unable to retrieve table names: " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.Dispose();
            }
            finally
            {
                this.lstSrcTables.EndUpdate();
            }
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void cmdFinished_onClick(object sender, EventArgs e)
        {
            char[] qualChars=new char[]{'\r','\n',','};
            try
            {
                string dirPath = this.fsbDest.SelectedPath;

                if (string.IsNullOrEmpty(this.fsbDest.SelectedPath))
                    throw new Exception("You must select a destination path.");

                if (this.lstSrcTables.SelectedItems.Count < 1)
                    throw new Exception("You must select one or more tables of data to export.");

                for (int i = 0; i < this.lstSrcTables.CheckedIndices.Count; i++)
                {
                    object objItem = this.lstSrcTables.Items[this.lstSrcTables.CheckedIndices[i]];
                    string strItem = objItem.ToString().Substring(3);
                    string sql = "USE " + this._dbNm + " SELECT * FROM " + strItem;
                    using (System.Data.DataSet ds = this._db.Execute(sql))
                    {
                        if (ds.Tables.Count > 0)
                        {
                            using (System.IO.FileStream fs = new System.IO.FileStream(System.IO.Path.Combine(dirPath, strItem.Replace('.','_'))+".csv", System.IO.FileMode.Create, System.IO.FileAccess.Write))
                            using (System.IO.StreamWriter sr = new System.IO.StreamWriter(fs))
                            {
                                for (int r = 0; r < ds.Tables[0].Rows.Count; r++)
                                {
                                    string rowData = "";
                                    for (int c = 0; c < ds.Tables[0].Columns.Count; c++)
                                    {
                                        string cellVal=ds.Tables[0].Rows[r][c].ToString();
                                        rowData += ((cellVal.IndexOfAny(qualChars) > -1) ? "\"" : "") + ((c > 0) ? "," : "") + cellVal + ((cellVal.IndexOfAny(qualChars) > -1) ? "\"" : "");
                                    }
                                    sr.WriteLine(rowData);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Cannot export data: " + ex.Message, "Export Error");
            }
        }
        private void cmdSelAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.lstSrcTables.Items.Count; i++)
                this.lstSrcTables.SetItemChecked(i, true);
        }
        private void cmdSelNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.lstSrcTables.Items.Count; i++)
                this.lstSrcTables.SetItemChecked(i, false);
        }
        #endregion
    }
}