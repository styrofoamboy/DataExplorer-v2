using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer
{
    public partial class frmVarEdit : Form
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public string VariableName
        {
            get { return this.txtVarName.Text; }
            set { this.txtVarName.Text = value; }
        }
        public string VariableValue
        {
            get { return this.txtVarValue.Text; }
            set { this.txtVarValue.Text = value; }
        }
        public SqlDbType VariableType
        {
            get { return this.sqlDataTypeList1.SelectedType; }
            set { this.sqlDataTypeList1.SelectedType = value; }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public frmVarEdit()
        {
            InitializeComponent();
        }
        public frmVarEdit(string varName, SqlDbType varType, string varVal)
            : this()
        {
            this.txtVarName.Text = varName;
            this.sqlDataTypeList1.SelectedType = varType;
            this.txtVarValue.Text = varVal;
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        //
        public void SelectVarName()
        {
            this.txtVarName.Focus();
            this.txtVarName.SelectAll();
        }
        public void SelectVarValue()
        {
            this.txtVarValue.Focus();
            this.txtVarValue.SelectAll();
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Overrides
        // 
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.sqlDataTypeList1.SelectedIndex < 0)
                this.sqlDataTypeList1.SelectedType = System.Data.SqlDbType.VarChar;

            if (!string.IsNullOrEmpty(this.txtVarName.Text))
            {
                this.txtVarValue.Focus();
                this.txtVarValue.SelectAll();
            }
        }
        #endregion
    }
}