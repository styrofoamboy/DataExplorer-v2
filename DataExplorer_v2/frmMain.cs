using System;
using System.IO;
using System.Xml;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RainstormStudios.IO;
using RainstormStudios.Controls;
using RainstormStudios.Data;
using RainstormStudios.Collections;

namespace DataExplorer
{
    public partial class frmMain : Form
    {
        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        const int
            animRefreshMS = 50,
            tabHeight = 22,
            tabPadding = 6;
        private int
            _ctrlCnt = -1,
            _varPanSz = -1;
        private bool
            _tabAutoNm = false,
            _regConnListClicked = false,
            _updatingActivePanel = false,
            _loadingFile = false,
            _importFile = false,
            _templateFile = false,
            _sqlExplorerMsOvr = false;
        private RainstormStudios.EventValueTypes.EventBoolean
            _unsaved;
        private frmDateCalc
            _frmDC;
        private frmSqlBrowser
            _frmSqlBrowse;
        private string
            _curTabKey,
            _curFile,
            _createdBy;
        private DateTime
            _createdOn = DateTime.MinValue,
            _modifiedOn = DateTime.MinValue;
        private Control
            _tmpCtrl;
        private DataPanelManagerCollection
            _dpManCol;
        private ConnectionCollection
            _connCol;
        private GlobalVariableCollection
            _gblVarCol;
        private ProjectNoteCollection
            _noteCol;
        private Timer
            _tmrSqlExpHider;
        private SqlBrowserTreeView
            _sqlExplorer;
        //private System.Threading.WaitCallback
        //    _showSqlExpThread,
        //    _hideSqlExpThread;
        //RainstormStudios.Unmanaged.DeviceContext
        //    _hDC = null;
        RainstormStudios.Collections.StringCollection
            _mruList = null;
        private Point
            _drgThreshStart = Point.Empty;
        private DataPanelPrefs
            _defPrefs;
        Guid
            _autoSaveProcID;
        #endregion

