namespace DataBoxer
{
    partial class Form1
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
            this.combox = new System.Windows.Forms.ComboBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.textconsole = new System.Windows.Forms.TextBox();
            this.bDownload = new System.Windows.Forms.Button();
            this.bReload = new System.Windows.Forms.Button();
            this.tOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bAutoDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bmaxplus = new System.Windows.Forms.Button();
            this.bmaxminus = new System.Windows.Forms.Button();
            this.tmax = new System.Windows.Forms.TextBox();
            this.bminplus = new System.Windows.Forms.Button();
            this.bminminus = new System.Windows.Forms.Button();
            this.tmin = new System.Windows.Forms.TextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combox
            // 
            this.combox.FormattingEnabled = true;
            this.combox.Location = new System.Drawing.Point(6, 19);
            this.combox.Name = "combox";
            this.combox.Size = new System.Drawing.Size(168, 21);
            this.combox.TabIndex = 0;
            this.combox.SelectedIndexChanged += new System.EventHandler(this.combox_SelectedIndexChanged);
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(6, 47);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(168, 23);
            this.bConnect.TabIndex = 1;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bDisconnect
            // 
            this.bDisconnect.Location = new System.Drawing.Point(6, 77);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(168, 23);
            this.bDisconnect.TabIndex = 2;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // textconsole
            // 
            this.textconsole.Location = new System.Drawing.Point(198, 12);
            this.textconsole.Multiline = true;
            this.textconsole.Name = "textconsole";
            this.textconsole.Size = new System.Drawing.Size(690, 440);
            this.textconsole.TabIndex = 3;
            // 
            // bDownload
            // 
            this.bDownload.Location = new System.Drawing.Point(5, 240);
            this.bDownload.Name = "bDownload";
            this.bDownload.Size = new System.Drawing.Size(169, 23);
            this.bDownload.TabIndex = 4;
            this.bDownload.Text = "Download Package";
            this.bDownload.UseVisualStyleBackColor = true;
            this.bDownload.Click += new System.EventHandler(this.bDownload_Click);
            // 
            // bReload
            // 
            this.bReload.Location = new System.Drawing.Point(6, 211);
            this.bReload.Name = "bReload";
            this.bReload.Size = new System.Drawing.Size(168, 23);
            this.bReload.TabIndex = 5;
            this.bReload.Text = "Reload Data";
            this.bReload.UseVisualStyleBackColor = true;
            this.bReload.Click += new System.EventHandler(this.bReload_Click);
            // 
            // tOutput
            // 
            this.tOutput.Location = new System.Drawing.Point(6, 107);
            this.tOutput.Name = "tOutput";
            this.tOutput.Size = new System.Drawing.Size(168, 20);
            this.tOutput.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Choose...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bAutoDownload);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bmaxplus);
            this.groupBox1.Controls.Add(this.bmaxminus);
            this.groupBox1.Controls.Add(this.tmax);
            this.groupBox1.Controls.Add(this.bminplus);
            this.groupBox1.Controls.Add(this.bminminus);
            this.groupBox1.Controls.Add(this.tmin);
            this.groupBox1.Controls.Add(this.bReload);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.combox);
            this.groupBox1.Controls.Add(this.tOutput);
            this.groupBox1.Controls.Add(this.bConnect);
            this.groupBox1.Controls.Add(this.bDisconnect);
            this.groupBox1.Controls.Add(this.bDownload);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 440);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // bAutoDownload
            // 
            this.bAutoDownload.Location = new System.Drawing.Point(7, 393);
            this.bAutoDownload.Name = "bAutoDownload";
            this.bAutoDownload.Size = new System.Drawing.Size(167, 41);
            this.bAutoDownload.TabIndex = 17;
            this.bAutoDownload.Text = "Auto Download";
            this.bAutoDownload.UseVisualStyleBackColor = true;
            this.bAutoDownload.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Location = new System.Drawing.Point(40, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Location = new System.Drawing.Point(40, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "From:";
            // 
            // bmaxplus
            // 
            this.bmaxplus.Location = new System.Drawing.Point(76, 332);
            this.bmaxplus.Name = "bmaxplus";
            this.bmaxplus.Size = new System.Drawing.Size(23, 23);
            this.bmaxplus.TabIndex = 14;
            this.bmaxplus.Text = ">";
            this.bmaxplus.UseVisualStyleBackColor = true;
            this.bmaxplus.Click += new System.EventHandler(this.tmaxplus_Click_1);
            // 
            // bmaxminus
            // 
            this.bmaxminus.Location = new System.Drawing.Point(12, 332);
            this.bmaxminus.Name = "bmaxminus";
            this.bmaxminus.Size = new System.Drawing.Size(25, 23);
            this.bmaxminus.TabIndex = 13;
            this.bmaxminus.Text = "<";
            this.bmaxminus.UseVisualStyleBackColor = true;
            this.bmaxminus.Click += new System.EventHandler(this.bmaxminus_Click);
            // 
            // tmax
            // 
            this.tmax.Location = new System.Drawing.Point(43, 333);
            this.tmax.Name = "tmax";
            this.tmax.ReadOnly = true;
            this.tmax.Size = new System.Drawing.Size(27, 20);
            this.tmax.TabIndex = 12;
            this.tmax.Text = "1";
            // 
            // bminplus
            // 
            this.bminplus.Location = new System.Drawing.Point(76, 288);
            this.bminplus.Name = "bminplus";
            this.bminplus.Size = new System.Drawing.Size(23, 23);
            this.bminplus.TabIndex = 11;
            this.bminplus.Text = ">";
            this.bminplus.UseVisualStyleBackColor = true;
            this.bminplus.Click += new System.EventHandler(this.bminplus_Click);
            // 
            // bminminus
            // 
            this.bminminus.Location = new System.Drawing.Point(12, 288);
            this.bminminus.Name = "bminminus";
            this.bminminus.Size = new System.Drawing.Size(25, 23);
            this.bminminus.TabIndex = 10;
            this.bminminus.Text = "<";
            this.bminminus.UseVisualStyleBackColor = true;
            this.bminminus.Click += new System.EventHandler(this.bminminus_Click);
            // 
            // tmin
            // 
            this.tmin.Location = new System.Drawing.Point(43, 289);
            this.tmin.Name = "tmin";
            this.tmin.ReadOnly = true;
            this.tmin.Size = new System.Drawing.Size(27, 20);
            this.tmin.TabIndex = 8;
            this.tmin.Text = "1";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textconsole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combox;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.TextBox textconsole;
        private System.Windows.Forms.Button bDownload;
        private System.Windows.Forms.Button bReload;
        private System.Windows.Forms.TextBox tOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bmaxplus;
        private System.Windows.Forms.Button bmaxminus;
        private System.Windows.Forms.TextBox tmax;
        private System.Windows.Forms.Button bminplus;
        private System.Windows.Forms.Button bminminus;
        private System.Windows.Forms.TextBox tmin;
        private System.Windows.Forms.Button bAutoDownload;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button button2;
    }
}

