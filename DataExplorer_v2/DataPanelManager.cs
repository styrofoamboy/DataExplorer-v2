using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using RainstormStudios;
using RainstormStudios.Collections;
using RainstormStudios.Controls;

namespace DataExplorer
{
    class DataPanelManager:IDisposable
    {
        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        private string
            _panNm,
            _colKey;
        private StringCollection
            _msgLog;
        private DataQueryPanel
            _qryPan;
        //***************************************************************************
        // Public Fields
        // 
        public int
            ID,
            ConnID;
        public AdvancedButton
            TabButton;
        public AnimWidgetRotator
            AnimWidget;
        public Panel
            TabPanel;
        public ContextMenuStrip
            PanelMenuStrip,
            TabMenuStrip;
        public TimeSpan
            ActiveTime;
        public bool
            InProcess,
            Parsed;
        public Timer
            ExecTimer;
        //***************************************************************************
        // Public Events
        // 
        public event EventHandler MessageAdded;
        public event EventHandler PanelNameChanged;
        public event EventHandler CollectionKeyChanged;
        public event EventHandler ConnectionChanged;
        public event EventHandler QueryChanged;
        public event EventHandler TimerElapsed;
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public string LastMessage
        {
            get
            {
                return (this._msgLog.Count > 0)
                        ? this._msgLog[this._msgLog.Count - 1]
                        : "";
            }
        }
        public int MessageCount
        { get { return this._msgLog.Count; } }
        public string PanelName
        {
            get { return this.TabButton.Text; }
            set
            {
                this.TabButton.Text = value;
                this.PanelNameChangedEvent();
            }
        }
        public string CollectionKey
        {
            get { return this._colKey; }
            set
            {
                this._colKey = value;
                this.CollectionKeyChangedEvent();
            }
        }
        public DataQueryPanel QueryPanel
        {
            get { return this._qryPan; }
            set
            {
                this._qryPan = value;
                this._qryPan.QueryTextParsed += new EventHandler(_qryPan_QueryTextParsed);
            }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public DataPanelManager(int id, string key, string name, Panel tabPan, AdvancedButton tab, AnimWidgetRotator anim, DataQueryPanel qryPanel, ContextMenuStrip mnuPanel, ContextMenuStrip mnuTabButton)
        {
            this.ID = id;
            this._colKey = key;
            this._panNm = name;
            this.TabPanel = tabPan;
            this.TabButton = tab;
            this.AnimWidget = anim;
            this.QueryPanel = qryPanel;
            this.TabMenuStrip = mnuTabButton;
            this.PanelMenuStrip = mnuPanel;
            this._msgLog = new StringCollection();
            this.QueryPanel.QueryStart += new EventHandler(this.DataPanel_onQueryExecStart);
            this.QueryPanel.QueryComplete += new EventHandler(this.DataPanel_onQueryExecStop);
            this.QueryPanel.QueryTextChanged += new EventHandler(this.DataPanel_onQueryChanged);
            this.QueryPanel.ConnectionTypeChanged += new EventHandler(this.DataPanel_onConnectionTypeChanged);
            this.QueryPanel.ConnectionStringChanged += new EventHandler(this.DataPanel_onConnectionStringChanged);
            this.QueryPanel.SetOwner(this);
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        //
        public void Dispose()
        {
            if (this._qryPan != null)
                this._qryPan.Dispose();
            if (this.TabButton != null)
                this.TabButton.Dispose();
            if (this.AnimWidget != null)
                this.AnimWidget.Dispose();
            if (this.PanelMenuStrip != null)
                this.PanelMenuStrip.Dispose();
            if (this.TabMenuStrip != null)
                this.TabMenuStrip.Dispose();
            if (this.TabPanel != null)
                this.TabPanel.Dispose();
            if (this.ExecTimer != null)
                this.ExecTimer.Dispose();
            this.ActiveTime = TimeSpan.MinValue;
            this._panNm = string.Empty;
            this._colKey = string.Empty;
            this._msgLog.Clear();
        }
        public void AddLogMessage(string msg)
        {
            this._msgLog.Add(msg);
            this.QueryPanel.UpdateStatusText(msg);
            this.MessageAddedEvent();
        }
        public string GetMessage(int id)
        {
            if (id < 0 || id > this._msgLog.Count)
                throw new ArgumentOutOfRangeException("id", "Index value must be greater than zero and less than the size of the array.");

            return this._msgLog[id];
        }
        public string[] GetLog()
        {
            return this._msgLog.ToArray();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void DataPanel_onConnectionStringChanged(object sener, EventArgs e)
        {
            this.ConnectionChangedEvent();
        }
        private void DataPanel_onConnectionTypeChanged(object sender, EventArgs e)
        {
            this.ConnectionChangedEvent();
        }
        private void DataPanel_onQueryChanged(object sender, EventArgs e)
        {
            this.QueryChangedEvent();
        }
        private void DataPanel_onQueryExecStart(object sender, EventArgs e)
        {
            this.InProcess = true;
            this.ExecTimer = new Timer();
            this.ExecTimer.Interval = 1000;
            this.ExecTimer.Tick += new EventHandler(this.timer_onTick);
            this.ExecTimer.Start();
        }
        private void DataPanel_onQueryExecStop(object sender, EventArgs e)
        {
            this.ExecTimer.Stop();
            this.ExecTimer.Dispose();
            this.InProcess = false;
        }
        private void timer_onTick(object sender, EventArgs e)
        {
            this.ActiveTime = this.ActiveTime.Add(new TimeSpan(0, 0, 0, 1));
            this.TimerElapsedEvent();
        }
        private void _qryPan_QueryTextParsed(object sender, EventArgs e)
        {
            this.Parsed = true;
        }
        //***************************************************************************
        // Event Triggers
        // 
        private void MessageAddedEvent()
        {
            if (this.MessageAdded != null)
                this.MessageAdded.Invoke(this, EventArgs.Empty);
        }
        private void PanelNameChangedEvent()
        {
            if (this.PanelNameChanged != null)
                this.PanelNameChanged.Invoke(this, EventArgs.Empty);
        }
        private void CollectionKeyChangedEvent()
        {
            if (this.CollectionKeyChanged != null)
                this.CollectionKeyChanged.Invoke(this, EventArgs.Empty);
        }
        private void ConnectionChangedEvent()
        {
            if (this.ConnectionChanged != null)
                this.ConnectionChanged.Invoke(this, EventArgs.Empty);
        }
        private void QueryChangedEvent()
        {
            if (this.QueryChanged != null)
                this.QueryChanged.Invoke(this, EventArgs.Empty);
        }
        private void TimerElapsedEvent()
        {
            if (this.TimerElapsed != null)
                this.TimerElapsed.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region Operator Overloads
        //***************************************************************************
        // Operator Overloads
        //
        public static bool operator ==(DataPanelManager val1, DataPanelManager val2)
        { return object.ReferenceEquals(val1, val2); }
        public static bool operator !=(DataPanelManager val1, DataPanelManager val2)
        { return !(val1 == val2); }
        #endregion
    }
    class DataPanelManagerCollection : RainstormStudios.Collections.ObjectCollectionBase<DataPanelManager>
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public new DataPanelManager this[int index]
        {
            get { return (DataPanelManager)base[index]; }
            set { base[index] = value; }
        }
        public new DataPanelManager this[string key]
        {
            get { return (DataPanelManager)base[key]; }
            set { base[key] = value; }
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public string Add(DataPanelManager dpMan)
        { return base.Add(dpMan, ""); }
        public void Add(DataPanelManager dpMan, string key)
        { base.Add(dpMan, key); }
        public string Insert(int index, DataPanelManager dpMan)
        { return base.Insert(index, dpMan, ""); }
        public void Insert(int index, DataPanelManager dpMan, string key)
        { base.Insert(index, dpMan, key); }
        #endregion
    }
}
