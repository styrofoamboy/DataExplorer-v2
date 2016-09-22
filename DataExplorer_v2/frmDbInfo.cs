using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer
{
    public partial class frmDbInfo : Form
    {
        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        private frmDbInfo()
        {
            InitializeComponent();
        }
        public frmDbInfo(DataSet ds)
            : this()
        {
            this.PopulateGrid(ds);
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private void PopulateGrid(DataSet ds)
        {
            object dbInfo = dbInfoGenerator.GetDbInfo(ds);
            if (dbInfo != null)
            {
                for (int i = 0; i < ds.Tables.Count; i++)
                    for (int j = 0; j < ds.Tables[i].Columns.Count; j++)
                    {
                        Type tdbInfo = dbInfo.GetType();
                        System.Reflection.FieldInfo fldInfo = tdbInfo.GetField("_" + ds.Tables[i].Columns[j].ColumnName.ToLower());
                        if (fldInfo != null)
                        {
                            fldInfo.SetValue(dbInfo, ds.Tables[i].Rows[0][j].ToString());
                        }
                    }
                this.prgdDbInfo.SelectedObject = dbInfo;
            }
            else
            {
                MessageBox.Show(this.Owner, "Unable to generated database info class.", "Unexpected Error");
                //this.Close();
            }
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Base-Class Overrides
        // 
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.prgdDbInfo.SelectedObject == null)
                this.Close();
        }
        #endregion
    }
}