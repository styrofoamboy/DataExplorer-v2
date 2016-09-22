using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer
{
    public partial class DestinationPanel : UserControl
    {
        #region Properties
        //***************************************************************************
        // Private Properties
        // 
        internal ctrlDataTarget DataTarget
        { get { return this.dataTarget; } }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public DestinationPanel()
        {
            InitializeComponent();
        }
        #endregion
    }
}
