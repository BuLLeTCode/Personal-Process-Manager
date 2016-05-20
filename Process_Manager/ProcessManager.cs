using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using Process_Manager.Properties;
using Timer = System.Windows.Forms.Timer;


namespace Process_Manager
{
    public partial class ProcessManager : Form
    {
        private readonly PerformanceCounter _theMemAvaibleCounter = new PerformanceCounter("Memory", "Available MBytes");
        //private readonly PerformanceCounter _theProcessThreadCounter = new PerformanceCounter("Process", "Thread Count");

        public ProcessManager()
        {
            InitializeComponent();

            Timer timer = new Timer {Interval = 1000};
            timer.Tick += timer_Tick;
            timer.Start();

            DisplayProcesses();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tbAvaibleRAM.Text = _theMemAvaibleCounter.NextValue().ToString(CultureInfo.InvariantCulture);

            double totalRam = GetTotalMemoryInBytes()/1024f/1024f;
            double ramInUse = totalRam - double.Parse(tbAvaibleRAM.Text);

            tbUseRAM.Text = ramInUse.ToString("0");

            tbTotalRAM.Text = totalRam.ToString("0");

            //DisplayProcesses();
        }

        private void DisplayProcesses()
        {
            Process [] processes = Process.GetProcesses();

            foreach (var proc in processes)
            {
                PerformanceCounter theCPUCounter = new PerformanceCounter("Process", "% Processor Time",
                proc.ProcessName);

                //Console.WriteLine(Resources.ProcessManager_DisplayProcesses_proc_name__ + proc.ProcessName);
                //processsNameList.Add(proc.ProcessName);
                dgvProcesses.Rows.Add(proc.ProcessName, proc.MainWindowTitle, theCPUCounter.NextValue());

            }
        }

        static ulong GetTotalMemoryInBytes()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
        }

        private void btnViewInExcel_Click(object sender, EventArgs e)
        {
            Type excelType = Type.GetTypeFromProgID("Excel.Application");
            dynamic excel = Activator.CreateInstance(excelType);
            excel.Visible = true;

            excel.Workbooks.Add();

            dynamic sheet = excel.ActiveSheet;

            sheet.Columns("A:B").ColumnWidth = 30;

            for (int i = 0; i < dgvProcesses.Rows.Count; i++)
            {
                
                sheet.Cells[i + 1, "A"] = dgvProcesses.Rows[i].Cells[0].Value;
                sheet.Cells[i + 1, "B"] = dgvProcesses.Rows[i].Cells[1].Value;
            }
        }
    }
}
