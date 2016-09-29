using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RainstormStudios;
using RainstormStudios.Data;
using RainstormStudios.Controls;
using RainstormStudios.Collections;

namespace DataExplorer
{
    internal delegate void CaratPosChangedEventHandler(object sender, CaratPosChangedEventArgs e);
    internal delegate void ScriptRecordEventHandler(object sender, ScriptRecordEventArgs e);
    partial class DataQueryPanel : RainstormStudios.Controls.RsUserControlBase
    {
        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        public static readonly TimeSpan
            EmptyTimespan = new TimeSpan(0);
        //private static readonly System.Text.RegularExpressions.Regex
        //    _rgxDynVars = new System.Text.RegularExpressions.Regex("(?<!--.*)<<@\\w+>>", System.Text.RegularExpressions.RegexOptions.Compiled);
        private DataQuery
            _dataQry;
        //private StringCollection
        //    _undo;
        private NumberedDataGridView
            _cntxMenu;
        private bool
            _isDisposing = false,
            _dataError = false,
            _openTrans = false,
            _hasData = false;
        private int
            _rowCount;
            //_prntDocPg;
        private Timer
            _execTimer;
        private string
            _lastSrch;
        private RainstormStudios.Forms.frmFindText
            _frmFind;
        //private System.Drawing.Printing.PrintDocument
        //    _prntDocData;
        private DataPanelManager
            _owner;
        private DataPanelPrefs
            _prefs;
        //***************************************************************************
        // Event Definitions
        // 
        public event EventHandler ConnectionStringChanged;
        public event EventHandler ConnectionTypeChanged;
        public event EventHandler NewConnectionButtonClick;
        public event EventHandler QueryTextChanged;
        public event EventHandler QueryStart;
        public event EventHandler QueryComplete;
        public event EventHandler QueryAbort;
        public event EventHandler QueryTextParsed;
        public event EventHandler QueryInsertModeChanged;
        public event CaratPosChangedEventHandler QuerySelectionChanged;
        public event EventHandler CollapsedPanelChanged;
        public event ScriptRecordEventHandler ScriptInsert;
        public event ScriptRecordEventHandler ScriptUpdate;
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public string[] QueryText
        {
            get { return this.txtQuery.Lines; }
            set { this.txtQuery.Lines = value; }
        }
        public DataSet QueryResult
        {
            get { return this._dataQry.ASyncResult; }
        }
        public bool QueryIsInsertMode
        {
            get { return this.txtQuery.IsInsertMode; }
        }
        public int RowCount
        {
            get { return this._rowCount; }
        }
        public string ConnectionString
        {
            get { return this.txtConnStr.Text; }
            set { this.txtConnStr.Text = value; }
        }
        public AdoProviderType DatabaseProvider
        {
            get { return (AdoProviderType)this.drpProviderType.SelectedIndex; }
            set { this.drpProviderType.SelectedIndex = (int)value; }
        }
        public TimeSpan TimeTaken
        {
            get
            {
                return (this._dataQry != null) 
                        ? ((DateTime)((this._dataQry.IsExecuting) 
                                        ? DateTime.Now 
                                        : this._dataQry.ASyncEnd)).Subtract(this._dataQry.ASyncStart) 
                        : DataQueryPanel.EmptyTimespan;
            }
        }
        public bool HideQuery
        {
            get { return this.splQuery.Panel1Collapsed; }
            set { this.splQuery.Panel1Collapsed = value; }
        }
        public bool HideData
        {
            get { return this.splQuery.Panel2Collapsed; }
            set { this.splQuery.Panel2Collapsed = value; }
        }
        public int SplitPosition
        {
            get { return this.splQuery.SplitterDistance; }
            set { this.splQuery.SplitterDistance = value; }
        }
        public NumberedDataGridView CurrentDataGrid
        {
            get { return this._cntxMenu; }
        }
        public Exception QueryException
        {
            get { return this._dataQry.AbortException; }
        }
        public bool HasData
        {
            //get { return (this.splQuery.Panel2.Controls.Count > 0); }
            get { return this._hasData; }
        }
        public string StatusMessage
        {
            get { return this.statusLabelGeneral.Text; }
        }
        public bool IsSQL
        {
            get { return rsDb.IsSQL(this.txtConnStr.Text, (AdoProviderType)this.drpProviderType.SelectedIndex); }
        }
        public int CaratPosition
        { get { return this.txtQuery.SelectionStart; } }
        public int CaratLineIndex
        { get { return this.txtQuery.GetLineFromCharIndex(this.CaratPosition); } }
        public int CaratColumnIndex
        { get { return this.txtQuery.GetFirstCharIndexFromLine(this.CaratLineIndex); } }
        public bool OpenTransaction
        { get { return this._openTrans; } }
        public string SelectedQueryText
        {
            get { return this.txtQuery.SelectedText; }
        }
        public bool CanCutCopy
        { get { return (this.txtQuery.SelectionLength > 0); } }
        public DataPanelManager Owner
        {
            get { return this._owner; }
        }
        public bool FillNullsValues
        {
            get { return this._prefs.FillNullCells; }
            set { this._prefs.FillNullCells = value; }
        }
        public Color SqlKeywordColor
        {
            get { return this._prefs.SqlKeywordColor; }
            set { this._prefs.SqlKeywordColor = this.txtQuery.KeywordColor = value; }
        }
        public Color SqlFunctionColor
        {
            get { return this._prefs.SqlFunctionColor; }
            set { this._prefs.SqlFunctionColor = this.txtQuery.FunctionColor = value; }
        }
        public Color SqlCommentColor
        {
            get { return this._prefs.SqlCommentColor; }
            set { this._prefs.SqlCommentColor = this.txtQuery.CommentColor = value; }
        }
        public Color SqlLiteralColor
        {
            get { return this._prefs.SqlLiteralColor; }
            set { this._prefs.SqlLiteralColor = this.txtQuery.StringLiteralColor = value; }
        }
        public Color SqlAliasColor
        {
            get { return this._prefs.SqlAliasColor; }
            set { this._prefs.SqlAliasColor = this.txtQuery.AliasColor = value; }
        }
        public Color SqlGlobalVariableColor
        {
            get { return this._prefs.SqlGlobalVarColor; }
            set { this._prefs.SqlGlobalVarColor = this.txtQuery.GlobalVariableColor = value; }
        }
        //***************************************************************************
        // Private Properties
        // 
        internal Color SelectionColor
        { get { return this.txtQuery.SelectionColor; } }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public DataQueryPanel()
        {
            InitializeComponent();
            this._prefs = new DataPanelPrefs();
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public new void Dispose()
        {
            this._isDisposing = true;
            this.DestroyDatasource();
            this.DisposeAllControls(this.Controls);
            base.Dispose(true);
        }
        public void RunQuery(GlobalVariableCollection vars)
        {
            try
            {
                if (this._dataQry != null && this._openTrans)
                {
                    DialogResult dlgResult=MessageBox.Show(this.FindForm(), "You have an open transaction.  Do you want to discard changes?", "Warning!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dlgResult == DialogResult.No)
                        if (MessageBox.Show(this.FindForm(), "Commit transaction changes?", "Confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            this._dataQry.CommitTransaction();
                        else
                            return;
                    else if (dlgResult == DialogResult.Yes)
                        this._dataQry.RollbackTransaction();
                    else
                        return;
                }
                else if(this._dataQry!=null)
                    this._dataQry.Dispose();

                this._openTrans = false;
                string qry = this.GetSQLQuery(vars);
                //System.Text.RegularExpressions.Regex regEx = new System.Text.RegularExpressions.Regex("(?<!--.*)\\b(TRAN|TRANSACTION)\\b.*$", System.Text.RegularExpressions.RegexOptions.Singleline | System.Text.RegularExpressions.RegexOptions.Multiline | System.Text.RegularExpressions.RegexOptions.Compiled);

                if (qry.ToUpper().Contains(" TRAN ") || qry.ToUpper().Contains(" TRANSACTION "))
                    this._openTrans = true;
                this._dataQry = new DataQuery(this.DatabaseProvider, this.ConnectionString, qry);
                this._dataQry.ExecuteStarted += new EventHandler(this.dataQuery_onExecuteStart);
                this._dataQry.ExecuteStopped += new EventHandler(this.dataQuery_onExecuteStopped);
                this._dataQry.ExecuteAbort += new EventHandler(this.dataQuery_onExecuteAbort);
                this._execTimer = new Timer();
                this._execTimer.Interval = 200;
                this._execTimer.Tick += new EventHandler(execTimer_onTick);
                this._execTimer.Start();
                this._dataQry.BeginExecuteQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.FindForm(), string.Format("Unable to execute query:\n\n{0}\n\nApplication Version:  {1}", ex.Message, Application.ProductVersion), "Error");
            }
        }
        public string CheckSyntax()
        {
            string qry = this.GetSQLQuery(null);
            using (this._dataQry = new DataQuery(this.DatabaseProvider, this.ConnectionString, qry))
            {
                return this._dataQry.CheckSyntax();
            }
        }
        public void AbortQuery()
        { this._dataQry.AbortExecute(); }
        public void FocusQuery()
        { this.txtQuery.Focus(); }
        public void ParseQueryColor()
        { this.txtQuery.Parse(); }
        public void SetCommandTimeout(int seconds)
        { this._dataQry.CommandTimeout = seconds; }
        public void UpdateStatusText(string msg)
        {
            string pMsg = msg;
            if (msg.Contains("\n") || msg.Contains("\r"))
            {
                pMsg = "Multiple Errors. Hover here for list.";
                RainstormStudios.CrossThreadUI.SetPropertyValue(this.statusLabelGeneral, "ToolTipText", msg);
            }
            RainstormStudios.CrossThreadUI.SetPropertyValue(this.statusLabelGeneral, "Text", pMsg);
        }
        public void CommitTransaction()
        {
            this.EndTransaction(true);
        }
        public void RollbackTransaction()
        {
            this.EndTransaction(false);
        }
        public void InitQueryText(string[] qry)
        {
            this.txtQuery.BeginParse(string.Join("\n", qry));
        }
        public void Cut()
        {
            this.txtQuery.Cut();
        }
        public void Copy()
        {
            this.txtQuery.Copy();
        }
        public void Paste()
        {
            this.txtQuery.Paste();
        }
        public void Find(string findText, bool matchCase, bool wholeWord)
        {
            this.Find(findText, 0, -1, matchCase, wholeWord);
        }
        public void Find(string findText, int startPos, int endPos, bool matchCase, bool wholeWord)
        {
            RichTextBoxFinds flags = RichTextBoxFinds.None;
            if (matchCase)
                flags |= RichTextBoxFinds.MatchCase;
            if (wholeWord)
                flags |= RichTextBoxFinds.WholeWord;

            this.txtQuery.Find(findText, startPos, endPos, flags);
        }
        internal void SetPrefs(DataPanelPrefs prefs)
        {
            this.FillNullsValues = prefs.FillNullCells;
            this.SqlAliasColor = prefs.SqlAliasColor;
            this.SqlCommentColor = prefs.SqlCommentColor;
            this.SqlFunctionColor = prefs.SqlFunctionColor;
            this.SqlGlobalVariableColor = prefs.SqlGlobalVarColor;
            this.SqlKeywordColor = prefs.SqlKeywordColor;
            this.SqlLiteralColor = prefs.SqlLiteralColor;
        }
        public void Print()
        {
            this.txtQuery.Print(this._owner.TabButton.Text);
        }
        public void PrintPreview()
        {
            this.txtQuery.PrintPreview();
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private void DestroyDatasource()
        {
            if (this._dataQry != null)
                this._dataQry.Dispose();
            if (!this._isDisposing)
            {
                //if (this.splQuery.Panel2.Controls.Count > 0)
                //    RainstormStudios.CrossThreadUI.InvokeMethod(this.splQuery.Panel2.Controls[0], "Dispose");
                //    //this.splQuery.Panel2.Controls[0].Dispose();

                //this.DisposeAllControls(this.splQuery.Panel2.Controls);
                RainstormStudios.CrossThreadUI.SetPropertyValue(this.splQuery, "Panel2Collapsed", true);
                this.OnCollapsedPanelChanged();
            }
        }
        private void GetSum()
        {
            double sum = 0;
            int rowFail = 0;
            foreach (DataGridViewCell cell in this._cntxMenu.SelectedCells)
            {
                double cellVal;
                if (double.TryParse(cell.Value.ToString(), out cellVal))
                    sum += cellVal;
                else
                    rowFail++;
            }
            MessageBox.Show(this, string.Format("Sum: {0}{1}", sum, (rowFail > 0) ? "\n\n" + rowFail.ToString() + " Row(s) failed to evaluate to numeric values." : ""), "Sum of Selected Fields");
        }
        private void GetAvg()
        {
            double sum = 0;
            int rowCount = 0;
            int rowFail = 0;
            foreach (DataGridViewCell cell in this._cntxMenu.SelectedCells)
            {
                double cellVal;
                if (double.TryParse(cell.Value.ToString(), out cellVal))
                    sum += cellVal;
                else
                    rowFail++;
            }
            MessageBox.Show(this, string.Format("Average: {0}{1}", (sum / rowCount), (rowFail > 0) ? "\n\n" + rowFail.ToString() + " Row(s) failed to evaluate to numeric values." : ""), "Sum of Selected Fields");
        }
        private void SetClipboard(NumberedDataGridView ndgv, bool includeHeaders = false)
        {
            try
            { Clipboard.SetDataObject(ndgv.GetClipboardContent(includeHeaders), true, 2, 200); }
            catch (Exception ex)
            { MessageBox.Show(this.FindForm(), string.Format("Unable to paste data to clipboard:\n\n{0}\n\nApplication Version: {1}", ex.Message, Application.ProductVersion), "Copy Error"); }

            #region DEPRECIATED METHOD
            // This works, but doing it by hand this way is horribly slow when large
            //   amounts of data are selected.

            //Int32Collection idxCol = new Int32Collection();
            //for (int i = 0; i < ndgv.SelectedCells.Count; i++)
            //{
            //    DataGridViewCell cl = ndgv.SelectedCells[i];
            //    idxCol.Add(i, cl.RowIndex.ToString().PadLeft(4, '0') + cl.ColumnIndex.ToString().PadLeft(4, '0'));
            //}
            //idxCol.Sort();

            //string cbData = string.Empty;
            //int rowIdx = -1;
            //for (int i = 0; i < idxCol.Count; i++)
            //{
            //    DataGridViewCell cl = ndgv.SelectedCells[idxCol[i]];
            //    cbData += ((cl.RowIndex != rowIdx) ? "\r\n" : "\t") + cl.Value.ToString();
            //    rowIdx = cl.RowIndex;
            //}
            //Clipboard.SetData(System.Windows.Forms.DataFormats.UnicodeText, cbData.TrimStart('\r', '\n'));
            #endregion
        }
        private void UpdateQueryTime(TimeSpan time)
        {
            CrossThreadUI.SetPropertyValue(this.statusLabelTime, "Text", string.Format("{0}:{1}:{2}", time.Hours.ToString().PadLeft(2, '0'), time.Minutes.ToString().PadLeft(2, '0'), time.Seconds.ToString().PadLeft(2, '0')));
        }
        private string GetSQLQuery(GlobalVariableCollection vars)
        {
            if (string.IsNullOrEmpty(this.ConnectionString))
                throw new Exception("Connection string blank.  Please provide a connection string before executing the query.");

            string[] qryStr;
            if (this.txtQuery.SelectedText.Length > 0)
                qryStr = this.txtQuery.SelectedText.Split(new char[] { '\n' }, StringSplitOptions.None);
            else
                qryStr = this.txtQuery.Lines;

            string qry = string.Empty;
            string qryText = string.Join(" ", qryStr);
            if (!qryText.Contains("ALTER ") && !qryText.Contains("CREATE "))
            {
                qryText = RainstormStudios.rsString.DeCommentQuery(qryStr, false);
                if (vars != null)
                    for (int i = 0; i < vars.Count; i++)
                        if (vars[i].VariableType == SqlDbType.Char || vars[i].VariableType == SqlDbType.NChar || vars[i].VariableType == SqlDbType.VarChar || vars[i].VariableType == SqlDbType.NVarChar || vars[i].VariableType == SqlDbType.Text || vars[i].VariableType == SqlDbType.Date || vars[i].VariableType == SqlDbType.DateTime || vars[i].VariableType == SqlDbType.DateTime2)
                            qry += string.Format("DECLARE @{0} {1}(max) SET @{0} = '{2}'", vars[i].VariableName, vars[i].VariableType, vars[i].VariableValue);
                        else
                            qry += string.Format("DECLARE @{0} {1} SET @{0} = {2} ", vars[i].VariableName, vars[i].VariableType, vars[i].VariableValue);
            }
            else
                qryText = string.Join("\r\n", qryStr);
            qry = " " + qry + qryText + " ";
            //qry = " " + qry + RainstormStudios.rsString.DeCommentQuery(qryStr, false) + " ";
            return qry; //.Replace(';', ' ').Replace(" GO ", " ").Trim();
        }
        private void StartFind()
        {
            if (this._frmFind == null || this._frmFind.IsDisposed)
            {
                this._frmFind = new RainstormStudios.Forms.frmFindText(this._lastSrch);
                this._frmFind.FindNext += new EventHandler(this.frmFind_onFindNext);
                this._frmFind.FormClosed += new FormClosedEventHandler(this.frmFind_onClose);
                this._frmFind.EnableRegExSearch = false;
                this._frmFind.Show(this.FindForm());
            }
            else
                this._frmFind.Focus();
        }
        private bool CellValueMatch(NumberedDataGridView ndg, bool matCase, int y, int x, string srchTxt)
        {
            string cellVal = this._cntxMenu.Rows[y].Cells[x].Value.ToString();
            if (!this._frmFind.MatchCase)
                cellVal = cellVal.ToLower();
            if (cellVal.Contains(srchTxt))
            {
                this._cntxMenu.Rows[y].Cells[x].Selected = true;
                this._cntxMenu.MakeRowVisible(y);
                return true;
            }
            else
                return false;
        }
        private void EndTransaction(bool commit)
        {
            try
            {
                if (!this._openTrans)
                    throw new ApplicationException("There is no open transaction to commit.");

                if (this._dataQry == null || this._dataQry.BaseConnection.DbConnection.State != ConnectionState.Open)
                    throw new ApplicationException("The database connection is not currently in a ready state.");

                if (commit)
                    this._dataQry.CommitTransaction();
                else
                    this._dataQry.RollbackTransaction();
            }
            catch
            {
                throw;
            }
            finally
            {
                this._openTrans = false;
                this._dataQry.Dispose();
            }
        }
        private ObjectCollection GetScriptVals()
        {
            //if (this._cntxMenu.SelectedCells.Count < 1)
            //{
            //    MessageBox.Show(this.FindForm(), "You must select the key field of the record you want to script.", "Error");
            //    return null;
            //}
            //else if (this._cntxMenu.SelectedCells.Count > 1)
            //{
            //    MessageBox.Show(this.FindForm(), "Only one record can be scripted at a time.\n\nPlease select a single cell.", "Error");
            //    return null;
            //}

            //int rowIdx=this._cntxMenu.SelectedCells[0].RowIndex;
            //StringCollection strCols = new StringCollection();
            //for (int i = 0; i < this._cntxMenu.ColumnCount; i++)
            //    strCols.Add(this._cntxMenu.Columns[i].Name);

            //bool[] incl = null;
            //using (frmTemplateVars frm = new frmTemplateVars(strCols.GetFlatArray(), "Select Fields to Include"))
            //    if (frm.ShowDialog(this.FindForm()) == DialogResult.OK)
            //    {
            //        incl = frm.BoolValues;
            //    }
            //    else
            //        return null;

            //ObjectCollection objCol = new ObjectCollection();
            //for (int i = 0; i < incl.Length; i++)
            //    if (incl[i])
            //        objCol.Add(this._cntxMenu.Rows[rowIdx].Cells[i].Value, this._cntxMenu.Columns[i].Name);
            //return objCol;
            return null;
        }
        private void SaveDataToFile(string filename)
        {
            try
            {
                char[] qualChars = new char[] { ',', '\r', '\n' };
                using (System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                using (System.IO.StreamWriter sr = new System.IO.StreamWriter(fs))
                {
                    for (int r = -1; r < this._cntxMenu.Rows.Count; r++)
                    {
                        string lnData = "";
                        for (int c = 0; c < this._cntxMenu.Columns.Count; c++)
                        {
                            if (r < 0)
                            {
                                if (c > 0)
                                    lnData += ",";
                                lnData += this._cntxMenu.Columns[c].HeaderText;
                            }
                            else
                            {
                                string
                                    cVal = "",
                                    dgVal = this._cntxMenu.Rows[r].Cells[c].Value.ToString();
                                if (c > 0)
                                    cVal += ",";
                                bool qual = (dgVal.IndexOfAny(qualChars) > -1);
                                if (qual)
                                    cVal += "\"";
                                cVal += dgVal;
                                if (qual)
                                    cVal += "\"";
                                lnData += cVal;
                            }
                        }
                        sr.WriteLine(lnData);
                    }
                }
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show(this, "Unable to save to selected file:\n\n" + ex.Message, "Error Writing File");
            }
            catch
            { throw; }
        }
        internal void SetOwner(DataPanelManager owner)
        {
            this._owner = owner;
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void dataQuery_onExecuteStart(object sender, EventArgs e)
        {
            CrossThreadUI.SetEnabled(this.txtQuery, false);
            CrossThreadUI.SetEnabled(this.panConn, false);
            //CrossThreadUI.SetPropertyValue(this.splQuery, "Panel2Collapsed", false);
            CrossThreadUI.SetPropertyValue(this.statusLabelTime, "ToolTipText", "");
            this.OnCollapsedPanelChanged();
            this.DestroyDatasource();
            this.OnQueryStart();
        }
        private void dataQuery_onExecuteStopped(object sender, EventArgs e)
        {
            if (this._execTimer.Enabled)
                this._execTimer.Stop();
            this._execTimer.Dispose();
            this._rowCount = 0;

            RainstormStudios.CrossThreadUI.SetEnabled(this.txtQuery, true);
            RainstormStudios.CrossThreadUI.SetEnabled(this.panConn, true);
            Control parent = this.splQuery.Panel2;
            this._hasData = false;
            this._rowCount = this._dataQry.RecordsAffected;

            if (this._dataQry.AbortException == null && this._dataQry.ASyncResult != null)
            {
                if (this._dataQry.ASyncResult.Tables.Count > 0)
                {
                    if (this.splQuery.Panel2Collapsed)
                        CrossThreadUI.SetPropertyValue(this.splQuery, "Panel2Collapsed", false);
                    CrossThreadUI.InvokeMethod(this.splQuery.Panel2, "SuspendLayout");
                    CrossThreadUI.InvokePropertyMethod(parent, "Controls", "Clear");
                    int dgSize = this.splQuery.Panel2.ClientRectangle.Height / this._dataQry.ASyncResult.Tables.Count;
                    for (int i = 0; i < this._dataQry.ASyncResult.Tables.Count; i++)
                    {
                        NumberedDataGridView ndgv = new NumberedDataGridView();
                        ndgv.Name = string.Format("numberedDataGridView{0}", Convert.ToString(i + 1).PadLeft(3, '0'));
                        ndgv.DataSource = this._dataQry.ASyncResult.Tables[i];
                        ndgv.Dock = DockStyle.Fill;

                        ndgv.ReadOnly = true;
                        ndgv.AllowUserToAddRows = false;
                        ndgv.AllowUserToDeleteRows = false;
                        ndgv.AllowUserToOrderColumns = true;
                        ndgv.AllowUserToResizeColumns = true;
                        ndgv.AllowUserToResizeRows = false;
                        if (this._prefs.FillNullCells)
                            ndgv.DefaultCellStyle.NullValue = "NULL";
                        ndgv.ContextMenuStrip = this.mnuDg;
                        ndgv.MouseEnter += new EventHandler(this.ndgv_MouseEnter);
                        ndgv.MouseDown += new MouseEventHandler(this.ndgv_MouseDown);
                        ndgv.DataError += new DataGridViewDataErrorEventHandler(ndgv_DataError);

                        if (this._dataQry.ASyncResult.Tables.Count > (i + 1))
                        {
                            SplitContainer splt = new SplitContainer();
                            splt.Orientation = Orientation.Horizontal;
                            splt.Dock = DockStyle.Fill;
                            //splt.SplitterDistance = dgSize + (dgSize / this._dataQry.ASyncResult.Tables.Count);
                            splt.SplitterDistance = (int)Math.Min(250, ((ndgv.RowCount + 1) * ndgv.ColumnHeadersHeight) + 20);
                            splt.Panel1.Controls.Add(ndgv);
                            CrossThreadUI.InvokePropertyMethod(parent, "Controls", "Add", splt);
                            parent = splt.Panel2;
                        }
                        else
                        {
                            CrossThreadUI.InvokePropertyMethod(parent, "Controls", "Add", ndgv);
                        }
                        //this._rowCount += this._dataQry.ASyncResult.Tables[i].Rows.Count;
                        this._dataQry.ASyncResult.Tables[i].Dispose();
                    }
                    CrossThreadUI.InvokeMethod(this.splQuery.Panel2, "ResumeLayout", true);
                    this._hasData = true;
                    this._dataQry.ASyncResult.Dispose();
                }
            }
            else
            {
                //AdvRichTextBox txtResult = new AdvRichTextBox();
                //txtResult.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
                //txtResult.Dock = DockStyle.Fill;
                //txtResult.WordWrap = true;
                //txtResult.ReadOnly = true;
                //txtResult.BackColor = SystemColors.Window;
                //txtResult.Text = string.Format("{0} Records Affected.", this._dataQry.RecordsAffected);
                //CrossThreadUI.InvokePropertyMethod(parent, "Controls", "Add", txtResult);
            }

            if (this._dataError)
                RainstormStudios.CrossThreadUI.ShowMessageBox(this, "One or more fields contained invalid data. Please check your datasources or try the query again.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            this._dataError = false;
            RainstormStudios.CrossThreadUI.SetPropertyValue(this.statusLabelRows, "Text", string.Format("{0} Rows", this._rowCount));
            this.OnQueryComplete();
            TimeSpan time = this.TimeTaken;
            this.UpdateQueryTime(time);
            CrossThreadUI.SetPropertyValue(this.statusLabelTime, "ToolTipText", string.Format("{0}:{1}:{2}.{3}", time.Hours.ToString().PadLeft(2, '0'), time.Minutes.ToString().PadLeft(2, '0'), time.Seconds.ToString().PadLeft(2, '0'), time.Milliseconds.ToString()));
            if (!this._openTrans)
                this._dataQry.Dispose();

            CrossThreadUI.InvokeMethod(this.txtQuery, "Focus");
        }
        private void dataQuery_onExecuteAbort(object sender, EventArgs e)
        {
            this._execTimer.Stop();
            this.OnQueryAbort();
            this._hasData = false;
            RainstormStudios.CrossThreadUI.InvokeMethod(this.txtQuery, "Focus");
        }
        private void ndgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // This gets thrown when certain rare types of invalid data are loaded.
            //   The control will actually pop-up a dialog box indicating the error
            //   for each and every cell that it tries to draw the bad data on, so
            //   we definitely want to supress that. At some point, I need to
            //   implement a means of logging specific fields which contain data
            //   that the DataGridView was unable to render.
            this._dataError = true;
            e.ThrowException = false;
            e.Cancel = true;
        }
        private void ndgv_MouseEnter(object sender, EventArgs e)
        {
            // We do this so that when a ContxtMenu item is click, we can tell which
            //   datagrid was the last one the mouse was hovering over.
            this._cntxMenu = (NumberedDataGridView)sender;
        }
        private void ndgv_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitTest = this._cntxMenu.HitTest(e.X,e.Y);
            DataGridViewCell cell = null;
            if (hitTest.RowIndex > -1 && hitTest.RowIndex < this._cntxMenu.RowCount && hitTest.ColumnIndex > -1 && hitTest.ColumnIndex < this._cntxMenu.ColumnCount)
                cell = this._cntxMenu.Rows[hitTest.RowIndex].Cells[hitTest.ColumnIndex];
            if (e.Button == MouseButtons.Left)
            {
                if (cell == null)
                    this._cntxMenu.ClearSelection();
            }
            else if (e.Button == MouseButtons.Right)
            {
                try
                {
                    if (cell != null && !cell.Selected)
                    {
                        this._cntxMenu.ClearSelection();
                        cell.Selected = true;
                    }
                }
                catch { }
            }
        }
        private void mnuDg_Opening(object sender, CancelEventArgs e)
        {
            bool isDataSel = (this._cntxMenu != null && this._cntxMenu.SelectedCells.Count > 0);
            this.mnuDgBgStyle.Enabled = isDataSel;
            this.mnuDgCopy.Enabled = isDataSel;
            this.mnuDgPrint.Enabled = isDataSel;
            this.mnuDgMath.Enabled = isDataSel;
            this.mnuAutoStyleByVal.Enabled = isDataSel;
        }
        private void mnuDg_onClick(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "mnuDgCopy":
                    this.SetClipboard(this._cntxMenu);
                    break;
                case "mnuDgCopyHeaders":
                    this.SetClipboard(this._cntxMenu, true);
                    break;
                case "mnuDgSelectAll":
                    this._cntxMenu.SelectAll();
                    break;
                case "mnuDgMathSum":
                    this.GetSum();
                    break;
                case "mnuDgMathAvg":
                    this.GetAvg();
                    break;
                case "mnuDgClearStyle":
                    this.Refresh();
                    break;
                case "mnuDgSaveData":
                    using (SaveFileDialog dlg = new SaveFileDialog())
                    {
                        dlg.DefaultExt = ".csv";
                        dlg.AddExtension = true;
                        dlg.OverwritePrompt = true;
                        dlg.Title = "Select Output CSV File";
                        dlg.ValidateNames = true;
                        dlg.SupportMultiDottedExtensions = true;
                        dlg.Filter = "CSV Files|*.csv|All Files|*.*";
                        dlg.FilterIndex = 0;
                        if (dlg.ShowDialog(this.FindForm()) == DialogResult.OK)
                            this.SaveDataToFile(dlg.FileName);
                    }
                    break;
                case "mnuDgPrintPrev":
                    this._cntxMenu.PrintPreview();
                    break;
                case "mnuDgPrint":
                    this._cntxMenu.Print(this._owner.TabButton.Text);
                    break;
                case "mnuDgFind":
                    this.StartFind();
                    break;
                case "mnuDgScriptInsert":
                    {
                        //ObjectCollection objCol = this.GetScriptVals();
                        //StringCollection lns = new StringCollection();
                        //lns.Add("INSERT INTO <choose table name>");
                        //lns.Add("(");
                        //for (int i = 0; i < objCol.Count; i++)
                        //    lns.Add(string.Format("\t{0}{1}", (i > 0) ? "," : " ", objCol.GetKey(i)));
                        //lns.Add(") VALUES (");
                        //for(int i=0;i<objCol.Count;i++)
                        //    lns.Add(string.Format("\t{0}{1}"
                        //this.txtQuery.AppendText(string.Join("\n", lns.GetFlatArray()));
                        //this.InvokeScriptInsert(objCol.GetFlatArray());
                    }
                    break;
                case "mnuDgScriptUpdate":
                    {
                        //ObjectCollection objCol = this.GetScriptVals();

                        //this.InvokeScriptUpdate(objCol.GetFlatArray());
                    }
                    break;
            }
        }
        private void frmFind_onFindNext(object sender, EventArgs e)
        {
            if (this._cntxMenu.SelectedCells.Count < 1)
            {
                MessageBox.Show(this.FindForm(), "You must select a column to search", "No Data");
                return;
            }
            else if (this._cntxMenu.SelectedCells.Count > 1)
            {
                MessageBox.Show(this.FindForm(), "Please select only one cell who's column you want to search on.", "No Data");
            }

            // There's only one cell selected, so search the column data.
            int y = this._cntxMenu.SelectedCells[0].RowIndex;
            int x = this._cntxMenu.SelectedCells[0].ColumnIndex;

            if (y == 0 && this._frmFind.SearchUp)
            {
                MessageBox.Show(this.FindForm(), "Already at top of grid.", "Can't Search");
                this._frmFind.Focus();
                return;
            }
            else if (y == this.RowCount - 1 && !this._frmFind.SearchUp)
            {
                MessageBox.Show(this.FindForm(), "Already at bottom of grid.", "Can't Search");
                this._frmFind.Focus();
                return;
            }

            if (this._frmFind.SearchScope == RainstormStudios.Forms.frmFindText.Scope.FromBeginning)
                y = 0;
            else if (this._frmFind.SearchScope == RainstormStudios.Forms.frmFindText.Scope.FromEnd)
                y = this.RowCount - 1;

            // Make sure the current cell doesn't already match, or we'll just sit here forever.
            //if (!string.IsNullOrEmpty(this._lastSrch) && this._cntxMenu.SelectedCells[0].Value.ToString() == this._frmFind.SearchText)
            if (this.CellValueMatch(this._cntxMenu, this._frmFind.MatchCase, y, x, this._frmFind.SearchText))
                if (this._frmFind.SearchUp)
                    y--;
                else
                    y++;

            // Determine the exact text to search for
            string srchTxt = this._frmFind.SearchText;
            if (!this._frmFind.MatchCase)
                srchTxt = srchTxt.ToLower();

            // Save the search parameters.
            this._lastSrch = this._frmFind.SearchText;

            // Do the search
            this._cntxMenu.ClearSelection();
            if (this._frmFind.SearchUp)
            {
                for (int i = y; i >= 0; i--)
                    if (this.CellValueMatch(this._cntxMenu, this._frmFind.MatchCase, i, x, srchTxt))
                        return;
            }
            else
            {
                for (int i = y; i < this._cntxMenu.RowCount; i++)
                    if (this.CellValueMatch(this._cntxMenu, this._frmFind.MatchCase, i, x, srchTxt))
                        return;
            }
            MessageBox.Show(this.FindForm(), "Specified value was not found.", "No Data");
            //this._cntxMenu.Rows[y].Cells[x].Selected = true;
            this._frmFind.Focus();
        }
        private void frmFind_onClose(object sender, FormClosedEventArgs e)
        {
            this._frmFind = null;
            this._lastSrch = string.Empty;
        }
        private void mnuDgSetClr_onClick(object sender, EventArgs e)
        {
            Color clr = Color.Empty;

            switch (((ToolStripMenuItem)sender).Text.ToLower())
            {
                case "red": clr = Color.LightCoral; break;
                case "orange": clr = Color.Moccasin; break;
                case "yellow": clr = Color.LemonChiffon; break;
                case "green": clr = Color.PaleGreen; break;
                case "blue": clr = Color.LightSteelBlue; break;
                case "purple": clr = Color.Thistle; break;
                case "more colors":
                    using (ColorDialog dlg = new ColorDialog())
                    {
                        dlg.AllowFullOpen = true;
                        dlg.AnyColor = true;
                        dlg.FullOpen = true;
                        dlg.SolidColorOnly = true;
                        if (dlg.ShowDialog(this.ParentForm) == DialogResult.OK)
                            clr = dlg.Color;
                    }
                    break;
            }

            if (clr != Color.Empty)
            {
                for (int i = 0; i < this._cntxMenu.SelectedCells.Count; i++)
                {
                    DataGridViewCellStyle style = this._cntxMenu.SelectedCells[i].Style;
                    style.BackColor = clr;
                    this._cntxMenu.SelectedCells[i].Style.ApplyStyle(style);
                }
            }
        }
        private void mnuDgAutoStyle_onClick(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "mnuAutoStyleAlt":
                    #region AutoStyle-Alternating
                    {
                        if (this.CurrentDataGrid != null)
                        {
                            DataGridViewCellStyle style = this.CurrentDataGrid.AlternatingRowsDefaultCellStyle;
                            style.BackColor = Color.LemonChiffon;
                            this.CurrentDataGrid.AlternatingRowsDefaultCellStyle.ApplyStyle(style);
                        }
                    }
                    #endregion
                    break;
                case "mnuAutoStyleBySeq":
                    #region AutoStyle-BySequence
                    {
                        if (this.CurrentDataGrid != null && this.CurrentDataGrid.SelectedCells.Count > 0)
                        {
                            Color clr = Color.Thistle;
                            List<int> selectedColumns = new List<int>();
                            for (int i = 0; i < this.CurrentDataGrid.SelectedCells.Count; i++)
                                if (!selectedColumns.Contains(this.CurrentDataGrid.SelectedCells[i].ColumnIndex))
                                    selectedColumns.Add(this.CurrentDataGrid.SelectedCells[i].ColumnIndex);
                            //int curCol = this.CurrentDataGrid.SelectedCells[0].ColumnIndex;
                            string lVal = string.Empty;
                            for (int r = 0; r < this.CurrentDataGrid.Rows.Count; r++)
                            {
                                //string cVal = Convert.ToString(this.CurrentDataGrid.Rows[r].Cells[curCol].Value).ToLower();
                                StringBuilder sbVal = new StringBuilder();
                                for (int i = 0; i < selectedColumns.Count; i++)
                                    sbVal.Append(Convert.ToString(this.CurrentDataGrid.Rows[r].Cells[selectedColumns[i]].Value).ToLower());
                                string cVal = sbVal.ToString();


                                if (cVal != lVal)
                                    switch (clr.Name)
                                    {
                                        case "LightSteelBlue":
                                            clr = Color.Moccasin; break;
                                        case "Moccasin":
                                            clr = Color.Thistle; break;
                                        case "Thistle":
                                            clr = Color.LightSteelBlue; break;
                                    }
                                lVal = cVal;
                                DataGridViewCellStyle style = this.CurrentDataGrid.Rows[r].DefaultCellStyle;
                                style.BackColor = clr;
                                this.CurrentDataGrid.Rows[r].DefaultCellStyle.ApplyStyle(style);
                            }
                        }
                    }
                    #endregion
                    break;
                case "mnuAutoStyleByVal":
                    #region AutoStyle-ByValue
                    {
                        if (this.CurrentDataGrid != null && this.CurrentDataGrid.SelectedCells.Count > 0)
                        {
                            if (this._cntxMenu == null)
                                return;
                            if (this._cntxMenu.SelectedCells.Count < 1)
                            {
                                MessageBox.Show(this.FindForm(), "You must select a column.", "Error");
                                return;
                            }
                            int colIdx = this._cntxMenu.SelectedCells[0].ColumnIndex;
                            int rowIdx = this._cntxMenu.CurrentCell.RowIndex;
                            using (frmClrByVal frm = new frmClrByVal(this._cntxMenu.SelectedCells[0].Value.ToString()))
                                if (frm.ShowDialog(this.FindForm()) == DialogResult.OK)
                                {
                                    for (int i = 0; i < this._cntxMenu.RowCount; i++)
                                    {
                                        bool match = false;
                                        if (frm.MatchCase)
                                            match = (this._cntxMenu[colIdx, i].Value.ToString() == frm.SearchValue);
                                        else
                                            match = (this._cntxMenu[colIdx, i].Value.ToString().ToLower() == frm.SearchValue.ToLower());

                                        if (match)
                                        {
                                            DataGridViewCellStyle style = this._cntxMenu[colIdx, i].Style;
                                            style.BackColor = frm.HighlightColor;
                                            this._cntxMenu[colIdx, i].Style.ApplyStyle(style);
                                        }
                                    }
                                }
                        }
                    }
                    #endregion
                    break;
                case "mnuAutoStyleHiLite":
                    #region AutoStyle-Highlight
                    {
                        if (this._cntxMenu == null)
                            return;
                        if (this._cntxMenu.SelectedCells.Count < 1)
                        {
                            MessageBox.Show(this.FindForm(), "You must select a column.", "Error");
                            return;
                        }
                        int colIdx = this._cntxMenu.SelectedCells[0].ColumnIndex;
                        StringCollection sCol = new StringCollection();
                        for (int i = 0; i < this._cntxMenu.Rows.Count; i++)
                        {
                            string cellVal = this._cntxMenu.Rows[i].Cells[colIdx].Value.ToString();
                            sCol.AddUnique(cellVal, cellVal);
                            //if (sCol.Count > ColorButton.ColorCount)
                            //{
                            //    MessageBox.Show(this.FindForm(), "Too many unique values found.", "Sorry");
                            //    sCol.Clear();
                            //    return;
                            //}
                        }
                        using (frmAutoHighlight frm = new frmAutoHighlight(sCol.ToArray()))
                        {
                            frm.StartPosition = FormStartPosition.CenterParent;
                            if (frm.ShowDialog(this.FindForm()) == DialogResult.OK)
                            {
                                for (int i = 0; i < sCol.Count; i++)
                                {
                                    sCol[i] = frm.GetColor(i).Name;
                                }
                                for (int i = 0; i < this._cntxMenu.Rows.Count; i++)
                                {
                                    DataGridViewCellStyle stl = new DataGridViewCellStyle();
                                    stl.BackColor = Color.FromName(sCol[this._cntxMenu.Rows[i].Cells[colIdx].Value.ToString()]);
                                    this._cntxMenu.Rows[i].DefaultCellStyle.ApplyStyle(stl);
                                }
                            }
                        }
                        sCol.Clear();
                    }
                    #endregion
                    break;
            }
        }
        private void execTimer_onTick(object sender, EventArgs e)
        {
            this.UpdateQueryTime(this.TimeTaken);
        }
        private void txtQuery_onTextChanged(object sender, EventArgs e)
        {
            this.OnQueryTextChanged();
        }
        private void txtQuery_SelectionChanged(object sender, EventArgs e)
        {
            this.OnQuerySelectionChanged();
        }
        private void txtQuery_onInsertModeChanged(object sender, EventArgs e)
        {
            this.OnQueryInsertModeChanged(e);
        }
        private void cmdConnStrBuilder_onClicked(object sender, EventArgs e)
        {
            this.OnNewConnectionButtonClick();
        }
        private void txtConnStr_onTextChanged(object sender, EventArgs e)
        {
            this.txtQuery.AutoCompleteConnectionString = this.txtConnStr.Text;
            this.txtQuery.AutoCompleteColumnNames = true;
            this.OnConnectionStringChanged();
        }
        private void drpConnType_onSelectedIndexChanged(object sender, EventArgs e)
        {
            this.OnConnectionTypeChanged();
        }
        //***************************************************************************
        // Event Overrides
        // 
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }
        //***************************************************************************
        // Event Triggers
        // 
        protected void OnConnectionStringChanged()
        {
            if (this.ConnectionStringChanged != null)
                this.ConnectionStringChanged.Invoke(this, EventArgs.Empty);
        }
        protected void OnConnectionTypeChanged()
        {
            if (this.ConnectionTypeChanged != null)
                this.ConnectionTypeChanged.Invoke(this, EventArgs.Empty);
        }
        protected void OnNewConnectionButtonClick()
        {
            if (this.NewConnectionButtonClick != null)
                this.NewConnectionButtonClick.Invoke(this, EventArgs.Empty);
        }
        protected void OnQueryTextChanged()
        {
            if (this.QueryTextChanged != null)
                this.QueryTextChanged.Invoke(this, EventArgs.Empty);
        }
        protected void OnQueryStart()
        {
            if (this.QueryStart != null)
                this.QueryStart.Invoke(this, EventArgs.Empty);
        }
        protected void OnQueryComplete()
        {
            if (this.QueryComplete != null)
                this.QueryComplete.Invoke(this, EventArgs.Empty);
        }
        protected void OnQueryAbort()
        {
            if (this.QueryAbort != null)
                this.QueryAbort.Invoke(this, EventArgs.Empty);
        }
        protected void OnQueryTextParsed()
        {
            if (this.QueryTextParsed != null)
                this.QueryTextParsed.Invoke(this, EventArgs.Empty);
        }
        protected void OnQuerySelectionChanged()
        {
            if (this.QuerySelectionChanged != null)
            {
                int iCr = this.txtQuery.SelectionStart,
                    iLn = this.txtQuery.GetLineFromCharIndex(iCr),
                    iCl = iCr - this.txtQuery.GetFirstCharIndexFromLine(iLn);
                this.QuerySelectionChanged.Invoke(this, new CaratPosChangedEventArgs(iCl, iCr, iLn));
            }
        }
        protected void OnCollapsedPanelChanged()
        {
            if (this.CollapsedPanelChanged != null)
                this.CollapsedPanelChanged.Invoke(this, EventArgs.Empty);
        }
        protected void OnScriptInsert(object[] vals)
        {
            if (this.ScriptInsert != null && vals != null)
                this.ScriptInsert.Invoke(this, new ScriptRecordEventArgs(vals));
        }
        protected void OnScriptUpdate(object[] vals)
        {
            if (this.ScriptUpdate != null && vals != null)
                this.ScriptUpdate.Invoke(this, new ScriptRecordEventArgs(vals));
        }
        protected void OnQueryInsertModeChanged(EventArgs e)
        {
            if (this.QueryInsertModeChanged != null)
                this.QueryInsertModeChanged.Invoke(this, e);
        }
        #endregion
    }
    internal class CaratPosChangedEventArgs : EventArgs
    {
        public readonly int
            Column,
            CharIndex,
            LineIndex;

        public CaratPosChangedEventArgs(int col, int chrIdx, int lnIdx)
            : base()
        {
            this.Column = col;
            this.CharIndex = chrIdx;
            this.LineIndex = lnIdx;
        }
    }
    internal class ScriptRecordEventArgs : EventArgs
    {
        public object[]
            Values;

        public ScriptRecordEventArgs(object[] vals)
            : base()
        {
            this.Values = vals;
        }
    }
}
