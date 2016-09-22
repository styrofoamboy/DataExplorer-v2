using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer
{
    public partial class frmDateCalc : Form
    {
        #region Declarations
        //***************************************************************************
        // Public Fields
        // 
        public string ResultString
        {
            get { return txtResult.Text; }
        }
        public int ResultNumeric
        {
            get
            {
                if (tabPanel.SelectedIndex == 0)
                    throw new Exception("Cannot retrieve numeric value from DateTime calculation.");
                return int.Parse(txtResult.Text);
            }
        }
        public DateTime ResultDateTime
        {
            get
            {
                if (tabPanel.SelectedIndex == 1)
                    throw new Exception("Cannot retrieve DateTime value from numeric calculation.");
                return Convert.ToDateTime(txtResult.Text);
            }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public frmDateCalc()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private void SetMaxTime()
        {
            TimeSpan tsSpan = new TimeSpan(DateTime.Now.Ticks - dtN2DBase.Value.Ticks);
            if (rdoN2DSeconds.Checked)
                numAddTime.Maximum = (decimal)tsSpan.TotalSeconds;
            else
                numAddTime.Maximum = (decimal)tsSpan.TotalMilliseconds;
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // User Control Event Handlers
        // 
        private void tabPanel_onSelectedIndexChanged(object sender, EventArgs e)
        {
            txtResult.Clear();
        }
        private void cmdCalc_onClick(object sender, EventArgs e)
        {
            if (tabPanel.SelectedIndex == 0)
            {
                if (rdoN2DSeconds.Checked)
                    txtResult.Text = dtN2DBase.Value.AddSeconds((double)numAddTime.Value).ToString("dddd, MMMM dd, yyyy");
                else
                    txtResult.Text = dtN2DBase.Value.AddMilliseconds((double)numAddTime.Value).ToString("dddd, MMMM dd, yyyy");
            }
            else
            {
                string strNumeric = "";
                if (rdoD2NSeconds.Checked)
                    strNumeric = new TimeSpan(dtD2NEnd.Value.Ticks - dtD2NBase.Value.Ticks).TotalSeconds.ToString();
                else
                    strNumeric = new TimeSpan(dtD2NEnd.Value.Ticks - dtD2NBase.Value.Ticks).TotalMilliseconds.ToString();
                if (strNumeric.IndexOf('.') > -1)
                    strNumeric = strNumeric.Substring(0, strNumeric.IndexOf('.'));
#if DEBUG
                Console.WriteLine("Unparsed result: " + strNumeric);
#endif
                string strParsed = ""; int i;
                for (i = strNumeric.Length; i > -1; i = i - 3)
                    if (i >= 0)
                        strParsed = strNumeric.Substring(i, 3) + "," + strParsed;
                    else
                        strParsed = strNumeric.Substring(0, 3 - Math.Abs(i)) + "," + strParsed;
                if (i > 0)
                    strParsed = strNumeric.Substring(0, i);
                txtResult.Text = strParsed;
            }
        }
        private void userCtrl_onCritialValueChanged(object sender, EventArgs e)
        {
            txtResult.Clear();
            SetMaxTime();
        }
        //***************************************************************************
        // Event Handlers
        // 
        private void frmDateCalc_onLoad(object sender, EventArgs e)
        {
            SetMaxTime();
        }
        #endregion
    }
}