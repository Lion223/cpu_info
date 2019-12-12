namespace CPUInfo
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cpuLabel = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarCpu = new MetroFramework.Controls.MetroProgressBar();
            this.cpuUsageLabel = new MetroFramework.Controls.MetroLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitIcon = new System.Windows.Forms.PictureBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.monitoringButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.uptimeLabel = new System.Windows.Forms.Label();
            this.generalButton = new System.Windows.Forms.Button();
            this.stressTestButton = new System.Windows.Forms.Button();
            this.formLabel = new MetroFramework.Controls.MetroLabel();
            this.tempCPULabel = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.clearButton = new System.Windows.Forms.Button();
            this.cpuFanSpeedLabel = new System.Windows.Forms.Label();
            this.maxTempLabel = new System.Windows.Forms.Label();
            this.minTempLabel = new System.Windows.Forms.Label();
            this.appCpuUsageLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.generalInfo1 = new CPUInfo.CPUInfoUC();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitIcon)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Location = new System.Drawing.Point(153, 73);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(75, 19);
            this.cpuLabel.TabIndex = 0;
            this.cpuLabel.Text = "CPU Usage";
            // 
            // metroProgressBarCpu
            // 
            this.metroProgressBarCpu.Location = new System.Drawing.Point(248, 73);
            this.metroProgressBarCpu.Name = "metroProgressBarCpu";
            this.metroProgressBarCpu.Size = new System.Drawing.Size(460, 23);
            this.metroProgressBarCpu.Style = MetroFramework.MetroColorStyle.Red;
            this.metroProgressBarCpu.TabIndex = 1;
            // 
            // cpuUsageLabel
            // 
            this.cpuUsageLabel.AutoSize = true;
            this.cpuUsageLabel.Location = new System.Drawing.Point(726, 74);
            this.cpuUsageLabel.Name = "cpuUsageLabel";
            this.cpuUsageLabel.Size = new System.Drawing.Size(27, 19);
            this.cpuUsageLabel.TabIndex = 2;
            this.cpuUsageLabel.Text = "0%";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cpuChart
            // 
            this.cpuChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea1.Name = "cpuChartArea";
            this.cpuChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cpuChart.Legends.Add(legend1);
            this.cpuChart.Location = new System.Drawing.Point(153, 101);
            this.cpuChart.Name = "cpuChart";
            series1.ChartArea = "cpuChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            this.cpuChart.Series.Add(series1);
            this.cpuChart.Size = new System.Drawing.Size(603, 270);
            this.cpuChart.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.exitIcon);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.monitoringButton);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.uptimeLabel);
            this.panel1.Controls.Add(this.generalButton);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 580);
            this.panel1.TabIndex = 7;
            // 
            // exitIcon
            // 
            this.exitIcon.Image = global::CPUInfo.Properties.Resources.shut_down_button_white;
            this.exitIcon.Location = new System.Drawing.Point(32, 373);
            this.exitIcon.Name = "exitIcon";
            this.exitIcon.Size = new System.Drawing.Size(64, 64);
            this.exitIcon.TabIndex = 14;
            this.exitIcon.TabStop = false;
            this.exitIcon.Click += new System.EventHandler(this.exitIcon_Click);
            this.exitIcon.MouseEnter += new System.EventHandler(this.exitIcon_MouseEnter);
            this.exitIcon.MouseLeave += new System.EventHandler(this.exitIcon_MouseLeave);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(14)))), ((int)(((byte)(64)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 41);
            this.sidePanel.TabIndex = 9;
            // 
            // monitoringButton
            // 
            this.monitoringButton.FlatAppearance.BorderSize = 0;
            this.monitoringButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitoringButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monitoringButton.ForeColor = System.Drawing.Color.White;
            this.monitoringButton.Location = new System.Drawing.Point(0, 41);
            this.monitoringButton.Name = "monitoringButton";
            this.monitoringButton.Size = new System.Drawing.Size(132, 41);
            this.monitoringButton.TabIndex = 13;
            this.monitoringButton.Text = "Monitoring";
            this.monitoringButton.UseVisualStyleBackColor = true;
            this.monitoringButton.Click += new System.EventHandler(this.monitoringButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(16, 520);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(84, 21);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "HH:MM:SS";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uptimeLabel
            // 
            this.uptimeLabel.AutoSize = true;
            this.uptimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uptimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(14)))), ((int)(((byte)(64)))));
            this.uptimeLabel.Location = new System.Drawing.Point(30, 466);
            this.uptimeLabel.Name = "uptimeLabel";
            this.uptimeLabel.Size = new System.Drawing.Size(84, 21);
            this.uptimeLabel.TabIndex = 12;
            this.uptimeLabel.Text = "HH:MM:SS";
            this.uptimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generalButton
            // 
            this.generalButton.FlatAppearance.BorderSize = 0;
            this.generalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generalButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.generalButton.ForeColor = System.Drawing.Color.White;
            this.generalButton.Location = new System.Drawing.Point(0, 0);
            this.generalButton.Name = "generalButton";
            this.generalButton.Size = new System.Drawing.Size(132, 41);
            this.generalButton.TabIndex = 1;
            this.generalButton.Text = "General";
            this.generalButton.UseVisualStyleBackColor = true;
            this.generalButton.Click += new System.EventHandler(this.generalButton_Click);
            // 
            // stressTestButton
            // 
            this.stressTestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.stressTestButton.FlatAppearance.BorderSize = 0;
            this.stressTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stressTestButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stressTestButton.ForeColor = System.Drawing.Color.White;
            this.stressTestButton.Location = new System.Drawing.Point(433, 391);
            this.stressTestButton.Name = "stressTestButton";
            this.stressTestButton.Size = new System.Drawing.Size(303, 45);
            this.stressTestButton.TabIndex = 12;
            this.stressTestButton.Text = "Stress Testing";
            this.stressTestButton.UseVisualStyleBackColor = false;
            this.stressTestButton.Click += new System.EventHandler(this.stressTestButton_Click);
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.formLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.formLabel.Location = new System.Drawing.Point(153, 30);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(102, 25);
            this.formLabel.TabIndex = 8;
            this.formLabel.Text = "CPU Name";
            // 
            // tempCPULabel
            // 
            this.tempCPULabel.AutoSize = true;
            this.tempCPULabel.BackColor = System.Drawing.Color.Transparent;
            this.tempCPULabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tempCPULabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(14)))), ((int)(((byte)(64)))));
            this.tempCPULabel.Location = new System.Drawing.Point(3, 3);
            this.tempCPULabel.Name = "tempCPULabel";
            this.tempCPULabel.Size = new System.Drawing.Size(225, 21);
            this.tempCPULabel.TabIndex = 13;
            this.tempCPULabel.Text = "CPU Core #1 Temperature: 50C";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Maroon;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.tempCPULabel);
            this.metroPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroPanel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(165, 391);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(259, 100);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroPanel1.TabIndex = 15;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(433, 446);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(303, 45);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Clear Graph";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // cpuFanSpeedLabel
            // 
            this.cpuFanSpeedLabel.AutoSize = true;
            this.cpuFanSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuFanSpeedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cpuFanSpeedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(14)))), ((int)(((byte)(64)))));
            this.cpuFanSpeedLabel.Location = new System.Drawing.Point(202, 533);
            this.cpuFanSpeedLabel.Name = "cpuFanSpeedLabel";
            this.cpuFanSpeedLabel.Size = new System.Drawing.Size(75, 21);
            this.cpuFanSpeedLabel.TabIndex = 14;
            this.cpuFanSpeedLabel.Text = "???? RPM";
            // 
            // maxTempLabel
            // 
            this.maxTempLabel.AutoSize = true;
            this.maxTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxTempLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxTempLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(14)))), ((int)(((byte)(64)))));
            this.maxTempLabel.Location = new System.Drawing.Point(364, 533);
            this.maxTempLabel.Name = "maxTempLabel";
            this.maxTempLabel.Size = new System.Drawing.Size(40, 21);
            this.maxTempLabel.TabIndex = 18;
            this.maxTempLabel.Text = "??°C";
            // 
            // minTempLabel
            // 
            this.minTempLabel.AutoSize = true;
            this.minTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.minTempLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minTempLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(14)))), ((int)(((byte)(64)))));
            this.minTempLabel.Location = new System.Drawing.Point(525, 533);
            this.minTempLabel.Name = "minTempLabel";
            this.minTempLabel.Size = new System.Drawing.Size(40, 21);
            this.minTempLabel.TabIndex = 20;
            this.minTempLabel.Text = "??°C";
            // 
            // appCpuUsageLabel
            // 
            this.appCpuUsageLabel.AutoSize = true;
            this.appCpuUsageLabel.BackColor = System.Drawing.Color.Transparent;
            this.appCpuUsageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appCpuUsageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(14)))), ((int)(((byte)(64)))));
            this.appCpuUsageLabel.Location = new System.Drawing.Point(686, 533);
            this.appCpuUsageLabel.Name = "appCpuUsageLabel";
            this.appCpuUsageLabel.Size = new System.Drawing.Size(37, 21);
            this.appCpuUsageLabel.TabIndex = 22;
            this.appCpuUsageLabel.Text = "??%";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(487, 528);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(326, 528);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 528);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CPUInfo.Properties.Resources.cpuApp;
            this.pictureBox4.Location = new System.Drawing.Point(648, 528);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // generalInfo1
            // 
            this.generalInfo1.BackColor = System.Drawing.Color.White;
            this.generalInfo1.Location = new System.Drawing.Point(146, 7);
            this.generalInfo1.Name = "generalInfo1";
            this.generalInfo1.Size = new System.Drawing.Size(610, 570);
            this.generalInfo1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 579);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.appCpuUsageLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.minTempLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.maxTempLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cpuFanSpeedLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.stressTestButton);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cpuChart);
            this.Controls.Add(this.cpuUsageLabel);
            this.Controls.Add(this.metroProgressBarCpu);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.generalInfo1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitIcon)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel cpuLabel;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarCpu;
        private MetroFramework.Controls.MetroLabel cpuUsageLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel formLabel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button generalButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label uptimeLabel;
        private System.Windows.Forms.Label tempCPULabel;
        private CPUInfoUC generalInfo1;
        private System.Windows.Forms.Button monitoringButton;
        private System.Windows.Forms.Button stressTestButton;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label cpuFanSpeedLabel;
        private System.Windows.Forms.PictureBox exitIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label maxTempLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label minTempLabel;
        private System.Windows.Forms.Label appCpuUsageLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

