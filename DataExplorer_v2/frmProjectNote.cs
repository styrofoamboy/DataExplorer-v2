using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer
{
    public partial class frmProjectNote : Form
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        internal ProjectNote Note
        {
            get { return new ProjectNote(this.txtSubject.Text, this.txtNote.Text); }
        }
        internal string Subject
        { get { return this.txtSubject.Text; } }
        internal string Body
        { get { return this.txtNote.Text; } }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public frmProjectNote()
        {
            InitializeComponent();
        }
        public frmProjectNote(string subject, string note)
            : this()
        {
            this.txtSubject.Text = subject;
            this.txtNote.Text = note;
        }
        #endregion
    }
}