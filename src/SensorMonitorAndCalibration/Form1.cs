using System;
using System.Drawing;
using System.Windows.Forms;

namespace SensorMonitorAndCalibration
{
    public partial class Form1 : Form
    {
        private readonly System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();
        private readonly Random rng = new Random();

        private readonly double[] sensorValues = new double[4];
        private readonly string[] sensorNames = { "Thermistor", "Loadcell", "Potentiometer", "Encoder" };
        private readonly string[] sensorUnits = { "°C", "kg", "deg", "RPM" };
        private readonly double[] sensorMax = { 100, 5, 300, 500 };

        private readonly Label[] lblValues = new Label[4];
        private readonly Label[] lblUnits = new Label[4];

        private Label? lblTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            Panel[] panels = { panelSensor1, panelSensor2, panelSensor3, panelSensor4 };

            for (int i = 0; i < 4; i++)
            {
                var lblName = new Label
                {
                    Text = $"Sensor {i + 1} — {sensorNames[i]}",
                    Location = new Point(10, 10),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.FromArgb(30, 100, 180)
                };

                lblValues[i] = new Label
                {
                    Text = "—",
                    Location = new Point(0, 60),
                    Size = new Size(390, 80),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 36, FontStyle.Bold),
                    ForeColor = Color.FromArgb(20, 20, 20)
                };

                lblUnits[i] = new Label
                {
                    Text = sensorUnits[i],
                    Location = new Point(0, 145),
                    Size = new Size(390, 24),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 11, FontStyle.Regular),
                    ForeColor = Color.Gray
                };

                panels[i].Controls.Add(lblName);
                panels[i].Controls.Add(lblValues[i]);
                panels[i].Controls.Add(lblUnits[i]);
            }

            lblTime = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(80, 80, 80),
                Padding = new Padding(10, 0, 0, 0)
            };
            statusBar.Controls.Add(lblTime);

            updateTimer.Interval = 1000;
            updateTimer.Tick += OnTimerTick;
            updateTimer.Start();

            // Nhúng CalibrationControl vào tabCalib
            CalibrationControl calibControl = new CalibrationControl { Dock = DockStyle.Fill };
            tabCalib.Controls.Add(calibControl);

            // Nhúng ChartControl vào tabChart
            ChartControl chartControl = new ChartControl { Dock = DockStyle.Fill };
            tabChart.Controls.Add(chartControl);
        }

        private void OnTimerTick(object? sender, EventArgs e)
        {
            sensorValues[0] = rng.NextDouble() * 100;
            sensorValues[1] = rng.NextDouble() * 5;
            sensorValues[2] = rng.NextDouble() * 300;
            sensorValues[3] = rng.NextDouble() * 500;

            for (int i = 0; i < 4; i++)
                UpdateSensorDisplay(i, sensorValues[i]);

            if (lblTime != null)
                lblTime.Text = $"Cập nhật lúc: {DateTime.Now:HH:mm:ss}   |   Chu kỳ: 1000 ms";
        }

        private void UpdateSensorDisplay(int index, double value)
        {
            lblValues[index].Text = value.ToString("F2");

            bool warning = value > sensorMax[index] * 0.9;
            lblValues[index].ForeColor = warning
                ? Color.FromArgb(200, 60, 30)
                : Color.FromArgb(20, 20, 20);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }
    }
}