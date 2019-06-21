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
            this.chkApplication = new System.Windows.Forms.CheckBox();
            this.chkAssets = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.lbImagePriority = new System.Windows.Forms.ListBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.radChoose = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radLinkAssets = new System.Windows.Forms.RadioButton();
            this.radCopyAssets = new System.Windows.Forms.RadioButton();
            this.clbAssetList = new System.Windows.Forms.CheckedListBox();
            this.radAutoChoose = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPlatforms = new System.Windows.Forms.DataGridView();
            this.colSelected = new PegasusExportPlugin.Controls.DataGridViewHeaderCheckBoxColumn();
            this.colPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetaData = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAssets = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colApplication = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewHeaderCheckBoxColumn1 = new PegasusExportPlugin.Controls.DataGridViewHeaderCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radLinkApplication = new System.Windows.Forms.RadioButton();
            this.radCopyApplication = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radAbsoluteApplication = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radAbsoluteAssets = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatforms)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(12, 441);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(770, 23);
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
            this.txtExportPath.Size = new System.Drawing.Size(611, 20);
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
            this.btnBrowse.Location = new System.Drawing.Point(707, 10);
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
            this.progressBar.Location = new System.Drawing.Point(12, 412);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(770, 23);
            this.progressBar.TabIndex = 4;
            // 
            // chkMetaData
            // 
            this.chkMetaData.AutoSize = true;
            this.chkMetaData.Checked = true;
            this.chkMetaData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMetaData.Location = new System.Drawing.Point(6, 19);
            this.chkMetaData.Name = "chkMetaData";
            this.chkMetaData.Size = new System.Drawing.Size(104, 17);
            this.chkMetaData.TabIndex = 5;
            this.chkMetaData.Text = "Export Metadata";
            this.chkMetaData.UseVisualStyleBackColor = true;
            // 
            // chkApplication
            // 
            this.chkApplication.AutoSize = true;
            this.chkApplication.Checked = true;
            this.chkApplication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkApplication.Location = new System.Drawing.Point(212, 19);
            this.chkApplication.Name = "chkApplication";
            this.chkApplication.Size = new System.Drawing.Size(111, 17);
            this.chkApplication.TabIndex = 6;
            this.chkApplication.Text = "Export Application";
            this.chkApplication.UseVisualStyleBackColor = true;
            // 
            // chkAssets
            // 
            this.chkAssets.AutoSize = true;
            this.chkAssets.Checked = true;
            this.chkAssets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAssets.Location = new System.Drawing.Point(116, 19);
            this.chkAssets.Name = "chkAssets";
            this.chkAssets.Size = new System.Drawing.Size(90, 17);
            this.chkAssets.TabIndex = 7;
            this.chkAssets.Text = "Export Assets";
            this.chkAssets.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.lbImagePriority);
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Location = new System.Drawing.Point(438, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 151);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Box Art Priority";
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
            // lbImagePriority
            // 
            this.lbImagePriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbImagePriority.Enabled = false;
            this.lbImagePriority.FormattingEnabled = true;
            this.lbImagePriority.Items.AddRange(new object[] {
            "Aspect Ratio (MODE)",
            "Smaller File Size",
            "Lossless",
            "Larger File Size"});
            this.lbImagePriority.Location = new System.Drawing.Point(12, 48);
            this.lbImagePriority.Name = "lbImagePriority";
            this.lbImagePriority.Size = new System.Drawing.Size(188, 82);
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
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.radLinkAssets);
            this.groupBox2.Controls.Add(this.radCopyAssets);
            this.groupBox2.Controls.Add(this.clbAssetList);
            this.groupBox2.Location = new System.Drawing.Point(9, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 151);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asset Export";
            // 
            // radLinkAssets
            // 
            this.radLinkAssets.AutoSize = true;
            this.radLinkAssets.Location = new System.Drawing.Point(177, 39);
            this.radLinkAssets.Name = "radLinkAssets";
            this.radLinkAssets.Size = new System.Drawing.Size(91, 17);
            this.radLinkAssets.TabIndex = 2;
            this.radLinkAssets.Text = "Link to Assets";
            this.radLinkAssets.UseVisualStyleBackColor = true;
            // 
            // radCopyAssets
            // 
            this.radCopyAssets.AutoSize = true;
            this.radCopyAssets.Checked = true;
            this.radCopyAssets.Location = new System.Drawing.Point(177, 16);
            this.radCopyAssets.Name = "radCopyAssets";
            this.radCopyAssets.Size = new System.Drawing.Size(83, 17);
            this.radCopyAssets.TabIndex = 1;
            this.radCopyAssets.TabStop = true;
            this.radCopyAssets.Text = "Copy Assets";
            this.radCopyAssets.UseVisualStyleBackColor = true;
            // 
            // clbAssetList
            // 
            this.clbAssetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbAssetList.CheckOnClick = true;
            this.clbAssetList.FormattingEnabled = true;
            this.clbAssetList.Location = new System.Drawing.Point(3, 16);
            this.clbAssetList.Name = "clbAssetList";
            this.clbAssetList.Size = new System.Drawing.Size(168, 124);
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
            this.groupBox3.Location = new System.Drawing.Point(655, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 70);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Duplicate Assets";
            // 
            // dgvPlatforms
            // 
            this.dgvPlatforms.AllowUserToAddRows = false;
            this.dgvPlatforms.AllowUserToDeleteRows = false;
            this.dgvPlatforms.AllowUserToResizeRows = false;
            this.dgvPlatforms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlatforms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlatforms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatforms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelected,
            this.colPlatform,
            this.colMetaData,
            this.colAssets,
            this.colApplication});
            this.dgvPlatforms.Location = new System.Drawing.Point(8, 19);
            this.dgvPlatforms.Name = "dgvPlatforms";
            this.dgvPlatforms.RowHeadersVisible = false;
            this.dgvPlatforms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.dgvPlatforms.ShowEditingIcon = false;
            this.dgvPlatforms.Size = new System.Drawing.Size(750, 119);
            this.dgvPlatforms.TabIndex = 13;
            // 
            // colSelected
            // 
            this.colSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSelected.DataPropertyName = "Selected";
            this.colSelected.HeaderCheckBox = true;
            this.colSelected.HeaderText = "";
            this.colSelected.MinimumWidth = 20;
            this.colSelected.Name = "colSelected";
            this.colSelected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelected.Width = 20;
            // 
            // colPlatform
            // 
            this.colPlatform.DataPropertyName = "Name";
            this.colPlatform.HeaderText = "Platform";
            this.colPlatform.Name = "colPlatform";
            this.colPlatform.ReadOnly = true;
            this.colPlatform.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMetaData
            // 
            this.colMetaData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMetaData.DataPropertyName = "ExportMetadata";
            this.colMetaData.HeaderText = "Metadata";
            this.colMetaData.Name = "colMetaData";
            this.colMetaData.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMetaData.Width = 58;
            // 
            // colAssets
            // 
            this.colAssets.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colAssets.DataPropertyName = "ExportAssets";
            this.colAssets.HeaderText = "Assets";
            this.colAssets.Name = "colAssets";
            this.colAssets.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAssets.Width = 44;
            // 
            // colApplication
            // 
            this.colApplication.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colApplication.DataPropertyName = "ExportApplication";
            this.colApplication.HeaderText = "Application";
            this.colApplication.Name = "colApplication";
            this.colApplication.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colApplication.Width = 65;
            // 
            // dataGridViewHeaderCheckBoxColumn1
            // 
            this.dataGridViewHeaderCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewHeaderCheckBoxColumn1.HeaderCheckBox = true;
            this.dataGridViewHeaderCheckBoxColumn1.HeaderText = "";
            this.dataGridViewHeaderCheckBoxColumn1.MinimumWidth = 20;
            this.dataGridViewHeaderCheckBoxColumn1.Name = "dataGridViewHeaderCheckBoxColumn1";
            this.dataGridViewHeaderCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHeaderCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewHeaderCheckBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Platform";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvPlatforms);
            this.groupBox4.Location = new System.Drawing.Point(3, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(764, 149);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Platform Export Options";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkMetaData);
            this.groupBox5.Controls.Add(this.chkAssets);
            this.groupBox5.Controls.Add(this.chkApplication);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(429, 44);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Global Override Settings";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 367);
            this.panel1.TabIndex = 14;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.radLinkApplication);
            this.groupBox6.Controls.Add(this.radCopyApplication);
            this.groupBox6.Location = new System.Drawing.Point(305, 208);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(127, 151);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Application Export";
            // 
            // radLinkApplication
            // 
            this.radLinkApplication.AutoSize = true;
            this.radLinkApplication.Location = new System.Drawing.Point(6, 39);
            this.radLinkApplication.Name = "radLinkApplication";
            this.radLinkApplication.Size = new System.Drawing.Size(112, 17);
            this.radLinkApplication.TabIndex = 4;
            this.radLinkApplication.Text = "Link to Application";
            this.radLinkApplication.UseVisualStyleBackColor = true;
            // 
            // radCopyApplication
            // 
            this.radCopyApplication.AutoSize = true;
            this.radCopyApplication.Checked = true;
            this.radCopyApplication.Location = new System.Drawing.Point(6, 16);
            this.radCopyApplication.Name = "radCopyApplication";
            this.radCopyApplication.Size = new System.Drawing.Size(104, 17);
            this.radCopyApplication.TabIndex = 3;
            this.radCopyApplication.TabStop = true;
            this.radCopyApplication.Text = "Copy Application";
            this.radCopyApplication.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButton2);
            this.groupBox7.Controls.Add(this.radAbsoluteApplication);
            this.groupBox7.Location = new System.Drawing.Point(6, 62);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(115, 68);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Path";
            // 
            // radAbsoluteApplication
            // 
            this.radAbsoluteApplication.AutoSize = true;
            this.radAbsoluteApplication.Checked = true;
            this.radAbsoluteApplication.Location = new System.Drawing.Point(16, 19);
            this.radAbsoluteApplication.Name = "radAbsoluteApplication";
            this.radAbsoluteApplication.Size = new System.Drawing.Size(69, 17);
            this.radAbsoluteApplication.TabIndex = 4;
            this.radAbsoluteApplication.TabStop = true;
            this.radAbsoluteApplication.Text = "Absolute.";
            this.radAbsoluteApplication.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Relative";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.radioButton3);
            this.groupBox8.Controls.Add(this.radAbsoluteAssets);
            this.groupBox8.Location = new System.Drawing.Point(177, 62);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(107, 68);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Path";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "Relative";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radAbsoluteAssets
            // 
            this.radAbsoluteAssets.AutoSize = true;
            this.radAbsoluteAssets.Checked = true;
            this.radAbsoluteAssets.Location = new System.Drawing.Point(16, 19);
            this.radAbsoluteAssets.Name = "radAbsoluteAssets";
            this.radAbsoluteAssets.Size = new System.Drawing.Size(66, 17);
            this.radAbsoluteAssets.TabIndex = 4;
            this.radAbsoluteAssets.TabStop = true;
            this.radAbsoluteAssets.Text = "Absolute";
            this.radAbsoluteAssets.UseVisualStyleBackColor = true;
            // 
            // frmPegasusExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 476);
            this.Controls.Add(this.panel1);
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
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatforms)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
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
        private System.Windows.Forms.CheckBox chkApplication;
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
        private System.Windows.Forms.DataGridView dgvPlatforms;
        private Controls.DataGridViewHeaderCheckBoxColumn dataGridViewHeaderCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel1;
        private Controls.DataGridViewHeaderCheckBoxColumn colSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlatform;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMetaData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAssets;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colApplication;
        private System.Windows.Forms.RadioButton radLinkAssets;
        private System.Windows.Forms.RadioButton radCopyAssets;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radLinkApplication;
        private System.Windows.Forms.RadioButton radCopyApplication;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radAbsoluteAssets;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radAbsoluteApplication;
    }
}