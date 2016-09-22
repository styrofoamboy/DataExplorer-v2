using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RainstormStudios.Data;

namespace DataExplorer
{
    public partial class frmSqlBrowser : Form
    {
        private enum SqlObjType
        {
            Database = 0,
            Table,
            TableGroup,
            Column,
            ColumnGroup,
            Key,
            KeyGroup,
            Constraint,
            ConstraintGroup,
            Trigger,
            TriggerGroup,
            Index,
            IndexGroup,
            View,
            ViewGroup,
            StoredProc,
            StoredProcGroup,
            Function,
            FunctionGroup,
            User,
            SecurityGroup,
            UserGroup,
        }

        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        private SqlBrowserTreeView
            _sqlExplorer;
        //***************************************************************************
        // Public Events
        // 
        public event EditObjectEventHandler ScriptObject;
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        private frmSqlBrowser()
        {
            InitializeComponent();
            //this.trvSqlList.BeforeExpand += new TreeViewCancelEventHandler(this.treeView_onBeforeExpanding);
            //this.trvSqlList.AfterSelect += new TreeViewEventHandler(this.treeView_onSelectedChanged);
            this.lstSearchResults.Columns.Add(new RainstormStudios.Controls.FixedColumnListView.FixedColumnHeader("colResult", "Result", 99, SizeType.Percent));
            this.splitContainer1.Panel2Collapsed = true;
        }
        internal frmSqlBrowser(ConnectionCollection connCol)
            : this()
        {
            this._sqlExplorer = new SqlBrowserTreeView(connCol);
            this._sqlExplorer.EditObject += new EditObjectEventHandler(sqlExplorer_onEditObject);
            this.splitContainer1.Panel1.Controls.Add(this._sqlExplorer);
            this._sqlExplorer.Dock = DockStyle.Fill;
        }
        internal frmSqlBrowser(ConnectionCollection connCol, int selConn)
            : this(connCol)
        {
            //if (selConn > -1 && this.trvSqlList.Nodes.Count > selConn)
            //    this.trvSqlList.Nodes[selConn].Expand();
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private rsDbSql GetDbObject(TreeNode nd)
        {
            while (nd.Level > 0)
                nd = nd.Parent;
            return (rsDbSql)nd.Tag;
        }
        private void DoSearch(string srchValue)
        { this.DoSearch(srchValue, false); }
        private void DoSearch(string srchValue, bool incCols)
        {
            this.UseWaitCursor = true;
            this.lstSearchResults.BeginUpdate();
            this.lstSearchResults.Items.Clear();
            this.lstSearchResults.ShowGroups = true;
            try
            {
                rsDbSql dbConn = this.GetDbObject(this._sqlExplorer.SelectedNode);
                bool noResults = true;
                foreach (string tbl in dbConn.SearchForTable(srchValue,true))
                { this.lstSearchResults.Items.Add(new ListViewItem(tbl, 2, this.lstSearchResults.Groups["grpTables"])); noResults = false; }
                foreach (string view in dbConn.SearchForView(srchValue, true))
                { this.lstSearchResults.Items.Add(new ListViewItem(view, 8, this.lstSearchResults.Groups["grpViews"])); noResults = false; }
                foreach (string sp in dbConn.SearchForStoredProceedure(srchValue, true))
                { this.lstSearchResults.Items.Add(new ListViewItem(sp, 4, this.lstSearchResults.Groups["grpStoredProcs"])); noResults = false; }
                foreach (string func in dbConn.SearchForFunction(srchValue, true))
                { this.lstSearchResults.Items.Add(new ListViewItem(func, 4, this.lstSearchResults.Groups["grpFuncs"])); noResults = false; }

                try
                {
                    if (incCols)
                        try
                        {
                            foreach (string dbNm in dbConn.GetDatabaseList())
                                try
                                {
                                    foreach (string tbl in dbConn.GetTableList(dbNm))
                                        try
                                        {
                                            foreach (ColumnParams cp in dbConn.GetColumns(dbNm, tbl))
                                                try
                                                {
                                                    if (cp.ColumnName.Contains(srchValue))
                                                    { this.lstSearchResults.Items.Add(new ListViewItem(string.Format("{0}.{1}.{2} ({3})", dbNm, tbl, cp.ColumnName, cp.DataType.ToString()), 5, this.lstSearchResults.Groups["grpCols"])); noResults = false; }
                                                }
                                                catch (Exception ex)
                                                {
                                                    if (ex.InnerException is System.Data.SqlClient.SqlException && ex.ToString().Contains("The server principal ") && ex.ToString().Contains(" is not able to access the database ") && ex.ToString().Contains(" under the current security context."))
                                                    {
                                                        // We're going to ignore this error and continue
                                                        //   searching whichever databases we *are*
                                                        //   allowed to access.
                                                    }
                                                    else
                                                        throw;
                                                }
                                        }
                                        catch (Exception ex)
                                        {
                                            if (ex.InnerException is System.Data.SqlClient.SqlException && ex.ToString().Contains("The server principal ") && ex.ToString().Contains(" is not able to access the database ") && ex.ToString().Contains(" under the current security context."))
                                            {
                                                // We're going to ignore this error and continue
                                                //   searching whichever databases we *are*
                                                //   allowed to access.
                                            }
                                            else
                                                throw;
                                        }
                                }
                                catch (Exception ex)
                                {
                                    if (ex.InnerException is System.Data.SqlClient.SqlException && ex.ToString().Contains("The server principal ") && ex.ToString().Contains(" is not able to access the database ") && ex.ToString().Contains(" under the current security context."))
                                    {
                                        // We're going to ignore this error and continue
                                        //   searching whichever databases we *are*
                                        //   allowed to access.
                                    }
                                    else
                                        throw;
                                }
                        }
                        catch (Exception ex)
                        {
                            if (ex.InnerException is System.Data.SqlClient.SqlException && ex.ToString().Contains("The server principal ") && ex.ToString().Contains(" is not able to access the database ") && ex.ToString().Contains(" under the current security context."))
                            {
                                // We're going to ignore this error and continue
                                //   searching whichever databases we *are*
                                //   allowed to access.
                            }
                            else
                                throw;
                        }
                }
                catch (Exception ex)
                { MessageBox.Show(this, "Unexpected Error", "An error occured while trying to search for the specified column:\n" + ex.Message); }

                // If nothing got added, we'll just add an entry informing the user
                //   that no objects matching their search were found.
                if (noResults)
                {
                    this.lstSearchResults.ShowGroups = false;
                    this.lstSearchResults.Items.Add(new ListViewItem("No matches found..."));
                }

                this.splitContainer1.Panel2Collapsed = false;
                this.txtSearch.Text = string.Empty;
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(this, "An error occured while trying to perform the search:\n\n" + ex.ToString() + "\n\nApplication Version:  " + Application.ProductVersion, "Error");
#else
                MessageBox.Show(this, "An error occured while trying to perform the search:\n\n" + ex.Message + "\n\nApplication Version:  " + Application.ProductVersion, "Error");
#endif
            }
            finally
            {
                this.lstSearchResults.EndUpdate();
                this.UseWaitCursor = false;
            }
        }
        protected void OnScriptObject(EditObjectEventArgs e)
        {
            if (this.ScriptObject != null)
                this.ScriptObject.Invoke(this, e);
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        //
        private void cmdClose_onClick(object sender, EventArgs e)
        { this.Close(); }
        private void cmdSearch_onClick(object sender, EventArgs e)
        {
            this.DoSearch(this.txtSearch.Text);
        }
        private void cmdSearchCol_onClick(object sender, EventArgs e)
        {
            this.DoSearch(this.txtSearch.Text, true);
        }
        private void lblSearch_onClick(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2Collapsed = true;
        }
        private void txtSearch_onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return || e.KeyCode == Keys.Execute)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.DoSearch(this.txtSearch.Text);
            }
        }
        private void lstSearchResults_onDoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(this, this.lstSearchResults.SelectedItems[0].Text, "DEBUG");
            string[] prts = this.lstSearchResults.SelectedItems[0].Text.Split('.');
            TreeNode dbNode = this._sqlExplorer.Nodes[prts[0]];
            if (dbNode != null)
            {
                dbNode.Expand();
                TreeNode ndFolder = null;
                switch (this.lstSearchResults.SelectedItems[0].Group.Name)
                {
                    case "grpTables":
                        ndFolder = dbNode.Nodes["grpTables"];
                        break;
                    case "grpViews":
                        ndFolder = dbNode.Nodes["grpViews"];
                        break;
                    case "grpStoredProcs":
                        ndFolder = dbNode.Nodes["grpStoredProcs"];
                        break;
                    case "grpFuncs":
                        break;
                }
                if (ndFolder != null)
                {
                    ndFolder.Expand();
                    this._sqlExplorer.SelectedNode = ndFolder.Nodes[this.lstSearchResults.SelectedItems[0].Text];
                    this._sqlExplorer.Focus();
                }
            }
        }
        private void sqlExplorer_onEditObject(object sender, EditObjectEventArgs e)
        {
            this.OnScriptObject(e);
        }
        //***************************************************************************
        // Event Overrides
        // 
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            foreach (TreeNode nd in this._sqlExplorer.Nodes)
                if (nd.Tag != null)
                    ((rsDbSql)nd.Tag).Dispose();
            base.OnFormClosed(e);
        }
        #endregion
    }
}