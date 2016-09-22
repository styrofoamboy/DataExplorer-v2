namespace DataExplorer
{
    partial class DestinationPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pan02Hdr = new System.Windows.Forms.Panel();
            this.pan02HdrPic = new System.Windows.Forms.PictureBox();
            this.pan02HdrlblSubTitle = new System.Windows.Forms.Label();
            this.pan02HdrlblTitle = new System.Windows.Forms.Label();
            this.pan02panSep = new System.Windows.Forms.Panel();
            this.dataTarget = new DataExplorer.ctrlDataTarget();
            this.pan02Hdr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pan02HdrPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pan02Hdr
            // 
            this.pan02Hdr.BackColor = System.Drawing.Color.White;
            this.pan02Hdr.Controls.Add(this.pan02HdrPic);
            this.pan02Hdr.Controls.Add(this.pan02HdrlblSubTitle);
            this.pan02Hdr.Controls.Add(this.pan02HdrlblTitle);
            this.pan02Hdr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan02Hdr.Location = new System.Drawing.Point(0, 0);
            this.pan02Hdr.Name = "pan02Hdr";
            this.pan02Hdr.Size = new System.Drawing.Size(592, 62);
            this.pan02Hdr.TabIndex = 2;
            // 
            // pan02HdrPic
            // 
            this.pan02HdrPic.Dock = System.Windows.Forms.DockStyle.Right;
            this.pan02HdrPic.Image = global::DataExplorer.Properties.Resources.Thumb_11_23_071;
            this.pan02HdrPic.Location = new System.Drawing.Point(525, 0);
            this.pan02HdrPic.Name = "pan02HdrPic";
            this.pan02HdrPic.Size = new System.Drawing.Size(67, 62);
            this.pan02HdrPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pan02HdrPic.TabIndex = 2;
            this.pan02HdrPic.TabStop = false;
            // 
            // pan02HdrlblSubTitle
            // 
            this.pan02HdrlblSubTitle.AutoSize = true;
            this.pan02HdrlblSubTitle.Location = new System.Drawing.Point(46, 31);
            this.pan02HdrlblSubTitle.Name = "pan02HdrlblSubTitle";
            this.pan02HdrlblSubTitle.Size = new System.Drawing.Size(262, 13);
            this.pan02HdrlblSubTitle.TabIndex = 1;
            this.pan02HdrlblSubTitle.Text = "Choose a destination where the data will be copied to.";
            // 
            // pan02HdrlblTitle
            // 
            this.pan02HdrlblTitle.AutoSize = true;
            this.pan02HdrlblTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan02HdrlblTitle.Location = new System.Drawing.Point(23, 12);
            this.pan02HdrlblTitle.Name = "pan02HdrlblTitle";
            this.pan02HdrlblTitle.Size = new System.Drawing.Size(211, 19);
            this.pan02HdrlblTitle.TabIndex = 0;
            this.pan02HdrlblTitle.Text = "Choose Data Destination";
            // 
            // pan02panSep
            // 
            this.pan02panSep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan02panSep.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan02panSep.Location = new System.Drawing.Point(0, 62);
            this.pan02panSep.Name = "pan02panSep";
            this.pan02panSep.Size = new System.Drawing.Size(592, 4);
            this.pan02panSep.TabIndex = 4;
            // 
            // dataTarget
            // 
            this.dataTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTarget.Location = new System.Drawing.Point(15, 72);
            this.dataTarget.MinimumSize = new System.Drawing.Size(560, 300);
            this.dataTarget.Name = "dataTarget";
            this.dataTarget.Size = new System.Drawing.Size(560, 309);
            this.dataTarget.TabIndex = 3;
            this.dataTarget.TargetDirection = DataExplorer.DataTargetDirection.Destination;
            // 
            // DestinationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pan02panSep);
            this.Controls.Add(this.pan02Hdr);
            this.Controls.Add(this.dataTarget);
            this.Name = "DestinationPanel";
            this.Size = new System.Drawing.Size(592, 384);
            this.pan02Hdr.ResumeLayout(false);
            this.pan02Hdr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pan02HdrPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan02Hdr;
        private System.Windows.Forms.PictureBox pan02HdrPic;
        private System.Windows.Forms.Label pan02HdrlblSubTitle;
        private System.Windows.Forms.Label pan02HdrlblTitle;
        private System.Windows.Forms.Panel pan02panSep;
        private ctrlDataTarget dataTarget;
    }
}
