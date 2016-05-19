using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;


namespace Process_Manager
{
    public partial class ProcessManager : Form
    {
        readonly PerformanceCounter _theMemAvaibleCounter = new PerformanceCounter("Memory", "Available MBytes");

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

            List<string> processNames = new List<string>();

            foreach (var proc in processes)
            {
                Console.WriteLine("proc name: " + proc.ProcessName);
                //processsNameList.Add(proc.ProcessName);

                dgvProcesses.Rows.Add(proc.ProcessName, proc.MainWindowTitle);

            }
        }

        static ulong GetTotalMemoryInBytes()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
        }
    }
}
