using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataExplorer
{
    public partial class frmProjectInfo : Form
    {
        #region Declarations
        //***************************************************************************
        // Declarations
        // 
        private ProjectNoteCollection
            _noteCol,
            _delNotes;
        private List<string>
            _newNotes;
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        internal string[] AddedNotes
        { get { return this._newNotes.ToArray(); } }
        internal ProjectNoteCollection DeletedNotes
        { get { return this._delNotes; } }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        private frmProjectInfo()
        {
            InitializeComponent();
            this._noteCol = new ProjectNoteCollection();
            this._delNotes = new ProjectNoteCollection();
            this._newNotes = new List<string>();
        }
        internal frmProjectInfo(ProjectNoteCollection notes, string fileName, int qryCount, string createBy, DateTime createOn, DateTime modifiedOn)
            : this()
        {
            if (string.IsNullOrEmpty(createBy))
                using (System.Security.Principal.WindowsIdentity wi = System.Security.Principal.WindowsIdentity.GetCurrent())
                    createBy = wi.Name;
            this.txtCreatedBy.Text = createBy;
            this.txtCreatedOn.Text = (createOn != null && createOn != DateTime.MinValue)
                                        ? createOn.ToString("MM/dd/yyyy  HH:mm:ss")
                                        : string.Empty;
            this.txtModifiedOn.Text = (modifiedOn != null && modifiedOn != DateTime.MinValue)
                                        ? modifiedOn.ToString("MM/dd/yyyy  HH:mm:ss") 
                                        : string.Empty;
            if (System.IO.File.Exists(fileName))
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(fileName);
                this.lblFileSize.Text = ((fi.Length > 1024) ? ((double)((double)fi.Length / 1024.0)).ToString("#,##0.00") + " Kb" : fi.Length.ToString("#,##0") + " bytes");
            }
            this.lblQryCnt.Text = qryCount.ToString();
            this._noteCol = notes;
            this.PopulateNoteList();
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private void PopulateNoteList()
        {
            this.lvwNotes.BeginUpdate();
            try
            {
                lvwNotes.Items.Clear();
                for (int i = 0; i < this._noteCol.Count; i++)
                {
                    ProjectNote note = this._noteCol[i];
                    this.lvwNotes.Items.Add(new ListViewItem(new string[] { "", note.Subject, note.Body }));
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(this, ex.ToString(), "Unexpected Error");
#else
                MessageBox.Show(this, "An unexpected error occured while trying to display project notes:\n\n" + ex.Message, "Unexpected Error");
#endif
            }
            finally
            {
                this.lvwNotes.EndUpdate();
            }
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void cmdAddNote_onClick(object sender, EventArgs e)
        {
            using (frmProjectNote frm = new frmProjectNote())
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    string noteKey=DateTime.Now.ToString("yyyyMMddHHmmss");
                    this._noteCol.Add(frm.Note, noteKey);
                    this._newNotes.Add(noteKey);
                    this.PopulateNoteList();
                }
        }
        private void cmdRemNote_onClick(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to permenantly delete this note?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string noteKey = this._noteCol.GetKey(this.lvwNotes.SelectedIndices[0]);
                this._delNotes.Add(this._noteCol[this.lvwNotes.SelectedIndices[0]], noteKey + this.lvwNotes.SelectedIndices[0].ToString().PadLeft(4, '0'));
                this._noteCol.RemoveAt(this.lvwNotes.SelectedIndices[0]);
                this.PopulateNoteList();
            }
        }
        private void lvwNotes_onSelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmdRemNote.Enabled = (this.lvwNotes.SelectedItems.Count > 0);
        }
        private void lvwNotes_onDoubleClick(object sender, EventArgs e)
        {
            if (this.lvwNotes.SelectedIndices.Count > 0)
            {
                ProjectNote note = this._noteCol[this.lvwNotes.SelectedIndices[0]];
                using(frmProjectNote frm=new frmProjectNote(note.Subject,note.Body))
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        if (frm.Subject != note.Subject || frm.Body != note.Body)
                        {
                            this._noteCol[this.lvwNotes.SelectedIndices[0]] = frm.Note;
                            this.PopulateNoteList();
                        }
                    }
            }
        }
        #endregion
    }
}