using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SensorMonitorAndCalibration
{
    /// <summary>
    /// Controller xử lý toàn bộ logic calibration.
    /// UI (controls) nằm trong Form1_Designer.cs — class này chỉ nhận references và xử lý logic.
    /// </summary>
    public class CalibrationControl
    {
        public Action<string>? SendSerialData { get; set; }

        // ── Sensor metadata — 3 sensor còn lại (đã bỏ Loadcell) ─────────────
        private static readonly string[] SensorNames = { "Thermistor", "Potentiometer", "Encoder" };
        private static readonly string[] SensorUnits = { "°C", "deg", "RPM" };
        private static readonly double[] DefaultZero = { 0, 0, 0 };
        private static readonly double[] DefaultSpan = { 100, 300, 500 };

        // ── Calibration state ─────────────────────────────────────────────────
        private readonly double[] _a = new double[3];
        private readonly double[] _b = new double[3];
        private readonly bool[] _calibrated = new bool[3];
        private readonly bool[] _hasA = new bool[3];
        private readonly bool[] _hasB = new bool[3];

        private int _selectedSensor = 0;
        private double _currentAdc = 0.0;

        // ── References đến controls của Form1 ────────────────────────────────
        private readonly Button _btnSensor1, _btnSensor2, _btnSensor3;
        private readonly Label _lblUnitZero, _lblUnitSpan;
        private readonly TextBox _txtAdcZero, _txtRealZero;
        private readonly TextBox _txtAdcSpan, _txtRealSpan;
        private readonly Button _btnCaptureZero, _btnCaptureSpan, _btnCalc, _btnSend;
        private readonly ScottPlot.WinForms.FormsPlot _plot;
        private readonly Label _lblFormula, _lblCoefA, _lblCoefB, _lblStatus;

        // Labels giá trị live — thêm động vào pnlLive
        private readonly Label _lblLiveAdcValue;
        private readonly Label _lblLiveRealValue;

        // ─────────────────────────────────────────────────────────────────────
        public CalibrationControl(
            Button btnSensor1, Button btnSensor2, Button btnSensor3,
            Panel pnlLive,
            TextBox txtAdcZero, TextBox txtRealZero, Label lblUnitZero,
            TextBox txtAdcSpan, TextBox txtRealSpan, Label lblUnitSpan,
            Button btnCaptureZero, Button btnCaptureSpan,
            Button btnCalc, Button btnSend,
            ScottPlot.WinForms.FormsPlot formsPlotCalib,
            Label lblFormula, Label lblCoefA, Label lblCoefB, Label lblStatus)
        {
            _btnSensor1 = btnSensor1;
            _btnSensor2 = btnSensor2;
            _btnSensor3 = btnSensor3;
            _txtAdcZero = txtAdcZero;
            _txtRealZero = txtRealZero;
            _lblUnitZero = lblUnitZero;
            _txtAdcSpan = txtAdcSpan;
            _txtRealSpan = txtRealSpan;
            _lblUnitSpan = lblUnitSpan;
            _btnCaptureZero = btnCaptureZero;
            _btnCaptureSpan = btnCaptureSpan;
            _btnCalc = btnCalc;
            _btnSend = btnSend;
            _plot = formsPlotCalib;
            _lblFormula = lblFormula;
            _lblCoefA = lblCoefA;
            _lblCoefB = lblCoefB;
            _lblStatus = lblStatus;

            // Mặc định identity để nếu chưa calib thì y = x.
            for (int i = 0; i < 3; i++)
            {
                _a[i] = 1.0;
                _b[i] = 0.0;
            }

            // Thêm label giá trị live vào pnlLive (designer chỉ có title labels)
            _lblLiveAdcValue = new Label
            {
                AutoSize = true,
                Location = new Point(12, 34),
                Font = new Font("Segoe UI", 11f, FontStyle.Bold),
                ForeColor = Color.FromArgb(24, 95, 165),
                Text = "—"
            };
            _lblLiveRealValue = new Label
            {
                AutoSize = true,
                Location = new Point(200, 34),
                Font = new Font("Segoe UI", 11f, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 130, 30),
                Text = "—"
            };
            pnlLive.Controls.Add(_lblLiveAdcValue);
            pnlLive.Controls.Add(_lblLiveRealValue);

            // Cập nhật text button đúng 3 sensor còn lại
            _btnSensor1.Text = "Sensor 1 — Thermistor";
            _btnSensor2.Text = "Sensor 2 — Potentiometer";
            _btnSensor3.Text = "Sensor 3 — Encoder";

            // Wire events
            _btnSensor1.Click += (_, __) => SelectSensor(0);
            _btnSensor2.Click += (_, __) => SelectSensor(1);
            _btnSensor3.Click += (_, __) => SelectSensor(2);
            _btnCaptureZero.Click += BtnCaptureZero_Click;
            _btnCaptureSpan.Click += BtnCaptureSpan_Click;
            _btnCalc.Click += BtnCalc_Click;
            _btnSend.Click += BtnSend_Click;

            SelectSensor(0);
            InitPlot();
        }

        // ── Public API ────────────────────────────────────────────────────────
        public void SetLiveAdcValues(double[] adcValues, double[] realValues)
        {
            if (adcValues == null || realValues == null) return;
            _currentAdc = adcValues[_selectedSensor];
            _lblLiveAdcValue.Text = $"{_currentAdc:F4} V";
            _lblLiveRealValue.Text = $"≈ {realValues[_selectedSensor]:F2} {SensorUnits[_selectedSensor]}";
        }

        public (double a, double b) GetCoefficients(int sensorIndex)
        {
            if (sensorIndex < 0 || sensorIndex >= 3) return (1.0, 0.0);
            return _calibrated[sensorIndex]
                ? (_a[sensorIndex], _b[sensorIndex])
                : (1.0, 0.0);
        }

        // Nhận hệ số từ frame MCU: *A1,value# / *B1,value# ...
        public void SetCoefficientFromMcu(int sensorIndex, char coeffType, double value)
        {
            if (sensorIndex < 0 || sensorIndex >= 3) return;

            coeffType = char.ToUpperInvariant(coeffType);
            if (coeffType == 'A')
            {
                _a[sensorIndex] = value;
                _hasA[sensorIndex] = true;
            }
            else if (coeffType == 'B')
            {
                _b[sensorIndex] = value;
                _hasB[sensorIndex] = true;
            }
            else
            {
                return;
            }

            // Khi đã có đủ A và B thì xem như sensor đã có hệ số hợp lệ.
            if (_hasA[sensorIndex] && _hasB[sensorIndex])
                _calibrated[sensorIndex] = true;

            if (_selectedSensor == sensorIndex)
                RefreshCoefficientLabels(sensorIndex, fromMcu: true);
        }

        // ── Capture ───────────────────────────────────────────────────────────
        private void BtnCaptureZero_Click(object? sender, EventArgs e)
        {
            _txtAdcZero.Text = _currentAdc.ToString("F4", CultureInfo.InvariantCulture);
            _txtRealZero.Text = DefaultZero[_selectedSensor].ToString("F1", CultureInfo.InvariantCulture);
        }

        private void BtnCaptureSpan_Click(object? sender, EventArgs e)
        {
            _txtAdcSpan.Text = _currentAdc.ToString("F4", CultureInfo.InvariantCulture);
            _txtRealSpan.Text = DefaultSpan[_selectedSensor].ToString("F1", CultureInfo.InvariantCulture);
        }

        // ── Calculate ─────────────────────────────────────────────────────────
        private void BtnCalc_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(_txtAdcZero.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out double x1) ||
                !double.TryParse(_txtRealZero.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out double y1) ||
                !double.TryParse(_txtAdcSpan.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out double x2) ||
                !double.TryParse(_txtRealSpan.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out double y2))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng số. Dùng dấu chấm cho số thập phân, ví dụ 1.234.",
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Math.Abs(x2 - x1) < 1e-9)
            {
                MessageBox.Show("ADC Zero và ADC Span không được bằng nhau.",
                    "Lỗi tính toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int i = _selectedSensor;
            _a[i] = (y2 - y1) / (x2 - x1);
            _b[i] = y1 - _a[i] * x1;
            _hasA[i] = true;
            _hasB[i] = true;
            _calibrated[i] = true;

            RefreshCoefficientLabels(i, fromMcu: false);
            DrawCalibLine(x1, y1, x2, y2, i);
        }

        private void RefreshCoefficientLabels(int i, bool fromMcu)
        {
            string bSign = _b[i] >= 0 ? "+" : "−";
            _lblFormula.Text = $"y  =  {_a[i]:F4} × x  {bSign}  {Math.Abs(_b[i]):F4}";
            _lblCoefA.Text = $"Hệ số  a  =  {_a[i]:F6}";
            _lblCoefB.Text = $"Hệ số  b  =  {_b[i]:F6}";

            if (_calibrated[i])
            {
                string source = fromMcu ? "Đã load từ MCU Flash" : "Đã calibrate";
                _lblStatus.Text = $"✓ Sensor {i + 1} ({SensorNames[i]}) — {source}  [{SensorUnits[i]}]";
                _lblStatus.ForeColor = Color.FromArgb(30, 130, 30);
            }
            else
            {
                _lblStatus.Text = $"Sensor {i + 1} ({SensorNames[i]}) — mới nhận một phần hệ số từ MCU";
                _lblStatus.ForeColor = Color.FromArgb(180, 120, 20);
            }
        }

        // ── Send to MCU ───────────────────────────────────────────────────────
        private void BtnSend_Click(object? sender, EventArgs e)
        {
            // Theo frame mới: gửi đồng thời 6 hệ số trong 1 frame duy nhất
            // *S,<A1>,<B1>,<A2>,<B2>,<A3>,<B3>#
            if (!AllSensorsHaveCoefficients())
            {
                MessageBox.Show(
                    "Frame *S cần đủ 6 hệ số A1,B1,A2,B2,A3,B3.\n" +
                    "Hãy calibrate đủ 3 sensor hoặc bấm 'Đọc hệ số Flash' để load hệ số đang có từ MCU trước khi lưu.",
                    "Chưa đủ hệ số", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cmd = string.Format(
                CultureInfo.InvariantCulture,
                "*S,{0:F6},{1:F6},{2:F6},{3:F6},{4:F6},{5:F6}#",
                _a[0], _b[0], _a[1], _b[1], _a[2], _b[2]);

            if (SendSerialData != null)
            {
                SendSerialData(cmd);
                MessageBox.Show(
                    $"Đã gửi về MCU:\n{cmd}",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    $"Chưa kết nối Serial!\n\nLệnh sẽ gửi:\n{cmd}",
                    "Chưa kết nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool AllSensorsHaveCoefficients()
        {
            for (int i = 0; i < 3; i++)
            {
                if (!_calibrated[i])
                    return false;
            }
            return true;
        }

        // ── Sensor selector ───────────────────────────────────────────────────
        private void SelectSensor(int index)
        {
            _selectedSensor = index;

            var btns = new[] { _btnSensor1, _btnSensor2, _btnSensor3 };
            foreach (var btn in btns)
            {
                btn.BackColor = SystemColors.Control;
                btn.ForeColor = Color.MidnightBlue;
                btn.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 210);
            }
            btns[index].BackColor = Color.FromArgb(220, 235, 252);
            btns[index].ForeColor = Color.FromArgb(24, 95, 165);
            btns[index].FlatAppearance.BorderColor = Color.FromArgb(24, 95, 165);

            _lblUnitZero.Text = SensorUnits[index];
            _lblUnitSpan.Text = SensorUnits[index];
            _txtRealZero.Text = DefaultZero[index].ToString("F1", CultureInfo.InvariantCulture);
            _txtRealSpan.Text = DefaultSpan[index].ToString("F1", CultureInfo.InvariantCulture);
            _txtAdcZero.Text = "0.00";
            _txtAdcSpan.Text = "0.00";

            if (_calibrated[index] || _hasA[index] || _hasB[index])
            {
                RefreshCoefficientLabels(index, fromMcu: false);
            }
            else
            {
                _lblFormula.Text = "Chưa có dữ liệu calib";
                _lblCoefA.Text = "Hệ số a: —";
                _lblCoefB.Text = "Hệ số b: —";
                _lblStatus.Text = $"Sensor {index + 1} ({SensorNames[index]}) chưa tính";
                _lblStatus.ForeColor = SystemColors.ControlDark;
            }

            _lblLiveAdcValue.Text = "—";
            _lblLiveRealValue.Text = "—";
            InitPlot();
        }

        // ── ScottPlot 5.x ─────────────────────────────────────────────────────
        private void InitPlot()
        {
            _plot.Plot.Clear();
            _plot.Plot.Title($"Calib — Sensor {_selectedSensor + 1}: {SensorNames[_selectedSensor]}");
            _plot.Plot.XLabel("ADC (V)");
            _plot.Plot.YLabel(SensorUnits[_selectedSensor]);
            _plot.Refresh();
        }

        private void DrawCalibLine(double x1, double y1, double x2, double y2, int idx)
        {
            _plot.Plot.Clear();

            var line = _plot.Plot.Add.Line(x1, y1, x2, y2);
            line.LineWidth = 2;
            line.Color = new ScottPlot.Color(24, 95, 165);

            var ptZero = _plot.Plot.Add.Scatter(new[] { x1 }, new[] { y1 });
            ptZero.MarkerSize = 10;
            ptZero.Color = new ScottPlot.Color(24, 95, 165);
            ptZero.LineWidth = 0;
            ptZero.LegendText = $"Zero  ({x1:F3} V → {y1:F2} {SensorUnits[idx]})";

            var ptSpan = _plot.Plot.Add.Scatter(new[] { x2 }, new[] { y2 });
            ptSpan.MarkerSize = 10;
            ptSpan.Color = new ScottPlot.Color(30, 140, 30);
            ptSpan.LineWidth = 0;
            ptSpan.LegendText = $"Span  ({x2:F3} V → {y2:F2} {SensorUnits[idx]})";

            _plot.Plot.ShowLegend();
            _plot.Plot.Title($"Calib — Sensor {idx + 1}: {SensorNames[idx]}");
            _plot.Plot.XLabel("ADC (V)");
            _plot.Plot.YLabel(SensorUnits[idx]);
            _plot.Refresh();
        }
    }
}
