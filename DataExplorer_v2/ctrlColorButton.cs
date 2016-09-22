using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using RainstormStudios.Drawing;

namespace DataExplorer
{
    class ColorButton : RainstormStudios.Controls.AdvancedButton
    {
        #region Nested Types
        //***************************************************************************
        // Nested Enums
        // 
        public enum DropMenuColors : int
        {
            Moccasin,
            Thistle,
            LightSteelBlue,
            LightCoral,
            LemonChiffon,
            PaleGreen,
            Lavender,
            LightCyan,
            LightSlateGray,
            IndianRed,
            HotPink,
            Fuchsia
        }
        #endregion

        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        //private static readonly Color[]
        //    DropMenuColors = new Color[]{
        //            Color.Moccasin,
        //            Color.Thistle,
        //            Color.LightSteelBlue,
        //            Color.LightCoral,
        //            Color.LemonChiffon,
        //            Color.PaleGreen,
        //            Color.Lavender,
        //            Color.LightCyan,
        //            Color.LightSlateGray,
        //            Color.IndianRed,
        //            Color.HotPink,
        //            Color.Fuchsia
        //    };
        private Color
            _clr;
        private ContextMenuStrip
            _mnu;
        //***************************************************************************
        // Static Fields
        // 
        private static Color[]
            _mnuClrs = null;
        private static RainstormStudios.Collections.BitmapCollection
            _bmpCol;
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public Color ButtonColor
        {
            get { return this._clr; }
            set { this._clr = value; }
        }
        public static int ColorCount
        {
            get { return ColorButton.MenuColors.Length; }
            //get { return Enum.GetNames(typeof(ColorButton.DropMenuColors)).Length; } }
            //get { return ColorButton.DropMenuColors.Length; } }
        }
        //***************************************************************************
        // Private Properties
        // 
        private static Color[] MenuColors
        {
            get
            {
                if (ColorButton._mnuClrs == null)
                    ColorButton._mnuClrs = ColorButton.GetMenuColors();

                return ColorButton._mnuClrs;
            }
        }
        private static RainstormStudios.Collections.BitmapCollection MenuColorBmps
        {
            get
            {
                if (ColorButton._bmpCol == null)
                    ColorButton.BuildBitmapCollection();

                return ColorButton._bmpCol;
            }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public ColorButton()
            : base()
        {
            this.ContextMenuStrip = this.BuildMenu();
        }
        ~ColorButton()
        {
            // Make sure we kill off all the little color squares we created
            //   for the drop-down menu.
            if (ColorButton._bmpCol != null)
                for (int i = 0; i < ColorButton._bmpCol.Count; i++)
                    ColorButton._bmpCol[i].Dispose();
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private new void Dispose()
        {
            if (this._mnu != null)
                this._mnu.Dispose();

            // Call the base dispose.
            base.Dispose(true);
        }
        private GraphicsPath GetTriangle()
        {
            GraphicsPath rg = new GraphicsPath(FillMode.Winding);
            int r = this.Width - this.CornerFeather,
                h = ((this.Height - (this.CornerFeather * 2)) / 2) + this.CornerFeather;
            rg.AddLines(new Point[]{
                    new Point(r - 14, h - 5), 
                    new Point(r, h - 5),
                    new Point(r - 7, h + 5),
                    new Point(r - 14, h - 5) });
            return rg;
        }
        private Color GetColorObj(object value)
        { return (Color)value; }
        private ContextMenuStrip BuildMenu()
        {
            if (this._mnu != null)
                this._mnu.Dispose();

            //this._bmpCol = new BitmapCollection();
            this._mnu = new ContextMenuStrip();
            //Color[] drpMenuClr = this.GetMenuColors();
            Color[] drpMenuClr = ColorButton.MenuColors;
            for (int i = 0; i < drpMenuClr.Length; i++)
            {
                //Bitmap bmp = new Bitmap(20, 20);
                //this._bmpCol.Add(bmp, drpMenuClr[i].Name);
                //using (Graphics g = Graphics.FromImage(bmp))
                //{
                //    g.Clear(drpMenuClr[i]);
                //    g.DrawRectangle(Pens.Black, 0, 0, 20, 20);
                //    g.DrawLines(Pens.Black, new Point[] { new Point(0, 20), new Point(0, 0), new Point(19, 0) });
                //}
                Bitmap bmp = ColorButton.MenuColorBmps[drpMenuClr[i].Name];
                this._mnu.Items.Add(drpMenuClr[i].Name, bmp, new EventHandler(this.mnu_onClick));
            }
            return this._mnu;
        }
        //***************************************************************************
        // Static Methods
        // 
        private static Color[] GetMenuColors()
        {
            //return DropMenuColors;

            List<Color> retValue = new List<Color>();
            Type clrType = typeof(System.Drawing.Color);
            System.Reflection.PropertyInfo[] props = clrType.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            for (int i = 0; i < props.Length; i++)
                retValue.Add(Color.FromName(props[i].Name));

            return retValue.ToArray();
        }
        private static void BuildBitmapCollection()
        {
            if (ColorButton._bmpCol != null)
                for (int i = 0; i < ColorButton._bmpCol.Count; i++)
                    ColorButton._bmpCol[i].Dispose();

            ColorButton._bmpCol = new RainstormStudios.Collections.BitmapCollection();
            Color[] drpMnuClrs = ColorButton.MenuColors;
            for (int i = 0; i < drpMnuClrs.Length; i++)
            {
                Bitmap bmp = new Bitmap(20, 20);
                ColorButton._bmpCol.Add(bmp, drpMnuClrs[i].Name);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(drpMnuClrs[i]);
                    g.DrawRectangle(Pens.Black, 0, 0, 20, 20);
                    g.DrawLines(Pens.Black, new Point[] { new Point(0, 20), new Point(0, 0), new Point(19, 0) });
                }
            }
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void mnu_onClick(object sender, EventArgs e)
        {
            this._clr = Color.FromName(((ToolStripMenuItem)sender).Text);
            this.Refresh();
        }
        //***************************************************************************
        // Event Overrides
        // 
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.Text = "";
            base.OnPaint(pevent);

            // Draw the rectangle of color.
            Rectangle r = new Rectangle((this.CornerFeather * 2), (this.CornerFeather * 2), 0, 0);
            r.Width = this.Width - (this.CornerFeather * 4) - 20;
            r.Height = this.Height - (this.CornerFeather * 4);
            using (SolidBrush brush = new SolidBrush(this._clr))
                pevent.Graphics.FillRectangle(brush, r);
            pevent.Graphics.DrawRectangle(Pens.Black, r);
            using (GraphicsPath gp = this.GetTriangle())
                pevent.Graphics.FillPath(Brushes.Black, gp);
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this._mnu.Show(this, new Point(0, this.Height));
        }
        #endregion
    }
}
