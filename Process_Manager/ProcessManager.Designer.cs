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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProcesses = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnWindowsTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesses)).BeginInit();
            this.gbRAM.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.columnWindowsTitle,
            this.column_CPU});
            this.dgvProcesses.Location = new System.Drawing.Point(9, 205);
            this.dgvProcesses.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProcesses.Name = "dgvProcesses";
            this.dgvProcesses.RowTemplate.Height = 24;
            this.dgvProcesses.Size = new System.Drawing.Size(538, 288);
            this.dgvProcesses.TabIndex = 1;
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
            // column_CPU
            // 
            this.column_CPU.HeaderText = "CPU";
            this.column_CPU.Name = "column_CPU";
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
            // ProcessManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 546);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnViewInExcel);
            this.Controls.Add(this.gbRAM);
            this.Controls.Add(this.dgvProcesses);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProcessManager";
            this.Text = "Procesu pārvaldnieks";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesses)).EndInit();
            this.gbRAM.ResumeLayout(false);
            this.gbRAM.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWindowsTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_CPU;
        private System.Windows.Forms.TextBox tbLoadCPU;
        private System.Windows.Forms.Label lblLoadCPU;
        private System.Windows.Forms.TextBox tbThreadsCPU;
        private System.Windows.Forms.Label lblThreadsCPU;
        private System.Windows.Forms.TextBox tbThreadSwitch;
        private System.Windows.Forms.Label lblThreadsSwitch;
    }
}

