using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Text;
using RainstormStudios.Data;

namespace DataExplorer
{
    delegate void RecordReadEventHandler(object sender, RecordReadEventArgs e);
    delegate void ResultStartedEventHandler(object sender, ResultStartedEventArgs e);
    class DataQuery : IDisposable
    {
        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        private DateTime
            _asyncStart,
            _asyncEnd;
        private DataSet
            _dtResult;
        private Exception
            _abortEx;
        private rsDb
            _db;
        private int
            _timeOut = 0,
            _recAffected;
        private bool
            _isExec;
        public string
            _connStr,
            _qryStr;
        public AdoProviderType
            _provType;
        public List<string>
            _msgs;
        //***************************************************************************
        // Thread Delegates
        // 
        //private delegate DataSet ExecuteQueryDelegate(rsDb dataObj);
        private delegate DataSet ExecuteQueryDelegate(string connStr, string qryStr, AdoProviderType provType);
        //***************************************************************************
        // Event Definitions
        // 
        public event EventHandler ExecuteStarted;
        public event EventHandler ExecuteStopped;
        public event EventHandler ExecuteAbort;
        //public event RecordReadEventHandler RecordProcessed;
        //public event ResultStartedEventHandler ResultStart;
        //public event EventHandler ResultComplete;
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public DataSet ASyncResult
        { get { return this._dtResult; } }
        public AdoProviderType Provider
        {
            get
            {
                return (this._db == null)
                    ? this._provType
                    : this._db.ProviderType;
            }
        }
        public DateTime ASyncStart
        { get { return this._asyncStart; } }
        public DateTime ASyncEnd
        { get { return this._asyncEnd; } }
        public string QueryString
        {
            get
            {
                return (this._db == null)
                    ? this._qryStr
                    : this._db.QueryString;
            }
            set
            {
                this._qryStr = value;
                if (this._db != null)
                    this._db.QueryString = value;
            }
        }
        public string ConnectionString
        {
            get
            {
                return (this._db == null)
                    ? this._connStr
                    : this._db.ConnectionString;
            }
            set
            {
                this._connStr = value;
                if (this._db != null)
                    this._db.ConnectionString = value;
            }
        }
        public Exception AbortException
        { get { return this._abortEx; } }
        public int CommandTimeout
        { get { return this._timeOut; } set { this._timeOut = value; } }
        public IsolationLevel TransactionIsolationLevel
        {
            get
            {
                return (this._db != null)
                    ? this._db.DbCommand.Transaction.IsolationLevel
                    : System.Data.IsolationLevel.Unspecified;
            }
        }
        public bool IsExecuting
        { get { return this._isExec; } }
        public int RecordsAffected
        { get { return this._recAffected; } }
        //***************************************************************************
        // Private Properties
        // 
        internal rsDb BaseConnection
        { get { return this._db; } }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        private DataQuery()
        {
            this._msgs = new List<string>();
        }
        public DataQuery(AdoProviderType provider, string connString, string qryString)
            : this()
        {
            //this._provider = provider;
            //this._cnStr = connString;
            //this._qry = qryString;
            //this._db = rsDb.GetDbObject(provider, connString, qryString);
            this._provType = provider;
            this._connStr = connString;
            this._qryStr = qryString;
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public void Dispose()
        {
            if (this._dtResult != null)
                this._dtResult.Dispose();
            if (this._db != null)
                this._db.Dispose();
        }
        public string CheckSyntax()
        {
            try
            {
                return this._db.PrepareCommand();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public DataSet ExecuteQuery()
        {
            //return this.DoQueryExec(this._db);
            return this.DoQueryExec(this._connStr, this._qryStr, this._provType);
        }
        public void BeginExecuteQuery()
        {
            ExecuteQueryDelegate del = new ExecuteQueryDelegate(this.DoQueryExec);
            //del.BeginInvoke(this._db, new AsyncCallback(this.BeginExecuteQueryCallback), del);
            del.BeginInvoke(this._connStr, this._qryStr, this._provType, new AsyncCallback(this.BeginExecuteQueryCallback), del);
        }
        public void AbortExecute()
        {
            if (this._db != null)
                this._db.AbortExecution();
        }
        public void RollbackTransaction()
        { this.RollbackTransaction(string.Empty); }
        public void RollbackTransaction(string tranName)
        {
            if (this._db.DbCommand != null && this._db.DbCommand.Transaction != null)
                this._db.DbCommand.Transaction.Rollback();
            else
                this._db.ExecuteNonQuery("ROLLBACK TRANSACTION" + ((!string.IsNullOrEmpty(tranName)) ? " " + tranName : ""));
        }
        public void CommitTransaction()
        { this.CommitTransaction(string.Empty); }
        public void CommitTransaction(string tranName)
        {
            if (this._db.DbCommand != null && this._db.DbCommand.Transaction != null)
                this._db.DbCommand.Transaction.Commit();
            else
                this._db.ExecuteNonQuery("COMMIT TRANSACTION" + ((!string.IsNullOrEmpty(tranName)) ? " " + tranName : ""));
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        //private DataSet DoQueryExec(rsDb dataObj)
        private DataSet DoQueryExec(string connStr, string qryString, AdoProviderType provId)
        {
            rsDb dataObj = null;
            this.RaiseExecuteStarted();
            this._abortEx = null;
            this._dtResult = null;
            this._recAffected = 0;
            DataSet retVal = null;

            try
            {
                if (this._db == null || this._db.ConnectionString != connStr || this._db.QueryString != qryString)
                {
                    if (this._db != null)
                        this._db.Dispose();

                    dataObj = rsDb.GetDbObject(provId, connStr, qryString);
                    dataObj.DbCommand.CommandTimeout = this._timeOut;
                    this._db = dataObj;
                }

                retVal = new DataSet();
                this._recAffected = dataObj.GetData(ref retVal);

                return retVal;
            }
            catch (Exception ex)
            {
                this._abortEx = ex;
                this.RaiseExecuteAbortEvent();
                return null;
            }
            //finally
            //{
            //    if (dataObj != null)
            //        dataObj.Dispose();
            //}
        }
        private void BeginExecuteQueryCallback(IAsyncResult state)
        {
            ExecuteQueryDelegate del = (ExecuteQueryDelegate)state.AsyncState;
            this._dtResult = del.EndInvoke(state);
            this.RaiseExecuteStopped();
        }
        #endregion

        #region Event Triggers
        //***************************************************************************
        // Event Triggers
        // 
        protected void RaiseExecuteStarted()
        {
            this._asyncStart = DateTime.Now;
            this._isExec = true;
            if (this.ExecuteStarted != null)
                this.ExecuteStarted.Invoke(this, EventArgs.Empty);
        }
        protected void RaiseExecuteStopped()
        {
            this._asyncEnd = DateTime.Now;
            this._isExec = false;
            if (this.ExecuteStopped != null)
                this.ExecuteStopped.Invoke(this, EventArgs.Empty);
        }
        protected void RaiseExecuteAbortEvent()
        {
            if (this.ExecuteAbort != null)
                this.ExecuteAbort.Invoke(this, EventArgs.Empty);
        }
        #endregion
    }
    class RecordReadEventArgs : EventArgs
    {
        public readonly
            object[] FieldValues;
        public readonly
            int RowIndex;

        public RecordReadEventArgs(int idx, object[] vals)
        {
            this.RowIndex = idx;
            this.FieldValues = vals;
        }
    }
    class ResultStartedEventArgs : EventArgs
    {
        public readonly
            DataTable SchemaTable;

        public ResultStartedEventArgs(DataTable schTbl)
        { this.SchemaTable = schTbl; }
    }
}
