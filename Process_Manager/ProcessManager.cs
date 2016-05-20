using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using Process_Manager.Properties;
using Timer = System.Windows.Forms.Timer;
using System.Drawing;

namespace Process_Manager
{
    public partial class ProcessManager : Form
    {
        private readonly PerformanceCounter _theMemAvaibleCounter = new PerformanceCounter("Memory", "Available MBytes");
        private readonly PerformanceCounter _theSystemThreadSwitchingCounter = new PerformanceCounter("System", "Context Switches/sec");
        private readonly PerformanceCounter _theContextSwitchingRate = new PerformanceCounter("Processor", "% Privileged Time", "_Total");
        private readonly PerformanceCounter _theProcLoadCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

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
            //Avaible ram
            tbAvaibleRAM.Text = _theMemAvaibleCounter.NextValue().ToString(CultureInfo.InvariantCulture);
            //Little calculation form ram
            double totalRam = GetTotalMemoryInBytes()/1024f/1024f;
            double ramInUse = totalRam - double.Parse(tbAvaibleRAM.Text);
            //Ram used.
            tbUseRAM.Text = ramInUse.ToString("0");
            //Total ram
            tbTotalRAM.Text = totalRam.ToString("0");
            //CPU load
            tbLoadCPU.Text = _theProcLoadCounter.NextValue().ToString("0");
            //Threads switching in system.
            tbThreadsCPU.Text = _theSystemThreadSwitchingCounter.NextValue().ToString("0");
            //Thread switching rate.
            tbThreadSwitch.Text = _theContextSwitchingRate.NextValue().ToString("0");//If this counter is at 40 percent or more and the context-switching rate is high, 
                                                                                  //then you can investigate the cause for high rates of context switches.
            //Color thread switching check, if over 40 - its on high rate.
            if (int.Parse(_theContextSwitchingRate.NextValue().ToString()) >= 40)
            {
                tbThreadSwitch.ForeColor = Color.Red;
            }
            else if(tbThreadSwitch.ForeColor.Equals(Color.Red))
            {
                tbThreadSwitch.ForeColor = Color.Black;
            }

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
