using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer
{
    public partial class frmClrByVal : Form
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public string SearchValue
        {
            get { return this.txtValue.Text; }
            set { this.txtValue.Text = value; }
        }
        public bool MatchCase
        {
            get { return this.chkMatchCase.Checked; }
            set { this.chkMatchCase.Checked = value; }
        }
        public Color HighlightColor
        {
            get { return this.colorButton1.ButtonColor; }
            set { this.colorButton1.ButtonColor = value; }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public frmClrByVal()
        {
            InitializeComponent();
        }
        public frmClrByVal(string initVal)
            : this()
        {
            this.txtValue.Text = initVal;
        }
        #endregion
    }
}