using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using IBM.Data.DB2;
using System.Collections.Generic;
using System.Text;
using RainstormStudios.Data;

namespace DataExplorer
{
    delegate void RecordReadEventHandler(object sender, RecordReadEventArgs e);
    delegate void ResultStartedEventHandler(object sender, ResultStartedEventArgs e);
    class DataQuery
    {
        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        private DateTime
            _asyncStart,
            _asyncEnd;
        //private DataSet
        //    _dtResult;
        private Exception
            _abortEx;
        //private rsDb
        //    _db;
        private int
            _timeOut = 0;
        private bool
            _isExec = false,
            _abort = false;
        private AdoProviderType
            _dbType;
        private string
            _cnStr,
            _qrStr;
        //***************************************************************************
        // Thread Delegates
        // 
        private delegate void ExecuteQueryDelegate(AdoProviderType dbType, string cnStr, string qrStr, int timeOut);
        //***************************************************************************
        // Event Definitions
        //
        public event EventHandler ExecuteStarted;
        public event EventHandler ExecuteStopped;
        public event EventHandler ExecuteAbort;
        public event RecordReadEventHandler RecordProcessed;
        public event ResultStartedEventHandler ResultStart;
        public event EventHandler ResultComplete;
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        //
        //public DataSet ASyncResult
        //{ get { return this._dtResult; } }
        public AdoProviderType Provider
        { get { return this._dbType; } }
        //{ get { return this._db.ProviderType; } }
        public DateTime ASyncStart
        { get { return this._asyncStart; } }
        public DateTime ASyncEnd
        { get { return this._asyncEnd; } }
        public string QueryString
        {
            //get { return this._db.QueryString; }
            //set { this._db.QueryString = value; }
            get { return this._qrStr; }
            set { this._qrStr = value; }
        }
        public string ConnectionString
        {
            //get { return this._db.ConnectionString; }
            //set { this._db.ConnectionString = value; }
            get { return this._cnStr; }
            set { this._cnStr = value; }
        }
        public Exception AbortException
        { get { return this._abortEx; } }
        public int CommandTimeout
        {
            get { return this._timeOut; }
            set { this._timeOut = value; }
        }
        //public IsolationLevel TransactionIsolationLevel
        //{ get { return this._db.DbCommand.Transaction.IsolationLevel; } }
        public bool IsExecuting
        { get { return this._isExec; } }
        //***************************************************************************
        // Private Properties
        // 
        //internal rsDb BaseConnection
        //{ get { return this._db; } }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public DataQuery(AdoProviderType provider, string connString, string qryString)
        {
            //this._db = rsDb.GetDbObject(provider, connString, qryString);
            this._dbType = provider;
            this._cnStr = connString;
            this._qrStr = qryString;
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public void Dispose()
        {
            //this._db.Dispose();
        }
        public void ExecuteQuery()
        {
            //this.DoQueryExec(this._db);
            this.DoQueryExec(this._dbType, this._cnStr, this._qrStr, this._timeOut);
        }
        public void BeginExecuteQuery()
        {
            ExecuteQueryDelegate del = new ExecuteQueryDelegate(this.DoQueryExec);
            //del.BeginInvoke(this._db, new AsyncCallback(this.BeginExecuteQueryCallback), del);
            del.BeginInvoke(this._dbType, this._cnStr, this._qrStr, this._timeOut, new AsyncCallback(this.BeginExecuteQueryCallback), del);
        }
        public void AbortExecute()
        {
            this._abort = true;
            //if (this._db != null)
            //    this._db.AbortExecution();
        }
        //public void BeginTransaction(IsolationLevel isoLvl)
        //{
        //    this._db.DbConnection.BeginTransaction(isoLvl);
        //}
        //public void RollbackTransaction()
        //{
        //    this._db.DbCommand.Transaction.Rollback();
        //}
        //public void CommitTransaction()
        //{
        //    this._db.DbCommand.Transaction.Commit();
        //}
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        //private void DoQueryExec(rsDb dataObj)
        private void DoQueryExec(AdoProviderType dbType, string cnStr, string qrStr, int timeOut)
        {
            this._abort = false;
            this._isExec = true;
            this.ExecuteStartedEvent();
            this._abortEx = null;

            // Create an rsDb object to handle our database interface.
            using (rsDb dataObj = rsDb.GetDbObject(dbType, cnStr, qrStr))
            {
                // We set the connection's timeout here. By default, this value is
                //   set to 'Zero' (meaning no timeout).
                dataObj.DbCommand.CommandTimeout = timeOut;


                // We use the 'keepReading' value to determine if the statement
                //   returns multiple result sets.
                bool keepReading = true;
                try
                {
                    // Performing the call to 'Prepare' ensures there are no syntax errors
                    //  before actually executing a batch of statements. This also helps
                    //  to speed execution slightly.
                    dataObj.DbCommand.Prepare();
                    dataObj.InitReader();

                    // Loop through each result set.
                    while (keepReading && !this._abort)
                    {
                        int idx = 0;
                        DataTable dtNew = dataObj.DataReader.GetSchemaTable().Clone();
                        this.ResultStartEvent(dtNew);
                        while (dataObj.DataReader.Read())
                        {
                            DataRow drNew = dtNew.NewRow();
                            dataObj.DataReader.GetValues(drNew.ItemArray);
                            this.RecordProcessedEvent(drNew.ItemArray, idx);
                        }
                        this.ResultCompleteEvent();
                        keepReading = dataObj.DataReader.NextResult();
                    }
                }
                catch (Exception ex)
                {
                    this._abortEx = ex;
                    this.ExecuteAbortEvent();
                    return;
                }
                finally
                {
                    dataObj.CloseReader();
                    this._isExec = false;
                }
            }
        }
        private void BeginExecuteQueryCallback(IAsyncResult state)
        {
            ExecuteQueryDelegate del = (ExecuteQueryDelegate)state.AsyncState;
            //this._dtResult = del.EndInvoke(state);
            del.EndInvoke(state);
            this.ExecuteStoppedEvent();
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Triggers
        //
        public void ExecuteStartedEvent()
        {
            this._asyncStart = DateTime.Now;
            if (this.ExecuteStarted != null)
                this.ExecuteStarted.Invoke(this, EventArgs.Empty);
        }
        public void ExecuteStoppedEvent()
        {
            this._asyncEnd = DateTime.Now;
            if (this.ExecuteStopped != null)
                this.ExecuteStopped.Invoke(this, EventArgs.Empty);
        }
        public void ExecuteAbortEvent()
        {
            if (this.ExecuteAbort != null)
                this.ExecuteAbort.Invoke(this, EventArgs.Empty);
        }
        public void RecordProcessedEvent(object[] vals, int idx)
        {
            if (this.RecordProcessed != null)
                this.RecordProcessed.Invoke(this, new RecordReadEventArgs(idx, vals));
        }
        public void ResultStartEvent(DataTable schema)
        {
            if (this.ResultStart != null)
                this.ResultStart.Invoke(this, new ResultStartedEventArgs(schema));
        }
        public void ResultCompleteEvent()
        {
            if (this.ResultComplete != null)
                this.ResultComplete.Invoke(this, EventArgs.Empty);
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
