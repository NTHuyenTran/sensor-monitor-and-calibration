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
        // true  = dùng dữ liệu giả lập để test GUI khi chưa có MCU
        // false = dùng Serial thật và đọc frame theo định dạng *...#
        private const bool USE_SIMULATION = false;

        // ── Timer & dữ liệu giả lập ──────────────────────────────────────────
        private readonly System.Windows.Forms.Timer _updateTimer = new();
        private readonly Random _rng = new();

        // 3 sensor: Thermistor, Potentiometer, Encoder  (đồng bộ với CalibrationControl)
        // Theo GUI hiện tại, giá trị nhận từ MCU được xem là ADC/raw value để đưa qua calib.
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
        private ComboBox _cmbComPort = null!;
        private ComboBox _cmbBaudrate = null!;
        private Button _btnConnect = null!;
        private Button _btnDisconnect = null!;
        private Button _btnLoadCoefficients = null!;
        private Panel _ledIndicator = null!;
        private Label _lblConnStatus = null!;

        // ── Serial Port (Phase 2: đọc thực từ MCU) ───────────────────────────
        private SerialPort? _serialPort;
        private bool _isConnected = false;

        // Buffer nhận frame dạng: *ID,value# hoặc *S,...#
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
            _cmbComPort = new ComboBox
            {
                Font = new Font("Segoe UI", 9.5f),
                Location = new Point(100, 49),
                Size = new Size(90, 26),
                DropDownStyle = ComboBoxStyle.DropDown
            };
            _cmbComPort.DropDown += (_, __) => RefreshComPorts();

            var lblBaud = new Label
            {
                Text = "Baudrate:",
                AutoSize = true,
                Font = new Font("Segoe UI", 9.5f),
                Location = new Point(210, 52)
            };
            _cmbBaudrate = new ComboBox
            {
                Font = new Font("Segoe UI", 9.5f),
                Location = new Point(295, 49),
                Size = new Size(100, 26),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            _cmbBaudrate.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" });
            _cmbBaudrate.SelectedIndex = 0;   // mặc định 9600

            panelConnect.Controls.Add(lblCom);
            panelConnect.Controls.Add(_cmbComPort);
            panelConnect.Controls.Add(lblBaud);
            panelConnect.Controls.Add(_cmbBaudrate);

            RefreshComPorts();

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

            _btnLoadCoefficients = new Button
            {
                Text = "Đọc hệ số Flash",
                Font = new Font("Segoe UI", 9.5f),
                Location = new Point(225, 95),
                Size = new Size(140, 32),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Enabled = false
            };
            _btnLoadCoefficients.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 210);
            _btnLoadCoefficients.Click += BtnLoadCoefficients_Click;

            panelConnect.Controls.Add(_btnConnect);
            panelConnect.Controls.Add(_btnDisconnect);
            panelConnect.Controls.Add(_btnLoadCoefficients);

            // ── Dòng 3: LED + trạng thái ─────────────────────────────────────
            _ledIndicator = new Panel
            {
                Location = new Point(16, 145),
                Size = new Size(16, 16),
                BackColor = Color.FromArgb(180, 180, 180)   // xám = chưa kết nối
            };
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

        private void RefreshComPorts()
        {
            string current = _cmbComPort.Text.Trim();
            string[] ports = SerialPort.GetPortNames()
                .OrderBy(p => p, StringComparer.OrdinalIgnoreCase)
                .ToArray();

            _cmbComPort.Items.Clear();
            _cmbComPort.Items.AddRange(ports);

            if (ports.Length == 0)
            {
                _cmbComPort.Text = "";
                return;
            }

            if (!string.IsNullOrWhiteSpace(current) && ports.Contains(current, StringComparer.OrdinalIgnoreCase))
                _cmbComPort.Text = current;
            else
                _cmbComPort.SelectedIndex = 0;
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
            string port = _cmbComPort.Text.Trim();
            int baud = int.Parse(_cmbBaudrate.SelectedItem!.ToString()!);

            if (USE_SIMULATION)
            {
                _isConnected = true;
                SetConnectionUI(connected: true, port: string.IsNullOrWhiteSpace(port) ? "SIM" : port, baud: baud);
                return;
            }

            string[] availablePorts = SerialPort.GetPortNames();
            if (string.IsNullOrWhiteSpace(port) ||
                !availablePorts.Contains(port, StringComparer.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Không tìm thấy cổng COM này. Hãy cắm MCU, bấm xổ danh sách COM rồi chọn đúng cổng.",
                    "Lỗi Serial", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RefreshComPorts();
                return;
            }

            try
            {
                _serialPort = new SerialPort(port, baud, Parity.None, 8, StopBits.One)
                {
                    Encoding = Encoding.ASCII,
                    ReadTimeout = 500,
                    WriteTimeout = 500,
                    DtrEnable = false,
                    RtsEnable = false
                };

                _serialPort.DataReceived += SerialPort_DataReceived;
                _serialPort.Open();
                _serialPort.DiscardInBuffer();
                _serialPort.DiscardOutBuffer();

                lock (_rxLock)
                    _rxBuffer.Clear();

                SetConnectionUI(connected: true, port: port, baud: baud);
            }
            catch (Exception ex)
            {
                try
                {
                    if (_serialPort != null)
                        _serialPort.DataReceived -= SerialPort_DataReceived;
                    _serialPort?.Dispose();
                }
                catch { /* ignore cleanup error */ }
                _serialPort = null;

                MessageBox.Show($"Không thể mở {port}:\n{ex.Message}",
                    "Lỗi Serial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDisconnect_Click(object? sender, EventArgs e)
        {
            try
            {
                if (_serialPort != null)
                {
                    _serialPort.DataReceived -= SerialPort_DataReceived;
                    if (_serialPort.IsOpen)
                        _serialPort.Close();
                    _serialPort.Dispose();
                }
            }
            catch { /* bỏ qua lỗi khi đóng port */ }
            finally
            {
                _serialPort = null;
                _isConnected = false;
                lock (_rxLock)
                    _rxBuffer.Clear();
                SetConnectionUI(connected: false);
            }
        }

        private void BtnLoadCoefficients_Click(object? sender, EventArgs e)
        {
            SendCommandToMcu("*L#");
        }

        private void SendCommandToMcu(string cmd)
        {
            if (USE_SIMULATION)
            {
                MessageBox.Show($"Simulation mode — lệnh sẽ gửi:\n{cmd}",
                    "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_serialPort == null || !_serialPort.IsOpen)
            {
                MessageBox.Show("Serial chưa mở!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _serialPort.Write(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không gửi được lệnh xuống MCU:\n{ex.Message}",
                    "Lỗi Serial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetConnectionUI(bool connected, string port = "", int baud = 0)
        {
            _isConnected = connected;

            if (connected)
            {
                _ledIndicator.BackColor = Color.FromArgb(34, 197, 94);
                _lblConnStatus.Text = $"Đang kết nối  —  {port}  @  {baud} bps";
                _lblConnStatus.ForeColor = Color.FromArgb(22, 140, 50);

                _btnConnect.Enabled = false;
                _btnConnect.BackColor = Color.FromArgb(160, 200, 240);
                _btnDisconnect.Enabled = true;
                _btnLoadCoefficients.Enabled = true;

                _cmbComPort.Enabled = false;
                _cmbBaudrate.Enabled = false;
            }
            else
            {
                _ledIndicator.BackColor = Color.FromArgb(180, 180, 180);
                _lblConnStatus.Text = "Chưa kết nối";
                _lblConnStatus.ForeColor = Color.Gray;

                _btnConnect.Enabled = true;
                _btnConnect.BackColor = Color.FromArgb(24, 95, 165);
                _btnDisconnect.Enabled = false;
                _btnLoadCoefficients.Enabled = false;

                _cmbComPort.Enabled = true;
                _cmbBaudrate.Enabled = true;
                RefreshComPorts();
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

            // Delegate gửi Serial. CalibrationControl chỉ đóng gói frame, Form1 chịu trách nhiệm ghi xuống port.
            _calib.SendSerialData = SendCommandToMcu;
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
            bool hasDataSource = USE_SIMULATION || _isConnected;

            // Phase 1: giả lập ADC thô. Phase 2: KHÔNG ghi đè dữ liệu Serial.
            if (USE_SIMULATION)
            {
                _adcRaw[0] = _rng.NextDouble() * 3.3;   // Thermistor
                _adcRaw[1] = _rng.NextDouble() * 3.3;   // Potentiometer
                _adcRaw[2] = _rng.NextDouble() * 3.3;   // Encoder
            }

            if (hasDataSource)
            {
                // Áp dụng hệ số calib để ra giá trị thực
                for (int i = 0; i < 3; i++)
                {
                    var (a, b) = _calib?.GetCoefficients(i) ?? (1.0, 0.0);
                    _realVals[i] = a * _adcRaw[i] + b;
                }

                // Cập nhật tab Monitor
                for (int i = 0; i < 3; i++)
                    UpdateSensorPanel(i, _realVals[i]);

                // Cập nhật tab Calib và Chart (live reading)
                _calib?.SetLiveAdcValues(_adcRaw, _realVals);
                _myChart?.UpdateChartData(_realVals);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    _lblValues[i].Text = "—";
                    _lblValues[i].ForeColor = Color.FromArgb(20, 20, 20);
                }
            }

            // Status bar
            if (_lblTime != null)
            {
                string source = USE_SIMULATION
                    ? "Giả lập"
                    : (_isConnected ? "Serial thật - frame *ID,value#" : "Chưa kết nối");

                string lastRx = _lastRxTime == DateTime.MinValue
                    ? "—"
                    : $"{_lastRxFrame} lúc {_lastRxTime:HH:mm:ss}";

                _lblTime.Text = $"Cập nhật lúc: {DateTime.Now:HH:mm:ss}   |   " +
                                $"Chu kỳ GUI: 1000 ms   |   Nguồn: {source}   |   Frame cuối: {lastRx}";
            }
        }

        // ── Cập nhật một panel sensor trên tab Monitor ────────────────────────
        private void UpdateSensorPanel(int i, double value)
        {
            _lblValues[i].Text = value.ToString("F2", CultureInfo.InvariantCulture);

            bool warning = value > SensorMaxReal[i] * 0.9;
            _lblValues[i].ForeColor = warning
                ? Color.FromArgb(200, 60, 30)
                : Color.FromArgb(20, 20, 20);
        }

        // ── Nhận Serial dạng frame *...# ──────────────────────────────────────
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
                    // Đưa về UI thread vì frame có thể cập nhật control/calib.
                    BeginInvoke(new Action(() => ProcessFrameOnUiThread(frame)));
                }
            }
            catch
            {
                // Bỏ qua frame lỗi để GUI không bị crash khi nhiễu Serial.
            }
        }

        private string[] ExtractCompleteFramesFromBuffer()
        {
            var frames = new System.Collections.Generic.List<string>();

            while (true)
            {
                string text = _rxBuffer.ToString();
                int start = text.IndexOf('*');

                // Chưa có ký tự bắt đầu frame: bỏ rác khỏi buffer.
                if (start < 0)
                {
                    _rxBuffer.Clear();
                    break;
                }

                // Bỏ dữ liệu rác trước ký tự '*'.
                if (start > 0)
                {
                    _rxBuffer.Remove(0, start);
                    text = _rxBuffer.ToString();
                }

                int end = text.IndexOf('#', 1);
                if (end < 0)
                    break; // Chưa đủ frame, chờ chunk tiếp theo.

                string payload = text.Substring(1, end - 1).Trim(); // bỏ * và #
                _rxBuffer.Remove(0, end + 1);

                if (!string.IsNullOrWhiteSpace(payload))
                    frames.Add(payload);
            }

            return frames.ToArray();
        }

        private void ProcessFrameOnUiThread(string payload)
        {
            string[] parts = payload.Split(',', StringSplitOptions.TrimEntries);
            if (parts.Length == 0) return;

            string id = parts[0].Trim().ToUpperInvariant();

            // Nhóm 1: cảm biến thời gian thực
            // *1,<giá_trị>#  Thermistor
            // *2,<giá_trị>#  Potentiometer
            // *3,<giá_trị>#  Encoder
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

            // Nhóm 2: hệ số trong Flash MCU
            // *A1,<giá_trị>#  *B1,<giá_trị># ... *A3,<giá_trị># *B3,<giá_trị>#
            if (IsCoefficientId(id, out char coeffType, out int coeffSensorIndex) && parts.Length >= 2)
            {
                if (TryParseFrameValue(parts[1], out double coeffValue))
                {
                    _calib?.SetCoefficientFromMcu(coeffSensorIndex, coeffType, coeffValue);
                    RememberLastFrame(payload);
                }
                return;
            }

            // ID khác: bỏ qua để không ảnh hưởng các phần khác của project.
        }

        private static bool TryParseFrameValue(string text, out double value)
        {
            return double.TryParse(
                text.Trim(),
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out value);
        }

        private static bool IsCoefficientId(string id, out char coeffType, out int sensorIndex)
        {
            coeffType = '\0';
            sensorIndex = -1;

            if (id.Length != 2) return false;
            char type = char.ToUpperInvariant(id[0]);
            char sensor = id[1];

            if (type != 'A' && type != 'B') return false;
            if (sensor < '1' || sensor > '3') return false;

            coeffType = type;
            sensorIndex = sensor - '1';
            return true;
        }

        private void RememberLastFrame(string payload)
        {
            _lastRxFrame = "*" + payload + "#";
            _lastRxTime = DateTime.Now;
        }
    }
}