        #region Properties
        //***************************************************************************
        // Private Properties
        // 
        private DataPanelManager ActivePanel
        {
            get
            {
                return (this._dpManCol.ContainsKey(this._curTabKey))
                        ? this._dpManCol[this._curTabKey]
                        : null;
            }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public frmMain()
        {
            InitializeComponent();
            this._dpManCol = new DataPanelManagerCollection();
            this._connCol = new ConnectionCollection();
            this._gblVarCol = new GlobalVariableCollection();
            this._noteCol = new ProjectNoteCollection();
            this._mruList = new StringCollection();

            this._autoSaveProcID = Guid.NewGuid();
            AutoSaveManager.RegisterProcess(this._autoSaveProcID, Application.UserAppDataPath, "Data Explorer v2", new AutoSaveManager.SaveFileDelegate(this.CreateAutoSaveFile));
        }
        public frmMain(string openFile)
            : this()
        {
            string fullPath = Path.GetFullPath(openFile);
            if (File.Exists(fullPath))
                this.LoadPanels(fullPath);
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public bool CreateAutoSaveFile(string fileName)
        {
            try
            {
                this.SaveAllPanels(fileName, false, true);
                return true;
            }
            catch
            {
                // TODO:: this should probably log some kind of error.
                return false;
            }
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private void ToggleDateCalculator()
        {
            if (this._frmDC == null)
            {
                this._frmDC = new frmDateCalc();
                this._frmDC.FormClosed += new FormClosedEventHandler(this.frmDateCalc_onClosed);
                this._frmDC.Show();
            }
            else
            {
                this._frmDC.Close();
            }
        }
        private string GetIDString(int id)
        { return id.ToString().PadLeft(4, '0'); }
        private Connection GetDefaultConnection()
        {
            if (this.lstRegConn.SelectedIndex >= 0 && this._connCol.Count > this.lstRegConn.SelectedIndex)
                return this._connCol[this.lstRegConn.SelectedIndex];
            else
                return Connection.Empty;
        }
        private Point GetTabPanelLocation(int index)
        {
            return new Point(0, (index * (tabHeight + tabPadding)) - this.panActiveQueries.VerticalScroll.Value);
        }
        private void SetSqlOnlyAvail(bool enable)
        {
            //this.cmdSqlExplorer.Enabled = enable;
            this.mnuToolsCreateSQL.Enabled = enable;
            this.mnuToolsDropSQL.Enabled = enable;
        }
        private void UpdateActiveTab(DataPanelManager dpman)
        {
            this._updatingActivePanel = true;
            this.panDataPanels.SuspendRefresh();
            this.panDataPanels.ForceBackgroundRefresh();
            foreach (DataPanelManager cn in this._dpManCol)
                if (cn != dpman)
                {
                    cn.TabButton.Activated = false;
                    cn.QueryPanel.Visible = false;
                }
            dpman.TabButton.Activated = true;
            dpman.QueryPanel.Visible = true;
            this.panActiveQueries.ScrollControlIntoView(dpman.TabPanel);
            RainstormStudios.CrossThreadUI.SetPropertyValue(this.cmdRunQry, "Enabled", !dpman.InProcess);
            this.UpdateTransactionButtons(dpman.QueryPanel.OpenTransaction && !dpman.InProcess);
            this.SetViewModeDropDown(dpman);
            this.UpdateCaratPos(dpman.QueryPanel.CaratPosition, dpman.QueryPanel.CaratColumnIndex, dpman.QueryPanel.CaratLineIndex);
            if (dpman.ConnID > -1)
                this.lstRegConn.SelectedIndex = dpman.ConnID;
            else
                this.lstRegConn.ClearSelected();
            this.panDataPanels.ResumeRefresh();
            this._curTabKey = dpman.CollectionKey;
            this.SetSqlOnlyAvail(dpman.QueryPanel.IsSQL);
            if (!dpman.Parsed)
                dpman.QueryPanel.ParseQueryColor();
            dpman.Parsed = true;
            dpman.QueryPanel.FocusQuery();
            this._updatingActivePanel = false;
            //this.statusLableTypeMethod.Text = (dpman.QueryPanel.QueryIsInsertMode) ? "INS" : "OVR";
            RainstormStudios.CrossThreadUI.SetPropertyValue(this.statusLableTypeMethod, "Text", (this.ActivePanel.QueryPanel.QueryIsInsertMode) ? "INS" : "OVR");
        }
        private DataPanelManager CreateNewPanel(string panelName)
        {
            int id = this._ctrlCnt++;
            string idStr = this.GetIDString(id);

            this.panActiveQueries.SuspendLayout();
            AdvancedButton btn = new AdvancedButton();
            btn.Name = "dataTab" + idStr;
            btn.Text = panelName;
            btn.Width = this.panActiveQueries.ClientRectangle.Width - 5;
            btn.Height = tabHeight;
            btn.CornerFeather = 4;
            btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn.Click += new EventHandler(this.cmdDataTab_onClick);
            btn.ToggleType = true;
            btn.ToggleActiveColor = Color.LightSteelBlue;
            //btn.DragDrop += new DragEventHandler(this.cmdDataTab_onDragDrop);
            btn.MouseMove += new MouseEventHandler(this.cmdDataTab_onMouseMove);
            btn.QueryContinueDrag += new QueryContinueDragEventHandler(this.cmdDataTab_onQueryContinueDrag);
            btn.MouseUp += new MouseEventHandler(this.cmdDataTab_onMouseUp);
            ContextMenuStrip drpMenu = new ContextMenuStrip();
            drpMenu.Name = "menuTab" + idStr;
            drpMenu.Opening += new CancelEventHandler(this.mnuDataTab_onOpening);
            drpMenu.Items.Add("Rename", null, new EventHandler(this.mnuDataTab_onClick));
            drpMenu.Items.Add("Copy", null, new EventHandler(this.mnuDataTab_onClick));
            drpMenu.Items.Add("-");
            drpMenu.Items.Add("Close", null, new EventHandler(this.mnuDataTab_onClick));
            drpMenu.Items.Add("-");
            drpMenu.Items.Add("Settings", null, new EventHandler(this.mnuDataTab_onClick));
            drpMenu.Items.Add("Default Settings", null, new EventHandler(this.mnuDataTab_onClick));
            drpMenu.ShowImageMargin = false;
            drpMenu.ShowCheckMargin = false;
            btn.ContextMenuStrip = drpMenu;
            AnimWidgetRotator awRot = new AnimWidgetRotator();
            awRot.Size = new Size((int)Math.Floor((double)(tabHeight * 3.2) / 3), tabHeight);
            awRot.SliceCount = 3;
            awRot.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            awRot.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
            awRot.MultiSample = true;
            awRot.CalcPrecision = 3;
            awRot.RefreshDelayMS = animRefreshMS;
            awRot.ForeColor = Color.SteelBlue;
            awRot.HoleDiameter = 4;
            awRot.Name = "animTab" + idStr;
            awRot.Visible = false;
            awRot.AutoStartStop = true;
            awRot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            awRot.Click += new EventHandler(this.cmdAnim_onClick);

            Panel pan = new Panel();
            pan.Size = new Size(this.panActiveQueries.ClientSize.Width - 3, tabHeight);
            pan.Name = "panTab" + idStr;
            //pan.Top = this._ctrlCnt * (tabHeight + tabPadding);
            pan.Location = this.GetTabPanelLocation(this._dpManCol.Count);
            pan.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            //pan.MouseDown += new MouseEventHandler(this.panTab_onMouseDown);
            //pan.QueryContinueDrag += new QueryContinueDragEventHandler(this.panTab_onQueryContinueDrag);
            pan.SuspendLayout();
            pan.Controls.Add(btn);
            pan.Controls.Add(awRot);
            awRot.Location = new Point(btn.Width - awRot.Width, 0);

            this.panDataPanels.SuspendLayout();
            DataQueryPanel dataPanel = new DataQueryPanel();
            dataPanel.Name = "dataPanel" + idStr;
            dataPanel.Location = new Point(this.panActiveQueries.Bounds.Right + 24, this.panActiveQueries.Bounds.Top);
            dataPanel.QueryStart += new EventHandler(this.dataQueryPanel_onQueryStarted);
            dataPanel.QueryComplete += new EventHandler(this.dataQueryPanel_onQueryComplete);
            dataPanel.QueryAbort += new EventHandler(this.dataQueryPanel_onQueryAbort);
            dataPanel.QueryTextChanged += new EventHandler(this.dataQueryPanel_onQueryTextChanged);
            dataPanel.ConnectionStringChanged += new EventHandler(this.dataQueryPanel_onConnectionStringChanged);
            dataPanel.ConnectionTypeChanged += new EventHandler(this.dataQueryPanel_onConnectionStringChanged);
            dataPanel.QuerySelectionChanged += new CaratPosChangedEventHandler(this.dataQueryPanel_onQueryTextCaratChanged);
            dataPanel.NewConnectionButtonClick += new EventHandler(this.dataQueryPanel_onNewConnectionStrBtnClicked);
            dataPanel.QueryInsertModeChanged += new EventHandler(this.dataQueryPanel_onInsertModeChanged);
            dataPanel.Dock = DockStyle.Fill;
            dataPanel.FillNullsValues = this._defPrefs.FillNullCells;
            if (!this._defPrefs.AllDefault)
            {
                dataPanel.SqlAliasColor = this._defPrefs.SqlAliasColor;
                dataPanel.SqlCommentColor = this._defPrefs.SqlCommentColor;
                dataPanel.SqlFunctionColor = this._defPrefs.SqlFunctionColor;
                dataPanel.SqlGlobalVariableColor = this._defPrefs.SqlGlobalVarColor;
                dataPanel.SqlKeywordColor = this._defPrefs.SqlKeywordColor;
                dataPanel.SqlLiteralColor = this._defPrefs.SqlLiteralColor;
            }
            Connection defConn = this.GetDefaultConnection();
            dataPanel.ConnectionString = defConn.ConnectionString;
            if (defConn.DatabaseProvider != AdoProviderType.Auto)
                dataPanel.DatabaseProvider = defConn.DatabaseProvider;

            // Create a struct with references to each of the controls just
            //   created and set each of their 'Tag' properties to this struct.
            //   This provides an easy way for they controls to reference each other
            //   without constantly 'searching' through control collections.
            DataPanelManager dpman = new DataPanelManager(id, idStr, panelName, pan, btn, awRot, dataPanel, null, drpMenu);
            this._dpManCol.Add(dpman, idStr);
            dpman.ConnID = this.lstRegConn.SelectedIndex;
            btn.Tag = idStr;
            awRot.Tag = idStr;
            dataPanel.Tag = idStr;
            drpMenu.Tag = idStr;
            pan.Tag = idStr;

            pan.ResumeLayout(true);
            this.panActiveQueries.Controls.Add(pan);
            this.panActiveQueries.ResumeLayout(true);
            this.panDataPanels.Controls.Add(dataPanel);
            this.panDataPanels.ResumeLayout(true);

            if (!this._importFile)
                this.UpdateActiveTab(dpman);

            if (!this._loadingFile && !this.Visible && !this._templateFile)
                this._unsaved.Value = true;

            return dpman;
        }
        private void EditButtonText()
        { this.EditButtonText(this.ActivePanel); }
        private void EditButtonText(DataPanelManager dpMan)
        {
            if (dpMan != null)
            {
                int x = dpMan.TabPanel.Location.X + this.panActiveQueries.Location.X + 5;
                int y = dpMan.TabPanel.Location.Y + this.panActiveQueries.Location.Y + ((dpMan.TabButton.Height / 2) - 4) + (this.lstRegConn.Height + this.panLblRegConn.Height) + this.spltConnPanels.SplitterWidth + this.panLblPanels.Height + this.toolStrip1.Height;
                this.panActiveQueries.Enabled = false;
                TextBox txtRename = new TextBox();
                txtRename.Location = new Point(x, y);
                txtRename.Size = new Size(dpMan.TabButton.Width - 6, dpMan.TabPanel.Height);
                txtRename.TextAlign = HorizontalAlignment.Center;
                txtRename.Text = dpMan.TabButton.Text;
                txtRename.LostFocus += new EventHandler(this.txtRename_onLostFocus);
                txtRename.KeyPress += new KeyPressEventHandler(this.txtRename_onKeyPress);
                txtRename.Tag = dpMan.CollectionKey;
                this.Controls.Add(txtRename);
                this._tmpCtrl = txtRename;
                txtRename.BringToFront();
                txtRename.Focus();
                txtRename.SelectAll();
            }
        }
        private void CommitButtonText(TextBox editFld)
        {
            if (!string.IsNullOrEmpty(editFld.Text) && editFld.Tag != null && this._dpManCol.ContainsKey(editFld.Tag.ToString()))
                this._dpManCol[editFld.Tag.ToString()].TabButton.Text = editFld.Text;
            this._unsaved.Value = true;
            this.CloseButtonTextEdit(editFld);
        }
        private void CloseButtonTextEdit(TextBox editFld)
        {
            this.Controls.Remove(editFld);
            editFld.Dispose();
            this._tmpCtrl = null;
            this.panActiveQueries.Enabled = true;
            this.ActivePanel.QueryPanel.FocusQuery();
        }
        private void SetViewModeDropDown(DataPanelManager dpman)
        {
            cmdShowQry.Checked = (!dpman.QueryPanel.HideQuery);
            cmdShowData.Checked = (!dpman.QueryPanel.HideData);
            cmdShowData.Enabled = (dpman.QueryPanel.HasData);
        }
        private void CopyPanel(DataPanelManager dpman)
        {
            DataPanelManager newDpMan = this.CreateNewPanel("Copy of " + dpman.TabButton.Text);
            DataQueryPanel newQPanel = newDpMan.QueryPanel;
            DataQueryPanel oldQPanel = dpman.QueryPanel;
            newQPanel.ConnectionString = oldQPanel.ConnectionString;
            newQPanel.DatabaseProvider = oldQPanel.DatabaseProvider;
            newQPanel.QueryText = oldQPanel.QueryText;
            this._unsaved.Value = true;
        }
        private bool SaveMenuClick()
        {
            if (string.IsNullOrEmpty(this._curFile))
                return this.SaveAsMenuClick();
            else
                this.SaveAllPanels(this._curFile);
            return true;
        }
        private bool SaveAsMenuClick()
        { return this.SaveAsMenuClick(false); }
        private bool SaveAsMenuClick(bool template)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.DefaultExt = ".deqry";
                dlg.AddExtension = true;
                dlg.Filter = "DataExplorer Config Files|*.deqry";
                dlg.FilterIndex = 0;
                dlg.OverwritePrompt = true;
                dlg.Title = "Save File As...";
                dlg.ValidateNames = true;
                dlg.SupportMultiDottedExtensions = true;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                    this.SaveAllPanels(dlg.FileName, template, false);
                else
                    return false;
            }
            return true;
        }
        private void LoadMenuClick(bool import)
        {
            bool prevUnsv = this._unsaved;
            if ((!import) ? this.CheckSaveFirst() : true)
            {
                this._unsaved.Value = false;
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.DefaultExt = ".deqry";
                    dlg.AddExtension = true;
                    dlg.Filter = "DataExplorer Config Files|*.deqry|All Files|*.*";
                    dlg.FilterIndex = 0;
                    dlg.CheckFileExists = true;
                    dlg.CheckPathExists = true;
                    dlg.Multiselect = false;
                    dlg.ShowReadOnly = false;
                    dlg.Title = "Select DataExplorer Config File";
                    dlg.ValidateNames = true;
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                        if (import)
                            this.ImportPanels(dlg.FileName);
                        else
                            this.LoadPanels(dlg.FileName);
                    else
                        this._unsaved.Value = prevUnsv;
                }
            }
        }
        private bool ClearAllPanels()
        {
            if (!this.CheckSaveFirst())
                return false;

            this.panDataPanels.SuspendRefresh();
            this.panActiveQueries.SuspendLayout();

            foreach (DataPanelManager dpMan in this._dpManCol)
            {
                if (dpMan.TabPanel != null)
                    this.panActiveQueries.Controls.Remove(dpMan.TabPanel);
                if (dpMan.QueryPanel != null)
                    this.panDataPanels.Controls.Remove(dpMan.QueryPanel);
                dpMan.Dispose();
            }
            this._dpManCol.Clear();
            this._curTabKey = string.Empty;
            this._gblVarCol.Clear();
            this.lstUniVars.Items.Clear();

            this.panActiveQueries.ResumeLayout(true);
            this.panDataPanels.ResumeRefresh();
            this.Text = "Data Explorer";
            this._curFile = string.Empty;
            this._ctrlCnt = -1;
            this._noteCol.Clear();
            this.statusLabelGeneral.Text = string.Empty;
            this._unsaved.Value = false;
            return true;
        }
        private void SaveAllPanels(string fileName)
        { this.SaveAllPanels(fileName, false, false); }
        private void SaveAllPanels(string fileName, bool template, bool autoSave)
        {
            if (this._dpManCol.Count > 0)
            {
                if (this._createdOn == null || this._createdOn == DateTime.MinValue)
                    this._createdOn = DateTime.Now;
                else
                    this._modifiedOn = DateTime.Now;
                if (string.IsNullOrEmpty(this._createdBy))
                    using (System.Security.Principal.WindowsIdentity wi = System.Security.Principal.WindowsIdentity.GetCurrent())
                        this._createdBy = wi.Name;

                using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                using (XmlTextWriter sr = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    sr.Formatting = Formatting.Indented;
                    sr.Indentation = 4;
                    sr.IndentChar = ' ';
                    sr.Namespaces = false;

                    sr.WriteStartDocument(true);
                    sr.WriteComment("DataExplorer v" + Application.ProductVersion);
                    sr.WriteStartElement("root");

                    // Save the project details.
                    sr.WriteStartElement("ProjectInfo");
                    sr.WriteElementString("CreatedBy", this._createdBy);
                    sr.WriteElementString("CreatedOn", this._createdOn.ToString("HH:mm:ss  MM/dd/yyyy"));
                    sr.WriteElementString("ModifiedOn", (this._modifiedOn == null || this._modifiedOn == DateTime.MinValue) ? "" : this._modifiedOn.ToString("HH:mm:ss  MM/dd/yyyy"));
                    sr.WriteEndElement();

                    // Save each query.
                    foreach (DataPanelManager dpman in this._dpManCol)
                    {
                        var adoProvider = (AdoProviderType)RainstormStudios.CrossThreadUI.GetPropertyInstance(dpman.QueryPanel, "DatabaseProvider");
                        var queryText = (string[])RainstormStudios.CrossThreadUI.GetPropertyInstance(dpman.QueryPanel, "QueryText");
                        var splitPosition = (int)RainstormStudios.CrossThreadUI.GetPropertyInstance(dpman.QueryPanel, "SplitPosition");

                        sr.WriteStartElement("DataPanel");
                        sr.WriteElementString("Name", dpman.TabButton.Text);
                        sr.WriteElementString("ConnStr", dpman.QueryPanel.ConnectionString);
                        sr.WriteElementString("ProviderID", Convert.ToString((int)adoProvider));
                        sr.WriteElementString("QueryStr", String.Join("<%nl%>", queryText));
                        sr.WriteElementString("QuerySz", splitPosition.ToString());
                        sr.WriteEndElement();
                    }

                    // Save the global variables.
                    bool[] bTemp = new bool[this._gblVarCol.Count];
                    bTemp.Initialize();
                    if (template)
                        using (frmTemplateVars frm = new frmTemplateVars(this._gblVarCol))
                            if (frm.ShowDialog(this) == DialogResult.OK)
                                bTemp = frm.BoolValues;

                    for (int i = 0; i < this._gblVarCol.Count; i++)
                    {
                        GlobalVariable gvar = this._gblVarCol[i];
                        sr.WriteStartElement("GlobalVariable");
                        sr.WriteElementString("VarName", gvar.VariableName);
                        sr.WriteElementString("VarType", gvar.VariableType.ToString());
                        sr.WriteElementString("VarValue", (!bTemp[i]) ? gvar.VariableValue : "");
                        sr.WriteEndElement();
                    }

                    // Save any notes attached to this project.
                    for (int i = 0; i < this._noteCol.Count; i++)
                    {
                        sr.WriteStartElement("Note");
                        sr.WriteElementString("NoteStamp", this._noteCol.GetKey(i));
                        sr.WriteElementString("NoteSubject", this._noteCol[i].Subject);
                        sr.WriteElementString("NoteBody", this._noteCol[i].Body);
                        sr.WriteEndElement();
                    }

                    // Close the "root" element and flush the write buffer.
                    sr.WriteEndElement();
                    sr.Flush();
                    sr.WriteEndDocument();
                }
                if (!template && !autoSave)
                {
                    this._unsaved.Value = false;
                    this._curFile = fileName;
                    this.Text = "Data Explorer - " + fileName;
                }

                // Update recent file list.
                if (!autoSave)
                    this.AddNewRecentFileName(fileName);
            }
            else if (!autoSave)
                MessageBox.Show(this, "You cannot save when you have not defined any database queries.", "Error");
        }
        private void ImportPanels(string fileName)
        { this.ImportPanels(fileName, false); }
        private void ImportPanels(string fileName, bool restoreAutoSave)
        {
            this._importFile = true;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                this.panDataPanels.SuspendRefresh();
                string
                    elmName = string.Empty,
                    panName = string.Empty,
                    connStr = string.Empty,
                    qryStr = string.Empty,
                    varName = string.Empty,
                    varValue = string.Empty,
                    varType = string.Empty,
                    noteStamp = string.Empty,
                    noteSubject = string.Empty,
                    noteBody = string.Empty,
                    createdBy = string.Empty,
                    createdOn = string.Empty,
                    modifiedOn = string.Empty;
                int
                    dbProvider = 0,
                    splitPos = 0,
                    panCnt = 0;
                bool[]
                    loadPan = null;
                string[]
                    qrySplit=new string[] { "<%nl%>" };


                if (!this._loadingFile)
                {
                    using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                    using (XmlTextReader sr = new XmlTextReader(fs))
                    {
                        sr.WhitespaceHandling = WhitespaceHandling.None;

                        // We're doing only an import, not a full load, so we want to just
                        //   quickly grab a list of data panel names in the file we're 
                        //   importing.
                        sr.WhitespaceHandling = WhitespaceHandling.None;
                        StringCollection str = new StringCollection();
                        while (sr.Read())
                        {
                            if (sr.NodeType == XmlNodeType.Element)
                                elmName = sr.Name;
                            else if (sr.NodeType == XmlNodeType.Text && elmName.ToLower() == "name")
                                str.Add(sr.Value);
                        }
                        using (frmTemplateVars frm = new frmTemplateVars(str.ToArray()))
                            if (frm.ShowDialog(this) == DialogResult.Cancel)
                                return;
                            else
                                loadPan = frm.BoolValues;
                    }
                }

                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                using (XmlTextReader sr = new XmlTextReader(fs))
                {
                    sr.WhitespaceHandling = WhitespaceHandling.None;

                    while (sr.Read())
                    {
                        if (sr.NodeType == XmlNodeType.Element)
                            elmName = sr.Name;
                        else if (sr.NodeType == XmlNodeType.Text)
                        {
                            switch (elmName.ToLower())
                            {
                                case "name": panName = sr.Value; break;
                                case "connstr": connStr = sr.Value; break;
                                case "providerid": if (!int.TryParse(sr.Value, out dbProvider)) dbProvider = 0; break;
                                case "querystr": qryStr = sr.Value; break;
                                case "querysz": if (!int.TryParse(sr.Value, out splitPos)) splitPos = 0; break;
                                case "varname": varName = sr.Value; break;
                                case "varvalue": varValue = sr.Value; break;
                                case "vartype": varType = sr.Value; break;
                                case "notestamp": noteStamp = sr.Value; break;
                                case "notesubject": noteSubject = sr.Value; break;
                                case "notebody": noteBody = sr.Value; break;
                                case "createdby": createdBy = sr.Value; break;
                                case "createdon": createdOn = sr.Value; break;
                                case "modifiedon": modifiedOn = sr.Value; break;
                            }
                        }
                        else if (sr.NodeType == XmlNodeType.EndElement && sr.Name == "DataPanel")
                        {
                            if (loadPan == null || loadPan[panCnt] == true)
                            {
                                DataPanelManager dpman = this.CreateNewPanel(panName);
                                dpman.QueryPanel.ConnectionString = connStr;
                                dpman.QueryPanel.DatabaseProvider = (RainstormStudios.Data.AdoProviderType)dbProvider;
                                dpman.ConnID = -1;
                                dpman.QueryPanel.QueryText = qryStr.Split(qrySplit, StringSplitOptions.None);
                                //dpman.QueryPanel.ParseQueryColor();
                                //dpman.QueryPanel.InitQueryText(qryStr.Split(qrySplit, StringSplitOptions.None));
                                if (splitPos > 0)
                                    dpman.QueryPanel.SplitPosition = splitPos;
                            }
                            panCnt++;
                        }
                        else if (sr.NodeType == XmlNodeType.EndElement && sr.Name == "GlobalVariable" && this._loadingFile)
                        {
                            // If the file's variable value was empty, then we've just loaded a template.
                            if (string.IsNullOrEmpty(varValue))
                            {
                                this._templateFile = true;
                                this.UpdateGlobalVariable(varName, (SqlDbType)Enum.Parse(typeof(SqlDbType), varType), "");
                            }
                            else
                                this._gblVarCol.Add(new GlobalVariable(varName, (SqlDbType)Enum.Parse(typeof(SqlDbType), varType), varValue), varName);

                            // If we don't clear the variable value after it's set,
                            //   it screws up the template processing.
                            varValue = string.Empty;
                        }
                        else if (sr.NodeType == XmlNodeType.EndElement && sr.Name == "Note" && this._loadingFile)
                        {
                            this._noteCol.Add(new ProjectNote(noteSubject, noteBody), noteStamp);
                        }
                        else if (sr.NodeType == XmlNodeType.EndElement && sr.Name == "ProjectInfo" && this._loadingFile)
                        {
                            this._createdBy = createdBy;
                            this._createdOn = (!string.IsNullOrEmpty(createdOn)) ? DateTime.ParseExact(createdOn, "HH:mm:ss  MM/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat) : DateTime.MinValue;
                            this._modifiedOn = (!string.IsNullOrEmpty(modifiedOn)) ? DateTime.ParseExact(modifiedOn, "HH:mm:ss  MM/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat) : DateTime.MinValue;
                        }
                    }
                }

                // Update the recent file list.
                if (!restoreAutoSave)
                    this.AddNewRecentFileName(fileName);

                this.RefreshVarList();
                this.panDataPanels.ResumeRefresh(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "There was a problem loading the selected file:\n\n" + ex.Message + "\n\nApplication Version: " + Application.ProductVersion, "Error");
            }
            finally
            {
                // If we've just loaded values from a template, we need to set the "unsaved" flag, since
                //   everywhere sees this as a file load and won't trigger the flag.
                if (this._templateFile)
                    this._unsaved.Value = true;

                // If we're not loading (only importing), then set the "templateFile" flag back to false.
                if (!this._loadingFile)
                    this._templateFile = false;

                // Turn off the flag specifying that we're in the process of importing a file and set the
                //   cursor back to the default.
                this._importFile = false;
                this.Cursor = Cursors.Default;
            }
        }
        private void LoadPanels(string fileName)
        { this.LoadPanels(fileName, false); }
        private void LoadPanels(string fileName, bool restoreAutoSave)
        {
            if (this.ClearAllPanels())
            {
                this._loadingFile = true;
                try
                {
                    this.ImportPanels(fileName, restoreAutoSave);
                    if (this._dpManCol.Count > 0)
                        this.UpdateActiveTab(this._dpManCol[0]);
                    if (!this._templateFile && !restoreAutoSave)
                    {
                        this._curFile = fileName;
#if DEBUG
                        this.Text = "DEBUG -- " + fileName;
#else
                        this.Text = "Data Explorer - " + fileName;
#endif
                    }
                }
                finally
                {
                    this._loadingFile = false;
                    this._templateFile = false;
                }
            }
        }
        private void LoadPrefs()
        {
            Microsoft.Win32.RegistryKey userData = Application.UserAppDataRegistry;
            //this._tabHght = (int)userData.GetValue("TabHeight", 22);
            this._tabAutoNm = Convert.ToBoolean(userData.GetValue("AutoName", true));
            //this._defConnStr = (string)userData.GetValue("DefConnStr");
            //this._defConnType = (AdoProviderType)Enum.Parse(typeof(AdoProviderType),
            //    userData.GetValue("DefConnType", "Auto").ToString());
        }
        private void SavePrefs(int tabHt, bool tabAutoNm, string defConn, AdoProviderType defConnType)
        {
            Microsoft.Win32.RegistryKey userData = Application.UserAppDataRegistry;
            //userData.SetValue("TabHeight", tabHt);
            userData.SetValue("AutoName", tabAutoNm);
            //userData.SetValue("DefConnStr", defConn);
            //userData.SetValue("DefConnType", defConnType.ToString());
        }
        private void LoadDefSettings()
        {
            Microsoft.Win32.RegistryKey userData = null;
            try
            {
                userData = Application.UserAppDataRegistry;
                int winWidth = int.Parse(userData.GetValue("WinWidth", "0").ToString());
                int winHeight = int.Parse(userData.GetValue("WinHeight", "0").ToString());
                if (winWidth > 0 && winHeight > 0)
                {
                    this.Width = winWidth;
                    this.Height = winHeight;
                }
                int locx = int.Parse(userData.GetValue("LocX", "-1").ToString());
                int locy = int.Parse(userData.GetValue("LocY", "-1").ToString());
                Rectangle scrn = Screen.GetWorkingArea(new Point(locx, locy));
                if (locx >= 0 || locy >= 0)
                    this.Location = new Point((int)Math.Min(locx, scrn.Right - this.Width), (int)Math.Min(locy, scrn.Bottom - this.Height));
                this.WindowState = (FormWindowState)Enum.Parse(typeof(FormWindowState), (string)userData.GetValue("WinState", "Normal"));
                if (this.WindowState == FormWindowState.Minimized)
                    this.WindowState = FormWindowState.Normal;

                // Load the Registered Connection Strings
                Microsoft.Win32.RegistryKey userDataConn = userData.OpenSubKey("RegConnList");
                if (userDataConn != null)
                {
                    Microsoft.Win32.RegistryKey regConn = null;
                    foreach (string regConnFldr in userDataConn.GetSubKeyNames())
                    {
                        regConn = userDataConn.OpenSubKey(regConnFldr);
                        string connStr = (string)regConn.GetValue("ConnStr", "");
                        AdoProviderType connType = (AdoProviderType)Enum.Parse(typeof(AdoProviderType), regConn.GetValue("ConnType", "").ToString());
                        if (!string.IsNullOrEmpty(connStr))
                            this._connCol.Add(new Connection(regConnFldr, connStr, connType), regConnFldr);
                    }
                    if (regConn != null)
                        regConn.Close();
                    if (userDataConn != null)
                        userDataConn.Close();
                    this.RefreshConnList();
                }

                int sideBarWidth;
                if (int.TryParse(userData.GetValue("SideBarWidth", 239).ToString(), out sideBarWidth))
                    if (sideBarWidth >= this.spltMain.Panel1MinSize && sideBarWidth <= this.spltMain.Width - this.spltMain.Panel2MinSize)
                        this.spltMain.SplitterDistance = sideBarWidth;

                // Load the Global Variables panel initial size.
                bool varPanColp = Convert.ToBoolean(userData.GetValue("GblVarPanColp", false));
                int varPanSize = int.Parse(userData.GetValue("GblVarPanSz", 150).ToString());
                if (varPanColp)
                {
                    this._varPanSz = varPanSize;
                    this.spltVarsPanels.SplitterDistance = this.spltVarsPanels.ClientRectangle.Height - (this.spltVarsPanels.Panel2MinSize + this.spltVarsPanels.SplitterWidth);
                }
                else
                    this.spltVarsPanels.SplitterDistance = varPanSize;

                Microsoft.Win32.RegistryKey mruRegList = userData.OpenSubKey("MRUList");
                if (mruRegList != null)
                {
                    foreach (string valNm in mruRegList.GetValueNames())
                        this._mruList.Add(mruRegList.GetValue(valNm).ToString());
                    mruRegList.Close();
                    this.RefreshMRUList();
                }

                // Load DataGridPrefs Defaults
                this._defPrefs = new DataPanelPrefs();
                this._defPrefs.SetDefault();
                Microsoft.Win32.RegistryKey rgkDefPrefs = userData.OpenSubKey("DefPrefs");
                if (rgkDefPrefs != null)
                {
                    object objSqlKeyword = rgkDefPrefs.GetValue("SqlKeyword");
                    object objSqlFunction = rgkDefPrefs.GetValue("SqlFunction");
                    object objSqlComment = rgkDefPrefs.GetValue("SqlComment");
                    object objSqlLiteral = rgkDefPrefs.GetValue("SqlLiteral");
                    object objSqlAlias = rgkDefPrefs.GetValue("SqlAlias");
                    object objSqlGlobalVar = rgkDefPrefs.GetValue("SqlGlobalVar");

                    int iSqlKeywordClr, iSqlFunctionClr, iSqlCommentClr,
                        iSqlLiteralClr, iSqlAliasClr, iSqlGlobalVarClr;

                    if (objSqlKeyword != null && int.TryParse(objSqlKeyword.ToString(),out iSqlKeywordClr))
                        this._defPrefs.SqlKeywordColor = Color.FromArgb(iSqlKeywordClr);
                    if (objSqlFunction != null && int.TryParse(objSqlFunction.ToString(), out iSqlFunctionClr))
                        this._defPrefs.SqlFunctionColor = Color.FromArgb(iSqlFunctionClr);
                    if (objSqlComment != null && int.TryParse(objSqlComment.ToString(), out iSqlCommentClr))
                        this._defPrefs.SqlCommentColor = Color.FromArgb(iSqlCommentClr);
                    if (objSqlLiteral != null && int.TryParse(objSqlLiteral.ToString(), out iSqlLiteralClr))
                        this._defPrefs.SqlLiteralColor = Color.FromArgb(iSqlLiteralClr);
                    if (objSqlAlias != null && int.TryParse(objSqlAlias.ToString(), out iSqlAliasClr))
                        this._defPrefs.SqlAliasColor = Color.FromArgb(iSqlAliasClr);
                    if (objSqlGlobalVar != null && int.TryParse(objSqlGlobalVar.ToString(), out iSqlGlobalVarClr))
                        this._defPrefs.SqlGlobalVarColor = Color.FromArgb(iSqlGlobalVarClr);
                }
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(this, "Error loading default settings:\n\n" + ex.Message + "\n\nRun application anyway?", "Load Exception", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    Application.Exit();
            }
        }
        private void SaveDefSettings()
        {
            Microsoft.Win32.RegistryKey userData = Application.UserAppDataRegistry;
            userData.SetValue("WinState", this.WindowState.ToString());
            if (this.WindowState == FormWindowState.Normal)
            {
                userData.SetValue("WinWidth", this.Width.ToString(), Microsoft.Win32.RegistryValueKind.DWord);
                userData.SetValue("WinHeight", this.Height.ToString(), Microsoft.Win32.RegistryValueKind.DWord);
            }
            userData.SetValue("LocX", this.Location.X.ToString(), Microsoft.Win32.RegistryValueKind.DWord);
            userData.SetValue("LocY", this.Location.Y.ToString(), Microsoft.Win32.RegistryValueKind.DWord);

            // Save the registered Connection Strings
            Microsoft.Win32.RegistryKey userDataConn = userData.CreateSubKey("RegConnList");
            foreach (Connection conn in this._connCol)
            {
                Microsoft.Win32.RegistryKey regConn = userDataConn.CreateSubKey(conn.Name);
                regConn.SetValue("ConnStr", conn.ConnectionString);
                regConn.SetValue("ConnType", conn.DatabaseProvider.ToString());
                regConn.Close();
            }
            // Delete any removed Connection Strings
            foreach (string oldConn in userDataConn.GetSubKeyNames())
                if (!this._connCol.ContainsKey(oldConn))
                    userDataConn.DeleteSubKey(oldConn, false);
            userDataConn.Close();

            // Get the initial size of the Global Variables panel.
            userData.SetValue("SideBarWidth", this.spltMain.SplitterDistance, Microsoft.Win32.RegistryValueKind.DWord);
            userData.SetValue("GblVarPanSz", (this.spltVarsPanels.Panel2.Height > this.spltVarsPanels.Panel2MinSize)
                                                ? this.spltVarsPanels.SplitterDistance
                                                : this._varPanSz
                                                , Microsoft.Win32.RegistryValueKind.DWord);
            userData.SetValue("GblVarPanColp", !Convert.ToBoolean(this.spltVarsPanels.Panel2.Height > this.spltVarsPanels.Panel2MinSize));

            userDataConn = userData.CreateSubKey("MRUList");
            // Clear all entries
            for (int i = 0; i < 20; i++)
                userDataConn.DeleteValue("MRU" + Convert.ToString(i + 1).PadLeft(2, '0'), false);
            // Rewrite the current MRU list.
            for (int i = 0; i < this._mruList.Count; i++)
                userDataConn.SetValue("MRU" + Convert.ToString(i + 1).PadLeft(2, '0'), this._mruList[i]);
            userDataConn.Close();

            // Save the default DataPanelPreferences
            if (this._defPrefs != null)
            {
                userDataConn = userData.CreateSubKey("DefPrefs");

                if (this._defPrefs.SqlKeywordColor == Color.Empty) userDataConn.DeleteValue("SqlKeyword", false);
                else userDataConn.SetValue("SqlKeyword", this._defPrefs.SqlKeywordColor.ToArgb());
                if (this._defPrefs.SqlFunctionColor == Color.Empty) userDataConn.DeleteValue("SqlFunction", false);
                else userDataConn.SetValue("SqlFunction", this._defPrefs.SqlFunctionColor.ToArgb());
                if (this._defPrefs.SqlLiteralColor == Color.Empty) userDataConn.DeleteValue("SqlLiteral", false);
                else userDataConn.SetValue("SqlLiteral", this._defPrefs.SqlLiteralColor.ToArgb());
                if (this._defPrefs.SqlCommentColor == Color.Empty) userDataConn.DeleteValue("SqlComment", false);
                else userDataConn.SetValue("SqlComment", this._defPrefs.SqlCommentColor.ToArgb());
                if (this._defPrefs.SqlAliasColor == Color.Empty) userDataConn.DeleteValue("SqlAlias", false);
                else userDataConn.SetValue("SqlAlias", this._defPrefs.SqlAliasColor.ToArgb());
                if (this._defPrefs.SqlGlobalVarColor == Color.Empty) userDataConn.DeleteValue("SqlGlobalVar", false);
                else userDataConn.SetValue("SqlGlobalVar", this._defPrefs.SqlGlobalVarColor.ToArgb());
                userDataConn.SetValue("FillNulls", this._defPrefs.FillNullCells);
            }

            //try
            //{
            //    string sqlFn = Path.Combine(Application.StartupPath, "SqlTreeView.xml");
            //    using (FileStream fs = new FileStream(sqlFn, FileMode.Create, FileAccess.Write))
            //    using (StreamWriter sr = new StreamWriter(fs))
            //        foreach (string str in this._sqlExplorer.GetXML())
            //            sr.WriteLine(str);
            //}
            //catch (Exception ex)
            //{ MessageBox.Show(this, "Error saving SQL Explorer data:\n\n" + ex.Message, "Error"); }
        }
        private bool CheckSaveFirst()
        {
            if (this._unsaved)
            {
                DialogResult dlg = MessageBox.Show(this, "Do you want to save your changes?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dlg == DialogResult.Yes)
                    return this.SaveMenuClick();
                else if (dlg == DialogResult.Cancel)
                    return false;
            }
            return true;
        }
        private void AddConnection()
        { this.UpdateConnection("", "", AdoProviderType.Auto); }
        private void UpdateConnection(Connection conn)
        { this.UpdateConnection(conn.Name, conn.ConnectionString, conn.DatabaseProvider); }
        private void UpdateConnection(string connName, string connStr, AdoProviderType provId)
        {
            bool complete = false;
            using (frmRegConn frm = (string.IsNullOrEmpty(connStr))
                                            ? new frmRegConn()
                                            : new frmRegConn(connName, connStr, provId))
                while (!complete)
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        // We check the passed parameter 'connName' because if it's not empty, then we're updating a value.
                        if (string.IsNullOrEmpty(connName) && this._connCol.ContainsKey(frm.ConnectionName))
                        {
                            if (MessageBox.Show(this, "A saved connection with this name already exists. Choose a different name?", "Error", MessageBoxButtons.YesNo) == DialogResult.No)
                                complete = true;
                        }
                        else
                        {
                            this._connCol.Update(new Connection(frm.ConnectionName, frm.ConnectionString, frm.ProviderType), frm.ConnectionName);
                            this.RefreshConnList();
                            this.InitSqlExplorer();
                            complete = true;
                        }
                    }
                    else
                        complete = true;
        }
        private void RefreshConnList()
        {
            this.lstRegConn.BeginUpdate();
            this.lstRegConn.Items.Clear();
            for (int i = 0; i < this._connCol.Count; i++)
            {
                this.lstRegConn.Items.Add(this._connCol[i].Name);
            }
            //this.lstRegConn.Sorted = true;
            this.lstRegConn.EndUpdate();
            this.lstRegConn.Refresh();
        }
        private void RefreshMRUList()
        {
            ToolStripMenuItem mnu = (ToolStripMenuItem)this.mnuFile.DropDownItems["mnuFileMRU"];
            mnu.DropDownItems.Clear();
            if (this._mruList.Count > 0)
                for (int i = 0; i < this._mruList.Count; i++)
                {
                    var menuItem = new ToolStripMenuItem(System.IO.Path.GetFileName(this._mruList[i]), null, new EventHandler(this.mnuMru_onClick), "mnuMRU" + this._mruList.GetKey(i));
                    menuItem.ToolTipText = this._mruList[i];
                    mnu.DropDownItems.Add(menuItem);
                }
            else
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem("None");
                tsmi.Enabled = false;
                mnu.DropDownItems.Add(tsmi);
            }
        }
        private void AddVariable()
        { this.UpdateGlobalVariable("", SqlDbType.VarChar, ""); }
        private void UpdateGlobalVariable(GlobalVariable var)
        { this.UpdateGlobalVariable(var.VariableName, var.VariableType, var.VariableValue); }
        private void UpdateGlobalVariable(string varName, SqlDbType varType, string varValue)
        {
            bool complete = false;
            // Whether or not 'varName' is empty determines whether we're inserting
            //   a new variable or updating an existing one (or copying a value).
            using (frmVarEdit frm = (string.IsNullOrEmpty(varName))
                                            ? new frmVarEdit()
                                            : new frmVarEdit(varName, varType, varValue))
            {
                if (string.IsNullOrEmpty(varValue))
                    frm.SelectVarValue();

                while (!complete)
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        if (string.IsNullOrEmpty(frm.VariableName))
                        {
                            MessageBox.Show(this, "You must supply a variable name.", "Error");
                            frm.SelectVarName();
                        }
                        else if (string.IsNullOrEmpty(frm.VariableValue))
                        {
                            MessageBox.Show(this, "You must supply a variable value.", "Error");
                            frm.SelectVarValue();
                        }
                        // We check the passed parameter 'varName' because if it's not empty, then we're updating a value.
                        else if (string.IsNullOrEmpty(varName) && this._gblVarCol.ContainsKey(frm.VariableName))
                        {
                            if (MessageBox.Show(this, "Variable name already exists. Choose another name?", "Error", MessageBoxButtons.YesNo) == DialogResult.No)
                                complete = true;
                            else
                                frm.SelectVarName();
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(varName) && frm.VariableName != varName && this._gblVarCol.ContainsKey(varName.ToLower()))
                                this._gblVarCol.RemoveByKey(varName.ToLower());
                            this._gblVarCol.Update(new GlobalVariable(frm.VariableName, frm.VariableType, frm.VariableValue), frm.VariableName.ToLower());
                            this.RefreshVarList();
                            complete = true;
                        }
                    }
                    else
                        complete = true;
            }
        }
        private void RefreshVarList()
        {
            this.lstUniVars.BeginUpdate();
            this.lstUniVars.Items.Clear();
            for (int i = 0; i < this._gblVarCol.Count; i++)
            {
                GlobalVariable gbl = this._gblVarCol[i];
                ListViewItem lvi = new ListViewItem(new string[] { "@" + this._gblVarCol[i].VariableName, this._gblVarCol[i].VariableValue });
                lvi.ToolTipText = string.Format("DECLARE @{0} {1} SET @{0} = {2}", gbl.VariableName, gbl.VariableType, gbl.VariableValue);
                this.lstUniVars.Items.Add(lvi);
            }
            this.lstUniVars.Sort();
            this.lstUniVars.EndUpdate();
        }
        private void AbortQuery(DataPanelManager dpman)
        {
            if (dpman.InProcess)
            {
                dpman.AddLogMessage("Canceling Query Execution...");
                dpman.QueryPanel.AbortQuery();
            }
        }
        private void ShowSqlExplorer()
        {
            if (this._sqlExplorerMsOvr)
                return;
            this._sqlExplorer.BringToFront();

            this._sqlExplorer.Focus();
            //System.Threading.ThreadPool.QueueUserWorkItem(this._showSqlExpThread);
            this._sqlExplorerMsOvr = true;
            for (int x = (int)Math.Min(this._sqlExplorer.Left, this.ClientRectangle.Right); x > this.ClientRectangle.Right - this._sqlExplorer.Width - 20; x -= 20)
            {
                this._sqlExplorer.Left = Math.Max(x, this.ClientRectangle.Right - this._sqlExplorer.Width - 20);
                this.Invalidate(this._sqlExplorer.Bounds);
                Application.DoEvents();
            }
        }
        private void HideSqlExplorer()
        {
            //System.Threading.ThreadPool.QueueUserWorkItem(this._hideSqlExpThread);
            this._sqlExplorerMsOvr = false;
            for (int x = (int)Math.Min(this._sqlExplorer.Left, this.ClientRectangle.Right); x < this.ClientRectangle.Right + 11; x += 10)
            {
                if (this._sqlExplorerMsOvr)
                    return;
                this._sqlExplorer.Left = x;
                this.Invalidate(this._sqlExplorer.Bounds);
                Application.DoEvents();
            }
        }
        private void UpdateCaratPos(int chIdx, int colIdx, int lnIdx)
        {
            RainstormStudios.CrossThreadUI.SetPropertyValue(this.statusLabelChar, "Text", "Cr " + chIdx.ToString());
            RainstormStudios.CrossThreadUI.SetPropertyValue(this.statusLabelCol, "Text", "Col " + colIdx.ToString());
            RainstormStudios.CrossThreadUI.SetPropertyValue(this.statusLabelLine, "Text", "Ln " + lnIdx.ToString());
        }
        private void UpdateTransactionButtons(bool enabled)
        {
            RainstormStudios.CrossThreadUI.SetPropertyValue(this.cmdCommitTrans, "Enabled", enabled);
            RainstormStudios.CrossThreadUI.SetPropertyValue(this.cmdRollbackTrans, "Enabled", enabled);
        }
        private void AddNewRecentFileName(string fn)
        {
            string key = "";
            if (this._mruList.Contains(fn))
            {
                int idx = this._mruList.IndexOf(fn);
                key = this._mruList.GetKey(idx);
                this._mruList.RemoveAt(idx);
            }
            else if (this._mruList.Count > 9)
            {
                this._mruList.RemoveAt(9);
            }
            this._mruList.Insert(0, fn, key);
            this.RefreshMRUList();
        }
        private void InitSqlExplorer()
        {
            if (this._sqlExplorer != null)
            {
                this.Controls.Remove(this._sqlExplorer);
                this._sqlExplorer.Dispose();
            }

            this._sqlExplorer = new SqlBrowserTreeView(this._connCol);
            this._sqlExplorer.MouseEnter += new EventHandler(this.sqlExplorer_onMouseOver);
            this._sqlExplorer.MouseLeave += new EventHandler(this.sqlExplorer_onMouseOut);
            this._sqlExplorer.HorizontalScroll += new ScrollEventHandler(this.sqlExplorer_onScroll);
            this._sqlExplorer.VerticalScroll += new ScrollEventHandler(this.sqlExplorer_onScroll);
            this._sqlExplorer.EditObject += new EditObjectEventHandler(this.sqlExplorer_onEditObject);
            this._sqlExplorer.OpenTable += new EditObjectEventHandler(this.sqlExplorer_onOpenTable);
            //this._sqlExplorer.LocationChanged += new EventHandler(this.sqlExplorer_onLocationChanged);
            // The width *must* be a multiple of 10 for the 'slider' animation to work properly!!!
            this._sqlExplorer.Width = 300;
            this._sqlExplorer.Top = this.toolStrip1.Bottom;
            this._sqlExplorer.Left = this.ClientRectangle.Right; //- this._sqlExplorer.Width; //+ 5;
            this._sqlExplorer.Height = this.ClientRectangle.Height - this.toolStrip1.Bottom - this.statusStrip1.Height;
            this._sqlExplorer.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            this.Controls.Add(this._sqlExplorer);
            //this._showSqlExpThread = new System.Threading.WaitCallback(this.DoShowSqlExp);
            //this._hideSqlExpThread = new System.Threading.WaitCallback(this.DoHideSqlExp);
        }
        private void CheckForTempFile()
        {
            FileInfo[] tempFiles = AutoSaveManager.GetExistingFiles(this._autoSaveProcID);
            if (tempFiles.Length > 0)
            {
                using (frmRestoreAutoSave frm = new frmRestoreAutoSave())
                {
                    frm.LoadFiles(tempFiles);
                    DialogResult dlgResult = frm.ShowDialog(this);
                    switch (dlgResult)
                    {
                        case System.Windows.Forms.DialogResult.Ignore:
                            // "Ignore" means to delete all temp files.
                            AutoSaveManager.ClearExistingTempFiles(this._autoSaveProcID);
                            break;
                        case System.Windows.Forms.DialogResult.OK:
                            // "OK" means restore selected file, leave others in place.
                            string restoreFile = frm.GetSelectedFile();
                            if (!string.IsNullOrEmpty(restoreFile))
                            {
                                this.LoadPanels(restoreFile, true);
                                if (File.Exists(restoreFile))
                                    File.Delete(restoreFile);
                            }
                            break;
                        case System.Windows.Forms.DialogResult.Cancel:
                            // If the user clicked "Cancel", just do nothing.
                            break;
                        default:
                            throw new Exception("Unexpected dialog result: " + dlgResult.ToString());
                    }
                }
            }
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void tbrButton_onClick(object sender, EventArgs e)
        {
            switch (((ToolStripButton)sender).Name)
            {
                case "cmdNewPanel":
                    if (this._tmpCtrl != null)
                        this.ActivePanel.QueryPanel.FocusQuery();
                    this.EditButtonText(this.CreateNewPanel("Panel " + Convert.ToString(this._ctrlCnt + 2).PadLeft(3, '0')));
                    this._unsaved.Value = true;
                    break;
                case "cmdRunQry":
                    this.ActivePanel.QueryPanel.RunQuery(this._gblVarCol);
                    break;
                case "cmdStopQry":
                    this.AbortQuery(this.ActivePanel);
                    break;
                case "cmdCommitTrans":
                    try
                    { this.ActivePanel.QueryPanel.CommitTransaction(); }
                    catch (Exception ex)
                    { MessageBox.Show(this, "Unable to commit transaction:\n\n" + ex.Message, "Error Durring Commit"); }
                    finally
                    { this.UpdateTransactionButtons(this.ActivePanel.QueryPanel.OpenTransaction); }
                    break;
                case "cmdRollbackTrans":
                    try
                    { this.ActivePanel.QueryPanel.RollbackTransaction(); }
                    catch (Exception ex)
                    { MessageBox.Show(this, "Unable to rollback transaction:\n\n" + ex.Message, "Error Durring Rollback"); }
                    finally
                    { this.UpdateTransactionButtons(this.ActivePanel.QueryPanel.OpenTransaction); }
                    break;
                case "cmdTestSql":
                    try
                    {
                        MessageBoxIcon mbIcon = MessageBoxIcon.Error;
                        string parseMsg = this.ActivePanel.QueryPanel.CheckSyntax();
                        if (string.IsNullOrEmpty(parseMsg))
                        {
                            parseMsg = "Query Evaluated Sucessfully!";
                            mbIcon = MessageBoxIcon.Information;
                        }
                        MessageBox.Show(this, parseMsg, "SQL Parser", MessageBoxButtons.OK, mbIcon);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, string.Format("An unexpected error occured:\n\n{0}\n\nApplication Version:  {1}", ex.Message, Application.ProductVersion), "Error");
                    }
                    break;
                case "cmdSave":
                        this.SaveMenuClick();
                    break;
                case "cmdSaveAs":
                        this.SaveAsMenuClick();
                    break;
                case "cmdLoad":
                    this.LoadMenuClick(Control.ModifierKeys == Keys.Shift);
                    break;
                case "cmdDateCalc":
                    this.ToggleDateCalculator();
                    break;
                case "cmdSqlExplorer":
                    if (this._frmSqlBrowse == null)
                    {
                        this._frmSqlBrowse = new frmSqlBrowser(this._connCol, this.lstRegConn.SelectedIndex);
                        this._frmSqlBrowse.Location = new Point(this.Location.X + 50, this.Location.Y + 20);
                        this._frmSqlBrowse.FormClosed += new FormClosedEventHandler(this.frmSqlBrowser_onClosed);
                        this._frmSqlBrowse.Show(this);
                    }
                    else
                    {
                        this._frmSqlBrowse.Dispose();
                        this._frmSqlBrowse = null;
                    }
                    break;
                case "cmdExport":
                    MessageBox.Show(this, "This feature is not yet implemented.", "Sorry");
                    break;
                case "cmdImport":
                    MessageBox.Show(this, "This feature is not yet implemented.", "Sorry");
                    break;
                case "cmdCalc":
                    using (System.Diagnostics.Process proc = new System.Diagnostics.Process())
                    {
                        System.Diagnostics.ProcessStartInfo stInfo = new System.Diagnostics.ProcessStartInfo();
                        stInfo.UseShellExecute = true;
                        stInfo.WorkingDirectory = "%windir%";
                        stInfo.FileName = "calc.exe";
                        stInfo.ErrorDialogParentHandle = this.Handle;
                        proc.StartInfo = stInfo;
                        proc.Start();
                    }
                    break;
            }
        }
        private void mnuFile_onClick(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "mnuFileNew":
                    this.ClearAllPanels();
                    this.CreateNewPanel("Panel 001");
                    this._unsaved.Value = false;
                    break;
                case "mnuFileLoad":
                    this.LoadMenuClick(Control.ModifierKeys == Keys.Shift);
                    break;
                case "mnuFileSave":
                    this.SaveMenuClick();
                    break;
                case "mnuFileSaveAs":
                    this.SaveAsMenuClick();
                    break;
                case "mnuFileSaveTemplate":
                    this.SaveAsMenuClick(true);
                    break;
                case "mnuFileImport":
                    this.LoadMenuClick(true);
                    break;
                case "mnuFilePref":
                    //MessageBox.Show(this, "Feature is not available at this time.", "Sorry");
                    using (frmPrefs frm = new frmPrefs())
                    {
                        frm.FillNullCells = this._defPrefs.FillNullCells;
                        frm.SqlAliasColor = this._defPrefs.SqlAliasColor;
                        frm.SqlCommentColor = this._defPrefs.SqlCommentColor;
                        frm.SqlFunctionColor = this._defPrefs.SqlFunctionColor;
                        frm.SqlGlobalVariableColor = this._defPrefs.SqlGlobalVarColor;
                        frm.SqlKeywordColor = this._defPrefs.SqlKeywordColor;
                        frm.SqlLiteralColor = this._defPrefs.SqlLiteralColor;
                        if (frm.ShowDialog(this) == DialogResult.OK)
                            this._defPrefs = frm.GetSettings();
                    }
                    break;
                case "mnuFileReset":
                    if (MessageBox.Show(this, "Are you sure you want to reset the application?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.SaveDefSettings();
                        Application.Restart();
                    }
                    break;
                case "mnuFilePrint":
                    this.ActivePanel.QueryPanel.Print();
                    break;
                case "mnuFilePrintPrev":
                    this.ActivePanel.QueryPanel.PrintPreview();
                    break;
                case "mnuFileProjInfo":
                    using (frmProjectInfo frm = new frmProjectInfo(this._noteCol, this._curFile, this._dpManCol.Count, this._createdBy, this._createdOn, this._modifiedOn))
                    {
                        if (frm.ShowDialog(this) == DialogResult.OK)
                        {
                            if ((frm.AddedNotes != null && frm.AddedNotes.Length > 0) || (frm.DeletedNotes != null && frm.DeletedNotes.Count > 0))
                                this._unsaved.Value = true;
                        }
                        else
                        {
                            if (frm.AddedNotes != null && frm.AddedNotes.Length > 0)
                                foreach (string noteId in frm.AddedNotes)
                                    this._noteCol.RemoveByKey(noteId);
                            if (frm.DeletedNotes != null && frm.DeletedNotes.Count > 0)
                                for (int i = 0; i < frm.DeletedNotes.Count; i++)
                                {
                                    string delNoteKey = frm.DeletedNotes.GetKey(i);
                                    string noteKey = delNoteKey.Substring(0, delNoteKey.Length - 4);
                                    int noteIdx = int.Parse(delNoteKey.Substring(delNoteKey.Length - 4));
                                    if (noteIdx < this._noteCol.Count)
                                        this._noteCol.Insert(noteIdx, frm.DeletedNotes[i], noteKey);
                                    else
                                        this._noteCol.Add(frm.DeletedNotes[i], noteKey);
                                }
                        }
                    }
                    break;
                case "mnuFileExit":
                    this.Close();
                    break;
            }
        }
        private void mnuEdit_onClick(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "mnuEditCut":
                    this.ActivePanel.QueryPanel.Cut();
                    break;
                case "mnuEditCopy":
                    this.ActivePanel.QueryPanel.Copy();
                    break;
                case "mnuEditPaste":
                    this.ActivePanel.QueryPanel.Paste();
                    break;
                case "mnuEditDelete":
                    MessageBox.Show(this, "This feature is currently unavailable.", "Sorry");
                    break;
                case "mnuEditDupPanel":
                    this.CopyPanel(this.ActivePanel);
                    break;
                case "mnuEditFind":
                    MessageBox.Show(this, "This feature is currently unavailable.", "Sorry");
                    break;
                case "mnuEditReplace":
                    MessageBox.Show(this, "This feature is currently unavailable.", "Sorry");
                    break;
            }
        }
        private void mnuTools_onClick(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "mnuToolsCreateSQL":
                    //MessageBox.Show(this, "This feature is not yet implemented.", "Sorry");
                    using (frmTableCreate frm = new frmTableCreate())
                    {
                        if (frm.ShowDialog(this) == DialogResult.OK)
                        {
                            DataPanelManager dpMan = this.CreateNewPanel(frm.TableName);
                            dpMan.QueryPanel.QueryText = frm.GetCreateScript();
                            dpMan.QueryPanel.ParseQueryColor();
                        }
                    }
                    break;
                case "mnuToolsDropSQL":
                    MessageBox.Show(this, "This feature is not yet implemented.", "Sorry");
                    break;
                case "mnuToolsTruncate":
                    MessageBox.Show(this, "This feature is not yet implemented.", "Sorry");
                    break;
                case "mnuToolsImport":
                    MessageBox.Show(this, "This feature is not yet implemented.", "Sorry");
                    break;
                case "mnuToolsExport":
                    MessageBox.Show(this, "This feature is not yet implemented.", "Sorry");
                    break;
                case "mnuToolsDateCalc":
                    this.ToggleDateCalculator();
                    break;
            }
        }
        private void mnuHelp_onClick(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "mnuHelpContents":
                    MessageBox.Show(this, "This feature is not yet implemented.", "Sorry");
                    break;
                case "mnuHelpAbout":
                    MessageBox.Show(this, "This feature is not yet implemented.", "Sorry");
                    break;
            }
        }
        private void mnuFile_onOpening(object sender, EventArgs e)
        {
            mnuFileSave.Enabled = this._unsaved;
        }
        private void munEdit_onOpening(object sender, EventArgs e)
        {
            mnuEditCut.Enabled =
                mnuEditCopy.Enabled =
                mnuEditDelete.Enabled = this.ActivePanel.QueryPanel.CanCutCopy;
        }
        private void mnuTools_onOpening(object sender, EventArgs e)
        {
            mnuToolsCreateSQL.Enabled = (this.ActivePanel.QueryPanel.IsSQL);
            mnuToolsDropSQL.Enabled = (this.ActivePanel.QueryPanel.IsSQL);
        }
        private void mnuMru_onClick(object sender, EventArgs e)
        {
            string keyNm = ((ToolStripMenuItem)sender).Name.Substring(6);
            if (this._mruList.ContainsKey(keyNm))
            {
                string flnm = this._mruList[keyNm];
                if (!File.Exists(flnm))
                {
                    if (MessageBox.Show(this, "Selected file could not be found.  Remove it from the recent file list?", "File Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int idx = this._mruList.IndexOfKey(keyNm);
                        this._mruList.RemoveAt(idx);
                        this.RefreshMRUList();
                        return;
                    }
                }
                this.LoadPanels(flnm);
            }
            else
            {
                MessageBox.Show(this, "An internal error has occured.  This recent file option is not available at this time.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmdDataTab_onClick(object sender, EventArgs e)
        {
            this.SuspendLayout();
            //DataPanelManager dpman = (DataPanelManager)((Control)sender).Tag;
            DataPanelManager dpman = this._dpManCol[((Control)sender).Tag.ToString()];

            this.UpdateActiveTab(dpman);

            this.ResumeLayout(true);
            this.Refresh();
        }
        private void cmdDataTab_onMouseUp(object sender, MouseEventArgs e)
        {
            this._drgThreshStart = Point.Empty;
        }
        private void cmdDataTab_onMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this._drgThreshStart == Point.Empty)
                {
                    this._drgThreshStart = new Point(e.X, e.Y);
                }
                else if (Math.Abs(e.X - this._drgThreshStart.X) > 10 || Math.Abs(e.Y - this._drgThreshStart.Y) > 10)
                {
                    this._drgThreshStart = Point.Empty;
                    AdvancedButton btn = (AdvancedButton)sender;
                    DataPanelManager dpMan = this._dpManCol[btn.Tag.ToString()];
                    DataPanelDragCapsule drgObj = new DataPanelDragCapsule(dpMan.PanelName, dpMan.QueryPanel.ConnectionString, dpMan.QueryPanel.QueryText);
                    btn.DoDragDrop(drgObj.Serialize(), DragDropEffects.Copy);
                }
            }
        }
        private void cmdDataTab_onQueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            if (Control.MouseButtons != MouseButtons.Left)
                e.Action = DragAction.Drop;
            else if (e.EscapePressed)
                e.Action = DragAction.Cancel;
            else
                e.Action = DragAction.Continue;

            if (e.Action != DragAction.Continue)
                this.panActiveQueries.Refresh();

            base.OnQueryContinueDrag(e);

            //Point mp = Control.MousePosition;
            //Control ctrl = this.panActiveQueries.GetChildAtPoint(this.PointToClient(mp));
            //if (ctrl != null)
            //{
            //    int lnPos = ctrl.Top - 3;
            //    this.panActiveQueries.Invalidate(new Rectangle());
            //    using (Pen p = new Pen(Color.Blue, 3.0f))
            //        this._hDC.ManagedGraphics.DrawLine(p, new Point(ctrl.Left, lnPos), new Point(ctrl.Right, lnPos));
            //}
            //this._hDC.ManagedGraphics.FillEllipse(Brushes.Red, new Rectangle(mp.X - 1, mp.Y - 1, 3, 3));
        }
        private void cmdDataTab_onDragDrop(object sender, DragEventArgs e)
        {
            //if (this._hDC != null)
            //    this._hDC.Dispose();
            //this._hDC = null;
            //this.panActiveQueries.AllowDrop = false;
        }
        private void mnuDataTab_onClick(object sender, EventArgs e)
        {
            DataPanelManager dpman = this._dpManCol[((ToolStripMenuItem)sender).Owner.Tag.ToString()];

            switch (((ToolStripMenuItem)sender).Text)
            {
                case "Rename":
                    this.EditButtonText(dpman);
                    break;
                case "Copy":
                    this.CopyPanel(dpman);
                    break;
                case "Close":
                    if (MessageBox.Show(this, "Are you sure you want to permenantly remove this query?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // We went to try and find either the 'next' data panel in
                        //   the collection, or the previous if the user is closing
                        //   the last data panel.
                        int dpmanIdx = this._dpManCol.IndexOfKey(dpman.CollectionKey);
                        int newDpmanIdx = -1;
                        if (dpmanIdx + 1 < this._dpManCol.Count)
                            newDpmanIdx = dpmanIdx;
                        else if (dpmanIdx > 0)
                            newDpmanIdx = dpmanIdx - 1;

                        this.panActiveQueries.SuspendLayout();
                        this.panActiveQueries.Controls.Remove(dpman.TabPanel);
                        this.panActiveQueries.ResumeLayout(true);
                        this.panDataPanels.SuspendLayout();
                        this.panDataPanels.Controls.Remove(dpman.QueryPanel);
                        this.panDataPanels.ResumeLayout(true);
                        dpman.TabButton.ContextMenuStrip.Dispose();
                        dpman.QueryPanel.Dispose();
                        dpman.AnimWidget.Dispose();
                        dpman.TabButton.Dispose();
                        dpman.TabPanel.Dispose();
                        this._dpManCol.RemoveAt(this._dpManCol.IndexOfKey(dpman.CollectionKey));
                        this._unsaved.Value = true;

                        // Move any panels below the one we just removed up.
                        for (int i = dpmanIdx; i < this._dpManCol.Count; i++)
                            this._dpManCol[i].TabPanel.Location = this.GetTabPanelLocation(i);

                        // Set focus to the next data panel in the collection.
                        if (newDpmanIdx >= 0 && newDpmanIdx < this._dpManCol.Count)
                            this.UpdateActiveTab(this._dpManCol[newDpmanIdx]);
                    }
                    break;
                case "Settings":
                    using (frmPrefs frm = new frmPrefs())
                    {
                        frm.FillNullCells = dpman.QueryPanel.FillNullsValues;
                        frm.SqlAliasColor = dpman.QueryPanel.SqlAliasColor;
                        frm.SqlCommentColor = dpman.QueryPanel.SqlCommentColor;
                        frm.SqlFunctionColor = dpman.QueryPanel.SqlFunctionColor;
                        frm.SqlGlobalVariableColor = dpman.QueryPanel.SqlGlobalVariableColor;
                        frm.SqlKeywordColor = dpman.QueryPanel.SqlKeywordColor;
                        frm.SqlLiteralColor = dpman.QueryPanel.SqlLiteralColor;
                        if (frm.ShowDialog(this) == DialogResult.OK)
                        {
                            dpman.QueryPanel.SetPrefs(frm.GetSettings());
                            dpman.QueryPanel.ParseQueryColor();
                        }
                    }
                    break;
                case "Default Settings":
                    dpman.QueryPanel.SetPrefs(this._defPrefs);
                    dpman.QueryPanel.ParseQueryColor();
                    break;
            }
        }
        private void mnuDataTab_onOpening(object sender, CancelEventArgs e)
        {
            DataPanelManager dpman = this._dpManCol[((ContextMenuStrip)sender).Tag.ToString()];
            dpman.TabMenuStrip.Items[3].Enabled = (this._dpManCol.Count > 1);
        }
        private void mnuSavedConn_onClick(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "mnuSavedConnAdd":
                    this.AddConnection();
                    break;
                case "mnuSavedConnDel":
                    this._connCol.RemoveAt(this.lstRegConn.SelectedIndex);
                    this.RefreshConnList();
                    this.InitSqlExplorer();
                    break;
            }
        }
        private void mnuSavedConn_onOpening(object sender, CancelEventArgs e)
        {
            this.mnuSavedConnDel.Enabled = (this.lstRegConn.SelectedIndex > -1);
        }
        private void cmdAnim_onClick(object sender, EventArgs e)
        {
            Control snd = (Control)sender;
            if (snd.Tag != null)
                this.AbortQuery(this._dpManCol[snd.Tag.ToString()]);
        }
        private void cmdViewMode_onClick(object sender, EventArgs e)
        {
            DataQueryPanel panel = this.ActivePanel.QueryPanel;
            string senderName = ((ToolStripButton)sender).Name;
            if (senderName == "cmdShowQry" && !this.cmdShowQry.Checked && !this.cmdShowData.Checked)
                this.cmdShowData.Checked = true;
            else if (senderName == "cmdShowData" && !this.cmdShowData.Checked && !this.cmdShowQry.Checked)
                this.cmdShowQry.Checked = true;

            panel.HideQuery = (!this.cmdShowQry.Checked);
            panel.HideData = (!this.cmdShowData.Checked);
        }
        private void dataQueryPanel_onQueryStarted(object sender, EventArgs e)
        {
            AutoSaveManager.ForceAutoSave(this._autoSaveProcID);
            DataPanelManager dpman = this._dpManCol[((Control)sender).Tag.ToString()];
            RainstormStudios.CrossThreadUI.SetWidth(dpman.TabButton, dpman.TabButton.Width - dpman.AnimWidget.Width - 4);
            RainstormStudios.CrossThreadUI.SetVisible(dpman.AnimWidget, true);
            RainstormStudios.CrossThreadUI.SetPropertyValue(this.cmdRunQry, "Enabled", false);
            dpman.AddLogMessage("Query Executing...");
        }
        private void dataQueryPanel_onQueryComplete(object sender, EventArgs e)
        {
            DataPanelManager dpman = this._dpManCol[((Control)sender).Tag.ToString()];
            RainstormStudios.CrossThreadUI.SetVisible(dpman.AnimWidget, false);
            RainstormStudios.CrossThreadUI.SetWidth(dpman.TabButton, dpman.TabPanel.Width - 2);
            RainstormStudios.CrossThreadUI.SetPropertyValue(this.cmdRunQry, "Enabled", true);
            if (dpman.QueryPanel.QueryException == null)
            {
                dpman.AddLogMessage("Query Completed Successfully!");
                if (dpman.TabButton.Activated)
                {
                    //RainstormStudios.CrossThreadUI.SetPropertyValue(this.cmdShowData, "Enabled", dpman.QueryPanel.RowCount > 0);
                    RainstormStudios.CrossThreadUI.SetPropertyValue(this.cmdShowData, "Enabled", dpman.QueryPanel.HasData);
                    RainstormStudios.CrossThreadUI.SetPropertyValue(this.cmdShowData, "Checked", true);
                    RainstormStudios.CrossThreadUI.SetPropertyValue(this.cmdCommitTrans, "Enabled", dpman.QueryPanel.OpenTransaction);
                    RainstormStudios.CrossThreadUI.SetPropertyValue(this.cmdRollbackTrans, "Enabled", dpman.QueryPanel.OpenTransaction);
                }
            }
        }
        private void dataQueryPanel_onQueryAbort(object sender, EventArgs e)
        {
            DataPanelManager dpman = this._dpManCol[((Control)sender).Tag.ToString()];
            if (!dpman.QueryPanel.QueryException.Message.ToLower().Contains("cancelled by user"))
            {
                string errMsg = string.Format("An error occured while processing query for task '{0}':\n\n{1}\n\nApplication Version: {2}", dpman.PanelName, dpman.QueryPanel.QueryException.Message, Application.ProductVersion);
                RainstormStudios.CrossThreadUI.ShowMessageBox(this.FindForm(), errMsg, "Query Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            dpman.AddLogMessage(dpman.QueryPanel.QueryException.Message);
        }
        private void dataQueryPanel_onQueryTextChanged(object sender, EventArgs e)
        {
            if (!this._loadingFile)
                this._unsaved.Value = true;
        }
        private void dataQueryPanel_onConnectionStringChanged(object sender, EventArgs e)
        {
            DataPanelManager dpman = this.ActivePanel;
            if (!this._updatingActivePanel && dpman != null && dpman.QueryPanel != null)
            {
                if (!this._regConnListClicked && this.lstRegConn.SelectedIndex > -1)
                    this.lstRegConn.ClearSelected();
                this._regConnListClicked = false;
                if (!this._loadingFile)
                    this._unsaved.Value = true;
                this.SetSqlOnlyAvail(dpman.QueryPanel.IsSQL);
            }
        }
        private void dataQueryPanel_onQueryTextCaratChanged(object sender, CaratPosChangedEventArgs e)
        {
            DataQueryPanel qp = (DataQueryPanel)sender;
            RainstormStudios.CrossThreadUI.SetPropertyValue(this.statusLabelGeneral, "Text", qp.SelectionColor);
            this.UpdateCaratPos(e.CharIndex, e.Column, e.LineIndex);
        }
        private void dataQueryPanel_onNewConnectionStrBtnClicked(object sender, EventArgs e)
        {
            using (RainstormStudios.Forms.frmStringBuilder frm = new RainstormStudios.Forms.frmStringBuilder())
            {
                frm.Location = new Point(this.Location.X + 50, this.Location.Y + 20);
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    DataPanelManager dpman = this.ActivePanel;
                    if (dpman != null)
                    {
                        dpman.QueryPanel.ConnectionString = frm.ConnectionString;
                        dpman.QueryPanel.DatabaseProvider = frm.AdoProvider;
                        this._dpManCol[dpman.CollectionKey] = dpman;
                    }
                }
            }
        }
        private void dataQueryPanel_onInsertModeChanged(object sender, EventArgs e)
        {
            //this.statusLableTypeMethod.Text = (this.ActivePanel.QueryPanel.QueryIsInsertMode) ? "INS" : "OVR";
            RainstormStudios.CrossThreadUI.SetPropertyValue(this.statusLableTypeMethod, "Text", (this.ActivePanel.QueryPanel.QueryIsInsertMode) ? "INS" : "OVR");
        }
        private void unsaved_onValueChanged(object sender, EventArgs e)
        {
            if (!this._unsaved)
                this.Text = this.Text.Trim('*');
            else if (this._unsaved && !string.IsNullOrEmpty(this._curFile) && !this.Text.EndsWith("*"))
                this.Text += "*";
            this.cmdSave.Enabled = this._unsaved;
            this.mnuFileSave.Enabled = this._unsaved;
            AutoSaveManager.MarkNeedSave(this._autoSaveProcID);
        }
        private void splSideBar_onSplitterMoved(object sender, SplitterEventArgs e)
        {
            this.panActiveQueries.SuspendLayout();
            for (int i = 0; i < this._dpManCol.Count; i++)
                this._dpManCol[i].TabPanel.Width = this.panActiveQueries.ClientRectangle.Width - 10;
            this.panActiveQueries.ResumeLayout(true);
        }
        private void lblVars_onClick(object sender, EventArgs e)
        {
            int colpSz = (this.spltVarsPanels.ClientRectangle.Height + 3) - (this.spltVarsPanels.Panel2MinSize + this.spltVarsPanels.SplitterWidth);
            if (this.spltVarsPanels.SplitterDistance < colpSz - 5)
            {
                this._varPanSz = this.spltVarsPanels.SplitterDistance;
                this.spltVarsPanels.SplitterDistance = colpSz;
            }
            else if (this._varPanSz > 0)
                this.spltVarsPanels.SplitterDistance = this._varPanSz;
        }
        private void cmdAddVar(object sender, EventArgs e)
        {
            this.AddVariable();
        }
        private void mnuVar_onClick(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "mnuVarAdd":
                    this.AddVariable();
                    break;
                case "mnuVarCopy":
                    GlobalVariable gblCopy = this._gblVarCol[this.lstUniVars.SelectedIndices[0]];
                    this.UpdateGlobalVariable("", gblCopy.VariableType, gblCopy.VariableValue);
                    break;
                case "mnuVarDel":
                    if (MessageBox.Show(this, "Are you sure you want to delete this global variable?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        this._gblVarCol.RemoveAt(this.lstUniVars.SelectedIndices[0]);
                        this.RefreshVarList();
                    }
                    break;
                case "mnuVarEdit":
                    this.UpdateGlobalVariable(this._gblVarCol[this.lstUniVars.SelectedIndices[0]]);
                    break;
            }
        }
        private void mnuVar_Opening(object sender, CancelEventArgs e)
        {
            bool btnEnabled = this.lstUniVars.SelectedIndices.Count > 0;
            this.mnuVarEdit.Enabled = btnEnabled;
            this.mnuVarDel.Enabled = btnEnabled;
            this.mnuVarCopy.Enabled = btnEnabled;
        }
        private void cmdAddRegConn_onClick(object sender, EventArgs e)
        {
            this.AddConnection();
        }
        private void lstRegConn_onSelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstRegConn.SelectedIndex >= 0 && !this._updatingActivePanel)
            {
                this._regConnListClicked = true;
                DataPanelManager dpMan = this.ActivePanel;
                if (dpMan != null)
                {
                    dpMan.QueryPanel.ConnectionString = this._connCol[this.lstRegConn.SelectedIndex].ConnectionString;
                    dpMan.QueryPanel.DatabaseProvider = this._connCol[this.lstRegConn.SelectedIndex].DatabaseProvider;
                    dpMan.ConnID = this.lstRegConn.SelectedIndex;
                    this._dpManCol[dpMan.CollectionKey] = dpMan;
                }
            }
        }
        private void frmDateCalc_onClosed(object sender, FormClosedEventArgs e)
        {
            this._frmDC.Dispose();
            this._frmDC = null;
        }
        private void frmSqlBrowser_onClosed(object sender, FormClosedEventArgs e)
        {
            this._frmSqlBrowse.Dispose();
            this._frmSqlBrowse = null;
        }
        private void txtRename_onLostFocus(object sender, EventArgs e)
        {
            this.CommitButtonText((TextBox)sender);
        }
        private void txtRename_onKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox sndr = (TextBox)sender;
            if (e.KeyChar == '\r')
            {
                this.CommitButtonText(sndr);
                e.Handled = true;
            }
            else if (e.KeyChar == '')
            {
                // If they press the 'ESC' key, then just kill the text box.
                sndr.Text = string.Empty;
                this.CloseButtonTextEdit(sndr);
                e.Handled = true;
            }
        }
        private void gblVarCol_onCleared(object sender, EventArgs e)
        {
            if (!this._loadingFile)
                this._unsaved.Value = true;
        }
        private void gblVarCol_onChanged(object sender, RainstormStudios.Collections.CollectionEventArgs e)
        {
            if (!this._loadingFile)
                this._unsaved.Value = true;
        }
        private void cmdSqlExplorer_onClick(object sender, EventArgs e)
        {
            if (this._frmSqlBrowse == null || this._frmSqlBrowse.IsDisposed)
            {
                this._frmSqlBrowse = new frmSqlBrowser(this._connCol);
                this._frmSqlBrowse.ScriptObject += new EditObjectEventHandler(frmSqlBrowse_onScriptObject);
            }
            this._frmSqlBrowse.Show(this);
        }
        private void cmdSqlExplorer_onMouseOver(object sender, EventArgs e)
        {
            if (this._tmrSqlExpHider.Enabled)
                this._tmrSqlExpHider.Stop();
            this.ShowSqlExplorer();
        }
        private void cmdSqlExplorer_onMouseOut(object sender, EventArgs e)
        {
            this._tmrSqlExpHider.Start();
        }
        private void frmSqlBrowse_onScriptObject(object sender, EditObjectEventArgs e)
        {
            DataPanelManager dpman = this.CreateNewPanel(e.ObjectName);
            dpman.QueryPanel.ConnectionString = e.ConnectionString;
            dpman.QueryPanel.QueryText = e.ObjectText;
            dpman.QueryPanel.ParseQueryColor();
        }
        private void tmrSqlExpHider_onTick(object sender, EventArgs e)
        {
            this._tmrSqlExpHider.Stop();
            this.HideSqlExplorer();
        }
        private void sqlExplorer_onMouseOver(object sender, EventArgs e)
        {
            if (this._tmrSqlExpHider.Enabled)
                this._tmrSqlExpHider.Stop();
            this.ShowSqlExplorer();
        }
        private void sqlExplorer_onMouseOut(object sender, EventArgs e)
        {
            this._tmrSqlExpHider.Start();
        }
        private void sqlExplorer_onScroll(object sender, ScrollEventArgs e)
        {
            if (this._tmrSqlExpHider.Enabled)
            {
                this._tmrSqlExpHider.Stop();
                this._tmrSqlExpHider.Start();
            }
        }
        private void sqlExplorer_onEditObject(object sender, EditObjectEventArgs e)
        {
            DataPanelManager dpman = this.CreateNewPanel(e.ObjectName);
            dpman.QueryPanel.ConnectionString = e.ConnectionString;
            dpman.QueryPanel.QueryText = e.ObjectText;
            dpman.QueryPanel.ParseQueryColor();
        }
        private void sqlExplorer_onOpenTable(object sender, EditObjectEventArgs e)
        {
            DataPanelManager dpman = this.CreateNewPanel(e.ObjectName);
            dpman.QueryPanel.ConnectionString = e.ConnectionString;
            dpman.QueryPanel.QueryText = e.ObjectText;
            dpman.QueryPanel.ParseQueryColor();
            dpman.QueryPanel.HideData = false;
            dpman.QueryPanel.HideQuery = true;
            Application.DoEvents();
            dpman.QueryPanel.RunQuery(this._gblVarCol);
        }
        private void panActiveQueries_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && e.Data.GetData(DataFormats.Text, true).ToString().StartsWith("t:dpdc;|p:"))
                e.Effect = e.AllowedEffect;
            else
                e.Effect = DragDropEffects.None;
        }
        private void panActiveQueries_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                try
                {
                    string drgData = e.Data.GetData(DataFormats.Text, true).ToString();
                    DataPanelManager dpman = null;
                    if (drgData.StartsWith("t:dpdc;|p:"))
                    {
                        DataPanelDragCapsule drgCap = new DataPanelDragCapsule(drgData);
                        dpman = this.CreateNewPanel(drgCap.PanelName);
                        dpman.QueryPanel.QueryText = drgCap.QueryString;
                        dpman.QueryPanel.ConnectionString = drgCap.ConnectionString;
                    }
                    else
                    {
                        dpman = this.CreateNewPanel("Panel " + this._dpManCol.Count.ToString().PadLeft(3, '0'));
                        dpman.QueryPanel.QueryText = drgData.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                    }
                    if (dpman != null)
                        dpman.QueryPanel.ParseQueryColor();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Could not create new panel from dragged data:\n\n" + ex.Message, "Unexpected Error");
                }
            }
        }
        //***************************************************************************
        // Form Event Overrides
        // 
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.LoadDefSettings();
            this.LoadPrefs();

            this._tmrSqlExpHider = new Timer();
            this._tmrSqlExpHider.Interval = 1800;
            this._tmrSqlExpHider.Tick += new EventHandler(this.tmrSqlExpHider_onTick);
            this.SuspendLayout();
            this.InitSqlExplorer();

            // This is just to force the initial "regex startup" delay that seems to occur in Windows 7.  If we don't do it here, it'll happen the first time the user clicks a panel.
            //if (Environment.OSVersion.Version.Major == 7) // Windows 7 reports as "Microsoft Windows NT 6.1.7601 Service Pack 1".  Will have to find a better way to do this.
                QueryTextParser.Instance.KeyWord.Match("the quick brown fox jumps over the lazy dog.");

            this._unsaved = new RainstormStudios.EventValueTypes.EventBoolean(false, new EventHandler(this.unsaved_onValueChanged));
            if (string.IsNullOrEmpty(this._curFile))
                this.CreateNewPanel("Panel 001");
            this._gblVarCol.Cleared += new EventHandler(this.gblVarCol_onCleared);
            this._gblVarCol.Inserted += new CollectionEventHandler(this.gblVarCol_onChanged);
            this._gblVarCol.Removed += new CollectionEventHandler(this.gblVarCol_onChanged);
            this._gblVarCol.Updated += new CollectionEventHandler(this.gblVarCol_onChanged);
            this.lstUniVars.Columns.Add(new FixedColumnListView.FixedColumnHeader("colVarName", "VarName", 39, SizeType.Percent));
            this.lstUniVars.Columns.Add(new FixedColumnListView.FixedColumnHeader("colVarVal", "VarValue", 59, SizeType.Percent));
            if (!string.IsNullOrEmpty(this._curFile))
                this.LoadPanels(this._curFile);
            this._unsaved.Value = false;
