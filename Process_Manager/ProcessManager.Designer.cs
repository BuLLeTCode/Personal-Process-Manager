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
            this.gbRAM = new System.Windows.Forms.GroupBox();
            this.tbTotalRAM = new System.Windows.Forms.TextBox();
            this.lblTotalRAM = new System.Windows.Forms.Label();
            this.tbUseRAM = new System.Windows.Forms.TextBox();
            this.lblUseRAM = new System.Windows.Forms.Label();
            this.tbAvaibleRAM = new System.Windows.Forms.TextBox();
            this.lblAvaibleRAM = new System.Windows.Forms.Label();
            this.btnViewInExcel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbThreadProcessor = new System.Windows.Forms.TextBox();
            this.lblThreadProcessor = new System.Windows.Forms.Label();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnWindowsTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesses)).BeginInit();
            this.gbRAM.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
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
            this.dgvProcesses.Location = new System.Drawing.Point(12, 252);
            this.dgvProcesses.Name = "dgvProcesses";
            this.dgvProcesses.RowTemplate.Height = 24;
            this.dgvProcesses.Size = new System.Drawing.Size(717, 355);
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
            this.gbRAM.Location = new System.Drawing.Point(300, 58);
            this.gbRAM.Name = "gbRAM";
            this.gbRAM.Size = new System.Drawing.Size(269, 114);
            this.gbRAM.TabIndex = 2;
            this.gbRAM.TabStop = false;
            this.gbRAM.Text = "RAM";
            // 
            // tbTotalRAM
            // 
            this.tbTotalRAM.Location = new System.Drawing.Point(116, 71);
            this.tbTotalRAM.Name = "tbTotalRAM";
            this.tbTotalRAM.ReadOnly = true;
            this.tbTotalRAM.Size = new System.Drawing.Size(100, 22);
            this.tbTotalRAM.TabIndex = 5;
            // 
            // lblTotalRAM
            // 
            this.lblTotalRAM.AutoSize = true;
            this.lblTotalRAM.Location = new System.Drawing.Point(3, 74);
            this.lblTotalRAM.Name = "lblTotalRAM";
            this.lblTotalRAM.Size = new System.Drawing.Size(45, 17);
            this.lblTotalRAM.TabIndex = 4;
            this.lblTotalRAM.Text = "Kopā:";
            // 
            // tbUseRAM
            // 
            this.tbUseRAM.Location = new System.Drawing.Point(116, 43);
            this.tbUseRAM.Name = "tbUseRAM";
            this.tbUseRAM.ReadOnly = true;
            this.tbUseRAM.Size = new System.Drawing.Size(100, 22);
            this.tbUseRAM.TabIndex = 3;
            // 
            // lblUseRAM
            // 
            this.lblUseRAM.AutoSize = true;
            this.lblUseRAM.Location = new System.Drawing.Point(3, 46);
            this.lblUseRAM.Name = "lblUseRAM";
            this.lblUseRAM.Size = new System.Drawing.Size(103, 17);
            this.lblUseRAM.TabIndex = 2;
            this.lblUseRAM.Text = "Tiek izmantots:";
            // 
            // tbAvaibleRAM
            // 
            this.tbAvaibleRAM.Location = new System.Drawing.Point(116, 15);
            this.tbAvaibleRAM.Name = "tbAvaibleRAM";
            this.tbAvaibleRAM.ReadOnly = true;
            this.tbAvaibleRAM.Size = new System.Drawing.Size(100, 22);
            this.tbAvaibleRAM.TabIndex = 1;
            // 
            // lblAvaibleRAM
            // 
            this.lblAvaibleRAM.AutoSize = true;
            this.lblAvaibleRAM.Location = new System.Drawing.Point(3, 18);
            this.lblAvaibleRAM.Name = "lblAvaibleRAM";
            this.lblAvaibleRAM.Size = new System.Drawing.Size(69, 17);
            this.lblAvaibleRAM.TabIndex = 0;
            this.lblAvaibleRAM.Text = "Pieejams:";
            // 
            // btnViewInExcel
            // 
            this.btnViewInExcel.Location = new System.Drawing.Point(12, 616);
            this.btnViewInExcel.Name = "btnViewInExcel";
            this.btnViewInExcel.Size = new System.Drawing.Size(91, 44);
            this.btnViewInExcel.TabIndex = 3;
            this.btnViewInExcel.Text = "Skatīties Excel";
            this.btnViewInExcel.UseVisualStyleBackColor = true;
            this.btnViewInExcel.Click += new System.EventHandler(this.btnViewInExcel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbThreadProcessor);
            this.groupBox1.Controls.Add(this.lblThreadProcessor);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 114);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procesors";
            // 
            // tbThreadProcessor
            // 
            this.tbThreadProcessor.Location = new System.Drawing.Point(116, 15);
            this.tbThreadProcessor.Name = "tbThreadProcessor";
            this.tbThreadProcessor.ReadOnly = true;
            this.tbThreadProcessor.Size = new System.Drawing.Size(100, 22);
            this.tbThreadProcessor.TabIndex = 1;
            // 
            // lblThreadProcessor
            // 
            this.lblThreadProcessor.AutoSize = true;
            this.lblThreadProcessor.Location = new System.Drawing.Point(3, 18);
            this.lblThreadProcessor.Name = "lblThreadProcessor";
            this.lblThreadProcessor.Size = new System.Drawing.Size(65, 17);
            this.lblThreadProcessor.TabIndex = 0;
            this.lblThreadProcessor.Text = "Threads:";
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
            // ProcessManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 672);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnViewInExcel);
            this.Controls.Add(this.gbRAM);
            this.Controls.Add(this.dgvProcesses);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox tbThreadProcessor;
        private System.Windows.Forms.Label lblThreadProcessor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWindowsTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_CPU;
    }
}

