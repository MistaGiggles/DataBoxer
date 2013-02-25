namespace DataBoxer
{
    partial class DataBoxer
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
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bmaxplus = new System.Windows.Forms.Button();
            this.bmaxminus = new System.Windows.Forms.Button();
            this.tmax = new System.Windows.Forms.TextBox();
            this.bminplus = new System.Windows.Forms.Button();
            this.bminminus = new System.Windows.Forms.Button();
            this.tmin = new System.Windows.Forms.TextBox();
            this.groupConnection = new System.Windows.Forms.GroupBox();
            this.combox = new System.Windows.Forms.ComboBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBox = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupCommDatFile = new System.Windows.Forms.GroupBox();
            this.bChooseCommdat = new System.Windows.Forms.Button();
            this.bOpenFileLocation = new System.Windows.Forms.Button();
            this.tFileName = new System.Windows.Forms.TextBox();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.bReloadData = new System.Windows.Forms.Button();
            this.bSyncronize = new System.Windows.Forms.Button();
            this.bStopDownload = new System.Windows.Forms.Button();
            this.bStartDownload = new System.Windows.Forms.Button();
            this.bDownloadSingle = new System.Windows.Forms.Button();
            this.groupConsole1 = new System.Windows.Forms.GroupBox();
            this.textconsole1 = new System.Windows.Forms.TextBox();
            this.tabScan = new System.Windows.Forms.TabPage();
            this.groupScanningControl = new System.Windows.Forms.GroupBox();
            this.bStopScanning = new System.Windows.Forms.Button();
            this.bStartScanning = new System.Windows.Forms.Button();
            this.groupScanningCSV = new System.Windows.Forms.GroupBox();
            this.bImportScanning = new System.Windows.Forms.Button();
            this.bExportScanning = new System.Windows.Forms.Button();
            this.bChooseScanning = new System.Windows.Forms.Button();
            this.textScanningCSV = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bClearBibs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bInsertBibRange = new System.Windows.Forms.Button();
            this.tBibTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBibFrom = new System.Windows.Forms.TextBox();
            this.dataGridBibs = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textCurrentChip = new System.Windows.Forms.TextBox();
            this.bLockBibs = new System.Windows.Forms.Button();
            this.textConsole2 = new System.Windows.Forms.TextBox();
            this.dataCSVView = new System.Windows.Forms.DataGridView();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.textConsole3 = new System.Windows.Forms.TextBox();
            this.bDeleteBox = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDownload = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogScanning = new System.Windows.Forms.OpenFileDialog();
            this.backgroundScanner = new System.ComponentModel.BackgroundWorker();
            this.bShowLive = new System.Windows.Forms.Button();
            this.groupBoxSelect.SuspendLayout();
            this.groupConnection.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupCommDatFile.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            this.groupConsole1.SuspendLayout();
            this.tabScan.SuspendLayout();
            this.groupScanningControl.SuspendLayout();
            this.groupScanningCSV.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBibs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCSVView)).BeginInit();
            this.tabDelete.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSelect.Controls.Add(this.label1);
            this.groupBoxSelect.Controls.Add(this.label2);
            this.groupBoxSelect.Controls.Add(this.bmaxplus);
            this.groupBoxSelect.Controls.Add(this.bmaxminus);
            this.groupBoxSelect.Controls.Add(this.tmax);
            this.groupBoxSelect.Controls.Add(this.bminplus);
            this.groupBoxSelect.Controls.Add(this.bminminus);
            this.groupBoxSelect.Controls.Add(this.tmin);
            this.groupBoxSelect.Location = new System.Drawing.Point(6, 122);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(138, 106);
            this.groupBoxSelect.TabIndex = 3;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Box Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "From:";
            // 
            // bmaxplus
            // 
            this.bmaxplus.Location = new System.Drawing.Point(70, 74);
            this.bmaxplus.Name = "bmaxplus";
            this.bmaxplus.Size = new System.Drawing.Size(23, 23);
            this.bmaxplus.TabIndex = 22;
            this.bmaxplus.Text = ">";
            this.bmaxplus.UseVisualStyleBackColor = true;
            this.bmaxplus.Click += new System.EventHandler(this.bmaxplus_Click);
            // 
            // bmaxminus
            // 
            this.bmaxminus.Location = new System.Drawing.Point(6, 74);
            this.bmaxminus.Name = "bmaxminus";
            this.bmaxminus.Size = new System.Drawing.Size(25, 23);
            this.bmaxminus.TabIndex = 21;
            this.bmaxminus.Text = "<";
            this.bmaxminus.UseVisualStyleBackColor = true;
            this.bmaxminus.Click += new System.EventHandler(this.bmaxminus_Click);
            // 
            // tmax
            // 
            this.tmax.Location = new System.Drawing.Point(37, 76);
            this.tmax.Name = "tmax";
            this.tmax.ReadOnly = true;
            this.tmax.Size = new System.Drawing.Size(27, 20);
            this.tmax.TabIndex = 20;
            this.tmax.Text = "1";
            // 
            // bminplus
            // 
            this.bminplus.Location = new System.Drawing.Point(70, 32);
            this.bminplus.Name = "bminplus";
            this.bminplus.Size = new System.Drawing.Size(23, 23);
            this.bminplus.TabIndex = 19;
            this.bminplus.Text = ">";
            this.bminplus.UseVisualStyleBackColor = true;
            this.bminplus.Click += new System.EventHandler(this.bminplus_Click);
            // 
            // bminminus
            // 
            this.bminminus.Location = new System.Drawing.Point(6, 32);
            this.bminminus.Name = "bminminus";
            this.bminminus.Size = new System.Drawing.Size(25, 23);
            this.bminminus.TabIndex = 18;
            this.bminminus.Text = "<";
            this.bminminus.UseVisualStyleBackColor = true;
            this.bminminus.Click += new System.EventHandler(this.bminminus_Click);
            // 
            // tmin
            // 
            this.tmin.Location = new System.Drawing.Point(37, 34);
            this.tmin.Name = "tmin";
            this.tmin.ReadOnly = true;
            this.tmin.Size = new System.Drawing.Size(27, 20);
            this.tmin.TabIndex = 17;
            this.tmin.Text = "1";
            // 
            // groupConnection
            // 
            this.groupConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupConnection.Controls.Add(this.combox);
            this.groupConnection.Controls.Add(this.bConnect);
            this.groupConnection.Controls.Add(this.bDisconnect);
            this.groupConnection.Location = new System.Drawing.Point(6, 0);
            this.groupConnection.Name = "groupConnection";
            this.groupConnection.Size = new System.Drawing.Size(138, 116);
            this.groupConnection.TabIndex = 2;
            this.groupConnection.TabStop = false;
            this.groupConnection.Text = "Box Connection";
            // 
            // combox
            // 
            this.combox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.combox.FormattingEnabled = true;
            this.combox.Location = new System.Drawing.Point(6, 19);
            this.combox.Name = "combox";
            this.combox.Size = new System.Drawing.Size(126, 21);
            this.combox.TabIndex = 10;
            this.combox.SelectedIndexChanged += new System.EventHandler(this.combox_SelectedIndexChanged);
            // 
            // bConnect
            // 
            this.bConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bConnect.Location = new System.Drawing.Point(6, 46);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(126, 26);
            this.bConnect.TabIndex = 4;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bDisconnect
            // 
            this.bDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bDisconnect.Enabled = false;
            this.bDisconnect.Location = new System.Drawing.Point(6, 78);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(126, 27);
            this.bDisconnect.TabIndex = 5;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabBox);
            this.tabControl.Controls.Add(this.tabScan);
            this.tabControl.Controls.Add(this.tabDelete);
            this.tabControl.Location = new System.Drawing.Point(153, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(965, 670);
            this.tabControl.TabIndex = 4;
            // 
            // tabBox
            // 
            this.tabBox.BackColor = System.Drawing.SystemColors.Control;
            this.tabBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBox.Controls.Add(this.panel1);
            this.tabBox.Controls.Add(this.groupConsole1);
            this.tabBox.Location = new System.Drawing.Point(4, 25);
            this.tabBox.Name = "tabBox";
            this.tabBox.Padding = new System.Windows.Forms.Padding(3);
            this.tabBox.Size = new System.Drawing.Size(957, 641);
            this.tabBox.TabIndex = 0;
            this.tabBox.Text = "Box Manager";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bShowLive);
            this.panel1.Controls.Add(this.groupCommDatFile);
            this.panel1.Controls.Add(this.groupBoxControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 633);
            this.panel1.TabIndex = 3;
            // 
            // groupCommDatFile
            // 
            this.groupCommDatFile.Controls.Add(this.bChooseCommdat);
            this.groupCommDatFile.Controls.Add(this.bOpenFileLocation);
            this.groupCommDatFile.Controls.Add(this.tFileName);
            this.groupCommDatFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupCommDatFile.Location = new System.Drawing.Point(0, 545);
            this.groupCommDatFile.Name = "groupCommDatFile";
            this.groupCommDatFile.Size = new System.Drawing.Size(184, 88);
            this.groupCommDatFile.TabIndex = 1;
            this.groupCommDatFile.TabStop = false;
            this.groupCommDatFile.Text = "File Location";
            // 
            // bChooseCommdat
            // 
            this.bChooseCommdat.AutoSize = true;
            this.bChooseCommdat.Dock = System.Windows.Forms.DockStyle.Top;
            this.bChooseCommdat.Location = new System.Drawing.Point(3, 59);
            this.bChooseCommdat.Name = "bChooseCommdat";
            this.bChooseCommdat.Size = new System.Drawing.Size(178, 23);
            this.bChooseCommdat.TabIndex = 2;
            this.bChooseCommdat.Text = "Choose...";
            this.bChooseCommdat.UseVisualStyleBackColor = true;
            this.bChooseCommdat.Click += new System.EventHandler(this.bChooseCommdat_Click);
            // 
            // bOpenFileLocation
            // 
            this.bOpenFileLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.bOpenFileLocation.Location = new System.Drawing.Point(3, 36);
            this.bOpenFileLocation.Name = "bOpenFileLocation";
            this.bOpenFileLocation.Size = new System.Drawing.Size(178, 23);
            this.bOpenFileLocation.TabIndex = 1;
            this.bOpenFileLocation.Text = "Open...";
            this.bOpenFileLocation.UseVisualStyleBackColor = true;
            this.bOpenFileLocation.Click += new System.EventHandler(this.bOpenFileLocation_Click);
            // 
            // tFileName
            // 
            this.tFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tFileName.Location = new System.Drawing.Point(3, 16);
            this.tFileName.Name = "tFileName";
            this.tFileName.Size = new System.Drawing.Size(178, 20);
            this.tFileName.TabIndex = 0;
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.bReloadData);
            this.groupBoxControl.Controls.Add(this.bSyncronize);
            this.groupBoxControl.Controls.Add(this.bStopDownload);
            this.groupBoxControl.Controls.Add(this.bStartDownload);
            this.groupBoxControl.Controls.Add(this.bDownloadSingle);
            this.groupBoxControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxControl.Location = new System.Drawing.Point(0, 0);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(184, 173);
            this.groupBoxControl.TabIndex = 0;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Box Control";
            // 
            // bReloadData
            // 
            this.bReloadData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bReloadData.Location = new System.Drawing.Point(3, 101);
            this.bReloadData.Name = "bReloadData";
            this.bReloadData.Size = new System.Drawing.Size(178, 23);
            this.bReloadData.TabIndex = 4;
            this.bReloadData.Text = "Reload Data";
            this.bReloadData.UseVisualStyleBackColor = true;
            this.bReloadData.Click += new System.EventHandler(this.bReloadData_Click);
            // 
            // bSyncronize
            // 
            this.bSyncronize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bSyncronize.Location = new System.Drawing.Point(3, 124);
            this.bSyncronize.Name = "bSyncronize";
            this.bSyncronize.Size = new System.Drawing.Size(178, 23);
            this.bSyncronize.TabIndex = 3;
            this.bSyncronize.Text = "Syncronize";
            this.bSyncronize.UseVisualStyleBackColor = true;
            this.bSyncronize.Click += new System.EventHandler(this.bSyncronize_Click);
            // 
            // bStopDownload
            // 
            this.bStopDownload.Dock = System.Windows.Forms.DockStyle.Top;
            this.bStopDownload.Enabled = false;
            this.bStopDownload.Location = new System.Drawing.Point(3, 39);
            this.bStopDownload.Name = "bStopDownload";
            this.bStopDownload.Size = new System.Drawing.Size(178, 23);
            this.bStopDownload.TabIndex = 2;
            this.bStopDownload.Text = "Stop";
            this.bStopDownload.UseVisualStyleBackColor = true;
            this.bStopDownload.Click += new System.EventHandler(this.bStopDownload_Click);
            // 
            // bStartDownload
            // 
            this.bStartDownload.Dock = System.Windows.Forms.DockStyle.Top;
            this.bStartDownload.Location = new System.Drawing.Point(3, 16);
            this.bStartDownload.Name = "bStartDownload";
            this.bStartDownload.Size = new System.Drawing.Size(178, 23);
            this.bStartDownload.TabIndex = 1;
            this.bStartDownload.Text = "Start";
            this.bStartDownload.UseVisualStyleBackColor = true;
            this.bStartDownload.Click += new System.EventHandler(this.bStartDownload_Click);
            // 
            // bDownloadSingle
            // 
            this.bDownloadSingle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bDownloadSingle.Location = new System.Drawing.Point(3, 147);
            this.bDownloadSingle.Name = "bDownloadSingle";
            this.bDownloadSingle.Size = new System.Drawing.Size(178, 23);
            this.bDownloadSingle.TabIndex = 0;
            this.bDownloadSingle.Text = "Download Packet";
            this.bDownloadSingle.UseVisualStyleBackColor = true;
            this.bDownloadSingle.Click += new System.EventHandler(this.bDownloadSingle_Click);
            // 
            // groupConsole1
            // 
            this.groupConsole1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupConsole1.Controls.Add(this.textconsole1);
            this.groupConsole1.Location = new System.Drawing.Point(193, 6);
            this.groupConsole1.Name = "groupConsole1";
            this.groupConsole1.Size = new System.Drawing.Size(759, 627);
            this.groupConsole1.TabIndex = 2;
            this.groupConsole1.TabStop = false;
            this.groupConsole1.Text = "Console";
            // 
            // textconsole1
            // 
            this.textconsole1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textconsole1.Location = new System.Drawing.Point(6, 19);
            this.textconsole1.Multiline = true;
            this.textconsole1.Name = "textconsole1";
            this.textconsole1.Size = new System.Drawing.Size(747, 602);
            this.textconsole1.TabIndex = 4;
            // 
            // tabScan
            // 
            this.tabScan.BackColor = System.Drawing.SystemColors.Control;
            this.tabScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabScan.Controls.Add(this.groupScanningControl);
            this.tabScan.Controls.Add(this.groupScanningCSV);
            this.tabScan.Controls.Add(this.panel3);
            this.tabScan.Controls.Add(this.textConsole2);
            this.tabScan.Controls.Add(this.dataCSVView);
            this.tabScan.Location = new System.Drawing.Point(4, 25);
            this.tabScan.Name = "tabScan";
            this.tabScan.Padding = new System.Windows.Forms.Padding(3);
            this.tabScan.Size = new System.Drawing.Size(957, 641);
            this.tabScan.TabIndex = 1;
            this.tabScan.Text = "Scanning";
            // 
            // groupScanningControl
            // 
            this.groupScanningControl.Controls.Add(this.bStopScanning);
            this.groupScanningControl.Controls.Add(this.bStartScanning);
            this.groupScanningControl.Location = new System.Drawing.Point(7, 216);
            this.groupScanningControl.Name = "groupScanningControl";
            this.groupScanningControl.Size = new System.Drawing.Size(226, 83);
            this.groupScanningControl.TabIndex = 9;
            this.groupScanningControl.TabStop = false;
            this.groupScanningControl.Text = "Control";
            // 
            // bStopScanning
            // 
            this.bStopScanning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bStopScanning.Enabled = false;
            this.bStopScanning.Location = new System.Drawing.Point(7, 50);
            this.bStopScanning.Name = "bStopScanning";
            this.bStopScanning.Size = new System.Drawing.Size(213, 23);
            this.bStopScanning.TabIndex = 1;
            this.bStopScanning.Text = "Stop";
            this.bStopScanning.UseVisualStyleBackColor = true;
            this.bStopScanning.Click += new System.EventHandler(this.bStopScanning_Click);
            // 
            // bStartScanning
            // 
            this.bStartScanning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bStartScanning.Enabled = false;
            this.bStartScanning.Location = new System.Drawing.Point(7, 20);
            this.bStartScanning.Name = "bStartScanning";
            this.bStartScanning.Size = new System.Drawing.Size(213, 23);
            this.bStartScanning.TabIndex = 0;
            this.bStartScanning.Text = "Start";
            this.bStartScanning.UseVisualStyleBackColor = true;
            this.bStartScanning.Click += new System.EventHandler(this.bStartScanning_Click);
            // 
            // groupScanningCSV
            // 
            this.groupScanningCSV.Controls.Add(this.bImportScanning);
            this.groupScanningCSV.Controls.Add(this.bExportScanning);
            this.groupScanningCSV.Controls.Add(this.bChooseScanning);
            this.groupScanningCSV.Controls.Add(this.textScanningCSV);
            this.groupScanningCSV.Location = new System.Drawing.Point(7, 3);
            this.groupScanningCSV.Name = "groupScanningCSV";
            this.groupScanningCSV.Size = new System.Drawing.Size(226, 206);
            this.groupScanningCSV.TabIndex = 8;
            this.groupScanningCSV.TabStop = false;
            this.groupScanningCSV.Text = "Chip CSV";
            // 
            // bImportScanning
            // 
            this.bImportScanning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bImportScanning.Location = new System.Drawing.Point(7, 148);
            this.bImportScanning.Name = "bImportScanning";
            this.bImportScanning.Size = new System.Drawing.Size(213, 23);
            this.bImportScanning.TabIndex = 3;
            this.bImportScanning.Text = "Import";
            this.bImportScanning.UseVisualStyleBackColor = true;
            this.bImportScanning.Click += new System.EventHandler(this.bImportScanning_Click);
            // 
            // bExportScanning
            // 
            this.bExportScanning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bExportScanning.Location = new System.Drawing.Point(7, 177);
            this.bExportScanning.Name = "bExportScanning";
            this.bExportScanning.Size = new System.Drawing.Size(213, 23);
            this.bExportScanning.TabIndex = 2;
            this.bExportScanning.Text = "Export";
            this.bExportScanning.UseVisualStyleBackColor = true;
            this.bExportScanning.Click += new System.EventHandler(this.bExportScanning_Click);
            // 
            // bChooseScanning
            // 
            this.bChooseScanning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bChooseScanning.Location = new System.Drawing.Point(7, 46);
            this.bChooseScanning.Name = "bChooseScanning";
            this.bChooseScanning.Size = new System.Drawing.Size(213, 23);
            this.bChooseScanning.TabIndex = 1;
            this.bChooseScanning.Text = "Choose...";
            this.bChooseScanning.UseVisualStyleBackColor = true;
            this.bChooseScanning.Click += new System.EventHandler(this.bChooseScanning_Click);
            // 
            // textScanningCSV
            // 
            this.textScanningCSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textScanningCSV.Location = new System.Drawing.Point(6, 19);
            this.textScanningCSV.Name = "textScanningCSV";
            this.textScanningCSV.Size = new System.Drawing.Size(214, 20);
            this.textScanningCSV.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bClearBibs);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.dataGridBibs);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textCurrentChip);
            this.panel3.Controls.Add(this.bLockBibs);
            this.panel3.Location = new System.Drawing.Point(239, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 474);
            this.panel3.TabIndex = 7;
            // 
            // bClearBibs
            // 
            this.bClearBibs.Location = new System.Drawing.Point(7, 375);
            this.bClearBibs.Name = "bClearBibs";
            this.bClearBibs.Size = new System.Drawing.Size(130, 23);
            this.bClearBibs.TabIndex = 13;
            this.bClearBibs.Text = "Clear Bib List";
            this.bClearBibs.UseVisualStyleBackColor = true;
            this.bClearBibs.Click += new System.EventHandler(this.bClearBibs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bInsertBibRange);
            this.groupBox1.Controls.Add(this.tBibTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tBibFrom);
            this.groupBox1.Location = new System.Drawing.Point(4, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 75);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert Range";
            // 
            // bInsertBibRange
            // 
            this.bInsertBibRange.Location = new System.Drawing.Point(7, 47);
            this.bInsertBibRange.Name = "bInsertBibRange";
            this.bInsertBibRange.Size = new System.Drawing.Size(126, 23);
            this.bInsertBibRange.TabIndex = 3;
            this.bInsertBibRange.Text = "Insert";
            this.bInsertBibRange.UseVisualStyleBackColor = true;
            this.bInsertBibRange.Click += new System.EventHandler(this.bInsertBibRange_Click);
            // 
            // tBibTo
            // 
            this.tBibTo.Location = new System.Drawing.Point(78, 19);
            this.tBibTo.Name = "tBibTo";
            this.tBibTo.Size = new System.Drawing.Size(43, 20);
            this.tBibTo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "to";
            // 
            // tBibFrom
            // 
            this.tBibFrom.Location = new System.Drawing.Point(7, 20);
            this.tBibFrom.Name = "tBibFrom";
            this.tBibFrom.Size = new System.Drawing.Size(43, 20);
            this.tBibFrom.TabIndex = 0;
            // 
            // dataGridBibs
            // 
            this.dataGridBibs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBibs.Location = new System.Drawing.Point(3, 4);
            this.dataGridBibs.Name = "dataGridBibs";
            this.dataGridBibs.Size = new System.Drawing.Size(140, 283);
            this.dataGridBibs.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Current Chip:";
            // 
            // textCurrentChip
            // 
            this.textCurrentChip.Location = new System.Drawing.Point(4, 422);
            this.textCurrentChip.Name = "textCurrentChip";
            this.textCurrentChip.Size = new System.Drawing.Size(139, 20);
            this.textCurrentChip.TabIndex = 9;
            // 
            // bLockBibs
            // 
            this.bLockBibs.Location = new System.Drawing.Point(4, 448);
            this.bLockBibs.Name = "bLockBibs";
            this.bLockBibs.Size = new System.Drawing.Size(139, 23);
            this.bLockBibs.TabIndex = 7;
            this.bLockBibs.Text = "Lock";
            this.bLockBibs.UseVisualStyleBackColor = true;
            this.bLockBibs.Click += new System.EventHandler(this.bLockBibs_Click);
            // 
            // textConsole2
            // 
            this.textConsole2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textConsole2.Location = new System.Drawing.Point(239, 482);
            this.textConsole2.Multiline = true;
            this.textConsole2.Name = "textConsole2";
            this.textConsole2.Size = new System.Drawing.Size(710, 151);
            this.textConsole2.TabIndex = 5;
            // 
            // dataCSVView
            // 
            this.dataCSVView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCSVView.Location = new System.Drawing.Point(391, 2);
            this.dataCSVView.Name = "dataCSVView";
            this.dataCSVView.Size = new System.Drawing.Size(561, 474);
            this.dataCSVView.TabIndex = 0;
            // 
            // tabDelete
            // 
            this.tabDelete.BackColor = System.Drawing.SystemColors.Control;
            this.tabDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDelete.Controls.Add(this.textConsole3);
            this.tabDelete.Controls.Add(this.bDeleteBox);
            this.tabDelete.Location = new System.Drawing.Point(4, 25);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(957, 641);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Delete";
            // 
            // textConsole3
            // 
            this.textConsole3.Location = new System.Drawing.Point(358, 8);
            this.textConsole3.Multiline = true;
            this.textConsole3.Name = "textConsole3";
            this.textConsole3.Size = new System.Drawing.Size(594, 397);
            this.textConsole3.TabIndex = 1;
            // 
            // bDeleteBox
            // 
            this.bDeleteBox.Location = new System.Drawing.Point(12, 17);
            this.bDeleteBox.Name = "bDeleteBox";
            this.bDeleteBox.Size = new System.Drawing.Size(340, 148);
            this.bDeleteBox.TabIndex = 0;
            this.bDeleteBox.Text = "Delete";
            this.bDeleteBox.UseVisualStyleBackColor = true;
            this.bDeleteBox.Click += new System.EventHandler(this.bDeleteBox_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.groupConnection);
            this.panel2.Controls.Add(this.groupBoxSelect);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 694);
            this.panel2.TabIndex = 5;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // backgroundScanner
            // 
            this.backgroundScanner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundScanner_DoWork);
            // 
            // bShowLive
            // 
            this.bShowLive.Location = new System.Drawing.Point(3, 180);
            this.bShowLive.Name = "bShowLive";
            this.bShowLive.Size = new System.Drawing.Size(178, 23);
            this.bShowLive.TabIndex = 2;
            this.bShowLive.Text = "Live Results";
            this.bShowLive.UseVisualStyleBackColor = true;
            // 
            // DataBoxer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl);
            this.Name = "DataBoxer";
            this.Text = "DataBoxer";
            this.Load += new System.EventHandler(this.DataBoxer_Load);
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.groupConnection.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupCommDatFile.ResumeLayout(false);
            this.groupCommDatFile.PerformLayout();
            this.groupBoxControl.ResumeLayout(false);
            this.groupConsole1.ResumeLayout(false);
            this.groupConsole1.PerformLayout();
            this.tabScan.ResumeLayout(false);
            this.tabScan.PerformLayout();
            this.groupScanningControl.ResumeLayout(false);
            this.groupScanningCSV.ResumeLayout(false);
            this.groupScanningCSV.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBibs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCSVView)).EndInit();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bmaxplus;
        private System.Windows.Forms.Button bmaxminus;
        private System.Windows.Forms.TextBox tmax;
        private System.Windows.Forms.Button bminplus;
        private System.Windows.Forms.Button bminminus;
        private System.Windows.Forms.TextBox tmin;
        private System.Windows.Forms.GroupBox groupConnection;
        private System.Windows.Forms.ComboBox combox;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupCommDatFile;
        private System.Windows.Forms.Button bChooseCommdat;
        private System.Windows.Forms.Button bOpenFileLocation;
        private System.Windows.Forms.TextBox tFileName;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.Button bReloadData;
        private System.Windows.Forms.Button bSyncronize;
        private System.Windows.Forms.Button bStopDownload;
        private System.Windows.Forms.Button bStartDownload;
        private System.Windows.Forms.Button bDownloadSingle;
        private System.Windows.Forms.GroupBox groupConsole1;
        private System.Windows.Forms.TextBox textconsole1;
        private System.Windows.Forms.TabPage tabScan;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupScanningControl;
        private System.Windows.Forms.Button bStopScanning;
        private System.Windows.Forms.Button bStartScanning;
        private System.Windows.Forms.GroupBox groupScanningCSV;
        private System.Windows.Forms.Button bImportScanning;
        private System.Windows.Forms.Button bExportScanning;
        private System.Windows.Forms.Button bChooseScanning;
        private System.Windows.Forms.TextBox textScanningCSV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bLockBibs;
        private System.Windows.Forms.TextBox textConsole2;
        private System.Windows.Forms.DataGridView dataCSVView;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDownload;
        private System.Windows.Forms.OpenFileDialog openFileDialogScanning;
        private System.ComponentModel.BackgroundWorker backgroundScanner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCurrentChip;
        private System.Windows.Forms.DataGridView dataGridBibs;
        private System.Windows.Forms.Button bClearBibs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bInsertBibRange;
        private System.Windows.Forms.TextBox tBibTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBibFrom;
        private System.Windows.Forms.Button bDeleteBox;
        private System.Windows.Forms.TextBox textConsole3;
        private System.Windows.Forms.Button bShowLive;

    }
}