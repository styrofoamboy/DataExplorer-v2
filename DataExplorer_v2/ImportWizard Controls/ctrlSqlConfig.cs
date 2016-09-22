using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer.ImportWizard_Controls
{
    public partial class ctrlSqlConfig : UserControl
    {
        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        private WizardDataTarget
            _tgtType;
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public string ServerName
        {
            get { return this.cboSqlServerName.Text; }
            set { this.cboSqlServerName.Text = value; }
        }
        public bool WindowsAuthentication
        {
            get { return this.rdoWinAuth.Checked; }
            set
            {
                this.rdoWinAuth.Checked = value;
                this.rdoSqlAuth.Checked = !value;
            }
        }
        public string LoginName
        {
            get { return this.txtSqlAuthUser.Text; }
        }
        public string LoginPassword
        {
            get { return this.txtSqlAuthPass.Text; }
        }
        public string DatabaseName
        {
            get { return this.sqlDatabaseList.SelectedText; }
            set
            {
                if (this.sqlDatabaseList.Items.Contains(value))
                    this.sqlDatabaseList.SelectedItem = value;
                else
                    this.sqlDatabaseList.SelectedIndex = 0;
            }
        }
        public WizardDataTarget TargetType
        {
            get { return this._tgtType; }
            set
            {
                if (this._tgtType != value)
                {
                    this.sqlDatabaseList.Items.Clear();
                    this._tgtType = value;
                    if (this._tgtType != WizardDataTarget.Microsoft_OLEDB_Provider_for_SQL && this._tgtType != WizardDataTarget.SQL_Native_Client)
                    {
                        this.rdoSqlAuth.Checked = true;
                        this.rdoWinAuth.Enabled = false;
                    }
                    else if (!this.rdoWinAuth.Enabled)
                        this.rdoWinAuth.Enabled = true;
                }
            }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public ctrlSqlConfig()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private void SetComboBoxConn()
        {
            StringBuilder sb = new StringBuilder();
            if (this._tgtType.ToString().Contains("OLEDB"))
            {
                sb.Append("Provider=");
                switch (this._tgtType)
                {
                    case WizardDataTarget.Microsoft_OLEDB_Provider_for_SQL:
                        sb.Append("SQLOLEDB");
                        break;
                    case WizardDataTarget.Microsoft_OLEDB_Provider_for_Oracle:
                        sb.Append("MSDAORA");
                        break;
                    case WizardDataTarget.Microsoft_OLEDB_Provider_for_OLAP_Services:
                        sb.Append("MSOLAP");
                        break;
                }
                sb.Append(";");
            }

            sb.Append("Data Source=" + this.cboSqlServerName.Text + ";");
            sb.Append("Initial Catalog=master;");

            if (this.rdoWinAuth.Checked)
                sb.Append("Integrated Security=SSPI;");
            else
            {
                sb.Append("User ID=" + this.txtSqlAuthUser.Text + ";");
                sb.Append("Password=" + this.txtSqlAuthPass.Text + ";");
            }

            if (this._tgtType == WizardDataTarget.Microsoft_OLEDB_Provider_for_OLAP_Services)
                sb.Append("Client Cache Size=25;Auto Synch Period=10000;");

            this.sqlDatabaseList.ConnectionString = sb.ToString();
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void cboSqlServerName_TextUpdate(object sender, EventArgs e)
        {
            this.SetComboBoxConn();
        }
        private void rdoSqlAuth_CheckedChanged(object sender, EventArgs e)
        {
            this.panSqlAuth.Enabled = (this.rdoSqlAuth.Checked);
            this.SetComboBoxConn();
        }
        private void txtSqlAuth_TextChanged(object sender, EventArgs e)
        {
            this.SetComboBoxConn();
        }
        private void cmdRefreshSqlDatabaseList_onClick(object sender, EventArgs e)
        {
            this.sqlDatabaseList.ResetList();
        }
        #endregion
    }
}
