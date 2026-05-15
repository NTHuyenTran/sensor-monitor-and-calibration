using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace SensorMonitorAndCalibration
{
    public partial class Form1 : Form
    {
        // ── Timer & dữ liệu giả lập ──────────────────────────────────────────
        private readonly System.Windows.Forms.Timer _updateTimer = new();
        private readonly Random _rng = new();

        // 3 sensor: Thermistor, Potentiometer, Encoder  (đồng bộ với CalibrationControl)
        private readonly double[] _adcRaw = new double[3];
        private readonly double[] _realVals = new double[3];

        private static readonly string[] SensorNames = { "Thermistor", "Potentiometer", "Encoder" };
        private static readonly string[] SensorUnits = { "°C", "deg", "RPM" };
        private static readonly double[] SensorMaxReal = { 100.0, 300.0, 500.0 };

        // ── UI labels trên tab Monitor (khởi tạo động) ───────────────────────
        private readonly Label[] _lblValues = new Label[3];
        private readonly Label[] _lblUnits = new Label[3];
        private Label? _lblTime;

        // ── Controls panelConnect (khai báo để dùng trong các handler) ───────
        private TextBox _txtComPort = null!;
        private ComboBox _cmbBaudrate = null!;
        private Button _btnConnect = null!;
        private Button _btnDisconnect = null!;
        private Panel _ledIndicator = null!;
        private Label _lblConnStatus = null!;

        // ── Serial Port (Phase 2: đọc thực từ MCU) ───────────────────────────
        private SerialPort? _serialPort;
        private bool _isConnected = false;

        // ── Controller calib and chart  ─────────────────────────────────────────────────
        private CalibrationControl? _calib;
        private ChartControl? _myChart;

        // ─────────────────────────────────────────────────────────────────────
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            SetupConnectPanel();
            SetupMonitorTab();
            SetupCalibController();
            SetupChartTab();

            _updateTimer.Interval = 1000;
            _updateTimer.Tick += OnTimerTick;
            _updateTimer.Start();
        }

        // ── Setup panelConnect ────────────────────────────────────────────────
        private void SetupConnectPanel()
        {
            panelConnect.Controls.Clear();
            panelConnect.BackColor = Color.WhiteSmoke;
            panelConnect.Padding = new Padding(16, 14, 16, 14);

            // ── Tiêu đề ──────────────────────────────────────────────────────
            var lblTitle = new Label
            {
                Text = "Kết nối Serial",
                AutoSize = true,
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 100, 180),
                Location = new Point(16, 14)
            };
            panelConnect.Controls.Add(lblTitle);

            // ── Dòng 1: COM Port ──────────────────────────────────────────────
            var lblCom = new Label
            {
                Text = "COM Port:",
                AutoSize = true,
                Font = new Font("Segoe UI", 9.5f),
                Location = new Point(16, 52)
            };
            _txtComPort = new TextBox
            {
                Text = "COM3",
                Font = new Font("Segoe UI", 9.5f),
                Location = new Point(100, 49),
                Size = new Size(80, 26),
                TextAlign = HorizontalAlignment.Center
            };

            var lblBaud = new Label
            {
                Text = "Baudrate:",
                AutoSize = true,
                Font = new Font("Segoe UI", 9.5f),
                Location = new Point(200, 52)
            };
            _cmbBaudrate = new ComboBox
            {
                Font = new Font("Segoe UI", 9.5f),
                Location = new Point(285, 49),
                Size = new Size(100, 26),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            _cmbBaudrate.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" });
            _cmbBaudrate.SelectedIndex = 0;   // mặc định 9600

            panelConnect.Controls.Add(lblCom);
            panelConnect.Controls.Add(_txtComPort);
            panelConnect.Controls.Add(lblBaud);
            panelConnect.Controls.Add(_cmbBaudrate);

            // ── Dòng 2: Buttons ───────────────────────────────────────────────
            _btnConnect = new Button
            {
                Text = "Kết nối",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                Location = new Point(16, 95),
                Size = new Size(100, 32),
                BackColor = Color.FromArgb(24, 95, 165),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            _btnConnect.FlatAppearance.BorderSize = 0;
            _btnConnect.Click += BtnConnect_Click;

            _btnDisconnect = new Button
            {
                Text = "Ngắt",
                Font = new Font("Segoe UI", 9.5f),
                Location = new Point(130, 95),
                Size = new Size(80, 32),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Enabled = false
            };
            _btnDisconnect.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 210);
            _btnDisconnect.Click += BtnDisconnect_Click;

            panelConnect.Controls.Add(_btnConnect);
            panelConnect.Controls.Add(_btnDisconnect);

            // ── Dòng 3: LED + trạng thái ─────────────────────────────────────
            _ledIndicator = new Panel
            {
                Location = new Point(16, 145),
                Size = new Size(16, 16),
                BackColor = Color.FromArgb(180, 180, 180)   // xám = chưa kết nối
            };
            // Bo tròn LED bằng Region
            _ledIndicator.Region = MakeCircleRegion(16, 16);

            _lblConnStatus = new Label
            {
                Text = "Chưa kết nối",
                AutoSize = true,
                Font = new Font("Segoe UI", 9.5f),
                ForeColor = Color.Gray,
                Location = new Point(38, 143)
            };

            panelConnect.Controls.Add(_ledIndicator);
            panelConnect.Controls.Add(_lblConnStatus);
        }

        // Tạo Region hình tròn cho LED indicator
        private static System.Drawing.Region MakeCircleRegion(int w, int h)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, w, h);
            return new System.Drawing.Region(path);
        }

        // ── Kết nối Serial ────────────────────────────────────────────────────
        private void BtnConnect_Click(object? sender, EventArgs e)
        {
            string port = _txtComPort.Text.Trim();
            int baud = int.Parse(_cmbBaudrate.SelectedItem!.ToString()!);

            // ── Phase 2: mở cổng thực ─────────────────────────────────────────
            try
            {
                _serialPort = new SerialPort(port, baud, Parity.None, 8, StopBits.One);
                _serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể mở {port}:\n{ex.Message}",
                    "Lỗi Serial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ── Phase 1: giả lập "đã kết nối" ────────────────────────────────
            //_isConnected = true;

            SetConnectionUI(connected: true, port: port, baud: baud);
        }

        private void BtnDisconnect_Click(object? sender, EventArgs e)
        {
            _serialPort?.Close();
            _serialPort?.Dispose();
            _serialPort = null;
            _isConnected = false;
            SetConnectionUI(connected: false);
        }

        private void SetConnectionUI(bool connected, string port = "", int baud = 0)
        {
            _isConnected = connected;

            if (connected)
            {
                // LED xanh
                _ledIndicator.BackColor = Color.FromArgb(34, 197, 94);
                _lblConnStatus.Text = $"Đang kết nối  —  {port}  @  {baud} bps";
                _lblConnStatus.ForeColor = Color.FromArgb(22, 140, 50);

                // Nút
                _btnConnect.Enabled = false;
                _btnConnect.BackColor = Color.FromArgb(160, 200, 240);
                _btnDisconnect.Enabled = true;

                // Khoá COM/Baud khi đang kết nối
                _txtComPort.Enabled = false;
                _cmbBaudrate.Enabled = false;
            }
            else
            {
                // LED xám
                _ledIndicator.BackColor = Color.FromArgb(180, 180, 180);
                _lblConnStatus.Text = "Chưa kết nối";
                _lblConnStatus.ForeColor = Color.Gray;

                // Nút
                _btnConnect.Enabled = true;
                _btnConnect.BackColor = Color.FromArgb(24, 95, 165);
                _btnDisconnect.Enabled = false;

                _txtComPort.Enabled = true;
                _cmbBaudrate.Enabled = true;
            }
        }

        // ── Setup tab Monitor ─────────────────────────────────────────────────
        private void SetupMonitorTab()
        {
            // panelSensor1 = Thermistor, panelSensor2 = Potentiometer, panelSensor3 = Encoder
            Panel[] panels = { panelSensor1, panelSensor2, panelSensor3 };

            for (int i = 0; i < 3; i++)
            {
                var lblName = new Label
                {
                    Text = $"Sensor {i + 1} — {SensorNames[i]}",
                    Location = new Point(10, 10),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.FromArgb(30, 100, 180)
                };

                _lblValues[i] = new Label
                {
                    Text = "—",
                    Size = new Size(390, 80),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 36, FontStyle.Bold),
                    ForeColor = Color.FromArgb(20, 20, 20)
                };

                _lblUnits[i] = new Label
                {
                    Text = SensorUnits[i],
                    Size = new Size(390, 24),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 11, FontStyle.Regular),
                    ForeColor = Color.Gray
                };

                int pw = panels[i].ClientSize.Width;
                _lblValues[i].Left = (pw - _lblValues[i].Width) / 2;
                _lblUnits[i].Left = (pw - _lblUnits[i].Width) / 2;
                _lblValues[i].Top = 55;
                _lblUnits[i].Top = 140;

                panels[i].Controls.Add(lblName);
                panels[i].Controls.Add(_lblValues[i]);
                panels[i].Controls.Add(_lblUnits[i]);
            }

            // Status bar ở dưới cùng tab Monitor
            _lblTime = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(80, 80, 80),
                Padding = new Padding(10, 0, 0, 0)
            };
            statusBar.Controls.Add(_lblTime);
        }

        // ── Setup CalibrationControl ──────────────────────────────────────────
        private void SetupCalibController()
        {
            _calib = new CalibrationControl(
                btnSensor1, btnSensor2, btnSensor3,
                pnlLive,
                txtAdcZero, txtRealZero, lblUnitZero,
                txtAdcSpan, txtRealSpan, lblUnitSpan,
                btnCaptureZero, btnCaptureSpan,
                btnCalc, button1,
                formsPlotCalib,
                lblFormula, lblCoefA, lblCoefB, lblStatus
            );

            // ── Kết nối delegate gửi Serial ──────────────────────────────────────
            _calib.SendSerialData = (cmd) =>
            {
                if (_serialPort == null || !_serialPort.IsOpen)
                {
                    MessageBox.Show("Serial chưa mở!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _serialPort.Write(cmd);
            };
        }

        // ── Setup tab Chart ─────────────────────────────────────────────────
        private void SetupChartTab()
        {
            _myChart = new ChartControl { Dock = DockStyle.Fill };
            tabChart.Controls.Add(_myChart);
        }

        // ── Timer tick: cập nhật dữ liệu mỗi giây ────────────────────────────
        private void OnTimerTick(object? sender, EventArgs e)
        {
            // Phase 1: giả lập ADC thô — Phase 2: đọc từ _serialPort
            //_adcRaw[0] = _rng.NextDouble() * 3.3;   // Thermistor
            //_adcRaw[1] = _rng.NextDouble() * 3.3;   // Potentiometer
            //_adcRaw[2] = _rng.NextDouble() * 3.3;   // Encoder

            //// Áp dụng hệ số calib để ra giá trị thực
            //for (int i = 0; i < 3; i++)
            //{
            //    var (a, b) = _calib?.GetCoefficients(i) ?? (1.0, 0.0);
            //    _realVals[i] = a * _adcRaw[i] + b;
            //}

            //// ── Phase 2: đọc từ buffer ─────────────────────────────────────────
            if (!_isConnected) return;

            // Cập nhật tab Monitor
            for (int i = 0; i < 3; i++)
                UpdateSensorPanel(i, _realVals[i]);

            // Cập nhật tab Calib và Chart (live reading)
            _calib?.SetLiveAdcValues(_adcRaw, _realVals);
            _myChart?.UpdateChartData(_realVals);

            // Status bar
            if (_lblTime != null)
            {
                string connStr = _isConnected ? "Serial (giả lập)" : "Chưa kết nối";
                _lblTime.Text = $"Cập nhật lúc: {DateTime.Now:HH:mm:ss}   |   " +
                                 $"Chu kỳ: 1000 ms   |   Nguồn: {connStr}";
            }
        }

        // ── Cập nhật một panel sensor trên tab Monitor ────────────────────────
        private void UpdateSensorPanel(int i, double value)
        {
            _lblValues[i].Text = value.ToString("F2");

            bool warning = value > SensorMaxReal[i] * 0.9;
            _lblValues[i].ForeColor = warning
                ? Color.FromArgb(200, 60, 30)
                : Color.FromArgb(20, 20, 20);
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string line = _serialPort!.ReadLine().Trim();  // "1.2500,0.8300,2.1000"
                string[] parts = line.Split(',');

                if (parts.Length != 3) return;

                double[] newAdc = new double[3];
                for (int i = 0; i < 3; i++)
                    if (!double.TryParse(parts[i],
                            System.Globalization.NumberStyles.Float,
                            System.Globalization.CultureInfo.InvariantCulture, 
                            out newAdc[i])) return;

                this.Invoke(() =>
                {
                    _adcRaw[0] = newAdc[0];
                    _adcRaw[1] = newAdc[1];
                    _adcRaw[2] = newAdc[2];
                });
            }
            catch { /* bỏ qua frame lỗi */ }
        }
    }
}