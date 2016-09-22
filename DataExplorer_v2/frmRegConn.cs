using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer
{
    public partial class frmRegConn : Form
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public string ConnectionName
        {
            get { return this.txtConnName.Text; }
            set { this.txtConnName.Text = value; }
        }
        public string ConnectionString
        {
            get { return this.connectionStringBox1.ConnectionString; }
            set { this.connectionStringBox1.ConnectionString = value; }
        }
        public RainstormStudios.Data.AdoProviderType ProviderType
        {
            get { return this.connectionStringBox1.ProviderID; }
            set { this.connectionStringBox1.ProviderID = value; }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        //
        public frmRegConn()
        {
            InitializeComponent();
        }
        public frmRegConn(string connName, string connStr, RainstormStudios.Data.AdoProviderType provId)
            :this()
        {
            this.txtConnName.Text = connName;
            this.connectionStringBox1.ConnectionString = connStr;
            this.connectionStringBox1.ProviderID = provId;
        }
        #endregion
    }
}