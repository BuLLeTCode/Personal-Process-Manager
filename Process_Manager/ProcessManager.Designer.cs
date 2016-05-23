namespace Process_Manager
{
    partial class ProcessManager
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
            System.Windows.Forms.Label lblWriteSpeedDisk;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessManager));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProcesses = new System.Windows.Forms.DataGridView();
            this.gbRAM = new System.Windows.Forms.GroupBox();
            this.tbTotalRAM = new System.Windows.Forms.TextBox();
            this.lblTotalRAM = new System.Windows.Forms.Label();
            this.tbUseRAM = new System.Windows.Forms.TextBox();
            this.lblUseRAM = new System.Windows.Forms.Label();
            this.tbAvaibleRAM = new System.Windows.Forms.TextBox();
            this.lblAvaibleRAM = new System.Windows.Forms.Label();
            this.btnViewInExcel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbThreadSwitch = new System.Windows.Forms.TextBox();
            this.lblThreadsSwitch = new System.Windows.Forms.Label();
            this.tbThreadsCPU = new System.Windows.Forms.TextBox();
            this.lblThreadsCPU = new System.Windows.Forms.Label();
            this.tbLoadCPU = new System.Windows.Forms.TextBox();
            this.lblLoadCPU = new System.Windows.Forms.Label();
            this.gbHardDisk = new System.Windows.Forms.GroupBox();
            this.tbReadSpeedDisk = new System.Windows.Forms.TextBox();
            this.lblReadSpeedDisk = new System.Windows.Forms.Label();
            this.tbWriteSpeedDisk = new System.Windows.Forms.TextBox();
            this.tbSystemRequestDisk = new System.Windows.Forms.TextBox();
            this.lblSystemRequestDisk = new System.Windows.Forms.Label();
            this.tbDiskBusy = new System.Windows.Forms.TextBox();
            this.lblDiskBusy = new System.Windows.Forms.Label();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnWindowsTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExitButton = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            lblWriteSpeedDisk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesses)).BeginInit();
            this.gbRAM.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbHardDisk.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWriteSpeedDisk
            // 
            lblWriteSpeedDisk.AutoSize = true;
            lblWriteSpeedDisk.Location = new System.Drawing.Point(2, 65);
            lblWriteSpeedDisk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblWriteSpeedDisk.Name = "lblWriteSpeedDisk";
            lblWriteSpeedDisk.Size = new System.Drawing.Size(106, 13);
            lblWriteSpeedDisk.TabIndex = 4;
            lblWriteSpeedDisk.Text = "Rakstīšanas ātrums: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procesu pārvaldnieks";
            // 
            // dgvProcesses
            // 
            this.dgvProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnWindowsTitle});
            this.dgvProcesses.Location = new System.Drawing.Point(9, 205);
            this.dgvProcesses.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProcesses.Name = "dgvProcesses";
            this.dgvProcesses.RowTemplate.Height = 24;
            this.dgvProcesses.Size = new System.Drawing.Size(538, 288);
            this.dgvProcesses.TabIndex = 1;
            // 
            // gbRAM
            // 
            this.gbRAM.Controls.Add(this.tbTotalRAM);
            this.gbRAM.Controls.Add(this.lblTotalRAM);
            this.gbRAM.Controls.Add(this.tbUseRAM);
            this.gbRAM.Controls.Add(this.lblUseRAM);
            this.gbRAM.Controls.Add(this.tbAvaibleRAM);
            this.gbRAM.Controls.Add(this.lblAvaibleRAM);
            this.gbRAM.Location = new System.Drawing.Point(225, 47);
            this.gbRAM.Margin = new System.Windows.Forms.Padding(2);
            this.gbRAM.Name = "gbRAM";
            this.gbRAM.Padding = new System.Windows.Forms.Padding(2);
            this.gbRAM.Size = new System.Drawing.Size(202, 93);
            this.gbRAM.TabIndex = 2;
            this.gbRAM.TabStop = false;
            this.gbRAM.Text = "RAM";
            // 
            // tbTotalRAM
            // 
            this.tbTotalRAM.Location = new System.Drawing.Point(87, 58);
            this.tbTotalRAM.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotalRAM.Name = "tbTotalRAM";
            this.tbTotalRAM.ReadOnly = true;
            this.tbTotalRAM.Size = new System.Drawing.Size(76, 20);
            this.tbTotalRAM.TabIndex = 5;
            // 
            // lblTotalRAM
            // 
            this.lblTotalRAM.AutoSize = true;
            this.lblTotalRAM.Location = new System.Drawing.Point(2, 60);
            this.lblTotalRAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRAM.Name = "lblTotalRAM";
            this.lblTotalRAM.Size = new System.Drawing.Size(35, 13);
            this.lblTotalRAM.TabIndex = 4;
            this.lblTotalRAM.Text = "Kopā:";
            // 
            // tbUseRAM
            // 
            this.tbUseRAM.Location = new System.Drawing.Point(87, 35);
            this.tbUseRAM.Margin = new System.Windows.Forms.Padding(2);
            this.tbUseRAM.Name = "tbUseRAM";
            this.tbUseRAM.ReadOnly = true;
            this.tbUseRAM.Size = new System.Drawing.Size(76, 20);
            this.tbUseRAM.TabIndex = 3;
            // 
            // lblUseRAM
            // 
            this.lblUseRAM.AutoSize = true;
            this.lblUseRAM.Location = new System.Drawing.Point(2, 37);
            this.lblUseRAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUseRAM.Name = "lblUseRAM";
            this.lblUseRAM.Size = new System.Drawing.Size(78, 13);
            this.lblUseRAM.TabIndex = 2;
            this.lblUseRAM.Text = "Tiek izmantots:";
            // 
            // tbAvaibleRAM
            // 
            this.tbAvaibleRAM.Location = new System.Drawing.Point(87, 12);
            this.tbAvaibleRAM.Margin = new System.Windows.Forms.Padding(2);
            this.tbAvaibleRAM.Name = "tbAvaibleRAM";
            this.tbAvaibleRAM.ReadOnly = true;
            this.tbAvaibleRAM.Size = new System.Drawing.Size(76, 20);
            this.tbAvaibleRAM.TabIndex = 1;
            // 
            // lblAvaibleRAM
            // 
            this.lblAvaibleRAM.AutoSize = true;
            this.lblAvaibleRAM.Location = new System.Drawing.Point(2, 15);
            this.lblAvaibleRAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvaibleRAM.Name = "lblAvaibleRAM";
            this.lblAvaibleRAM.Size = new System.Drawing.Size(52, 13);
            this.lblAvaibleRAM.TabIndex = 0;
            this.lblAvaibleRAM.Text = "Pieejams:";
            // 
            // btnViewInExcel
            // 
            this.btnViewInExcel.Location = new System.Drawing.Point(9, 500);
            this.btnViewInExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewInExcel.Name = "btnViewInExcel";
            this.btnViewInExcel.Size = new System.Drawing.Size(68, 36);
            this.btnViewInExcel.TabIndex = 3;
            this.btnViewInExcel.Text = "Skatīties Excel";
            this.btnViewInExcel.UseVisualStyleBackColor = true;
            this.btnViewInExcel.Click += new System.EventHandler(this.btnViewInExcel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbThreadSwitch);
            this.groupBox1.Controls.Add(this.lblThreadsSwitch);
            this.groupBox1.Controls.Add(this.tbThreadsCPU);
            this.groupBox1.Controls.Add(this.lblThreadsCPU);
            this.groupBox1.Controls.Add(this.tbLoadCPU);
            this.groupBox1.Controls.Add(this.lblLoadCPU);
            this.groupBox1.Location = new System.Drawing.Point(9, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(202, 93);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procesors";
            // 
            // tbThreadSwitch
            // 
            this.tbThreadSwitch.Location = new System.Drawing.Point(122, 65);
            this.tbThreadSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.tbThreadSwitch.Name = "tbThreadSwitch";
            this.tbThreadSwitch.ReadOnly = true;
            this.tbThreadSwitch.Size = new System.Drawing.Size(76, 20);
            this.tbThreadSwitch.TabIndex = 11;
            // 
            // lblThreadsSwitch
            // 
            this.lblThreadsSwitch.AutoSize = true;
            this.lblThreadsSwitch.Location = new System.Drawing.Point(7, 68);
            this.lblThreadsSwitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThreadsSwitch.Name = "lblThreadsSwitch";
            this.lblThreadsSwitch.Size = new System.Drawing.Size(103, 13);
            this.lblThreadsSwitch.TabIndex = 10;
            this.lblThreadsSwitch.Text = "Threads switch rate:";
            // 
            // tbThreadsCPU
            // 
            this.tbThreadsCPU.Location = new System.Drawing.Point(122, 41);
            this.tbThreadsCPU.Margin = new System.Windows.Forms.Padding(2);
            this.tbThreadsCPU.Name = "tbThreadsCPU";
            this.tbThreadsCPU.ReadOnly = true;
            this.tbThreadsCPU.Size = new System.Drawing.Size(76, 20);
            this.tbThreadsCPU.TabIndex = 9;
            // 
            // lblThreadsCPU
            // 
            this.lblThreadsCPU.AutoSize = true;
            this.lblThreadsCPU.Location = new System.Drawing.Point(7, 44);
            this.lblThreadsCPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThreadsCPU.Name = "lblThreadsCPU";
            this.lblThreadsCPU.Size = new System.Drawing.Size(116, 13);
            this.lblThreadsCPU.TabIndex = 8;
            this.lblThreadsCPU.Text = "System Threads switch";
            // 
            // tbLoadCPU
            // 
            this.tbLoadCPU.Location = new System.Drawing.Point(122, 12);
            this.tbLoadCPU.Margin = new System.Windows.Forms.Padding(2);
            this.tbLoadCPU.Name = "tbLoadCPU";
            this.tbLoadCPU.ReadOnly = true;
            this.tbLoadCPU.Size = new System.Drawing.Size(76, 20);
            this.tbLoadCPU.TabIndex = 7;
            // 
            // lblLoadCPU
            // 
            this.lblLoadCPU.AutoSize = true;
            this.lblLoadCPU.Location = new System.Drawing.Point(7, 20);
            this.lblLoadCPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoadCPU.Name = "lblLoadCPU";
            this.lblLoadCPU.Size = new System.Drawing.Size(87, 13);
            this.lblLoadCPU.TabIndex = 6;
            this.lblLoadCPU.Text = "Noslogojums (%):";
            // 
            // gbHardDisk
            // 
            this.gbHardDisk.Controls.Add(this.tbReadSpeedDisk);
            this.gbHardDisk.Controls.Add(this.lblReadSpeedDisk);
            this.gbHardDisk.Controls.Add(this.tbWriteSpeedDisk);
            this.gbHardDisk.Controls.Add(lblWriteSpeedDisk);
            this.gbHardDisk.Controls.Add(this.tbSystemRequestDisk);
            this.gbHardDisk.Controls.Add(this.lblSystemRequestDisk);
            this.gbHardDisk.Controls.Add(this.tbDiskBusy);
            this.gbHardDisk.Controls.Add(this.lblDiskBusy);
            this.gbHardDisk.Location = new System.Drawing.Point(443, 47);
            this.gbHardDisk.Margin = new System.Windows.Forms.Padding(2);
            this.gbHardDisk.Name = "gbHardDisk";
            this.gbHardDisk.Padding = new System.Windows.Forms.Padding(2);
            this.gbHardDisk.Size = new System.Drawing.Size(202, 117);
            this.gbHardDisk.TabIndex = 6;
            this.gbHardDisk.TabStop = false;
            this.gbHardDisk.Text = "Cietais disks:";
            // 
            // tbReadSpeedDisk
            // 
            this.tbReadSpeedDisk.Location = new System.Drawing.Point(116, 86);
            this.tbReadSpeedDisk.Margin = new System.Windows.Forms.Padding(2);
            this.tbReadSpeedDisk.Name = "tbReadSpeedDisk";
            this.tbReadSpeedDisk.ReadOnly = true;
            this.tbReadSpeedDisk.Size = new System.Drawing.Size(76, 20);
            this.tbReadSpeedDisk.TabIndex = 7;
            // 
            // lblReadSpeedDisk
            // 
            this.lblReadSpeedDisk.AutoSize = true;
            this.lblReadSpeedDisk.Location = new System.Drawing.Point(2, 89);
            this.lblReadSpeedDisk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReadSpeedDisk.Name = "lblReadSpeedDisk";
            this.lblReadSpeedDisk.Size = new System.Drawing.Size(92, 13);
            this.lblReadSpeedDisk.TabIndex = 6;
            this.lblReadSpeedDisk.Text = "Lasīšanas ātrums:";
            // 
            // tbWriteSpeedDisk
            // 
            this.tbWriteSpeedDisk.Location = new System.Drawing.Point(116, 62);
            this.tbWriteSpeedDisk.Margin = new System.Windows.Forms.Padding(2);
            this.tbWriteSpeedDisk.Name = "tbWriteSpeedDisk";
            this.tbWriteSpeedDisk.ReadOnly = true;
            this.tbWriteSpeedDisk.Size = new System.Drawing.Size(76, 20);
            this.tbWriteSpeedDisk.TabIndex = 5;
            // 
            // tbSystemRequestDisk
            // 
            this.tbSystemRequestDisk.Location = new System.Drawing.Point(116, 37);
            this.tbSystemRequestDisk.Margin = new System.Windows.Forms.Padding(2);
            this.tbSystemRequestDisk.Name = "tbSystemRequestDisk";
            this.tbSystemRequestDisk.ReadOnly = true;
            this.tbSystemRequestDisk.Size = new System.Drawing.Size(76, 20);
            this.tbSystemRequestDisk.TabIndex = 3;
            // 
            // lblSystemRequestDisk
            // 
            this.lblSystemRequestDisk.AutoSize = true;
            this.lblSystemRequestDisk.Location = new System.Drawing.Point(2, 38);
            this.lblSystemRequestDisk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSystemRequestDisk.Name = "lblSystemRequestDisk";
            this.lblSystemRequestDisk.Size = new System.Drawing.Size(110, 13);
            this.lblSystemRequestDisk.TabIndex = 2;
            this.lblSystemRequestDisk.Text = "Sistēmas pieprasījumi:";
            // 
            // tbDiskBusy
            // 
            this.tbDiskBusy.Location = new System.Drawing.Point(116, 12);
            this.tbDiskBusy.Margin = new System.Windows.Forms.Padding(2);
            this.tbDiskBusy.Name = "tbDiskBusy";
            this.tbDiskBusy.ReadOnly = true;
            this.tbDiskBusy.Size = new System.Drawing.Size(76, 20);
            this.tbDiskBusy.TabIndex = 1;
            // 
            // lblDiskBusy
            // 
            this.lblDiskBusy.AutoSize = true;
            this.lblDiskBusy.Location = new System.Drawing.Point(2, 15);
            this.lblDiskBusy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiskBusy.Name = "lblDiskBusy";
            this.lblDiskBusy.Size = new System.Drawing.Size(94, 13);
            this.lblDiskBusy.TabIndex = 0;
            this.lblDiskBusy.Text = "Disks nodarbināts:";
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Nosaukums";
            this.columnName.Name = "columnName";
            // 
            // columnWindowsTitle
            // 
            this.columnWindowsTitle.HeaderText = "Windows virsraksts";
            this.columnWindowsTitle.Name = "columnWindowsTitle";
            // 
            // btnExitButton
            // 
            this.btnExitButton.Location = new System.Drawing.Point(90, 500);
            this.btnExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitButton.Name = "btnExitButton";
            this.btnExitButton.Size = new System.Drawing.Size(68, 36);
            this.btnExitButton.TabIndex = 7;
            this.btnExitButton.Text = "Iziet";
            this.btnExitButton.UseVisualStyleBackColor = true;
            this.btnExitButton.Click += new System.EventHandler(this.btnExitButton_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(559, 245);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(276, 248);
            this.tbInfo.TabIndex = 8;
            this.tbInfo.Text = resources.GetString("tbInfo.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(652, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Informācija";
            // 
            // ProcessManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(847, 546);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.btnExitButton);
            this.Controls.Add(this.gbHardDisk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnViewInExcel);
            this.Controls.Add(this.gbRAM);
            this.Controls.Add(this.dgvProcesses);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ProcessManager";
            this.Text = "Procesu pārvaldnieks";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesses)).EndInit();
            this.gbRAM.ResumeLayout(false);
            this.gbRAM.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbHardDisk.ResumeLayout(false);
            this.gbHardDisk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProcesses;
        private System.Windows.Forms.GroupBox gbRAM;
        private System.Windows.Forms.TextBox tbAvaibleRAM;
        private System.Windows.Forms.Label lblAvaibleRAM;
        private System.Windows.Forms.TextBox tbUseRAM;
        private System.Windows.Forms.Label lblUseRAM;
        private System.Windows.Forms.TextBox tbTotalRAM;
        private System.Windows.Forms.Label lblTotalRAM;
        private System.Windows.Forms.Button btnViewInExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLoadCPU;
        private System.Windows.Forms.Label lblLoadCPU;
        private System.Windows.Forms.TextBox tbThreadsCPU;
        private System.Windows.Forms.Label lblThreadsCPU;
        private System.Windows.Forms.TextBox tbThreadSwitch;
        private System.Windows.Forms.Label lblThreadsSwitch;
        private System.Windows.Forms.TextBox tbDiskBusy;
        private System.Windows.Forms.Label lblDiskBusy;
        private System.Windows.Forms.GroupBox gbHardDisk;
        private System.Windows.Forms.TextBox tbSystemRequestDisk;
        private System.Windows.Forms.Label lblSystemRequestDisk;
        private System.Windows.Forms.TextBox tbReadSpeedDisk;
        private System.Windows.Forms.Label lblReadSpeedDisk;
        private System.Windows.Forms.TextBox tbWriteSpeedDisk;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWindowsTitle;
        private System.Windows.Forms.Button btnExitButton;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label label2;
    }
}

