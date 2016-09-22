using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Data;
using RainstormStudios;
using RainstormStudios.Data;
using RainstormStudios.Collections;

namespace DataExplorer
{
    internal struct Connection
    {
        #region Declarations
        //***************************************************************************
        // Public Fields
        // 
        public static readonly Connection
            Empty;
        public string
            ConnectionString,
            Name;
        public AdoProviderType
            DatabaseProvider;
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public Connection(string nm, string cnStr, AdoProviderType provId)
        {
            this.ConnectionString = cnStr;
            this.Name = nm;
            this.DatabaseProvider = provId;
        }
        #endregion
    }
    internal class ConnectionCollection : ObjectCollectionBase<Connection>
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public new Connection this[int index]
        {
            get { return (Connection)base[index]; }
            set { base[index] = value; }
        }
        public new Connection this[string key]
        {
            get { return (Connection)base[key]; }
            set { base[key] = value; }
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public string Add(Connection value)
        { return base.Add(value, ""); }
        public void Add(Connection value, string key)
        { base.Add(value, key); }
        public string Insert(int index, Connection value)
        { return base.Insert(index, value, ""); }
        public void Insert(int index, Connection value, string key)
        { base.Insert(index, value, key); }
        public void Remove(Connection value)
        { base.RemoveAt(base.IndexOf(value)); }
        public void Update(Connection value, string key)
        {
            if (this.ContainsKey(key))
                this[key] = value;
            else
                this.Add(value, key);
        }
        #endregion
    }
    internal struct GlobalVariable
    {
        #region Declarations
        //***************************************************************************
        // Public Methods
        // 
        public static readonly GlobalVariable
            Empty;
        public string
            VariableName,
            VariableValue;
        public SqlDbType
            VariableType;
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public GlobalVariable(string varName, SqlDbType varType, string varValue)
        {
            this.VariableName = varName;
            this.VariableType = varType;
            this.VariableValue = varValue;
        }
        #endregion
    }
    internal class GlobalVariableCollection : ObjectCollectionBase<GlobalVariable>
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public new GlobalVariable this[int index]
        {
            get { return (GlobalVariable)base[index]; }
            set { base[index] = value; }
        }
        public new GlobalVariable this[string key]
        {
            get { return (GlobalVariable)base[key]; }
            set { base[key] = value; }
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public string Add(GlobalVariable value)
        { return base.Add(value, ""); }
        public void Add(GlobalVariable value, string key)
        { base.Add(value, key); }
        public string Insert(int index, GlobalVariable value)
        { return base.Insert(index, value, ""); }
        public void Insert(int index, GlobalVariable value, string key)
        { base.Insert(index, value, key); }
        public void Remove(GlobalVariable value)
        { base.RemoveAt(base.IndexOf(value)); }
        public void Update(GlobalVariable value, string key)
        {
            if (this.ContainsKey(key))
                this[key] = value;
            else
                this.Add(value, key);
        }
        #endregion
    }
    internal struct ProjectNote
    {
        #region Declarations
        //***************************************************************************
        // Public Fields
        // 
        public static readonly ProjectNote
            Empty;
        public string
            Subject,
            Body;
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public ProjectNote(string noteSubj, string noteBody)
        {
            this.Subject = noteSubj;
            this.Body = noteBody;
        }
        #endregion
    }
    internal class ProjectNoteCollection : ObjectCollectionBase<ProjectNote>
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public new ProjectNote this[int index]
        {
            get { return (ProjectNote)base[index]; }
            set { base[index] = value; }
        }
        public new ProjectNote this[string key]
        {
            get { return (ProjectNote)base[key]; }
            set { base[key] = value; }
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public string Add(ProjectNote value)
        { return base.Add(value, DateTime.Now.ToString("yyyyMMddHHmmss")); }
        public void Add(ProjectNote value, string key)
        { base.Add(value, key); }
        public string Insert(int index, ProjectNote value)
        { return base.Insert(index, value, DateTime.Now.ToString("yyyyMMddHHmmss")); }
        public void Insert(int index, ProjectNote value, string key)
        { base.Insert(index, value, key); }
        public void Remove(ProjectNote value)
        { base.RemoveAt(base.IndexOf(value)); }
        public void Remove(string key)
        { base.RemoveByKey(key); }
        public void Update(ProjectNote newValue, string key)
        {
            if (this.ContainsKey(key))
                this[key] = newValue;
            else
                this.Add(newValue, key);
        }
        #endregion
    }
    [Serializable]
    internal struct DataPanelDragCapsule
    {
        #region Declarations
        //***************************************************************************
        // Public Fields
        // 
        public readonly string
            PanelName,
            ConnectionString;
        public readonly string[]
            QueryString;
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Contructors
        // 
        public DataPanelDragCapsule(string panNm, string connStr, string[] qryStr)
        {
            this.PanelName = panNm;
            this.ConnectionString = connStr;
            this.QueryString = qryStr;
        }
        public DataPanelDragCapsule(string serializedData)
        {
            int iPName = serializedData.IndexOf(";|p:") + 4,
                iCnStr = serializedData.IndexOf(";|c:", iPName) + 4,
                iQyStr = serializedData.IndexOf(";|q:", iCnStr) + 4;

            // Verify the structure of the incoming data string.
            if (!serializedData.StartsWith("t:dpdc;|p:") || iPName < 6 || iCnStr < iPName || iQyStr < iCnStr)
                throw new ArgumentException("Serialized data was not in the expected format.");

            this.PanelName = serializedData.Substring(iPName, iCnStr - iPName - 4);
            this.ConnectionString = serializedData.Substring(iCnStr, iQyStr - iCnStr - 4);
            this.QueryString = serializedData.Substring(iQyStr, serializedData.Length - iQyStr).Split(new char[] { '\n' }, StringSplitOptions.None);
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public string Serialize()
        {
            return "t:dpdc;|p:" + PanelName + ";|c:" + ConnectionString + ";|q:" + string.Join("\n", QueryString);
        }
        #endregion
    }
    internal class DataPanelPrefs
    {
        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        public bool
            FillNullCells;
        public Color
            SqlKeywordColor = Color.Empty,
            SqlFunctionColor = Color.Empty,
            SqlLiteralColor = Color.Empty,
            SqlCommentColor = Color.Empty,
            SqlAliasColor = Color.Empty,
            SqlGlobalVarColor = Color.Empty;
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public bool AllDefault
        {
            get
            {
                return this.FillNullCells &&
                          this.SqlAliasColor == Color.Empty &&
                          this.SqlCommentColor == Color.Empty &&
                          this.SqlFunctionColor == Color.Empty &&
                          this.SqlGlobalVarColor == Color.Empty &&
                          this.SqlKeywordColor == Color.Empty &&
                          this.SqlLiteralColor == Color.Empty;
            }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public DataPanelPrefs()
            : this(true)
        { }
        public DataPanelPrefs(bool fillNulls)
        {
            this.FillNullCells = fillNulls;
        }
        public DataPanelPrefs(Color sqlKeyword, Color sqlFunc, Color sqlLiteral, Color sqlComment, Color sqlAlias, Color sqlGlobalVar)
            : this(sqlKeyword, sqlFunc, sqlLiteral, sqlComment, sqlAlias, sqlGlobalVar, true)
        { }
        public DataPanelPrefs(Color sqlKeyword, Color sqlFunc, Color sqlLiteral, Color sqlComment, Color sqlAlias, Color sqlGlobalVar, bool fillNulls)
            :this(fillNulls)
        {
            this.SqlKeywordColor = sqlKeyword;
            this.SqlFunctionColor = sqlFunc;
            this.SqlCommentColor = sqlComment;
            this.SqlAliasColor = sqlAlias;
            this.SqlLiteralColor = sqlLiteral;
            this.SqlGlobalVarColor = sqlGlobalVar;
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public void SetDefault()
        {
            this.FillNullCells = true;
            this.SqlAliasColor =
                this.SqlCommentColor =
                this.SqlFunctionColor =
                this.SqlGlobalVarColor =
                this.SqlKeywordColor =
                this.SqlLiteralColor = Color.Empty;
        }
        #endregion
    }
}
