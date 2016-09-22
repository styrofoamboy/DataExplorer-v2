using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer
{
    public partial class frmTemplateVars : Form
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public bool[] BoolValues
        { get { return this.GetBoolArray(); } }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        private frmTemplateVars()
        {
            InitializeComponent();
        }
        internal frmTemplateVars(GlobalVariableCollection varCol)
            : this()
        {
            for (int i = 0; i < varCol.Count; i++)
                this.lstVars.Items.Add(varCol[i].VariableName);
        }
        internal frmTemplateVars(string[] panelNames)
            : this(panelNames, "Please Choose Items to Include")
        { }
        internal frmTemplateVars(string[] panelNames, string windowTitle)
            : this()
        {
            this.Text = windowTitle;
            for (int i = 0; i < panelNames.Length; i++)
                this.lstVars.Items.Add(panelNames[i]);
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private bool[] GetBoolArray()
        {
            // Create an array of Boolean values.
            bool[] bVals = new bool[this.lstVars.Items.Count];
            // Set all Booleans to their default value (false).
            bVals.Initialize();
            // Set all checked indices to 'True'.
            for (int i = 0; i < this.lstVars.CheckedIndices.Count; i++)
                bVals[this.lstVars.CheckedIndices[i]] = true;
            return bVals;
        }
        #endregion
    }
}