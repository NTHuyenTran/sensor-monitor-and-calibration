using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ScottPlot.WinForms;

namespace SensorMonitorAndCalibration
{
    public partial class ChartControl : UserControl
    {
        // ── Arrays để quản lý chung 3 đồ thị ────────────────────────────────
        private readonly FormsPlot[] _plots;
        private readonly ScottPlot.Plottables.DataLogger[] _loggers;

        private readonly DateTime _startTime;

        // Quản lý các nút bấm tương ứng với từng đồ thị
        private readonly Button[] _btnPc;
        private readonly Button[] _btnCsv;

        // Trạng thái Pause của từng đồ thị
        private readonly bool[] _isPaused = { false, false, false };

        // Lưu trữ dữ liệu thô để xuất CSV (thời gian, giá trị)
        private readonly List<(DateTime Time, double Value)>[] _exportData;
        private const int MAX_CSV_ROWS = 500000; // Giới hạn an toàn chống tràn RAM

        // ── Biến phục vụ tính toán Sampling Rate (s_rate) ────────────────────
        private int _sampleCount = 0;
        private DateTime _lastRateCalcTime;

        // Tên các cảm biến (đồng bộ với Form1)
        private readonly string[] _sensorNames = { "Thermistor (°C)", "Potentiometer (deg)", "Encoder (RPM)" };
        private readonly ScottPlot.Color[] _lineColors = {
            new ScottPlot.Color(200, 50, 50),   // Đỏ
            new ScottPlot.Color(50, 200, 50),   // Xanh lá
            new ScottPlot.Color(50, 50, 200)    // Xanh dương
        };

        public ChartControl()
        {
            InitializeComponent();

            _plots = new[] { formsPlot1, formsPlot2, formsPlot3 };
            _btnPc = new[] { btn_pc_1, btn_pc_2, btn_pc_3 };
            _btnCsv = new[] { btn_csv_1, btn_csv_2, btn_csv_3 };

            _loggers = new ScottPlot.Plottables.DataLogger[3];
            _startTime = DateTime.Now;
            _lastRateCalcTime = DateTime.Now;

            _exportData = new List<(DateTime, double)>[]
            {
                new(), new(), new()
            };

            SetupCharts();
            SetupEvents();
        }

        private void SetupCharts()
        {
            for (int i = 0; i < 3; i++)
            {
                _plots[i].Plot.XLabel("Thời gian (s)");
                _plots[i].Plot.YLabel("Giá trị");

                _loggers[i] = _plots[i].Plot.Add.DataLogger();
                _loggers[i].Color = _lineColors[i];
                _loggers[i].LineWidth = 2;
                _loggers[i].ManageAxisLimits = true;
                _plots[i].Refresh();

                _btnPc[i].ImageIndex = 0;
            }
        }

        private void SetupEvents()
        {
            for (int i = 0; i < 3; i++)
            {
                int index = i;
                _btnPc[index].Click += (s, e) => TogglePause(index);
                _btnCsv[index].Click += (s, e) => ExportCsv(index);
            }

            btn_all_pc.Click += (s, e) => ToggleAllPause();
            btn_all_csv.Click += (s, e) => ExportAllCsv();
        }