#if DEBUG
            this.Text = "DEBUG -- " + this.Text;
#endif
            this.ResumeLayout(true);

            this.CheckForTempFile();
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
//#if DEBUG
//            SizeF sz = e.Graphics.MeasureString("DEBUGW", SystemFonts.MenuFont);
//            e.Graphics.DrawString("DEBUG", SystemFonts.MenuFont, SystemBrushes.MenuText, new PointF(this.ClientRectangle.Right - sz.Width, this.ClientRectangle.Top + 2));
//#endif
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = (!this.CheckSaveFirst());

            if (!e.Cancel)
            {
                this.SaveDefSettings();
                this._sqlExplorerMsOvr = false;
                if (this._sqlExplorer != null)
                    this._sqlExplorer.Left = this.ClientRectangle.Right + 12;
                if (this._frmSqlBrowse != null)
                    this._frmSqlBrowse.Dispose();
                for (int i = 0; i < this._dpManCol.Count; i++)
                    this._dpManCol[i].Dispose();

                try
                { AutoSaveManager.DeregisterProcess(this._autoSaveProcID); }
                catch (Exception ex)
                { MessageBox.Show("Unable to clear auto-save temp file: " + ex.Message); }
            }
            base.OnClosing(e);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.F5 && this.ActivePanel != null)
                this.ActivePanel.QueryPanel.RunQuery(this._gblVarCol);
            else if (e.KeyCode == Keys.F2 && e.Shift)
                this.EditButtonText(this.CreateNewPanel("Panel " + Convert.ToString(this._ctrlCnt + 2).PadLeft(3, '0')));
            else if (e.KeyCode == Keys.F2)
                this.EditButtonText();
            else if (e.KeyCode == Keys.S && e.Modifiers == (Keys.Control | Keys.Shift))
                this.SaveAsMenuClick();
            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
                this.SaveMenuClick();
            else if (e.KeyCode == Keys.Down && e.Modifiers == (Keys.Control | Keys.Shift | Keys.Alt))
            {
                int colIdx = this._dpManCol.IndexOfKey(this.ActivePanel.CollectionKey);
                if (colIdx > -1 && colIdx < this._dpManCol.Count - 1)
                {
                    DataPanelManager dpman = this._dpManCol[colIdx];
                    this._dpManCol.RemoveAt(colIdx);
                    this._dpManCol.Insert(colIdx + 1, dpman, dpman.CollectionKey);
                    this.panActiveQueries.SuspendLayout();
                    this._dpManCol[colIdx + 1].TabPanel.Location = this.GetTabPanelLocation(colIdx + 1);
                    this._dpManCol[colIdx].TabPanel.Location = this.GetTabPanelLocation(colIdx);
                    this.panActiveQueries.ResumeLayout(true);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    this._unsaved.Value = true;
                }
            }
            else if (e.KeyCode == Keys.Up && e.Modifiers == (Keys.Control | Keys.Shift | Keys.Alt))
            {
                int colIdx = this._dpManCol.IndexOfKey(this.ActivePanel.CollectionKey);
                if (colIdx > 0 && colIdx < this._dpManCol.Count)
                {
                    DataPanelManager dpman = this._dpManCol[colIdx - 1];
                    this._dpManCol.RemoveAt(colIdx - 1);
                    this._dpManCol.Insert(colIdx, dpman, dpman.CollectionKey);
                    this.panActiveQueries.SuspendLayout();
                    this._dpManCol[colIdx - 1].TabPanel.Location = this.GetTabPanelLocation(colIdx - 1);
                    this._dpManCol[colIdx].TabPanel.Location = this.GetTabPanelLocation(colIdx);
                    this.panActiveQueries.ResumeLayout(true);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    this._unsaved.Value = true;
                }
            }
            else if (e.KeyCode == Keys.Up && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                int colIdx = this._dpManCol.IndexOfKey(this.ActivePanel.CollectionKey);
                if (colIdx > 0)
                    this.UpdateActiveTab(this._dpManCol[colIdx - 1]);
            }
            else if (e.KeyCode == Keys.Down && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                int colIdx = this._dpManCol.IndexOfKey(this.ActivePanel.CollectionKey);
                if (colIdx < this._dpManCol.Count - 1)
                    try
                    { this.UpdateActiveTab(this._dpManCol[colIdx + 1]); }
                    catch { }
            }
            else if (e.KeyCode == Keys.C && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                // Copy list of column names.
                string colNms = "";
                if (this.ActivePanel != null && this.ActivePanel.QueryPanel != null && this.ActivePanel.QueryPanel.CurrentDataGrid != null)
                {
                    NumberedDataGridView dg = this.ActivePanel.QueryPanel.CurrentDataGrid;
                    for (int i = 0; i < dg.Columns.Count; i++)
                        colNms += dg.Columns[i].Name + ((i > 0) ? "\t" : "");
                    Clipboard.SetText(colNms);
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            if (!this._sqlExplorerMsOvr && this._sqlExplorer.Left < this.ClientRectangle.Right)
                this._sqlExplorer.Left = this.ClientRectangle.Right;
        }
        #endregion
    }
}