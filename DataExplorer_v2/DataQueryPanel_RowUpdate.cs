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

namespace DataExplorer
{
    internal delegate void CaratPosChangedEventHandler(object sender, CaratPosChangedEventArgs e);
    partial class DataQueryPanel : RainstormStudios.Controls.RsUserControlBase
    {
        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        const Keys
            NonPrintable = Keys.Add | Keys.Alt | Keys.Apps | Keys.Attn | Keys.Back | Keys.BrowserBack | Keys.BrowserFavorites | Keys.BrowserForward
                        | Keys.BrowserHome | Keys.BrowserRefresh | Keys.BrowserSearch | Keys.BrowserStop | Keys.Cancel | Keys.Capital | Keys.CapsLock
                        | Keys.Clear | Keys.Control | Keys.ControlKey | Keys.Crsel | Keys.Down | Keys.End | Keys.Escape | Keys.Exsel | Keys.F1 | Keys.F10
                        | Keys.F11 | Keys.F12 | Keys.F13 | Keys.F14 | Keys.F15 | Keys.F16 | Keys.F17 | Keys.F18 | Keys.F19 | Keys.F2 | Keys.F20 | Keys.F21
                        | Keys.F22 | Keys.F23 | Keys.F24 | Keys.F3 | Keys.F4 | Keys.F5 | Keys.F6 | Keys.F7 | Keys.F8 | Keys.F9 | Keys.FinalMode
                        | Keys.IMEAccept | Keys.IMEConvert | Keys.IMEModeChange | Keys.IMENonconvert | Keys.Insert | Keys.JunjaMode
                        | Keys.KanaMode | Keys.KanjiMode | Keys.LaunchApplication1 | Keys.LaunchApplication2 | Keys.LaunchMail | Keys.LButton
                        | Keys.LControlKey | Keys.Left | Keys.LineFeed | Keys.LMenu | Keys.LShiftKey | Keys.LWin | Keys.MButton | Keys.MediaNextTrack
                        | Keys.MediaPlayPause | Keys.MediaPreviousTrack | Keys.MediaStop | Keys.Menu | Keys.Next | Keys.None | Keys.PageDown
                        | Keys.PageUp | Keys.Pause | Keys.Play | Keys.Print | Keys.PrintScreen | Keys.Prior | Keys.ProcessKey | Keys.RButton
                        | Keys.RControlKey | Keys.Right | Keys.RMenu | Keys.RShiftKey | Keys.RWin | Keys.Scroll | Keys.Select | Keys.SelectMedia
                        | Keys.Shift | Keys.ShiftKey | Keys.Sleep | Keys.Snapshot | Keys.VolumeDown | Keys.VolumeMute | Keys.VolumeUp
                        | Keys.XButton1 | Keys.XButton2 | Keys.Zoom;
        public static readonly TimeSpan
            EmptyTimespan = new TimeSpan(0);
        private DataQuery
            _dataQry;
        private StringCollection
            _undo;
        private NumberedDataGridView
            _cntxMenu,
            _lastCreated;
        private Control
            _createParent;
        private bool
            _isDisposing = false,
            _dataError = false;
        private int
            _rowCount;
        private Timer
            _execTimer;
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
        public event CaratPosChangedEventHandler QuerySelectionChanged;
        public event EventHandler CollapsedPanelChanged;
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
        { get { return this._dataQry.ASyncResult; } }
        public int RowCount
        { get { return this._rowCount; } }
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
        { get { return (this._dataQry != null) ? ((DateTime)((this._dataQry.IsExecuting) ? this._dataQry.ASyncEnd : DateTime.Now)).Subtract(this._dataQry.ASyncStart) : DataQueryPanel.EmptyTimespan; } }
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
        { get { return this._cntxMenu; } }
        public Exception QueryException
        { get { return this._dataQry.AbortException; } }
        public bool HasData
        { get { return (this._dataQry != null && this.splQuery.Panel2.Controls.Count > 0 && ((NumberedDataGridView)((SplitContainer)this.splQuery.Panel2.Controls[0]).Panel1.Controls[0]).Rows.Count > 0); } }
        public string StatusMessage
        {
            get { return this.statusLabelGeneral.Text; }
            set { RainstormStudios.CrossThreadUI.SetPropertyValue(this.statusLabelGeneral, "Text", value); }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public DataQueryPanel()
        {
            InitializeComponent();
            this._undo = new StringCollection();
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
            string[] qryStr;
            if (this.txtQuery.SelectedText.Length > 0)
                qryStr = this.txtQuery.SelectedText.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            else
                qryStr = this.txtQuery.Lines;

            string qry = string.Empty;
            if (vars != null)
                for (int i = 0; i < vars.Count; i++)
                    qry += string.Format("DECLARE @{0} {1} SET @{0} = {2} ", vars[i].VariableName, vars[i].VariableType, vars[i].VariableValue);
            this._dataQry = new DataQuery(this.DatabaseProvider, this.ConnectionString, qry + rsData.DeCommentQuery(qryStr));
            this._dataQry.ExecuteStarted += new EventHandler(this.dataQuery_onExecuteStart);
            this._dataQry.ExecuteStopped += new EventHandler(this.dataQuery_onExecuteStopped);
            this._dataQry.ExecuteAbort += new EventHandler(this.dataQuery_onExecuteAbort);
            //this._dataQry.ResultStart += new ResultStartedEventHandler(this.dataQuery_onResultStart);
            //this._dataQry.ResultComplete += new EventHandler(this.dataQuery_onResultComplete);
            //this._dataQry.RecordProcessed += new RecordReadEventHandler(this.dataQuery_onRecordProcessed);
            this._dataQry.BeginExecuteQuery();
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
            RainstormStudios.CrossThreadUI.SetPropertyValue(this.statusLabelGeneral, "Text", msg);
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
                this.DisposeAllControls(this.splQuery.Panel2.Controls);
                RainstormStudios.CrossThreadUI.SetPropertyValue(this.splQuery, "Panel2Collapsed", true);
                this.InvokeCollapsedPanelChanged();
            }
        }
        private void GetSum()
        {
        }
        private void SetClipboard(NumberedDataGridView ndgv)
        {
            string cbData = string.Empty;
            int rowIdx = -1;
            for (int i = 0; i < ndgv.SelectedCells.Count; i++)
            {
                DataGridViewCell cl = ndgv.SelectedCells[i];
                cbData += ((cl.RowIndex != rowIdx) ? "\n" : "\t") + cl.Value.ToString();
                rowIdx = cl.RowIndex;
            }
            Clipboard.SetData(System.Windows.Forms.DataFormats.UnicodeText, cbData.TrimStart('\n'));
        }
        private void UpdateQueryTime(TimeSpan time)
        {
            CrossThreadUI.SetPropertyValue(this.statusLabelTime, "Text", string.Format("{0}:{1}:{2}", time.Hours.ToString().PadLeft(2, '0'), time.Minutes.ToString().PadLeft(2, '0'), time.Seconds.ToString().PadLeft(2, '0')));
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
            CrossThreadUI.SetPropertyValue(this.splQuery, "Panel2Collapsed", false);
            this._createParent = this.splQuery.Panel2;
            this.InvokeCollapsedPanelChanged();
            this.DestroyDatasource();
            this._execTimer = new Timer();
            this._execTimer.Interval = 500;
            this._execTimer.Tick += new EventHandler(execTimer_onTick);
            this._execTimer.Start();
            this.InvokeQueryStart();
        }
        private void dataQuery_onExecuteStopped(object sender, EventArgs e)
        {
            this._execTimer.Stop();
            this._execTimer.Dispose();
            CrossThreadUI.SetEnabled(this.txtQuery, true);
            CrossThreadUI.SetEnabled(this.panConn, true);
            this.UpdateQueryTime(this.TimeTaken);
            this._dataQry.Dispose();
        }
        private void dataQuery_onExecuteAbort(object sender, EventArgs e)
        {
            this.InvokeQueryAbort();
        }
        private void dataQuery_onResultStart(object sender, ResultStartedEventArgs e)
        {
            NumberedDataGridView ndgv = new NumberedDataGridView();
            ndgv.Name = e.SchemaTable.TableName;
            ndgv.Dock = DockStyle.Fill;
            ndgv.AllowUserToAddRows = false;
            ndgv.AllowUserToDeleteRows = false;
            ndgv.AllowUserToOrderColumns = true;
            ndgv.AllowUserToResizeColumns = true;
            ndgv.AllowUserToResizeRows = false;
            ndgv.ContextMenuStrip = this.mnuDg;
            ndgv.DataError += new DataGridViewDataErrorEventHandler(ndgv_DataError);
            ndgv.MouseEnter += new EventHandler(ndgv_MouseEnter);
            ndgv.MouseDown += new MouseEventHandler(ndgv_MouseDown);
            for (int c = 0; c < e.SchemaTable.Columns.Count; c++)
                ndgv.Columns.Add(e.SchemaTable.Columns[c].ColumnName, e.SchemaTable.Columns[c].ColumnName);
            ndgv.ReadOnly = true;
            this._lastCreated = ndgv;
        }
        private void dataQuery_onResultComplete(object sender, EventArgs e)
        {
            SplitContainer splData = new SplitContainer();
            splData.Orientation = Orientation.Horizontal;
            splData.Dock = DockStyle.Fill;
            splData.SplitterDistance = this.splQuery.Panel2.ClientRectangle.Height / 3;
            splData.Panel1.Controls.Add(this._lastCreated);
            CrossThreadUI.InvokePropertyMethod(this._createParent, "Controls", "Add", splData);
            this._createParent = splData;
        }
        private void dataQuery_onRecordProcessed(object sender, RecordReadEventArgs e)
        {
            this._lastCreated.Rows.Add(e.FieldValues);
        }
        private void ndgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // This gets thrown when certain rare types of invalid data is loaded.
            //   The control will actually pop-up a dialog box indicating the error
            //   for each and every row that it tries to draw the bad data on, so
            //   we definitely want to supress that. At some point, I need to
            //   implement a means of logging specific fields which contain data
            //   that the DataGridView was unable to render.
            e.ThrowException = false;
            this._dataError = true;
        }
        private void ndgv_MouseEnter(object sender, EventArgs e)
        {
            // We do this so that when a ContxtMenu item is click, we can tell which
            //   datagrid was the last one the mouse was hovering over.
            this._cntxMenu = (NumberedDataGridView)sender;
        }
        private void ndgv_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this._cntxMenu.ClearSelection();
                DataGridView.HitTestInfo hitTest = this._cntxMenu.HitTest(e.X,e.Y);
                DataGridViewCell cell = this._cntxMenu.Rows[hitTest.RowIndex].Cells[hitTest.ColumnIndex];
                cell.Selected = true;
            }
        }
        private void mnuDg_Opening(object sender, CancelEventArgs e)
        {
            bool isDataSel = (this._cntxMenu != null && this._cntxMenu.SelectedCells.Count > 0);
            this.mnuDgBgStyle.Enabled = isDataSel;
            this.mnuDgCopy.Enabled = isDataSel;
            this.mnuDgPrint.Enabled = isDataSel;
            this.mnuDgSum.Enabled = isDataSel;
            this.mnuAutoStyleByVal.Enabled = isDataSel;
        }
        private void mnuDg_onClick(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "mnuDgCopy":
                    this.SetClipboard(this._cntxMenu);
                    break;
                case "mnuDgSelectAll":
                    this._cntxMenu.SelectAll();
                    break;
                case "mnuAutoStyleAlt":
                    break;
                case "mnuAutoStyleByVal":
                    break;
                case "mnuDgSum":
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
                    break;
                case "mnuDgClearStyle":
                    this.Refresh();
                    break;
                case "mnuDgSaveData":
                    MessageBox.Show(this.ParentForm, "This feature is not yet implemented.", "Sorry");
                    break;
                case "mnuDgPgSetup":
                    MessageBox.Show(this.ParentForm, "This feature is not yet implemented.", "Sorry");
                    break;
                case "mnuDgPrint":
                    MessageBox.Show(this.ParentForm, "This feature is not yet implemented.", "Sorry");
                    break;
            }
        }
        private void execTimer_onTick(object sender, EventArgs e)
        {
            this.UpdateQueryTime(this.TimeTaken);
        }
        private void txtQuery_SelectionChanged(object sender, EventArgs e)
        {
            this.InvokeQuerySelectionChanged();
        }
        //***************************************************************************
        // Event Triggers
        // 
        private void InvokeConnectionStringChanged()
        {
            if (this.ConnectionStringChanged != null)
                this.ConnectionStringChanged.Invoke(this, EventArgs.Empty);
        }
        private void InvokeConnectionTypeChanged()
        {
            if (this.ConnectionTypeChanged != null)
                this.ConnectionTypeChanged.Invoke(this, EventArgs.Empty);
        }
        private void InvokeNewConnectionButtonClick()
        {
            if (this.NewConnectionButtonClick != null)
                this.NewConnectionButtonClick.Invoke(this, EventArgs.Empty);
        }
        private void InvokeQueryTextChanged()
        {
            if (this.QueryTextChanged != null)
                this.QueryTextChanged.Invoke(this, EventArgs.Empty);
        }
        private void InvokeQueryStart()
        {
            if (this.QueryStart != null)
                this.QueryStart.Invoke(this, EventArgs.Empty);
        }
        private void InvokeQueryComplete()
        {
            if (this.QueryComplete != null)
                this.QueryComplete.Invoke(this, EventArgs.Empty);
        }
        private void InvokeQueryAbort()
        {
            if (this.QueryAbort != null)
                this.QueryAbort.Invoke(this, EventArgs.Empty);
        }
        private void InvokeQuerySelectionChanged()
        {
            if (this.QuerySelectionChanged != null)
            {
                int iCr = this.txtQuery.SelectionStart,
                    iLn = this.txtQuery.GetLineFromCharIndex(iCr),
                    iCl = iCr - this.txtQuery.GetFirstCharIndexFromLine(iLn);
                this.QuerySelectionChanged.Invoke(this, new CaratPosChangedEventArgs(iCl, iCr, iLn));
            }
        }
        private void InvokeCollapsedPanelChanged()
        {
            if (this.CollapsedPanelChanged != null)
                this.CollapsedPanelChanged.Invoke(this, EventArgs.Empty);
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
        {
            this.Column = col;
            this.CharIndex = chrIdx;
            this.LineIndex = lnIdx;
        }
    }
}
