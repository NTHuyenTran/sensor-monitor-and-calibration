using System;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SensorMonitorAndCalibration
{
    public partial class Form1 : Form
    {
        // ── Chọn chế độ chạy ────────────────────────────────────────────────
        private const bool USE_SIMULATION = false;

        // ── 3 Timer độc lập cho 3 Tab ────────────────────────────────────────
        private readonly System.Windows.Forms.Timer _monitorTimer = new(); // Tab Monitor: 1000ms (1Hz)
        private readonly System.Windows.Forms.Timer _calibTimer = new();   // Tab Calib: 250ms (4Hz)
        private readonly System.Windows.Forms.Timer _chartTimer = new();   // Tab Chart: 50ms (20Hz)

        private readonly Random _rng = new();

        // Dữ liệu thô và thực tế
        private readonly double[] _adcRaw = new double[3];
        private readonly double[] _realVals = new double[3];

        private static readonly string[] SensorNames = { "Thermistor", "Potentiometer", "Laser" };
        private static readonly string[] SensorUnits = { "°C", "deg", "RPM" };
        private static readonly double[] SensorMaxReal = { 100.0, 300.0, 500.0 };

        // ── UI labels trên tab Monitor ───────────────────────────────────────
        private readonly Label[] _lblValues = new Label[3];
        private readonly Label[] _lblUnits = new Label[3];
        private Label? _lblTime;

        // ── Controls panelConnect ────────────────────────────────────────────
        private ComboBox _cmbComPort = null!;
        private ComboBox _cmbBaudrate = null!;
        private Button _btnConnect = null!;
        private Button _btnDisconnect = null!;
        private Button _btnLoadCoefficients = null!;
        private Panel _ledIndicator = null!;
        private Label _lblConnStatus = null!;

        // ── Serial Port ──────────────────────────────────────────────────────
        private SerialPort? _serialPort;
        private bool _isConnected = false;

        private readonly StringBuilder _rxBuffer = new();
        private readonly object _rxLock = new();
        private string _lastRxFrame = "—";
        private DateTime _lastRxTime = DateTime.MinValue;

        // ── Controller calib and chart ───────────────────────────────────────
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

            // 1. Timer cho Tab Monitor (Chậm - 1 giây 1 lần để mắt kịp đọc)
            _monitorTimer.Interval = 1000;
            _monitorTimer.Tick += OnMonitorTick;
            _monitorTimer.Start();

            // 2. Timer cho Tab Calib (Vừa phải - 250ms để bắt mốc Zero/Span nhạy bén)
            _calibTimer.Interval = 250;
            _calibTimer.Tick += OnCalibTick;
            _calibTimer.Start();

            // 3. Timer cho Tab Chart (Rất nhanh - 50ms để đồ thị mượt mà)
            _chartTimer.Interval = 50;
            _chartTimer.Tick += OnChartTick;
            _chartTimer.Start();
        }

        // =====================================================================
        // HÀM TÍNH TOÁN DỮ LIỆU DÙNG CHUNG
        // =====================================================================
        private void CalculateRealValues()
        {
            for (int i = 0; i < 3; i++)
            {
                var (a, b) = _calib?.GetCoefficients(i) ?? (1.0, 0.0);
                _realVals[i] = a * _adcRaw[i] + b;
            }
        }

        // =====================================================================
        // CÁC HÀM XỬ LÝ TIMER ĐỘC LẬP
        // =====================================================================

        private void OnMonitorTick(object? sender, EventArgs e)
        {
            bool hasDataSource = USE_SIMULATION || _isConnected;

            if (hasDataSource)
            {
                CalculateRealValues();
                for (int i = 0; i < 3; i++)
                    UpdateSensorPanel(i, _realVals[i]);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    _lblValues[i].Text = "—";
                    _lblValues[i].ForeColor = Color.FromArgb(20, 20, 20);
                }
            }

            // Status bar chỉ cần cập nhật cùng nhịp với Monitor
            if (_lblTime != null)
            {
                string source = USE_SIMULATION ? "Giả lập" : (_isConnected ? "Serial thật" : "Chưa kết nối");
                string lastRx = _lastRxTime == DateTime.MinValue ? "—" : $"{_lastRxFrame} lúc {_lastRxTime:HH:mm:ss}";
                _lblTime.Text = $"Cập nhật lúc: {DateTime.Now:HH:mm:ss}   |   Nguồn: {source}   |   Frame cuối: {lastRx}";
            }
        }

        private void OnCalibTick(object? sender, EventArgs e)
        {
            if (USE_SIMULATION || _isConnected)
            {
                CalculateRealValues();
                _calib?.SetLiveAdcValues(_adcRaw, _realVals);
            }
        }

        private void OnChartTick(object? sender, EventArgs e)
        {
            // Nếu là Simulation, ta tạo số liệu giả lập ở nhịp 50ms để đồ thị chạy mượt
            if (USE_SIMULATION)
            {
                _adcRaw[0] = _rng.NextDouble() * 3.3;   // Thermistor
                _adcRaw[1] = _rng.NextDouble() * 3.3;   // Potentiometer
                _adcRaw[2] = _rng.NextDouble() * 3.3;   // Laser
            }

            if (USE_SIMULATION || _isConnected)
            {
                CalculateRealValues();
                _myChart?.UpdateChartData(_realVals);
            }
        }

        // =====================================================================
        // PHẦN SETUP GIAO DIỆN VÀ SERIAL (Giữ nguyên logic của bạn)
        // =====================================================================

        private void SetupConnectPanel()
        {
            panelConnect.Controls.Clear();
            panelConnect.BackColor = Color.WhiteSmoke;
            panelConnect.Padding = new Padding(16, 14, 16, 14);

            var lblTitle = new Label { Text = "Kết nối Serial", AutoSize = true, Font = new Font("Segoe UI", 10f, FontStyle.Bold), ForeColor = Color.FromArgb(30, 100, 180), Location = new Point(16, 14) };
            panelConnect.Controls.Add(lblTitle);

            var lblCom = new Label { Text = "COM Port:", AutoSize = true, Font = new Font("Segoe UI", 9.5f), Location = new Point(16, 52) };
            _cmbComPort = new ComboBox { Font = new Font("Segoe UI", 9.5f), Location = new Point(100, 49), Size = new Size(90, 26), DropDownStyle = ComboBoxStyle.DropDown };
            _cmbComPort.DropDown += (_, __) => RefreshComPorts();

            var lblBaud = new Label { Text = "Baudrate:", AutoSize = true, Font = new Font("Segoe UI", 9.5f), Location = new Point(210, 52) };
            _cmbBaudrate = new ComboBox { Font = new Font("Segoe UI", 9.5f), Location = new Point(295, 49), Size = new Size(100, 26), DropDownStyle = ComboBoxStyle.DropDownList };
            _cmbBaudrate.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" });
            _cmbBaudrate.SelectedIndex = 0;

            panelConnect.Controls.Add(lblCom);
            panelConnect.Controls.Add(_cmbComPort);
            panelConnect.Controls.Add(lblBaud);
            panelConnect.Controls.Add(_cmbBaudrate);

            RefreshComPorts();

            _btnConnect = new Button { Text = "Kết nối", Font = new Font("Segoe UI", 9.5f, FontStyle.Bold), Location = new Point(16, 95), Size = new Size(100, 32), BackColor = Color.FromArgb(24, 95, 165), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Cursor = Cursors.Hand };
            _btnConnect.FlatAppearance.BorderSize = 0;
            _btnConnect.Click += BtnConnect_Click;

            _btnDisconnect = new Button { Text = "Ngắt", Font = new Font("Segoe UI", 9.5f), Location = new Point(130, 95), Size = new Size(80, 32), FlatStyle = FlatStyle.Flat, Cursor = Cursors.Hand, Enabled = false };
            _btnDisconnect.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 210);
            _btnDisconnect.Click += BtnDisconnect_Click;

            _btnLoadCoefficients = new Button { Text = "Đọc hệ số Flash", Font = new Font("Segoe UI", 9.5f), Location = new Point(225, 95), Size = new Size(140, 32), FlatStyle = FlatStyle.Flat, Cursor = Cursors.Hand, Enabled = false };
            _btnLoadCoefficients.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 210);
            _btnLoadCoefficients.Click += BtnLoadCoefficients_Click;

            panelConnect.Controls.Add(_btnConnect);
            panelConnect.Controls.Add(_btnDisconnect);
            panelConnect.Controls.Add(_btnLoadCoefficients);

            _ledIndicator = new Panel { Location = new Point(16, 145), Size = new Size(16, 16), BackColor = Color.FromArgb(180, 180, 180) };
            _ledIndicator.Region = MakeCircleRegion(16, 16);

            _lblConnStatus = new Label { Text = "Chưa kết nối", AutoSize = true, Font = new Font("Segoe UI", 9.5f), ForeColor = Color.Gray, Location = new Point(38, 143) };

            panelConnect.Controls.Add(_ledIndicator);
            panelConnect.Controls.Add(_lblConnStatus);
        }

        private void RefreshComPorts()
        {
            string current = _cmbComPort.Text.Trim();
            string[] ports = SerialPort.GetPortNames().OrderBy(p => p, StringComparer.OrdinalIgnoreCase).ToArray();
            _cmbComPort.Items.Clear();
            _cmbComPort.Items.AddRange(ports);
            if (ports.Length == 0) { _cmbComPort.Text = ""; return; }
            if (!string.IsNullOrWhiteSpace(current) && ports.Contains(current, StringComparer.OrdinalIgnoreCase)) _cmbComPort.Text = current;
            else _cmbComPort.SelectedIndex = 0;
        }

        private static System.Drawing.Region MakeCircleRegion(int w, int h)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, w, h);
            return new System.Drawing.Region(path);
        }

        private void BtnConnect_Click(object? sender, EventArgs e)
        {
            string port = _cmbComPort.Text.Trim();
            int baud = int.Parse(_cmbBaudrate.SelectedItem!.ToString()!);

            if (USE_SIMULATION)
            {
                SetConnectionUI(true, string.IsNullOrWhiteSpace(port) ? "SIM" : port, baud);
                return;
            }

            string[] availablePorts = SerialPort.GetPortNames();
            if (string.IsNullOrWhiteSpace(port) || !availablePorts.Contains(port, StringComparer.OrdinalIgnoreCase))
            {
                MessageBox.Show("Không tìm thấy cổng COM này.", "Lỗi Serial", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RefreshComPorts();
                return;
            }

            try
            {
                _serialPort = new SerialPort(port, baud, Parity.None, 8, StopBits.One) { Encoding = Encoding.ASCII, ReadTimeout = 500, WriteTimeout = 500, DtrEnable = false, RtsEnable = false };
                _serialPort.DataReceived += SerialPort_DataReceived;
                _serialPort.Open();
                _serialPort.DiscardInBuffer();
                _serialPort.DiscardOutBuffer();

                lock (_rxLock) _rxBuffer.Clear();
                SetConnectionUI(true, port, baud);
            }
            catch (Exception ex)
            {
                try { if (_serialPort != null) _serialPort.DataReceived -= SerialPort_DataReceived; _serialPort?.Dispose(); } catch { }
                _serialPort = null;
                MessageBox.Show($"Không thể mở {port}:\n{ex.Message}", "Lỗi Serial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDisconnect_Click(object? sender, EventArgs e)
        {
            try
            {
                if (_serialPort != null)
                {
                    _serialPort.DataReceived -= SerialPort_DataReceived;
                    if (_serialPort.IsOpen) _serialPort.Close();
                    _serialPort.Dispose();
                }
            }
            catch { }
            finally
            {
                _serialPort = null;
                lock (_rxLock) _rxBuffer.Clear();
                SetConnectionUI(false);
            }
        }

        private void BtnLoadCoefficients_Click(object? sender, EventArgs e)
        {
            SendCommandToMcu("*L#");
        }

        private void SendCommandToMcu(string cmd)
        {
            if (USE_SIMULATION) { MessageBox.Show($"Simulation mode — lệnh sẽ gửi:\n{cmd}"); return; }
            if (_serialPort == null || !_serialPort.IsOpen) { MessageBox.Show("Serial chưa mở!"); return; }
            try { _serialPort.Write(cmd); } catch (Exception ex) { MessageBox.Show($"Lỗi gửi lệnh:\n{ex.Message}"); }
        }

        private void SetConnectionUI(bool connected, string port = "", int baud = 0)
        {
            _isConnected = connected;
            if (connected)
            {
                _ledIndicator.BackColor = Color.FromArgb(34, 197, 94);
                _lblConnStatus.Text = $"Đang kết nối  —  {port}  @  {baud} bps";
                _lblConnStatus.ForeColor = Color.FromArgb(22, 140, 50);
                _btnConnect.Enabled = false; _btnConnect.BackColor = Color.FromArgb(160, 200, 240);
                _btnDisconnect.Enabled = true; _btnLoadCoefficients.Enabled = true;
                _cmbComPort.Enabled = false; _cmbBaudrate.Enabled = false;
            }
            else
            {
                _ledIndicator.BackColor = Color.FromArgb(180, 180, 180);
                _lblConnStatus.Text = "Chưa kết nối";
                _lblConnStatus.ForeColor = Color.Gray;
                _btnConnect.Enabled = true; _btnConnect.BackColor = Color.FromArgb(24, 95, 165);
                _btnDisconnect.Enabled = false; _btnLoadCoefficients.Enabled = false;
                _cmbComPort.Enabled = true; _cmbBaudrate.Enabled = true;
                RefreshComPorts();
            }
        }

        private void SetupMonitorTab()
        {
            Panel[] panels = { panelSensor1, panelSensor2, panelSensor3 };
            for (int i = 0; i < 3; i++)
            {
                var lblName = new Label { Text = $"Sensor {i + 1} — {SensorNames[i]}", Location = new Point(10, 10), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold), ForeColor = Color.FromArgb(30, 100, 180) };
                _lblValues[i] = new Label { Text = "—", Size = new Size(390, 80), TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 36, FontStyle.Bold), ForeColor = Color.FromArgb(20, 20, 20) };
                _lblUnits[i] = new Label { Text = SensorUnits[i], Size = new Size(390, 24), TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 11, FontStyle.Regular), ForeColor = Color.Gray };
                int pw = panels[i].ClientSize.Width;
                _lblValues[i].Left = (pw - _lblValues[i].Width) / 2; _lblUnits[i].Left = (pw - _lblUnits[i].Width) / 2;
                _lblValues[i].Top = 55; _lblUnits[i].Top = 140;
                panels[i].Controls.Add(lblName); panels[i].Controls.Add(_lblValues[i]); panels[i].Controls.Add(_lblUnits[i]);
            }
            _lblTime = new Label { Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(80, 80, 80), Padding = new Padding(10, 0, 0, 0) };
            statusBar.Controls.Add(_lblTime);
        }

        private void SetupCalibController()
        {
            _calib = new CalibrationControl(btnSensor1, btnSensor2, btnSensor3, pnlLive, txtAdcZero, txtRealZero, lblUnitZero, txtAdcSpan, txtRealSpan, lblUnitSpan, btnCaptureZero, btnCaptureSpan, btnCalc, button1, formsPlotCalib, lblFormula, lblCoefA, lblCoefB, lblStatus)
            {
                SendSerialData = SendCommandToMcu
            };
        }

        private void SetupChartTab()
        {
            _myChart = new ChartControl { Dock = DockStyle.Fill };
            tabChart.Controls.Add(_myChart);
        }

        private void UpdateSensorPanel(int i, double value)
        {
            _lblValues[i].Text = value.ToString("F2", CultureInfo.InvariantCulture);
            bool warning = value > SensorMaxReal[i] * 0.9;
            _lblValues[i].ForeColor = warning ? Color.FromArgb(200, 60, 30) : Color.FromArgb(20, 20, 20);
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                var port = _serialPort;
                if (port == null || !port.IsOpen) return;
                string chunk = port.ReadExisting();
                if (string.IsNullOrEmpty(chunk)) return;

                string[] frames;
                lock (_rxLock)
                {
                    _rxBuffer.Append(chunk);
                    frames = ExtractCompleteFramesFromBuffer();
                }
                foreach (string frame in frames)
                {
                    BeginInvoke(new Action(() => ProcessFrameOnUiThread(frame)));
                }
            }
            catch { }
        }

        private string[] ExtractCompleteFramesFromBuffer()
        {
            var frames = new System.Collections.Generic.List<string>();

            // CHỐT CHẶN CHỐNG TRÀN BỘ NHỚ (Memory Leak Guard)
            // Nếu MCU lỗi gửi toàn rác không có dấu '#' kéo dài quá 1024 ký tự, xóa sạch buffer.
            if (_rxBuffer.Length > 1024)
            {
                _rxBuffer.Clear();
                return frames.ToArray();
            }

            while (true)
            {
                string text = _rxBuffer.ToString();
                int start = text.IndexOf('*');

                if (start < 0) { _rxBuffer.Clear(); break; }
                if (start > 0) { _rxBuffer.Remove(0, start); text = _rxBuffer.ToString(); }

                int end = text.IndexOf('#', 1);
                if (end < 0) break;

                string payload = text.Substring(1, end - 1).Trim();
                _rxBuffer.Remove(0, end + 1);

                if (!string.IsNullOrWhiteSpace(payload)) frames.Add(payload);
            }
            return frames.ToArray();
        }

        private void ProcessFrameOnUiThread(string payload)
        {
            string[] parts = payload.Split(',', StringSplitOptions.TrimEntries);
            if (parts.Length == 0) return;

            string id = parts[0].Trim().ToUpperInvariant();

            if ((id == "1" || id == "2" || id == "3") && parts.Length >= 2)
            {
                if (TryParseFrameValue(parts[1], out double value))
                {
                    int sensorIndex = int.Parse(id, CultureInfo.InvariantCulture) - 1;
                    _adcRaw[sensorIndex] = value;
                    RememberLastFrame(payload);
                }
                return;
            }

            if (IsCoefficientId(id, out char coeffType, out int coeffSensorIndex) && parts.Length >= 2)
            {
                if (TryParseFrameValue(parts[1], out double coeffValue))
                {
                    _calib?.SetCoefficientFromMcu(coeffSensorIndex, coeffType, coeffValue);
                    RememberLastFrame(payload);
                }
                return;
            }
        }

        private static bool TryParseFrameValue(string text, out double value)
        {
            return double.TryParse(text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out value);
        }

        private static bool IsCoefficientId(string id, out char coeffType, out int sensorIndex)
        {
            coeffType = '\0'; sensorIndex = -1;
            if (id.Length != 2) return false;
            char type = char.ToUpperInvariant(id[0]);
            char sensor = id[1];
            if (type != 'A' && type != 'B') return false;
            if (sensor < '1' || sensor > '3') return false;
            coeffType = type; sensorIndex = sensor - '1';
            return true;
        }

        private void RememberLastFrame(string payload)
        {
            _lastRxFrame = "*" + payload + "#";
            _lastRxTime = DateTime.Now;
        }
    }
}