using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer
{
    public partial class frmPrefs : Form
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public Color SqlKeywordColor
        {
            get { return this.clrBtnKeyword.ButtonColor; }
            set { this.clrBtnKeyword.ButtonColor = value; }
        }
        public Color SqlLiteralColor
        {
            get { return this.clrBtnLiteral.ButtonColor; }
            set { this.clrBtnLiteral.ButtonColor = value; }
        }
        public Color SqlFunctionColor
        {
            get { return this.clrBtnFunction.ButtonColor; }
            set { this.clrBtnFunction.ButtonColor = value; }
        }
        public Color SqlAliasColor
        {
            get { return this.clrBtnAlias.ButtonColor; }
            set { this.clrBtnAlias.ButtonColor = value; }
        }
        public Color SqlGlobalVariableColor
        {
            get { return this.clrBtnGlobalVar.ButtonColor; }
            set { this.clrBtnGlobalVar.ButtonColor = value; }
        }
        public Color SqlCommentColor
        {
            get { return this.clrBtnComment.ButtonColor; }
            set { this.clrBtnComment.ButtonColor = value; }
        }
        public bool FillNullCells
        {
            get { return this.chkFillNull.Checked; }
            set { this.chkFillNull.Checked = value; }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public frmPrefs()
        {
            InitializeComponent();
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        internal DataPanelPrefs GetSettings()
        {
            return new DataPanelPrefs(
                (this.SqlKeywordColor == Color.Transparent) ? Color.Empty : this.SqlKeywordColor,
                (this.SqlFunctionColor == Color.Transparent) ? Color.Empty : this.SqlFunctionColor,
                (this.SqlLiteralColor == Color.Transparent) ? Color.Empty : this.SqlLiteralColor,
                (this.SqlCommentColor == Color.Transparent) ? Color.Empty : this.SqlCommentColor,
                (this.SqlAliasColor == Color.Transparent) ? Color.Empty : this.SqlAliasColor,
                (this.SqlGlobalVariableColor == Color.Transparent) ? Color.Empty : this.SqlGlobalVariableColor,
                this.FillNullCells);
        }
        #endregion
    }
}