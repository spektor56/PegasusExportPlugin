namespace PegasusExportPlugin
{
    partial class frmPegasusExport
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExport = new System.Windows.Forms.Button();
            this.fbdExportFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.txtExportPath = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.chkMetaData = new System.Windows.Forms.CheckBox();
            this.chkRoms = new System.Windows.Forms.CheckBox();
            this.chkAssets = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbImagePriority = new System.Windows.Forms.ListBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.radChoose = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clbAssetList = new System.Windows.Forms.CheckedListBox();
            this.radAutoChoose = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(12, 226);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(474, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // txtExportPath
            // 
            this.txtExportPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExportPath.Location = new System.Drawing.Point(90, 12);
            this.txtExportPath.Name = "txtExportPath";
            this.txtExportPath.ReadOnly = true;
            this.txtExportPath.Size = new System.Drawing.Size(315, 20);
            this.txtExportPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Export Folder:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(411, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 197);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(474, 23);
            this.progressBar.TabIndex = 4;
            // 
            // chkMetaData
            // 
            this.chkMetaData.AutoSize = true;
            this.chkMetaData.Checked = true;
            this.chkMetaData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMetaData.Location = new System.Drawing.Point(15, 39);
            this.chkMetaData.Name = "chkMetaData";
            this.chkMetaData.Size = new System.Drawing.Size(104, 17);
            this.chkMetaData.TabIndex = 5;
            this.chkMetaData.Text = "Export Metadata";
            this.chkMetaData.UseVisualStyleBackColor = true;
            // 
            // chkRoms
            // 
            this.chkRoms.AutoSize = true;
            this.chkRoms.Checked = true;
            this.chkRoms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRoms.Location = new System.Drawing.Point(221, 38);
            this.chkRoms.Name = "chkRoms";
            this.chkRoms.Size = new System.Drawing.Size(86, 17);
            this.chkRoms.TabIndex = 6;
            this.chkRoms.Text = "Export Roms";
            this.chkRoms.UseVisualStyleBackColor = true;
            // 
            // chkAssets
            // 
            this.chkAssets.AutoSize = true;
            this.chkAssets.Checked = true;
            this.chkAssets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAssets.Location = new System.Drawing.Point(125, 38);
            this.chkAssets.Name = "chkAssets";
            this.chkAssets.Size = new System.Drawing.Size(90, 17);
            this.chkAssets.TabIndex = 7;
            this.chkAssets.Text = "Export Assets";
            this.chkAssets.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.lbImagePriority);
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Location = new System.Drawing.Point(135, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 125);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Box Art Priority";
            // 
            // lbImagePriority
            // 
            this.lbImagePriority.Enabled = false;
            this.lbImagePriority.FormattingEnabled = true;
            this.lbImagePriority.Items.AddRange(new object[] {
            "Aspect Ratio (MODE)",
            "Smaller File Size",
            "Lossless",
            "Larger File Size"});
            this.lbImagePriority.Location = new System.Drawing.Point(12, 48);
            this.lbImagePriority.Name = "lbImagePriority";
            this.lbImagePriority.Size = new System.Drawing.Size(188, 69);
            this.lbImagePriority.TabIndex = 10;
            // 
            // btnDown
            // 
            this.btnDown.Enabled = false;
            this.btnDown.Location = new System.Drawing.Point(173, 19);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(27, 23);
            this.btnDown.TabIndex = 11;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Enabled = false;
            this.btnUp.Location = new System.Drawing.Point(140, 19);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(27, 23);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // radChoose
            // 
            this.radChoose.AutoSize = true;
            this.radChoose.Enabled = false;
            this.radChoose.Location = new System.Drawing.Point(8, 42);
            this.radChoose.Name = "radChoose";
            this.radChoose.Size = new System.Drawing.Size(95, 17);
            this.radChoose.TabIndex = 10;
            this.radChoose.Text = "Let me choose";
            this.radChoose.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.clbAssetList);
            this.groupBox2.Location = new System.Drawing.Point(352, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 124);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asset Export";
            // 
            // clbAssetList
            // 
            this.clbAssetList.CheckOnClick = true;
            this.clbAssetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbAssetList.FormattingEnabled = true;
            this.clbAssetList.Location = new System.Drawing.Point(3, 16);
            this.clbAssetList.Name = "clbAssetList";
            this.clbAssetList.Size = new System.Drawing.Size(129, 105);
            this.clbAssetList.TabIndex = 0;
            // 
            // radAutoChoose
            // 
            this.radAutoChoose.AutoSize = true;
            this.radAutoChoose.Checked = true;
            this.radAutoChoose.Location = new System.Drawing.Point(8, 19);
            this.radAutoChoose.Name = "radAutoChoose";
            this.radAutoChoose.Size = new System.Drawing.Size(93, 17);
            this.radAutoChoose.TabIndex = 13;
            this.radAutoChoose.TabStop = true;
            this.radAutoChoose.Text = "Choose for me";
            this.radAutoChoose.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radAutoChoose);
            this.groupBox3.Controls.Add(this.radChoose);
            this.groupBox3.Location = new System.Drawing.Point(15, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 70);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Duplicate Assets";
            // 
            // frmPegasusExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 261);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkAssets);
            this.Controls.Add(this.chkRoms);
            this.Controls.Add(this.chkMetaData);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExportPath);
            this.Controls.Add(this.btnExport);
            this.MinimumSize = new System.Drawing.Size(514, 300);
            this.Name = "frmPegasusExport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pegasus Export";
            this.Load += new System.EventHandler(this.FrmPegasusExport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.FolderBrowserDialog fbdExportFolder;
        private System.Windows.Forms.MaskedTextBox txtExportPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox chkMetaData;
        private System.Windows.Forms.CheckBox chkRoms;
        private System.Windows.Forms.CheckBox chkAssets;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbImagePriority;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.RadioButton radChoose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox clbAssetList;
        private System.Windows.Forms.RadioButton radAutoChoose;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}