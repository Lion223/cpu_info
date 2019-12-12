using OpenHardwareMonitor.Hardware;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Threading;

namespace CPUInfo
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        // stress test
        bool testRunning = false;

        // CPU load, uptime, app load on CPU indicators
        PerformanceCounter pCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter pUptime = new PerformanceCounter("System", "System Up Time");
        PerformanceCounter pApp = new PerformanceCounter("Process", "% Processor Time", "CPUInfo", true);
        TimeSpan Uptime;

        // CPU cores temperature, fan RPM
        Computer compMonitor = new Computer();

        // extreme CPU temperature values
        int maxTemp = 0;
        int minTemp = 1000;

        // CPU load values
        double dcpu = 0;
        double dapp = 0;

        public MainForm()
        {
            InitializeComponent();

            //hover-effect on exit app
            exitIcon.MouseEnter += new EventHandler(exitIcon_MouseEnter);
            exitIcon.MouseLeave += new EventHandler(exitIcon_MouseLeave);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generalInfo1.BringToFront();

            timer.Start();

            // CPU name
            formLabel.Text = GetComponent("root\\CIMV2", "SELECT * FROM ", "Win32_Processor", "Name");

            compMonitor.MainboardEnabled = true;
            compMonitor.CPUEnabled = true;
            compMonitor.GPUEnabled = true;
            compMonitor.FanControllerEnabled = true;
            compMonitor.Open();

            cpuChart.ChartAreas["cpuChartArea"].AxisX.Title = "Time(sec)";
            cpuChart.ChartAreas["cpuChartArea"].AxisY.Title = "Usage(%)";
            cpuChart.ChartAreas["cpuChartArea"].AxisX.TitleFont = new System.Drawing.Font("Segoe WP", 10F, FontStyle.Bold);
            cpuChart.ChartAreas["cpuChartArea"].AxisY.TitleFont = new System.Drawing.Font("Segoe WP", 10F, FontStyle.Bold);
            cpuChart.ChartAreas["cpuChartArea"].AxisY.Maximum = 100;
            cpuChart.Series["CPU"].Color = Color.Red;
        }

        // receive WMI data
        private static string GetComponent(string source, string sqlsequence, string hwclass, string parameter)
        {
            ManagementObjectSearcher srch = new ManagementObjectSearcher(source, sqlsequence + hwclass);
            string getObj = "";
            foreach (ManagementObject mo in srch.Get())
            {
                getObj = Convert.ToString(mo[parameter]);
            }
            if (getObj != "")
            {
                while (getObj.IndexOf("  ") != -1) getObj = getObj.Replace("  ", " ");
                return getObj;
            }
            return null;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            dapp = pApp.NextValue() / 10;
            appCpuUsageLabel.Text = dapp.ToString("0.##") + "%";

            dcpu = pCPU.NextValue();
            metroProgressBarCpu.Value = (int)dcpu;
            cpuUsageLabel.Text = string.Format("{0:0}%", dcpu);

            cpuChart.Series["CPU"].Points.AddY(dcpu);

            timeLabel.Text = "System Time:\n" + DateTime.Now.ToString("HH:mm:ss");

            pUptime.NextValue();
            Uptime = TimeSpan.FromSeconds(pUptime.NextValue());
            uptimeLabel.Text = "Uptime:\n" + Uptime.ToString(@"hh\:mm\:ss");

            // retrieve temperature values
            tempCPULabel.Text = "";
            foreach (var hardware in compMonitor.Hardware)
            {
                if (hardware.HardwareType == HardwareType.CPU)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            if (sensor.Max > maxTemp) maxTemp = (int)sensor.Max;
                            if (sensor.Min < minTemp) minTemp = (int)sensor.Min;
                            tempCPULabel.Text += sensor.Name + " " + sensor.SensorType + ": " + sensor.Value + "°C\n";
                        }
                    }
                }
            }
            maxTempLabel.Text = maxTemp.ToString() + "°C";
            minTempLabel.Text = minTemp.ToString() + "°C";

            // retrieve CPU fan info
            foreach (var hardware in compMonitor.Hardware)
            {
                hardware.Update();
                foreach (var subhardware in hardware.SubHardware)
                {
                    subhardware.Update();
                    if (subhardware.Sensors.Length > 0)
                    {
                        foreach (var sensor in subhardware.Sensors)
                        {
                            if (sensor.Name == "CPU Fan")
                            {
                                cpuFanSpeedLabel.Text = Convert.ToString((int)(float)sensor.Value) + " RPM";
                            }
                        }
                    }
                }
            }

            if (cpuFanSpeedLabel.Text == "???? RPM") cpuFanSpeedLabel.Text = "N/A";
            if (tempCPULabel.Text.Contains("CPU Core #1 Temperature: °C")) tempCPULabel.Text = "N/A";
            if (maxTempLabel.Text == "0°C") maxTempLabel.Text = "N/A";
            if (minTempLabel.Text == "1000°C") minTempLabel.Text = "N/A";
            if (appCpuUsageLabel.Text == "??°C") appCpuUsageLabel.Text = "N/A";
        }

        // CPU stress test
        void cpuLoadProc()
        {
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();

            while (testRunning)
            {
                if (stopWatch.ElapsedMilliseconds > metroProgressBarCpu.Value)
                {
                    Thread.Sleep(100 - metroProgressBarCpu.Value);
                    stopWatch.Reset();
                    stopWatch.Start();
                }
            }
        }

        private void stressTestButton_Click(object sender, EventArgs e)
        {
            if (!testRunning)
            {
                stressTestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(14)))), ((int)(((byte)(64)))));
                stressTestButton.Text = " Stop";
                testRunning = true;
                Thread[] cpuLoadThread;
                cpuLoadThread = new Thread[Environment.ProcessorCount];

                for (int i = 0; i < cpuLoadThread.Length; i++)
                {
                    cpuLoadThread[i] = new Thread(new ThreadStart(cpuLoadProc));

                    cpuLoadThread[i].IsBackground = true;
                    cpuLoadThread[i].Name = "CPU Load Thread";
                    cpuLoadThread[i].Start();
                }
            }
            else
            {
                stressTestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));

                stressTestButton.Text = " Stress testing";
                testRunning = false;
            }
        }

        private void generalButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = generalButton.Height;
            sidePanel.Top = generalButton.Top;
            generalInfo1.BringToFront();
            generalInfo1.Visible = true;
        }

        private void monitoringButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = monitoringButton.Height;
            sidePanel.Top = monitoringButton.Top;
            generalInfo1.SendToBack();
            generalInfo1.Visible = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cpuChart.Series["CPU"].Points.Clear();
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // exit app hover-effect
        private void exitIcon_MouseEnter(object sender, EventArgs e)
        {
            this.exitIcon.Image = ((System.Drawing.Image)(Properties.Resources.shut_down_button_red));
        }

        private void exitIcon_MouseLeave(object sender, EventArgs e)
        {
            this.exitIcon.Image = ((System.Drawing.Image)(Properties.Resources.shut_down_button_white));
            BringToFront();
        }
    }
}
