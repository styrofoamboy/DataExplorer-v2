using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer
{
    public partial class frmAutoHighlight : Form
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public int ColorCount
        {
            get { return this.flwColorAssign.Controls.Count / 2; }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        private frmAutoHighlight()
        {
            InitializeComponent();
        }
        public frmAutoHighlight(string[] values)
            : this()
        {
            this.PopulateFlowControl(values);
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private void PopulateFlowControl(string[] values)
        {
            try
            {
                Color clr = Color.LemonChiffon;
                this.flwColorAssign.SuspendLayout();
                foreach (string val in values)
                {
                    Label lbl = new Label();
                    lbl.AutoSize = false;
                    lbl.Name = "lbl" + val;
                    lbl.Text = val;
                    lbl.Width = (this.flwColorAssign.ClientSize.Width / 2) - 20;
                    lbl.Height = 20;
                    ColorButton btn = new ColorButton();
                    btn.Name = "btn" + val;
                    btn.Text = "";
                    btn.Width = (this.flwColorAssign.ClientSize.Width / 2) - 20;
                    btn.Height = 20;
                    switch (clr.Name)
                    {
                        case "LightSteelBlue":
                            clr = Color.Moccasin; break;
                        case "Moccasin":
                            clr = Color.Thistle; break;
                        case "Thistle":
                            clr = Color.LightCoral; break;
                        case "LightCoral":
                            clr = Color.LemonChiffon; break;
                        case "LemonChiffon":
                            clr = Color.LightSteelBlue; break;
                    }
                    btn.ButtonColor = clr;
                    this.flwColorAssign.Controls.Add(lbl);
                    this.flwColorAssign.Controls.Add(btn);
                }
                this.flwColorAssign.ResumeLayout(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("There was an error while trying to build the form.\n\n{0}\n\nPlease try again.", ex.Message), "Unexpected Error");
                this.Dispose();
            }
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public Color GetColor(int idx)
        {
            Control ctrl = this.flwColorAssign.Controls[(idx * 2) + 1];
            return ((ColorButton)ctrl).ButtonColor;
        }
        #endregion
    }
}