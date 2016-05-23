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
        private readonly PerformanceCounter _theHardTotalBusy = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
        private readonly PerformanceCounter _theHardRequestsForAccess = new PerformanceCounter("PhysicalDisk", "Current Disk Queue Length", "_Total");

        //Hard disk read / write speeds. Logical Disk is used, if computer for one hard drive have more logical partations.
        private readonly PerformanceCounter _theHardReadSpeed = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "_Total");
        private readonly PerformanceCounter _theHardWriteSpeed = new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "_Total");

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
            //--RAM
            //Avaible ram
            tbAvaibleRAM.Text = _theMemAvaibleCounter.NextValue().ToString(CultureInfo.InvariantCulture);
            //Little calculation form ram
            double totalRam = GetTotalMemoryInBytes()/1024f/1024f;
            double ramInUse = totalRam - double.Parse(tbAvaibleRAM.Text);
            //Ram used.
            tbUseRAM.Text = ramInUse.ToString("0");
            //Total ram
            tbTotalRAM.Text = totalRam.ToString("0");
            
            //--CPU 
            //CPU load
            tbLoadCPU.Text = _theProcLoadCounter.NextValue().ToString("0");//If this counter is greater than 80 constantly, then need to think about changing CPU.
            //Threads switching in system.
            tbThreadsCPU.Text = _theSystemThreadSwitchingCounter.NextValue().ToString("0");
            //Thread switching rate.
            tbThreadSwitch.Text = _theContextSwitchingRate.NextValue().ToString("0");//If this counter is at 40 percent or more and the context-switching rate is high, 
                                                                                      //then you can investigate the cause for high rates of context switches.
                                                                                      //Color thread switching check, if over 40 - its on high rate.

             //--Hard disk
             tbDiskBusy.Text = _theHardTotalBusy.NextValue().ToString("0") + " %"; //monitors the percentage of time that the disk is busy with read/write activity
            //TODO - for disk busy, also need check: is high (more than 90 percent). then need one more counter - _theHardRequestsForAccess.

            tbSystemRequestDisk.Text = _theHardRequestsForAccess.NextValue().ToString();//no more than 1.5 to 2 times the number of spindles making up the physical disk. 
                                                                                        //Most disks have one spindle, although redundant array of inexpensive disks (RAID) devices usually have more.

            //If both hard disk counters are high - consider:
            /*
            Using a faster disk drive. 

            Moving some files to an additional disk or server.

            Adding additional disks to a RAID array, if one is being used.
            */

            double readSpeed = Convert.ToDouble(_theHardReadSpeed.NextValue().ToString()) / 1024f / 1024f;
            double writeSpeed = Convert.ToDouble(_theHardWriteSpeed.NextValue().ToString()) / 1024f / 1024f;

            tbReadSpeedDisk.Text = Math.Round(readSpeed, 2).ToString() + " MB/s";//Additional - simple Math.Round. - No need to very specific about round.
            tbWriteSpeedDisk.Text = Math.Round(writeSpeed, 2).ToString() + " MB/s";

            //Different checks, if element is not on high rate.
            try
            {
                if (int.Parse(tbThreadSwitch.Text) >= 40)
                {
                    changeTextBoxColor(tbThreadSwitch, Color.Red);
                }
                else if (tbThreadSwitch.ForeColor.Equals(Color.Red))
                {
                    changeTextBoxColor(tbThreadSwitch, Color.Black);
                }

                if (int.Parse(tbDiskBusy.Text.Remove(tbDiskBusy.Text.Length-2, 2)) >= 90)
                {
                    changeTextBoxColor(tbDiskBusy, Color.Red);
                }
                else if (tbDiskBusy.ForeColor.Equals(Color.Red))
                {
                    changeTextBoxColor(tbDiskBusy, Color.Black);
                }

                if (int.Parse(tbSystemRequestDisk.Text) >= 2)
                {
                    changeTextBoxColor(tbSystemRequestDisk, Color.Green);
                }
                else if (tbSystemRequestDisk.ForeColor.Equals(Color.Green))
                {
                    changeTextBoxColor(tbSystemRequestDisk, Color.Black);
                }

                if(int.Parse(tbLoadCPU.Text) >= 80)
                {
                    changeTextBoxColor(tbLoadCPU, Color.Red);
                }
                else if(tbLoadCPU.ForeColor.Equals(Color.Red))
                {
                    changeTextBoxColor(tbLoadCPU, Color.Black);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                dgvProcesses.Rows.Add(proc.ProcessName, proc.MainWindowTitle);

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
        //Simple function for changing color of TextBox
        private void changeTextBoxColor(TextBox target, Color targetColor)
        {
            //All this for ReadOnly field. :(
            target.ReadOnly = false;
            target.BackColor = Color.FromKnownColor(KnownColor.Control);
            target.ForeColor = targetColor;
            target.ReadOnly = true;
        }

        private void btnExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
