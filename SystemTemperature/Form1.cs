using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;
using SystemTemperature.Service;

namespace SystemTemperature
{
    public partial class Form1 : Form
    {
        public bool appPause;
        Form1 form;
        SensorsMonitor sm;
        public Form1()
        {
            InitializeComponent();
            appPause = false;
            PerformanceMeasure.To = 120;
            System.Drawing.Color color = Color.DarkRed;
            System.Windows.Media.Color mediaColor = System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B);
            PerformanceMeasure.ToColor = mediaColor;
            PerformanceMeasure.FromColor = mediaColor;
            form = this;
            sm = new SensorsMonitor();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(chkTemp));
            thread.Start();
        }

        public void chkTemp()
        {
            appPause = false;
            while (!appPause)
            {
                sm.GetSystemInfo(form);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            appPause = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            appPause = true;
            sm.threadC1.Abort();
            sm.threadC2.Abort();
            sm.threadC3.Abort();
            sm.threadC4.Abort();
            sm.threadC5.Abort();
            sm.threadC6.Abort();
            Thread.Sleep(120);
            Environment.Exit(0);
        }
    }
    public class UpdateVisitor : IVisitor
    {
        public void VisitComputer(IComputer computer)
        {
            computer.Traverse(this);
        }
        public void VisitHardware(IHardware hardware)
        {
            hardware.Update();
            foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
        }
        public void VisitSensor(ISensor sensor) { }
        public void VisitParameter(IParameter parameter) { }
    }
    public class SensorsMonitor
    {
        CpuUsage usage;
        public Thread threadC1 = null, threadC2 = null, threadC3 = null, threadC4 = null, threadC5 = null, threadC6 = null;
        Form1 Main;
        int minTemp = 0;
        int maxTemp = 0;

        public SensorsMonitor()
        {
            usage = new CpuUsage();
        }
        public void GetSystemInfo(Form1 form)
        {
            Main = form;
            UpdateVisitor updateVisitor = new UpdateVisitor();
            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;
            computer.GPUEnabled = true;
            computer.MainboardEnabled = true;
            computer.Accept(updateVisitor);
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            string name = computer.Hardware[i].Sensors[j].Name.ToString();
                            int te = (int)computer.Hardware[i].Sensors[j].Value;
                            string temp = te.ToString() + "°C";
                            string CPUName = computer.Hardware[i].Name.ToString();
                            UpdateMinMaxTemp(te);
                            form.PerformanceMeasure.Invoke((Action)(() =>
                            {
                                form.PerformanceMeasure.Value = te;
                                form.fieldCurrentTemp.Text = temp;
                                form.fieldCpuModel.Text = CPUName;
                                form.fieldMinTemp.Text = minTemp.ToString() + "°C";
                                form.fieldMaxTemp.Text = maxTemp.ToString() + "°C";
                                form.fieldC1MinTemp.Text = usage.minUsage[0].ToString() + "%";
                                form.fieldC2MinTemp.Text = usage.minUsage[1].ToString() + "%";
                                form.fieldC3MinTemp.Text = usage.minUsage[2].ToString() + "%";
                                form.fieldC4MinTemp.Text = usage.minUsage[3].ToString() + "%";
                                form.fieldC5MinTemp.Text = usage.minUsage[4].ToString() + "%";
                                form.fieldC6MinTemp.Text = usage.minUsage[5].ToString() + "%";
                                form.fieldC1MaxTemp.Text = usage.maxUsage[0].ToString() + "%";
                                form.fieldC2MaxTemp.Text = usage.maxUsage[1].ToString() + "%";
                                form.fieldC3MaxTemp.Text = usage.maxUsage[2].ToString() + "%";
                                form.fieldC4MaxTemp.Text = usage.maxUsage[3].ToString() + "%";
                                form.fieldC5MaxTemp.Text = usage.maxUsage[4].ToString() + "%";
                                form.fieldC6MaxTemp.Text = usage.maxUsage[5].ToString() + "%";
                            }
                            ));

                        }

                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Load)
                        {
                            var thiSensor = computer.Hardware[i].Sensors[j];
                            float Load = 0;
                            Load = (float)computer.Hardware[i].Sensors[j].Value;
                            SetCoreLoadLevel(thiSensor.Index, Load);
                        }
                    }
                }
                if (computer.Hardware[i].HardwareType == HardwareType.GpuNvidia)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            string gpuName = computer.Hardware[i].Name;
                            int gTemp = (int)computer.Hardware[i].Sensors[j].Value;
                            form.Invoke((Action)(() =>
                            {
                                form.fieldGpuN.Text = gpuName;
                                form.TemperatureBar.Value = gTemp;
                                form.lGpuTemp.Text = gTemp.ToString() + "°C";
                            }
                            ));
                        }
                    }
                }
                if (computer.Hardware[i].HardwareType == HardwareType.Mainboard)
                {
                    string motherboardName = computer.Hardware[i].Name;
                    form.Invoke((Action)(() =>
                    {
                        form.fMBN.Text = motherboardName;
                    }
                ));
                }
            }
            computer.Close();
        }

        private void UpdateMinMaxTemp(int te)
        {
            if (minTemp == 0 && maxTemp == 0)
            {
                minTemp = te;
                maxTemp = te;
            }
            else if (minTemp > te)
            {
                minTemp = te;
            }
            else if (maxTemp < te)
            {
                maxTemp = te;
            }
        }

        public void SetCoreLoadLevel(int coreIndex, float loadLevel)
        {
            double avgUsage;
            switch (coreIndex)
            {
                case 1:
                    avgUsage = usage.AvgUsagePerCore(coreIndex, loadLevel);
                    if (threadC1 != null && threadC1.ThreadState != ThreadState.WaitSleepJoin)
                    {
                        Main.fieldLoad1.Invoke((Action)(() =>
                            Main.fieldLoad1.Text = avgUsage.ToString() + "%"
                        ));
                        TimerForCore1();
                    }
                    if (threadC1 == null)
                    {
                        threadC1 = new Thread(new ThreadStart(TimerForCore1));
                        threadC1.Start();
                    }
                    break;
                case 2:
                    avgUsage = usage.AvgUsagePerCore(coreIndex, loadLevel);
                    if (threadC2 != null && threadC2.ThreadState != ThreadState.WaitSleepJoin)
                    {
                        Main.fieldLoad1.Invoke((Action)(() =>
                            Main.fieldLoad2.Text = avgUsage.ToString() + "%"
                        ));
                        TimerForCore2();
                    }
                    if (threadC2 == null)
                    {
                        threadC2 = new Thread(new ThreadStart(TimerForCore2));
                        threadC2.Start();
                    }
                    break;
                case 3:
                    avgUsage = usage.AvgUsagePerCore(coreIndex, loadLevel);
                    if (threadC3 != null && threadC3.ThreadState != ThreadState.WaitSleepJoin)
                    {
                        Main.fieldLoad1.Invoke((Action)(() =>
                            Main.fieldLoad3.Text = avgUsage.ToString() + "%"
                        ));
                        TimerForCore3();
                    }
                    if (threadC3 == null)
                    {
                        threadC3 = new Thread(new ThreadStart(TimerForCore3));
                        threadC3.Start();
                    }
                    break;
                case 4:
                    avgUsage = usage.AvgUsagePerCore(coreIndex, loadLevel);
                    if (threadC4 != null && threadC1.ThreadState != ThreadState.WaitSleepJoin)
                    {
                        Main.fieldLoad1.Invoke((Action)(() =>
                            Main.fieldLoad4.Text = avgUsage.ToString() + "%"
                        ));
                        TimerForCore4();
                    }
                    if (threadC4 == null)
                    {
                        threadC4 = new Thread(new ThreadStart(TimerForCore4));
                        threadC4.Start();
                    }
                    break;
                case 5:
                    avgUsage = usage.AvgUsagePerCore(coreIndex, loadLevel);
                    if (threadC5 != null && threadC5.ThreadState != ThreadState.WaitSleepJoin)
                    {
                        Main.fieldLoad1.Invoke((Action)(() =>
                            Main.fieldLoad5.Text = avgUsage.ToString() + "%"
                        ));
                        TimerForCore5();
                    }
                    if (threadC5 == null)
                    {
                        threadC5 = new Thread(new ThreadStart(TimerForCore5));
                        threadC5.Start();
                    }
                    break;
                case 6:
                    avgUsage = usage.AvgUsagePerCore(coreIndex, loadLevel);
                    if (threadC6 != null && threadC6.ThreadState != ThreadState.WaitSleepJoin)
                    {
                        Main.fieldLoad1.Invoke((Action)(() =>
                            Main.fieldLoad6.Text = avgUsage.ToString() + "%"
                        ));
                        TimerForCore6();
                    }
                    if (threadC6 == null)
                    {
                        threadC6 = new Thread(new ThreadStart(TimerForCore6));
                        threadC6.Start();
                    }
                    break;
            }
        }
        private void TimerForCore1()
        {
            Thread.Sleep(100);
        }
        private void TimerForCore2()
        {
            Thread.Sleep(100);
        }
        private void TimerForCore3()
        {
            Thread.Sleep(100);
        }
        private void TimerForCore4()
        {
            Thread.Sleep(100);
        }
        private void TimerForCore5()
        {
            Thread.Sleep(100);
        }
        private void TimerForCore6()
        {
            Thread.Sleep(100);
        }
    }
}