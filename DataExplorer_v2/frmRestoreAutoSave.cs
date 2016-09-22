using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer
{
    public partial class frmRestoreAutoSave : Form
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public frmRestoreAutoSave()
        {
            InitializeComponent();
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public void LoadFiles(System.IO.FileInfo[] files)
        {
            this.lstFiles.SuspendLayout();
            try
            {
                for (int i = 0; i < files.Length; i++)
                {
                    RadioButton rdo = new RadioButton();
                    rdo.AutoSize = true;
                    rdo.Name = string.Format("rdo_{0}", i);
                    rdo.Tag = files[i].FullName;
                    rdo.TextAlign = ContentAlignment.MiddleLeft;
                    rdo.Text = string.Format("{0} - {1}", files[i].LastWriteTime, files[i].Name);
                    this.lstFiles.Controls.Add(rdo);
                }
            }
            finally
            { this.lstFiles.ResumeLayout(true); }
        }
        public string GetSelectedFile()
        {
            for (int i = 0; i < this.lstFiles.Controls.Count; i++)
            {
                var ctrl = (this.lstFiles.Controls[i] as RadioButton);
                if (ctrl == null)
                    continue;

                if (ctrl.Checked)
                    return ctrl.Tag.ToString();
            }
            return string.Empty;
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.Close();
        }
        #endregion

    }
}