        // ── API để Form1 gọi và bơm dữ liệu ở tốc độ cao (50ms) ───────────────
        public void UpdateChartData(double[] realValues)
        {
            if (realValues == null || realValues.Length < 3) return;

            DateTime now = DateTime.Now;
            double elapsedSec = (now - _startTime).TotalSeconds;

            // 1. Tính toán Tốc độ lấy mẫu thực tế (Sampling Rate - Hz)
            _sampleCount++;
            if ((now - _lastRateCalcTime).TotalSeconds >= 1.0)
            {
                int currentRate = _sampleCount;
                _sampleCount = 0;
                _lastRateCalcTime = now;

                // Cập nhật lên Label trạng thái (Giả định control tên là 'status')
                if (status != null)
                {
                    status.BackColor = Color.DarkGreen;
                    s_rate.Text = $"Tốc độ thực tế: {currentRate} Hz";
                }
            }

            // 2. Bơm dữ liệu vào đồ thị và List CSV
            for (int i = 0; i < 3; i++)
            {
                if (!_isPaused[i])
                {
                    _loggers[i].Add(elapsedSec, realValues[i]);
                    _plots[i].Plot.Axes.AutoScale();
                    _plots[i].Refresh();

                    // Cảnh báo chống tràn RAM nếu treo máy đo quá lâu
                    if (_exportData[i].Count < MAX_CSV_ROWS)
                    {
                        _exportData[i].Add((now, realValues[i]));
                    }
                    else if (_exportData[i].Count == MAX_CSV_ROWS)
                    {
                        MessageBox.Show($"Dữ liệu Sensor {i + 1} đã đạt giới hạn an toàn {MAX_CSV_ROWS} dòng.\nPhần mềm sẽ ngừng lưu thêm dữ liệu để tránh treo máy. Vui lòng xuất CSV ngay!",
                            "Cảnh báo bộ nhớ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        _exportData[i].Add((now, double.NaN)); // Đánh dấu điểm tràn
                    }
                }
            }
        }

        // ── Logic Pause/Continue ──────────────────────────────────────────────
        private void TogglePause(int i)
        {
            _isPaused[i] = !_isPaused[i];

            if (_isPaused[i])
            {
                _btnPc[i].ForeColor = Color.DarkGreen;
                _btnPc[i].ImageIndex = 1; // Play icon
                double elapsedSec = (DateTime.Now - _startTime).TotalSeconds;
                _loggers[i].Add(elapsedSec, double.NaN);
            }
            else
            {
                _btnPc[i].ForeColor = Color.DarkRed;
                _btnPc[i].ImageIndex = 0; // Pause icon
            }
        }

        private void ToggleAllPause()
        {
            // Kiểm tra xem đa số đang chạy hay đang dừng để quyết định hành động chung
            bool anyRunning = !_isPaused[0] || !_isPaused[1] || !_isPaused[2];

            for (int i = 0; i < 3; i++)
            {
                if (anyRunning && !_isPaused[i])
                {
                    double elapsedSec = (DateTime.Now - _startTime).TotalSeconds;
                    _loggers[i].Add(elapsedSec, double.NaN);
                    TogglePause(i); // Nếu có cái đang chạy -> Dừng tất cả
                    btn_all_pc.Text = "Tiếp tục";
                }
                else if (!anyRunning && _isPaused[i])
                {
                    TogglePause(i); // Nếu tất cả đang dừng -> Chạy tất cả
                    btn_all_pc.Text = "Dừng lại";
                }
            }
        }

        // ── Logic Xuất CSV ────────────────────────────────────────────────────
        private void ExportCsv(int i)
        {
            if (_exportData[i].Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = $"Data_{_sensorNames[i].Replace(" ", "_")}_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Timestamp,Value");

                foreach (var data in _exportData[i])
                {
                    sb.AppendLine($"{data.Time:yyyy-MM-dd HH:mm:ss.fff},{data.Value}");
                }

                File.WriteAllText(sfd.FileName, sb.ToString());
                MessageBox.Show($"Xuất CSV Sensor {i + 1} thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportAllCsv()
        {
            // Kiểm tra xem có bất kỳ dữ liệu nào để xuất không
            if (_exportData[0].Count == 0 && _exportData[1].Count == 0 && _exportData[2].Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu nào để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = $"All_Sensors_Data_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();

                    // 1. Tạo Header (Tiêu đề 4 cột)
                    sb.AppendLine("Timestamp,Thermistor (degC),Potentiometer (deg),Encoder (RPM)");

                    // 2. Gom tất cả các mốc thời gian (Timestamp) của cả 3 sensor lại, 
                    // loại bỏ các mốc trùng lặp và sắp xếp theo thứ tự thời gian tăng dần.
                    var allTimestamps = _exportData[0].Select(d => d.Time)
                        .Union(_exportData[1].Select(d => d.Time))
                        .Union(_exportData[2].Select(d => d.Time))
                        .Distinct()
                        .OrderBy(t => t)
                        .ToList();

                    // 3. Chuyển List thành Dictionary để tra cứu tốc độ cao O(1)
                    // Tránh việc dùng vòng lặp lồng nhau gây đơ máy nếu data quá lớn
                    var dictS1 = _exportData[0].ToDictionary(d => d.Time, d => d.Value);
                    var dictS2 = _exportData[1].ToDictionary(d => d.Time, d => d.Value);
                    var dictS3 = _exportData[2].ToDictionary(d => d.Time, d => d.Value);

                    // 4. Duyệt qua trục thời gian chuẩn để ghi dữ liệu
                    foreach (var time in allTimestamps)
                    {
                        string tStr = time.ToString("yyyy-MM-dd HH:mm:ss.fff");

                        // Nếu tại thời điểm đó sensor đang bị Pause, hàm TryGetValue sẽ trả về false
                        // và ta sẽ in ra chuỗi rỗng (không ghi data ảo vào)
                        string v1 = dictS1.TryGetValue(time, out double val1) ? val1.ToString() : "";
                        string v2 = dictS2.TryGetValue(time, out double val2) ? val2.ToString() : "";
                        string v3 = dictS3.TryGetValue(time, out double val3) ? val3.ToString() : "";

                        sb.AppendLine($"{tStr},{v1},{v2},{v3}");
                    }

                    // 5. Ghi xuống file
                    File.WriteAllText(sfd.FileName, sb.ToString());
                    MessageBox.Show("Xuất gộp dữ liệu 3 Sensor thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi xuất file:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ── Logic Datasheet ───────────────────────────────────────────────────
        private void ShowDatasheetLogic(int i)
        {
            // Gợi ý: Bạn có thể thêm 1 đường line hằng số (threshold) lên đồ thị
            // _plots[i].Plot.Add.HorizontalLine(y: 100, color: Colors.Red);
            // _plots[i].Refresh();

            MessageBox.Show($"Tính năng so sánh với Datasheet cho Sensor {i + 1} đang phát triển.\n(Gợi ý: Có thể vẽ 1 đường threshold cảnh báo lên đồ thị).",
                            "Datasheet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}