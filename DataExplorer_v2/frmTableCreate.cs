using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer
{
    public partial class frmTableCreate : Form
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public string TableName
        {
            get { return this.txtTableName.Text; }
            set { this.txtTableName.Text = value; }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public frmTableCreate()
        {
            InitializeComponent();
            DataGridViewComboBoxColumn colType = (DataGridViewComboBoxColumn)this.dataGridView1.Columns[1];
            foreach (string val in Enum.GetNames(typeof(System.Data.SqlDbType)))
                colType.Items.Add(val);
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public string[] GetCreateScript()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine(string.Format("USE [{0}]", this._connStr));
            //sb.AppendLine("GO");
            sb.AppendLine(string.Format("/***** object:  Table [dbo].[{0}]    Script Date: {1} *****/", this.TableName, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")));
            sb.AppendLine("SET ANSI_NULLS ON");
            sb.AppendLine("GO");
            sb.AppendLine("SET QUOTED_IDENTIFIER ON");
            sb.AppendLine("GO");
            sb.AppendLine("SET ANSI_PADDING ON");
            sb.AppendLine("GO");
            sb.AppendLine(string.Format("CRATE TABLE [dbo].[{0}](", this.TableName));
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                string ln = "\t";
                DataGridViewRow r = this.dataGridView1.Rows[i];
                if (!r.IsNewRow)
                {
                    ln += string.Format("[{0}] [{1}]", r.Cells[0].Value, r.Cells[1].Value.ToString().ToLower());
                    string typeVal = r.Cells[1].Value.ToString().ToLower();
                    string fldLen = r.Cells[2].Value.ToString().ToLower();
                    int fldSz;
                    if (RainstormStudios.rsString.EqualToAny(typeVal, "varchar", "nvarchar", "binary", "varbinary", "char", "nchar"))
                    {
                        if (fldLen == "-1" || fldLen == "max")
                            ln += "(max)";
                        else
                        {
                            // Make sure the field contains a valid integer value.
                            if (!int.TryParse(fldLen, out fldSz))
                                throw new Exception("Specified field size is not valid.");
                            else
                                ln += string.Format("({0})", fldSz);
                        }

                        if (RainstormStudios.rsString.EqualToAny(typeVal, "varchar", "nvarchar", "char", "nchar"))
                            ln += " COLLATE SQL_Latin1_General_CP1_CI_AS";
                    }
                    else if (RainstormStudios.rsString.EqualToAny(typeVal, "numeric", "decimal"))
                    {
                        int cmPos = fldLen.IndexOf(',');
                        if (cmPos < 0)
                        {
                            // Field size does not contain a comma.
                            if (!int.TryParse(fldLen, out fldSz))
                                throw new Exception("Specified field size is not valid");
                            else
                                ln += string.Format("({0},0)", fldSz);
                        }
                        else if (cmPos == 0)
                        {
                            // Comma is the first thing in the field size.
                        }
                        else if (cmPos == fldLen.Length - 1)
                        {
                            // Comma is the last character.
                        }
                    }
                    if (r.Cells[4].Value != null && r.Cells[4].Value.ToString().ToLower() == "true")
                        ln += string.Format(" IDENTITY({0},{1})", r.Cells[5].Value, r.Cells[6].Value);
                    ln += ((r.Cells[3].Value != null && r.Cells[3].Value.ToString().ToLower() == "true") ? " " : " NOT ") + "NULL";
                    string defVal = (r.Cells[7].Value == null)
                                        ? string.Empty
                                        : r.Cells[7].Value.ToString();
                    if (!string.IsNullOrEmpty(defVal))
                    {
                        if (r.Cells[3].Value == null || r.Cells[3].Value.ToString().ToLower() == "false")
                            ln += string.Format(" CONSTRAINT [DF_{0}_{1}] ", this.TableName, r.Cells[0].Value);
                        ln += string.Format(" DEFAULT(({0}))", defVal);
                    }
                    if (i < this.dataGridView1.Rows.Count - 1)
                        ln += ",";
                    sb.AppendLine(ln);
                }
            }
            sb.AppendLine(") ON [PRIMARY]");
            sb.AppendLine("");
            sb.AppendLine("GO");
            sb.AppendLine("SET ANSI_PADDING OFF");
            return sb.ToString().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                DataGridViewRow r=this.dataGridView1.Rows[i];

                r.Cells[2].ReadOnly = true;
                //if (r.Cells[3].Value == null)
                //    this.dataGridView1.Rows[i].Cells[3].Value = true;
                r.Cells[4].ReadOnly = true;
                //if (r.Cells[4].Value == null)
                //    this.dataGridView1.Rows[i].Cells[4].Value = false;
                r.Cells[5].ReadOnly = true;
                r.Cells[6].ReadOnly = true;
                //if (r.Cells[7].Value == null)
                //    this.dataGridView1.Rows[i].Cells[7].Value = string.Empty;
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1 && this.dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    string typeVal = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().ToLower();
                    this.dataGridView1.Rows[e.RowIndex].Cells[4].ReadOnly = !(typeVal == "int");
                    this.dataGridView1.Rows[e.RowIndex].Cells[2].ReadOnly = !(RainstormStudios.rsString.EqualToAny(typeVal, "varchar", "nvarchar", "binary", "varbinary", "char", "nchar", "decimal", "numeric"));
                    if (this.dataGridView1.Rows[e.RowIndex].Cells[2].Value == null)
                    {
                        if (RainstormStudios.rsString.EqualToAny(typeVal, "varchar", "nvarchar", "binary", "varbinary"))
                            this.dataGridView1.Rows[e.RowIndex].Cells[2].Value = "50";
                        else if (RainstormStudios.rsString.EqualToAny(typeVal, "char", "nchar"))
                            this.dataGridView1.Rows[e.RowIndex].Cells[2].Value = "10";
                        else if (RainstormStudios.rsString.EqualToAny(typeVal, "int", "real", "smalldatetime", "smallmoney"))
                            this.dataGridView1.Rows[e.RowIndex].Cells[2].Value = "4";
                        else if (RainstormStudios.rsString.EqualToAny(typeVal, "bigint", "datetime", "float", "money", "timestamp"))
                            this.dataGridView1.Rows[e.RowIndex].Cells[2].Value = "8";
                        else if (RainstormStudios.rsString.EqualToAny(typeVal, "bit", "tinyint"))
                            this.dataGridView1.Rows[e.RowIndex].Cells[2].Value = "1";
                        else if (RainstormStudios.rsString.EqualToAny(typeVal, "image", "ntext", "text", "uniqueidentifier"))
                            this.dataGridView1.Rows[e.RowIndex].Cells[2].Value = "16";
                        else if (RainstormStudios.rsString.EqualToAny(typeVal, "numeric", "decimal"))
                            this.dataGridView1.Rows[e.RowIndex].Cells[2].Value = "18, 0";
                        else if (typeVal == "smallint")
                            this.dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2";
                        else if (typeVal == "variant")
                            this.dataGridView1.Rows[e.RowIndex].Cells[2].Value = "8016";
                        else if (typeVal == "xml")
                            this.dataGridView1.Rows[e.RowIndex].Cells[2].Value = "-1";
                    }
                }
                else if (e.ColumnIndex == 4 && this.dataGridView1.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    this.dataGridView1.Rows[e.RowIndex].Cells[5].ReadOnly = !Convert.ToBoolean(this.dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    if (this.dataGridView1.Rows[e.RowIndex].Cells[5].Value == null && !this.dataGridView1.Rows[e.RowIndex].Cells[5].ReadOnly)
                        this.dataGridView1.Rows[e.RowIndex].Cells[5].Value = "1";
                    this.dataGridView1.Rows[e.RowIndex].Cells[6].ReadOnly = !Convert.ToBoolean(this.dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    if (this.dataGridView1.Rows[e.RowIndex].Cells[6].Value == null && !this.dataGridView1.Rows[e.RowIndex].Cells[6].ReadOnly)
                        this.dataGridView1.Rows[e.RowIndex].Cells[6].Value = "1";
                }
                this.Refresh();
            }
            catch (ArgumentException)
            {
                // This will exception will occur sometimes when the datagrid is
                //   first created because this event triggers, but the datagrid
                //   doesn't actually contain any rows yet, so referencing the "Rows"
                //   collection with an index value throws this exception.
                // We don't need to actually *do* anything about it; just prevent
                //   the exception from causing the application to terminate.
            }
            catch
            { throw; }
        }
        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.ReadOnly)
            {
                DataGridViewCellStyle style = e.Cell.Style;
                style.BackColor = (e.Cell.ReadOnly) ? System.Drawing.Color.LightGray : this.dataGridView1.DefaultCellStyle.BackColor;
                e.Cell.Style.ApplyStyle(style);
            }
        }
        #endregion
    }
}