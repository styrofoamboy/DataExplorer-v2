using System;
using System.IO;
using System.Xml;
using System.Runtime.InteropServices;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using RainstormStudios;
using RainstormStudios.Data;
using RainstormStudios.Unmanaged;
using RainstormStudios.Collections;

namespace DataExplorer
{
    class SqlBrowserTreeView : TreeView
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
        private ImageList trvImgList;
        private System.ComponentModel.IContainer components;
        private ContextMenuStrip
            mnuNdObj,
            mnuNdGroup,
            mnuNdScript,
            mnuNdDb;
        private TreeNode
            _lstRc;
        private delegate void DisposeDelegate(bool disposing);
        //***************************************************************************
        // Public Events
        // 
        public event ScrollEventHandler VerticalScroll;
        public event ScrollEventHandler HorizontalScroll;
        public event EditObjectEventHandler EditObject;
        public event EditObjectEventHandler OpenTable;
        //***************************************************************************
        // External Aliases
        // 
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        protected static extern int GetScrollPos(IntPtr hWnd, int nBar);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        protected static extern bool SetScrollPos(IntPtr hWnd, int nBar, int nPos, bool bRedraw);
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public int HorizontalScrollPos
        {
            get { return GetScrollPos(this.Handle, (int)ScrollBarTypes.SB_HORZ); }
            set { SetScrollPos(this.Handle, (int)ScrollBarTypes.SB_HORZ, value, true); }
        }
        public int VerticalScrollPos
        {
            get { return GetScrollPos(this.Handle, (int)ScrollBarTypes.SB_VERT); }
            set { SetScrollPos(this.Handle, (int)ScrollBarTypes.SB_VERT, value, true); }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        private SqlBrowserTreeView()
            : base()
        {
            this.InitializeComponent();
            this.ImageList = this.trvImgList;
            this.InitializeContextMenus();
        }
        internal SqlBrowserTreeView(ConnectionCollection connCol)
            : this()
        {
            this.BeginUpdate();
            try
            {
                RainstormStudios.Collections.StringCollection colDatasource = new StringCollection();
                for (int i = 0; i < connCol.Count; i++)
                    colDatasource.AddUnique(rsData.GetDataSource(connCol[i].ConnectionString), i.ToString());

                for (int i = 0; i < colDatasource.Count; i++)
                {
                    Connection cn = connCol[int.Parse(colDatasource.GetKey(i))];
                    if (rsDb.IsSQL(cn.ConnectionString, cn.DatabaseProvider))
                    {
                        TreeNode ndDb = new TreeNode(colDatasource[i]);
                        ndDb.Tag = new rsDbSql(cn.ConnectionString);
                        //ndDb.Name = cn.Name + "-" + cn.DatabaseProvider.ToString();
                        ndDb.Name = colDatasource[i];
                        ndDb.Nodes.Add("<EMPTY>");
                        ndDb.ImageIndex = 1;
                        ndDb.SelectedImageIndex = 1;
                        ndDb.ContextMenuStrip = this.mnuNdGroup;
                        this.Nodes.Add(ndDb);
                    }
                }
            }
            catch (Exception ex)
            {
                this.Nodes.Clear();
                this.Nodes.Add("An Error Occured:");
                this.Nodes.Add(ex.Message);
            }
            finally
            {
                this.EndUpdate();
            }
        }
        internal SqlBrowserTreeView(ConnectionCollection connCol, int selConn)
            : this(connCol)
        {
            if (selConn > -1 && this.Nodes.Count > selConn)
                this.Nodes[selConn].Expand();
        }
        internal SqlBrowserTreeView(ConnectionCollection connCol, string xmlFile)
            : this(connCol)
        {
            this.ReadXML(xmlFile);
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public string[] GetXML()
        {
            if (this.Nodes.Count > 0)
            {
                ArrayList retVal = new ArrayList();
                for (int i = 0; i < this.Nodes.Count; i++)
                    retVal.AddRange(this.GetNodeXML(this.Nodes[i]));
                return (string[])retVal.ToArray(typeof(System.String));
            }
            else
                return new string[0];
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlBrowserTreeView));
            this.trvImgList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // trvImgList
            // 
            this.trvImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("trvImgList.ImageStream")));
            this.trvImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.trvImgList.Images.SetKeyName(0, "Folder");
            this.trvImgList.Images.SetKeyName(1, "DBEngine");
            this.trvImgList.Images.SetKeyName(2, "Database");
            this.trvImgList.Images.SetKeyName(3, "Table");
            this.trvImgList.Images.SetKeyName(4, "View");
            this.trvImgList.Images.SetKeyName(5, "Column");
            this.trvImgList.Images.SetKeyName(6, "Key");
            this.trvImgList.Images.SetKeyName(7, "Index");
            this.trvImgList.Images.SetKeyName(8, "Trigger");
            this.trvImgList.Images.SetKeyName(9, "Constraint");
            this.trvImgList.Images.SetKeyName(10, "StoredProc");
            this.trvImgList.Images.SetKeyName(11, "Function");
            this.trvImgList.Images.SetKeyName(12, "User");
            this.trvImgList.Images.SetKeyName(13, "SecurityGroup");
            // 
            // SqlBrowserTreeView
            // 
            this.LineColor = System.Drawing.Color.Black;
            this.ResumeLayout(false);
        }
        private void InitializeContextMenus()
        {
            this.mnuNdObj = new ContextMenuStrip(this.components);
            this.mnuNdObj.Items.Add(new ToolStripMenuItem("Edit", null, new EventHandler(this.mnuNd_onClick), "mnuNdObjEdit"));

            this.mnuNdGroup = new ContextMenuStrip(this.components);
            this.mnuNdGroup.Items.Add(new ToolStripMenuItem("Refresh", null, new EventHandler(this.mnuNd_onClick), "mnuNdGroupRefresh"));

            this.mnuNdScript = new ContextMenuStrip(this.components);
            this.mnuNdScript.Items.Add(new ToolStripMenuItem("Open", null, new EventHandler(this.mnuNd_onClick), "mnuNdScriptOpen"));
            this.mnuNdScript.Items.Add("-");
            this.mnuNdScript.Items.Add(new ToolStripMenuItem("Script Create", null, new EventHandler(this.mnuNd_onClick), "mnuNdScriptCreate"));
            this.mnuNdScript.Items.Add(new ToolStripMenuItem("Script Alter", null, new EventHandler(this.mnuNd_onClick), "mnuNdScriptAlter"));
            this.mnuNdScript.Items.Add(new ToolStripMenuItem("Script Insert", null, new EventHandler(this.mnuNd_onClick), "mnuScriptInsert"));
            this.mnuNdScript.Items.Add("-");
            this.mnuNdScript.Items.Add(new ToolStripMenuItem("Delete", null, new EventHandler(this.mnuNd_onClick), "mnuNdScriptDelete"));

            this.mnuNdDb = new ContextMenuStrip(this.components);
            this.mnuNdDb.Items.Add(new ToolStripMenuItem("Import Data", null, new EventHandler(this.mnuNd_onClick), "mnuNdImportData"));
            this.mnuNdDb.Items.Add(new ToolStripMenuItem("Export Data", null, new EventHandler(this.mnuNd_onClick), "mnuNdExportData"));
            this.mnuNdDb.Items.Add(new ToolStripSeparator());
            this.mnuNdDb.Items.Add(new ToolStripMenuItem("Generate Scripts", null, new EventHandler(this.mnuNd_onClick), "mnuNdGenScripts"));
            this.mnuNdDb.Items.Add(new ToolStripSeparator());
            this.mnuNdDb.Items.Add(new ToolStripMenuItem("Database Info", null, new EventHandler(this.mnuNd_onClick), "mnuNdDbInfo"));
        }
        protected override void Dispose(bool disposing)
        {
            for (int i = 0; i < this.Nodes.Count; i++)
                if (this.Nodes[i].Tag != null)
                    ((rsDbSql)this.Nodes[i].Tag).Dispose();
            base.Dispose(disposing);
        }
        private void RefreshNode(TreeNode nd)
        {
            if (nd.Level == 0 && nd.Nodes.Count == 1 && nd.Nodes[0].Text == "<EMPTY>")
            {
                this.RefreshDbList(nd);
            }
            else if (nd.Nodes.Count == 1 && nd.Nodes[0].Text == "<EMPTY>")
            {
                SqlObjType objType = (SqlObjType)nd.Tag;
                if (objType == SqlObjType.TableGroup || objType == SqlObjType.ViewGroup)
                    this.RefreshTableList(nd);
                else if (objType == SqlObjType.ColumnGroup)
                    this.RefreshColumnList(nd);
                else
                    this.RefreshGroupList(nd);
            }
        }
        private void RefreshDbList(TreeNode nd)
        {
            nd.Text += " (expanding...)";
            Application.DoEvents();
            this.BeginUpdate();
            this.UseWaitCursor = true;
            try
            {
                rsDbSql dbConn = (rsDbSql)nd.Tag;
                if (dbConn == null)
                    throw new ArgumentException("Selected TreeNode does not reference a connection string.");

                nd.Nodes.Clear();
                foreach (string db in dbConn.GetDatabaseList())
                {
                    TreeNode ndDatabase = new TreeNode();
                    ndDatabase.Text = db;
                    ndDatabase.Name = db;
                    ndDatabase.Tag = SqlObjType.Database;
                    ndDatabase.ImageKey = ndDatabase.SelectedImageKey = "Database";
                    ndDatabase.ContextMenuStrip = this.mnuNdDb;
                    TreeNode ndTables = new TreeNode("Tables");
                    ndTables.Name = "grpTables";
                    ndTables.Nodes.Add("<EMPTY>");
                    ndTables.Tag = SqlObjType.TableGroup;
                    ndTables.ContextMenuStrip = this.mnuNdGroup;
                    ndDatabase.Nodes.Add(ndTables);
                    TreeNode ndViews = new TreeNode("Views");
                    ndViews.Name = "grpViews";
                    ndViews.Nodes.Add("<EMPTY>");
                    ndViews.Tag = SqlObjType.ViewGroup;
                    ndViews.ContextMenuStrip = this.mnuNdGroup;
                    ndDatabase.Nodes.Add(ndViews);
                    TreeNode ndStoredProcs = new TreeNode("Stored Proceedures");
                    ndStoredProcs.Name = "grpStoredProcs";
                    ndStoredProcs.Nodes.Add("<EMPTY>");
                    ndStoredProcs.Tag = SqlObjType.StoredProcGroup;
                    ndStoredProcs.ContextMenuStrip = this.mnuNdGroup;
                    ndDatabase.Nodes.Add(ndStoredProcs);
                    TreeNode ndFuncsT = new TreeNode("Table-valued Functions");
                    ndFuncsT.Name = "grpTFuncs";
                    ndFuncsT.Nodes.Add("<EMPTY>");
                    ndFuncsT.Tag = SqlObjType.FunctionGroup;
                    ndFuncsT.ContextMenuStrip = this.mnuNdGroup;
                    TreeNode ndFuncsS = new TreeNode("Scalar-valued Functions");
                    ndFuncsS.Name = "grpSFuncs";
                    ndFuncsS.Nodes.Add("<EMPTY>");
                    ndFuncsS.Tag = SqlObjType.FunctionGroup;
                    ndFuncsS.ContextMenuStrip = this.mnuNdGroup;
                    TreeNode ndFuncs = new TreeNode("Functions");
                    ndFuncs.Nodes.Add(ndFuncsT);
                    ndFuncs.Nodes.Add(ndFuncsS);
                    ndDatabase.Nodes.Add(ndFuncs);
                    TreeNode ndUsers = new TreeNode("Users");
                    ndUsers.Nodes.Add("<EMPTY>");
                    ndUsers.Tag = SqlObjType.UserGroup;
                    ndUsers.ContextMenuStrip = this.mnuNdGroup;
                    ndDatabase.Nodes.Add(ndUsers);
                    nd.Nodes.Add(ndDatabase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Unable to retreive the list of databases from the SQL server:\n\n{0}\n\nApplication Version: {1}", ex.Message, Application.ProductVersion), "Error");
            }
            finally
            {
                nd.Text = nd.Text.Substring(0, nd.Text.LastIndexOf('(')).TrimEnd();
                this.EndUpdate();
                this.UseWaitCursor = false;
            }
        }
        private void RefreshTableList(TreeNode nd)
        {
            nd.Text += " (expanding...)";
            Application.DoEvents();
            this.BeginUpdate();
            this.UseWaitCursor = true;
            rsDbSql dbConn = this.GetDbObject(nd);
            try
            {
                nd.Nodes.Clear();
                string[] objList = null;
                if ((SqlObjType)nd.Tag == SqlObjType.TableGroup)
                    objList = dbConn.GetTableList(nd.Parent.Text);
                else
                    objList = dbConn.GetViewList(nd.Parent.Text);
                foreach (string tbl in objList)
                {
                    TreeNode ndTbl = new TreeNode(tbl);
                    ndTbl.Name = string.Format("{0}.{1}", nd.Parent.Text, tbl);
                    if ((SqlObjType)nd.Tag == SqlObjType.TableGroup)
                    {
                        ndTbl.Tag = SqlObjType.Table;
                        ndTbl.ContextMenuStrip = this.mnuNdScript;
                    }
                    else
                    {
                        ndTbl.Tag = SqlObjType.View;
                        ndTbl.ContextMenuStrip = this.mnuNdObj;
                    }
                    ndTbl.ImageIndex = ((SqlObjType)ndTbl.Tag == SqlObjType.Table) ? 2 : 8;
                    ndTbl.SelectedImageIndex = ((SqlObjType)ndTbl.Tag == SqlObjType.Table) ? 2 : 8;
                    ndTbl.ImageKey = ndTbl.SelectedImageKey = ((SqlObjType)ndTbl.Tag).ToString(); // == SqlObjType.Table) ? "Table" : "StoredProc";
                    TreeNode ndColumns = new TreeNode("Columns");
                    ndColumns.Nodes.Add("<EMPTY>");
                    ndColumns.Tag = SqlObjType.ColumnGroup;
                    ndColumns.ContextMenuStrip = this.mnuNdGroup;
                    ndTbl.Nodes.Add(ndColumns);
                    if ((SqlObjType)ndTbl.Tag == SqlObjType.Table)
                    {
                        TreeNode ndKeys = new TreeNode("Keys");
                        ndKeys.Nodes.Add("<EMPTY>");
                        ndKeys.Tag = SqlObjType.KeyGroup;
                        ndKeys.ContextMenuStrip = this.mnuNdGroup;
                        ndTbl.Nodes.Add(ndKeys);
                        TreeNode ndConstraints = new TreeNode("Constraints");
                        ndConstraints.Nodes.Add("<EMPTY>");
                        ndConstraints.Tag = SqlObjType.ConstraintGroup;
                        ndConstraints.ContextMenuStrip = this.mnuNdGroup;
                        ndTbl.Nodes.Add(ndConstraints);
                    }
                    TreeNode ndTriggers = new TreeNode("Triggers");
                    ndTriggers.Nodes.Add("<EMPTY>");
                    ndTriggers.Tag = SqlObjType.TriggerGroup;
                    ndTriggers.ContextMenuStrip = this.mnuNdGroup;
                    ndTbl.Nodes.Add(ndTriggers);
                    TreeNode ndIndexes = new TreeNode("Indexes");
                    ndIndexes.Nodes.Add("<EMPTY>");
                    ndIndexes.Tag = SqlObjType.IndexGroup;
                    ndIndexes.ContextMenuStrip = this.mnuNdGroup;
                    ndTbl.Nodes.Add(ndIndexes);
                    nd.Nodes.Add(ndTbl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Unable to retreive the list of tables from the SQL server:\n\n{0}\n\nApplication Version: {1}", ex.Message, Application.ProductVersion), "Error");
                nd.Nodes.Clear();
                nd.Nodes.Add("<EMPTY>");
                nd.Collapse(false);
            }
            finally
            {
                nd.Text = nd.Text.Substring(0, nd.Text.LastIndexOf('(')).TrimEnd();
                this.EndUpdate();
                this.UseWaitCursor = false;
            }
        }
        private void RefreshColumnList(TreeNode nd)
        {
            nd.Text += " (expanding...)";
            Application.DoEvents();
            this.BeginUpdate();
            this.UseWaitCursor = true;
            rsDbSql dbConn = this.GetDbObject(nd);
            try
            {
                nd.Nodes.Clear();
                foreach (ColumnParams cp in dbConn.GetColumns(nd.Parent.Parent.Parent.Text, nd.Parent.Text, (SqlObjType)nd.Parent.Tag == SqlObjType.View))
                {
                    TreeNode ndCol = new TreeNode(cp.ToString());
                    ndCol.Name = string.Format("{0}.{1}.{2}", nd.Parent.Parent.Parent.Text, nd.Parent.Text, cp.ColumnName);
                    ndCol.Tag = SqlObjType.Column;
                    ndCol.ImageKey = ndCol.SelectedImageKey = "Column";
                    nd.Nodes.Add(ndCol);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Unable to retreive the list of columns from the SQL server:\n\n{0}\n\nApplication Version: {1}", ex.Message, Application.ProductVersion), "Error");
                nd.Nodes.Clear();
                nd.Nodes.Add("<EMPTY>");
                nd.Collapse(false);
            }
            finally
            {
                nd.Text = nd.Text.Substring(0, nd.Text.LastIndexOf('(')).TrimEnd();
                this.EndUpdate();
                this.UseWaitCursor = false;
            }
        }
        private void RefreshGroupList(TreeNode nd)
        {
            nd.Text += " (expanding...)";
            Application.DoEvents();
            this.BeginUpdate();
            this.UseWaitCursor = true;
            rsDbSql dbConn = this.GetDbObject(nd);
            SqlObjType objType = (SqlObjType)nd.Tag;
            try
            {
                nd.Nodes.Clear();
                string[] objCol = new string[0];
                switch (objType)
                {
                    case SqlObjType.StoredProcGroup:
                        objCol = dbConn.GetStoredProceedureList(nd.Parent.Text);
                        break;
                    case SqlObjType.FunctionGroup:
                        if (nd.Text.ToLower().StartsWith("table"))
                            objCol = dbConn.GetTableValueFunctionList(nd.Parent.Parent.Text);
                        else
                            objCol = dbConn.GetScalarFunctionList(nd.Parent.Parent.Text);
                        break;
                    case SqlObjType.ConstraintGroup:
                        objCol = dbConn.GetConstraintList(nd.Parent.Parent.Parent.Text, nd.Parent.Text);
                        break;
                    case SqlObjType.IndexGroup:
                        objCol = dbConn.GetIndexList(nd.Parent.Parent.Parent.Text, nd.Parent.Text, (SqlObjType)nd.Parent.Parent.Tag == SqlObjType.ViewGroup);
                        break;
                    case SqlObjType.TriggerGroup:
                        objCol = dbConn.GetTriggerList(nd.Parent.Parent.Parent.Text, nd.Parent.Text, (SqlObjType)nd.Parent.Parent.Tag == SqlObjType.ViewGroup);
                        break;
                    case SqlObjType.KeyGroup:
                        objCol = dbConn.GetPrimaryKeyList(nd.Parent.Parent.Parent.Text, nd.Parent.Text);
                        break;
                    case SqlObjType.UserGroup:
                        objCol = dbConn.GetUserList(nd.Parent.Text);
                        break;
                }
                foreach (string obj in objCol)
                {
                    TreeNode ndObj = new TreeNode(obj);
                    SqlObjType ndType = (SqlObjType)Enum.Parse(typeof(SqlObjType), objType.ToString().Substring(0, objType.ToString().IndexOf("Group")));
                    ndObj.ImageKey = ndObj.SelectedImageKey = ndType.ToString();
                    ndObj.ContextMenuStrip=this.mnuNdObj;
                    ndObj.Tag = ndType;
                    nd.Nodes.Add(ndObj);
                }
                if (objType == SqlObjType.KeyGroup)
                    foreach (string obj in dbConn.GetForeignKeyList(nd.Parent.Parent.Parent.Text, nd.Parent.Text))
                    {
                        TreeNode ndObj = new TreeNode(obj);
                        ndObj.Tag = SqlObjType.Key;
                        ndObj.ImageKey = ndObj.SelectedImageKey = "Key";
                        nd.Nodes.Add(ndObj);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Unable to retreive the list of columns from the SQL server:\n\n{0}\n\nApplication Version: {1}", ex.Message, Application.ProductVersion), "Error");
                nd.Nodes.Clear();
                nd.Nodes.Add("<EMPTY>");
                nd.Collapse(false);
            }
            finally
            {
                nd.Text = nd.Text.Substring(0, nd.Text.LastIndexOf('(')).TrimEnd();
                this.EndUpdate();
                this.UseWaitCursor = false;
            }
        }
        private rsDbSql GetDbObject(TreeNode nd)
        {
            TreeNode rNd = this.GetLevel(nd, 0);
            if (rNd.Tag != null)
                return (rsDbSql)rNd.Tag;
            else
                return null;
        }
        private TreeNode GetLevel(TreeNode nd, int lvl)
        {
            TreeNode rNd = nd;
            while (rNd.Level > lvl && rNd.Parent != null)
                rNd = rNd.Parent;
            return rNd;
        }
        private TreeNode GetDatabaseLevel(TreeNode nd)
        {
            return this.GetLevel(nd, 1);
        }
        private TreeNode GetTableLevel(TreeNode nd)
        {
            return this.GetLevel(nd, 3);
        }
        private string[] GetNodeXML(TreeNode nd)
        {
            ArrayList str = new ArrayList();
            // Determine XML element name.
            string ndType = string.Empty;
            if (nd.Text == "<EMPTY>" && nd.Tag == null)
                ndType = "Placeholder";
            else if (nd.Level == 0)
                ndType = "Connection";
            else if (nd.Level == 1)
                ndType = "Database";
            else if (nd.Tag != null)
                ndType = ((SqlObjType)nd.Tag).ToString();
            else
                ndType = "Unknown";

            // Create XML data.
            string elemStart = string.Format("{1}<{0}", ndType, "".PadLeft(nd.Level, '\t'));
            if (ndType != "Placeholder")
                elemStart += string.Format(" text=\"{0}\"", nd.Text);
            if (nd.Level == 0)
                elemStart += " ConnStr=" + ((rsDbSql)nd.Tag).ConnectionString;
            if (nd.Nodes.Count > 0)
            {
                elemStart += ">";
                str.Add(elemStart);
                foreach (TreeNode ndChild in nd.Nodes)
                    str.AddRange(this.GetNodeXML(ndChild));
                str.Add(string.Format("{1}</{0}>", ndType, "".PadLeft(nd.Level, '\t')));
            }
            else
            {
                elemStart += " />";
                str.Add(elemStart);
            }
            return (string[])str.ToArray(typeof(System.String));
        }
        private void ReadXML(string fn)
        {
            try
            {
                using (FileStream fs = new FileStream(fn, FileMode.Open, FileAccess.Read))
                using (XmlTextReader xr = new XmlTextReader(fs))
                {
                    string
                        elemName = string.Empty,
                        attrText = string.Empty;
                    //TreeNode nd = null;

                    while (xr.Read())
                    {
                        switch (xr.NodeType)
                        {
                            case XmlNodeType.Element:
                                elemName=xr.Name;
                                break;
                            case XmlNodeType.Attribute:
                                switch (xr.Name)
                                {
                                    case "Text":
                                        break;
                                    case "ConnStr":
                                        break;
                                }
                                break;
                            case XmlNodeType.EndElement:
                                //if(nd==null)
                                //    TreeNode nds[]=this.Nodes.Find(
                                break;
                        }
                    }
                }
            }
            catch //(Exception ex)
            {
                return;
            }
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void mnuNd_onClick(object sender, EventArgs e)
        {
            if (this._lstRc == null)
                return;

            TreeNode nd = this._lstRc;
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "mnuNdObjEdit":
                    #region ObjEdit
                    {
                        rsDbSql db = this.GetDbObject(nd);
                        string dbName = this.GetDatabaseLevel(nd).Text;
                        string procName = nd.Text;
                        string dbConnectionString = db.ConnectionString;
                        if (dbConnectionString.ToLower().Contains("initial catalog="))
                        {
                            int icSt = dbConnectionString.ToLower().IndexOf("initial catalog=");
                            int icEd = dbConnectionString.IndexOf(';', icSt);
                            dbConnectionString = dbConnectionString.Substring(0, icSt) + "Initial Catalog=" + dbName + dbConnectionString.Substring(icEd);
                        }
                        try
                        {
                            string[] objText = null;
                            if ((SqlObjType)nd.Tag == SqlObjType.Index)
                                objText = db.ScriptCreateIndex(dbName, this.GetTableLevel(nd).Text, nd.Text);
                            else
                                objText = db.GetObjectTextAlter(dbName, procName);
                            this.RaiseEditObject(objText, dbConnectionString, procName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this.FindForm(), string.Format("Error retrieving meta-data:\n\n{0}\n\nApplication Version: {1}", ex.Message, Application.ProductVersion), "Error");
                            return;
                        }
                    }
                    break;
                    #endregion

                case "mnuNdGroupRefresh":
                    #region GroupRefresh
                    {
                        nd.Collapse();
                        nd.Nodes.Clear();
                        nd.Nodes.Add("<EMPTY>");
                        this.RefreshNode(nd);
                        nd.Expand();
                    }
                    break;
                    #endregion

                case "mnuNdScriptCreate":
                    #region ScriptCreate
                    {
                        rsDbSql db = this.GetDbObject(nd);
                        string dbName = this.GetDatabaseLevel(nd).Text;
                        string tableNm = nd.Text;
                        string dbConnectionString = db.ConnectionString;
                        if (dbConnectionString.ToLower().Contains("initial catalog="))
                        {
                            int icSt = dbConnectionString.ToLower().IndexOf("initial catalog=");
                            int icEd = dbConnectionString.IndexOf(';', icSt);
                            dbConnectionString = dbConnectionString.Substring(0, icSt) + "Initial Catalog=" + dbName + dbConnectionString.Substring(icEd);
                        }
                        try
                        {
                            string[] objText = db.ScriptCreateTable(dbName, tableNm);
                            this.RaiseEditObject(objText, dbConnectionString, tableNm);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this.FindForm(), string.Format("Error scripting 'Create':\n\n{0}\n\nApplication Version: {1}", ex.Message, Application.ProductVersion), "Error");
                            return;
                        }
                    }
                    break;
                    #endregion

                case "mnuNdScriptAlter":
                    #region ScriptAlter
                    {
                        rsDbSql db = this.GetDbObject(nd);
                        string dbName = this.GetDatabaseLevel(nd).Text;
                        string tableNm = nd.Text;
                        string dbConnectionString = db.ConnectionString;
                        if (dbConnectionString.ToLower().Contains("initial catalog="))
                        {
                            int icSt = dbConnectionString.ToLower().IndexOf("initial catalog=");
                            int icEd = dbConnectionString.IndexOf(';', icSt);
                            dbConnectionString = dbConnectionString.Substring(0, icSt) + "Initial Catalog=" + dbName + dbConnectionString.Substring(icEd);
                        }
                        try
                        {
                            string[] objText = db.ScriptAlterTable(dbName, tableNm);
                            this.RaiseEditObject(objText, dbConnectionString, tableNm);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this.FindForm(), string.Format("Error scripting 'Create':\n\n{0}\n\nApplication Version: {1}", ex.Message, Application.ProductVersion), "Error");
                            return;
                        }
                    }
                    break;
                    #endregion

                case "mnuScriptInsert":
                    #region ScriptInsert
                    {
                        rsDbSql db = this.GetDbObject(nd);
                        string dbName = this.GetDatabaseLevel(nd).Text;
                        string tableNm = nd.Text;
                        string dbConnString = db.ConnectionString;
                        if (dbConnString.ToLower().Contains("initial catalog="))
                        {
                            int icSt = dbConnString.ToLower().IndexOf("initial catalog=");
                            int icEd = dbConnString.IndexOf(';', icSt);
                            dbConnString = dbConnString.Substring(0, icSt) + "Initial Catalog=" + dbName + dbConnString.Substring(icEd);
                        }
                        try
                        {
                            string[] objText = db.ScriptInsert(dbName, tableNm, false);
                            this.RaiseEditObject(objText, dbConnString, tableNm);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this.FindForm(), string.Format("Error scripting 'Insert':\n\n{0}\n\nApplication Version: {1}", ex.Message, Application.ProductVersion), "Error");
                            return;
                        }
                    }
                    break;
                    #endregion

                case "mnuNdScriptDelete":
                    // NOTE: Despite the name, this will *actually* delete the table and all data!
                    #region ScriptDelete
                    if (MessageBox.Show(this, "This will delete the table and *ALL* data. This action is not recoverable!\n\nAre you sure you want to continue?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        rsDbSql db = this.GetDbObject(nd);
                        string dbLevel = this.GetDatabaseLevel(nd).Text;
                        string tblNm = nd.Text;
                        string qry = string.Format("USE [{0}] DROP TABLE {1}", dbLevel, tblNm);
                        db.ExecuteNonQuery(qry);
                        this.RefreshTableList(nd.Parent);
                    }
                    break;
                    #endregion

                case "mnuNdExportData":
                    #region ExportData
                    using (frmDataExport frm = new frmDataExport(this.GetDbObject(this.GetDatabaseLevel(this.SelectedNode)), this.SelectedNode.Text))
                    {
                        if (frm.IsDisposed)
                            return;
                        else if (frm.ShowDialog(this.FindForm()) == DialogResult.OK)
                        {
                            this.GetDbObject(this.SelectedNode);
                        }
                    }
                    break;
                    #endregion

                case "mnuNdImportData":
                    #region ImportData
                    //using (frmDataImport frm = new frmDataImport(this.GetDbObject(this.GetDatabaseLevel(this.SelectedNode)), this.SelectedNode.Text))
                    //{
                    //    if (frm.IsDisposed)
                    //        return;
                    //    else if (frm.ShowDialog(this.FindForm()) == DialogResult.OK)
                    //    {
                    //        this.GetDbObject(this.SelectedNode);
                    //    }
                    //}
                    break;
                    #endregion

                case "mnuNdGenScripts":
                    #region GenerateScripts
                    MessageBox.Show(this, "This functionality is not yet available.", "Sorry");
                    break;
                    #endregion

                case "mnuNdDbInfo":
                    #region DatabaseInfo
                    using (frmDbInfo frm = new frmDbInfo(this.GetDbObject(this.GetDatabaseLevel(this.SelectedNode)).GetDatabaseInfo(this.SelectedNode.Text)))
                        frm.ShowDialog(this);
                    break;
                    #endregion

                case "mnuNdScriptOpen":
                    #region Open Table
                    {
                        rsDbSql db = this.GetDbObject(nd);
                        string dbName = this.GetDatabaseLevel(nd).Text;
                        string tableNm = nd.Text;
                        string dbConnectionString = db.ConnectionString;
                        if (dbConnectionString.ToLower().Contains("initial catalog="))
                        {
                            int icSt = dbConnectionString.ToLower().IndexOf("initial catalog=");
                            int icEd = dbConnectionString.IndexOf(';', icSt);
                            dbConnectionString = dbConnectionString.Substring(0, icSt) + "Initial Catalog=" + dbName + dbConnectionString.Substring(icEd);
                        }
                        this.RaiseOpenTable(dbConnectionString, tableNm);
                    }
                    break;
                    #endregion
            }
        }
        //***************************************************************************
        // Event Overrides
        // 
        protected override void OnBeforeExpand(TreeViewCancelEventArgs e)
        {
            base.OnBeforeExpand(e);
            this.RefreshNode(e.Node);
        }
        protected override void OnItemDrag(ItemDragEventArgs e)
        {
            base.OnItemDrag(e);
            if (e.Item.GetType().Name == "TreeNode")
            {
                TreeNode ndEItem = (TreeNode)e.Item;
                this.SelectedNode = ndEItem;
                string tagTypeName = ndEItem.Tag.GetType().Name;
                if (tagTypeName != "SqlObjType" || !((SqlObjType)ndEItem.Tag).ToString().ToLower().EndsWith("group"))
                {
                    string oleText = ndEItem.Text;
                    if (tagTypeName == "SqlObjType" && ((SqlObjType)ndEItem.Tag) == SqlObjType.Column)
                        oleText = oleText.Substring(0, oleText.IndexOf('(')).Trim();
                    DragDropEffects drgFx = this.DoDragDrop(oleText, DragDropEffects.All);
                }
            }
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == (int)Win32Messages.WM_HSCROLL && this.HorizontalScroll != null)
                this.HorizontalScroll.Invoke(this, new ScrollEventArgs(ScrollEventType.ThumbPosition, this.HorizontalScrollPos, ScrollOrientation.HorizontalScroll));
            if (m.Msg == (int)Win32Messages.WM_VSCROLL && this.VerticalScroll != null)
                this.VerticalScroll.Invoke(this, new ScrollEventArgs(ScrollEventType.ThumbPosition, this.VerticalScrollPos, ScrollOrientation.VerticalScroll));
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button == MouseButtons.Right)
            {
                TreeViewHitTestInfo hti = this.HitTest(e.X, e.Y);
                if (hti.Node != null)
                    this.SelectedNode = hti.Node;
                this._lstRc = hti.Node;
            }
        }
        //***************************************************************************
        // Event Triggers
        // 
        protected void RaiseEditObject(string[] objText, string connStr, string objName)
        {
            if (this.EditObject != null)
                this.EditObject.Invoke(this, new EditObjectEventArgs(objText, connStr, objName));
        }
        protected void RaiseOpenTable(string connStr, string tblName)
        {
            string[] objText = new string[] { "SELECT *", "FROM " + tblName };
            if (this.OpenTable != null)
                this.OpenTable.Invoke(this, new EditObjectEventArgs(objText, connStr, tblName));
        }
        #endregion
    }
    public delegate void EditObjectEventHandler(object sender, EditObjectEventArgs e);
    public class EditObjectEventArgs : EventArgs
    {
        public string[]
            ObjectText;
        public string
            ConnectionString,
            ObjectName;

        public EditObjectEventArgs(string[] text, string connStr, string objNm)
        {
            this.ObjectText = text;
            this.ConnectionString = connStr;
            this.ObjectName = objNm;
        }
    }
}
