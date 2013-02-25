namespace DataBoxer
{
    partial class LiveResults
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridLiveResults = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileChips = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tFileChip = new System.Windows.Forms.TextBox();
            this.tFileRunners = new System.Windows.Forms.TextBox();
            this.bImportRunners = new System.Windows.Forms.Button();
            this.bImportChips = new System.Windows.Forms.Button();
            this.bChooseFileRunners = new System.Windows.Forms.Button();
            this.bChooseFileChip = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLiveResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 546);
            this.panel1.TabIndex = 0;
            // 
            // dataGridLiveResults
            // 
            this.dataGridLiveResults.AllowUserToAddRows = false;
            this.dataGridLiveResults.AllowUserToDeleteRows = false;
            this.dataGridLiveResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLiveResults.Location = new System.Drawing.Point(255, 13);
            this.dataGridLiveResults.Name = "dataGridLiveResults";
            this.dataGridLiveResults.ReadOnly = true;
            this.dataGridLiveResults.Size = new System.Drawing.Size(767, 546);
            this.dataGridLiveResults.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bChooseFileChip);
            this.groupBox1.Controls.Add(this.bImportChips);
            this.groupBox1.Controls.Add(this.tFileChip);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chip Allocations";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bChooseFileRunners);
            this.groupBox2.Controls.Add(this.bImportRunners);
            this.groupBox2.Controls.Add(this.tFileRunners);
            this.groupBox2.Location = new System.Drawing.Point(4, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Runners";
            // 
            // openFileChips
            // 
            this.openFileChips.FileName = "openFileDialog1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileRunners";
            // 
            // tFileChip
            // 
            this.tFileChip.Dock = System.Windows.Forms.DockStyle.Top;
            this.tFileChip.Location = new System.Drawing.Point(3, 16);
            this.tFileChip.Name = "tFileChip";
            this.tFileChip.Size = new System.Drawing.Size(223, 20);
            this.tFileChip.TabIndex = 3;
            // 
            // tFileRunners
            // 
            this.tFileRunners.Dock = System.Windows.Forms.DockStyle.Top;
            this.tFileRunners.Location = new System.Drawing.Point(3, 16);
            this.tFileRunners.Name = "tFileRunners";
            this.tFileRunners.Size = new System.Drawing.Size(223, 20);
            this.tFileRunners.TabIndex = 3;
            // 
            // bImportRunners
            // 
            this.bImportRunners.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bImportRunners.Location = new System.Drawing.Point(4, 71);
            this.bImportRunners.Name = "bImportRunners";
            this.bImportRunners.Size = new System.Drawing.Size(223, 23);
            this.bImportRunners.TabIndex = 6;
            this.bImportRunners.Text = "Import";
            this.bImportRunners.UseVisualStyleBackColor = true;
            this.bImportRunners.Click += new System.EventHandler(this.bImportRunners_Click);
            // 
            // bImportChips
            // 
            this.bImportChips.Location = new System.Drawing.Point(3, 71);
            this.bImportChips.Name = "bImportChips";
            this.bImportChips.Size = new System.Drawing.Size(220, 23);
            this.bImportChips.TabIndex = 6;
            this.bImportChips.Text = "Import";
            this.bImportChips.UseVisualStyleBackColor = true;
            // 
            // bChooseFileRunners
            // 
            this.bChooseFileRunners.Location = new System.Drawing.Point(3, 42);
            this.bChooseFileRunners.Name = "bChooseFileRunners";
            this.bChooseFileRunners.Size = new System.Drawing.Size(223, 23);
            this.bChooseFileRunners.TabIndex = 7;
            this.bChooseFileRunners.Text = "Choose";
            this.bChooseFileRunners.UseVisualStyleBackColor = true;
            // 
            // bChooseFileChip
            // 
            this.bChooseFileChip.Location = new System.Drawing.Point(2, 42);
            this.bChooseFileChip.Name = "bChooseFileChip";
            this.bChooseFileChip.Size = new System.Drawing.Size(220, 23);
            this.bChooseFileChip.TabIndex = 7;
            this.bChooseFileChip.Text = "Choose";
            this.bChooseFileChip.UseVisualStyleBackColor = true;
            // 
            // LiveResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 571);
            this.Controls.Add(this.dataGridLiveResults);
            this.Controls.Add(this.panel1);
            this.Name = "LiveResults";
            this.Text = "LiveResults";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLiveResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridLiveResults;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileChips;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bChooseFileRunners;
        private System.Windows.Forms.Button bImportRunners;
        private System.Windows.Forms.TextBox tFileRunners;
        private System.Windows.Forms.Button bImportChips;
        private System.Windows.Forms.TextBox tFileChip;
        private System.Windows.Forms.Button bChooseFileChip;
    }
}