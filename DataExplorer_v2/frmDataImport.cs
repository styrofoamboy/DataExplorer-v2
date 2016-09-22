using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer
{
    public partial class frmDataImport : Form
    {
        #region Declarations
        //***************************************************************************
        // Priate Fields
        // 
        private bool
            _switching = false;
        private int
            _curPanel;
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public DestinationPanel DataDestination
        {
            get { return this.destinationPanel1; }
        }
        public SourcePanel DataSource
        {
            get { return this.sourcePanel1; }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        private frmDataImport()
        {
            InitializeComponent();
        }
        public frmDataImport(System.Data.Common.DbConnection conn)
            : this()
        {
        }
        public frmDataImport(RainstormStudios.Data.rsDb dst, string dbName)
            : this(dst.DbConnection)
        {
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private void ShowErrMsg(string msg)
        {
            this.panErrMsgLbl.Text = msg;
            this.panErrMsg.Visible = true;
            this.panErrMsg.BringToFront();
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void cmdNext_onClick(object sender, EventArgs e)
        {
            this._switching = true;
            this.panErrMsg.Visible = false;
            switch (this._curPanel)
            {
                case 0:         // Welcome screen
                    this.pan01.Visible = false;
                    this.cmdBack.Enabled = true;
                    this.sourcePanel1.Visible = true;
                    break;
                case 1:         // DataSource
                    //if (string.IsNullOrEmpty(this.pan02txtFlatSrcFileName.Text))
                    //{ this.ShowErrMsg("You must specify a file name."); return; }
                    this.sourcePanel1.Visible = false;
                    this.destinationPanel1.Visible = true;
                    break;
                case 2:         // Destination
                    //pan03.Visible = true;
                    this.destinationPanel1.Visible = false;
                    this.cmdFinished.Enabled = true;
                    break;
                case 3:         // Column Mappings
                    //pan03.Visible = true;
                    //pan04.Visible = false;
                    this.cmdNext.Enabled = false;
                    break;
            }
            this._curPanel++;
            this._switching = false;
            this.Refresh();
        }
        private void cmdBack_onClick(object sender, EventArgs e)
        {
            this._switching = true;
            this.panErrMsg.Visible = false;
            switch (this._curPanel)
            {
                case 0:
                    // The button should be disabled at this point, so
                    //   this event code should never be reached.
                    return;
                case 1:
                    this.cmdBack.Enabled = false;
                    this.pan01.Visible = true;
                    this.sourcePanel1.Visible = false;
                    break;
                case 2:
                    this.destinationPanel1.Visible = false;
                    this.sourcePanel1.Visible = true;
                    break;
                case 3:
                    this.destinationPanel1.Visible = true;
                    break;
                case 4:
                    this.cmdNext.Enabled = true;
                    break;
            }
            this._curPanel--;
            this._switching = false;
            this.Refresh();
        }
        private void cmdHelp_onClick(object sender, EventArgs e)
        {
        }
        private void cmdErrMsgClose_onClick(object sender, EventArgs e)
        {
            this.panErrMsg.Visible = false;
        }
        #endregion

        #region Base-Class Overrides
        //***************************************************************************
        // Base-Class Overrides
        // 
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (this.DialogResult == DialogResult.Cancel
                && MessageBox.Show(this, "Are you sure you want to cancel the data importer wizard?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                e.Cancel = true; ;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (!_switching)
                base.OnPaint(e);
        }
        #endregion
    }
}