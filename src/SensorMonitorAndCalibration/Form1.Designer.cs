namespace SensorMonitorAndCalibration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSensor1 = new Panel();
            panelSensor2 = new Panel();
            panelSensor3 = new Panel();
            panelSensor4 = new Panel();
            tabControlMain = new TabControl();
            tabMonitor = new TabPage();
            statusBar = new Panel();
            tabCalib = new TabPage();
            tableLayoutMain = new TableLayoutPanel();
            pnlLeft = new Panel();
            btnCalc = new Button();
            grpSpan = new GroupBox();
            btnCaptureSpan = new Button();
            txtAdcSpan = new TextBox();
            lblAdcSpan = new Label();
            lblUnitSpan = new Label();
            txtRealSpan = new TextBox();
            lblRealSpan = new Label();
            grpZero = new GroupBox();
            btnCaptureZero = new Button();
            txtAdcZero = new TextBox();
            lblAdcZero = new Label();
            lblUnitZero = new Label();
            txtRealZero = new TextBox();
            lblRealZero = new Label();
            pnlLive = new Panel();
            lblLiveRealTitle = new Label();
            lblLiveAdcTitle = new Label();
            lblLiveTitle = new Label();
            pnlRight = new Panel();
            button1 = new Button();
            formsPlotCalib = new ScottPlot.WinForms.FormsPlot();
            pnlResult = new Panel();
            lblCoefB = new Label();
            lblStatus = new Label();
            lblCoefA = new Label();
            lblFormula = new Label();
            pnlSensorBar = new Panel();
            btnSensor3 = new Button();
            btnSensor2 = new Button();
            btnSensor1 = new Button();
            lblSelectSensor = new Label();
            tabChart = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            flowLayoutPanel3 = new FlowLayoutPanel();
            btn_pc_2 = new Button();
            btn_dts_2 = new Button();
            btn_csv_2 = new Button();
            panel4 = new Panel();
            formsPlot3 = new ScottPlot.WinForms.FormsPlot();
            flowLayoutPanel4 = new FlowLayoutPanel();
            btn_pc_3 = new Button();
            btn_dts_3 = new Button();
            btn_csv_3 = new Button();
            panel5 = new Panel();
            formsPlot4 = new ScottPlot.WinForms.FormsPlot();
            flowLayoutPanel5 = new FlowLayoutPanel();
            btn_pc_4 = new Button();
            btn_dts_4 = new Button();
            btn_csv_4 = new Button();
            panel1 = new Panel();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn_pc_1 = new Button();
            btn_dts_1 = new Button();
            btn_csv_1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_chose_1 = new Button();
            btn_chose_2 = new Button();
            btn_chose_3 = new Button();
            btn_chose_4 = new Button();
            tabControlMain.SuspendLayout();
            tabMonitor.SuspendLayout();
            tabCalib.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            pnlLeft.SuspendLayout();
            grpSpan.SuspendLayout();
            grpZero.SuspendLayout();
            pnlLive.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlResult.SuspendLayout();
            pnlSensorBar.SuspendLayout();
            tabChart.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panel4.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            panel5.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSensor1
            // 
            panelSensor1.BackColor = Color.WhiteSmoke;
            panelSensor1.BorderStyle = BorderStyle.FixedSingle;
            panelSensor1.Location = new Point(17, 22);
            panelSensor1.Name = "panelSensor1";
            panelSensor1.Size = new Size(390, 180);
            panelSensor1.TabIndex = 0;
            // 
            // panelSensor2
            // 
            panelSensor2.BackColor = Color.WhiteSmoke;
            panelSensor2.BorderStyle = BorderStyle.FixedSingle;
            panelSensor2.Location = new Point(427, 22);
            panelSensor2.Name = "panelSensor2";
            panelSensor2.Size = new Size(390, 180);
            panelSensor2.TabIndex = 1;
            // 
            // panelSensor3
            // 
            panelSensor3.BackColor = Color.WhiteSmoke;
            panelSensor3.BorderStyle = BorderStyle.FixedSingle;
            panelSensor3.Location = new Point(17, 222);
            panelSensor3.Name = "panelSensor3";
            panelSensor3.Size = new Size(390, 180);
            panelSensor3.TabIndex = 2;
            // 
            // panelSensor4
            // 
            panelSensor4.BackColor = Color.WhiteSmoke;
            panelSensor4.BorderStyle = BorderStyle.FixedSingle;
            panelSensor4.Location = new Point(427, 222);
            panelSensor4.Name = "panelSensor4";
            panelSensor4.Size = new Size(390, 180);
            panelSensor4.TabIndex = 3;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabMonitor);
            tabControlMain.Controls.Add(tabCalib);
            tabControlMain.Controls.Add(tabChart);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(842, 513);
            tabControlMain.TabIndex = 5;
            // 
            // tabMonitor
            // 
            tabMonitor.BackColor = Color.AliceBlue;
            tabMonitor.Controls.Add(statusBar);
            tabMonitor.Controls.Add(panelSensor1);
            tabMonitor.Controls.Add(panelSensor2);
            tabMonitor.Controls.Add(panelSensor3);
            tabMonitor.Controls.Add(panelSensor4);
            tabMonitor.Location = new Point(4, 29);
            tabMonitor.Name = "tabMonitor";
            tabMonitor.Padding = new Padding(3);
            tabMonitor.Size = new Size(834, 480);
            tabMonitor.TabIndex = 0;
            tabMonitor.Text = "Monitor";
            // 
            // statusBar
            // 
            statusBar.AutoScroll = true;
            statusBar.BackColor = Color.WhiteSmoke;
            statusBar.BorderStyle = BorderStyle.FixedSingle;
            statusBar.Dock = DockStyle.Bottom;
            statusBar.Location = new Point(3, 422);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(828, 55);
            statusBar.TabIndex = 4;
            // 
            // tabCalib
            // 
            tabCalib.Controls.Add(tableLayoutMain);
            tabCalib.Controls.Add(pnlSensorBar);
            tabCalib.Location = new Point(4, 29);
            tabCalib.Name = "tabCalib";
            tabCalib.Padding = new Padding(3);
            tabCalib.Size = new Size(834, 480);
            tabCalib.TabIndex = 1;
            tabCalib.Text = "Calib";
            tabCalib.UseVisualStyleBackColor = true;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutMain.Controls.Add(pnlLeft, 0, 0);
            tableLayoutMain.Controls.Add(pnlRight, 1, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(3, 49);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 1;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutMain.Size = new Size(828, 428);
            tableLayoutMain.TabIndex = 1;
            tableLayoutMain.Paint += tableLayoutMain_Paint;
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(btnCalc);
            pnlLeft.Controls.Add(grpSpan);
            pnlLeft.Controls.Add(grpZero);
            pnlLeft.Controls.Add(pnlLive);
            pnlLeft.Controls.Add(lblLiveTitle);
            pnlLeft.Dock = DockStyle.Fill;
            pnlLeft.Location = new Point(3, 3);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(20, 16, 12, 16);
            pnlLeft.Size = new Size(408, 422);
            pnlLeft.TabIndex = 0;
            // 
            // btnCalc
            // 
            btnCalc.BackColor = SystemColors.ActiveCaption;
            btnCalc.Cursor = Cursors.Hand;
            btnCalc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCalc.ForeColor = Color.White;
            btnCalc.Location = new Point(19, 364);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(370, 38);
            btnCalc.TabIndex = 4;
            btnCalc.Text = "Tính hệ số và Cập nhật đồ thị";
            btnCalc.UseVisualStyleBackColor = false;
            // 
            // grpSpan
            // 
            grpSpan.Controls.Add(btnCaptureSpan);
            grpSpan.Controls.Add(txtAdcSpan);
            grpSpan.Controls.Add(lblAdcSpan);
            grpSpan.Controls.Add(lblUnitSpan);
            grpSpan.Controls.Add(txtRealSpan);
            grpSpan.Controls.Add(lblRealSpan);
            grpSpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSpan.ForeColor = Color.FromArgb(64, 64, 64);
            grpSpan.Location = new Point(19, 242);
            grpSpan.Name = "grpSpan";
            grpSpan.Size = new Size(370, 110);
            grpSpan.TabIndex = 3;
            grpSpan.TabStop = false;
            grpSpan.Text = "Điểm Span  (tải chuẩn / điểm cao nhất)";
            // 
            // btnCaptureSpan
            // 
            btnCaptureSpan.Cursor = Cursors.Hand;
            btnCaptureSpan.Location = new Point(246, 67);
            btnCaptureSpan.Name = "btnCaptureSpan";
            btnCaptureSpan.Size = new Size(110, 26);
            btnCaptureSpan.TabIndex = 5;
            btnCaptureSpan.Text = "⬅ Lấy giá trị";
            btnCaptureSpan.UseVisualStyleBackColor = true;
            // 
            // txtAdcSpan
            // 
            txtAdcSpan.Location = new Point(156, 67);
            txtAdcSpan.Name = "txtAdcSpan";
            txtAdcSpan.ReadOnly = true;
            txtAdcSpan.Size = new Size(80, 27);
            txtAdcSpan.TabIndex = 4;
            txtAdcSpan.Text = "0.00";
            // 
            // lblAdcSpan
            // 
            lblAdcSpan.AutoSize = true;
            lblAdcSpan.Location = new Point(12, 70);
            lblAdcSpan.Name = "lblAdcSpan";
            lblAdcSpan.Size = new Size(138, 20);
            lblAdcSpan.TabIndex = 3;
            lblAdcSpan.Text = "ADC đọc được (V):";
            // 
            // lblUnitSpan
            // 
            lblUnitSpan.AutoSize = true;
            lblUnitSpan.Location = new Point(216, 36);
            lblUnitSpan.Name = "lblUnitSpan";
            lblUnitSpan.Size = new Size(24, 20);
            lblUnitSpan.TabIndex = 2;
            lblUnitSpan.Text = "°C";
            // 
            // txtRealSpan
            // 
            txtRealSpan.Cursor = Cursors.IBeam;
            txtRealSpan.Location = new Point(130, 33);
            txtRealSpan.Name = "txtRealSpan";
            txtRealSpan.Size = new Size(80, 27);
            txtRealSpan.TabIndex = 1;
            txtRealSpan.Text = "0";
            // 
            // lblRealSpan
            // 
            lblRealSpan.AutoSize = true;
            lblRealSpan.Location = new Point(12, 36);
            lblRealSpan.Name = "lblRealSpan";
            lblRealSpan.Size = new Size(110, 20);
            lblRealSpan.TabIndex = 0;
            lblRealSpan.Text = "Giá trị thực tế:";
            // 
            // grpZero
            // 
            grpZero.Controls.Add(btnCaptureZero);
            grpZero.Controls.Add(txtAdcZero);
            grpZero.Controls.Add(lblAdcZero);
            grpZero.Controls.Add(lblUnitZero);
            grpZero.Controls.Add(txtRealZero);
            grpZero.Controls.Add(lblRealZero);
            grpZero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpZero.ForeColor = Color.FromArgb(64, 64, 64);
            grpZero.Location = new Point(19, 120);
            grpZero.Name = "grpZero";
            grpZero.Size = new Size(370, 110);
            grpZero.TabIndex = 2;
            grpZero.TabStop = false;
            grpZero.Text = "Điểm Zero  (không tải / điểm thấp nhất)";
            // 
            // btnCaptureZero
            // 
            btnCaptureZero.Cursor = Cursors.Hand;
            btnCaptureZero.Location = new Point(246, 67);
            btnCaptureZero.Name = "btnCaptureZero";
            btnCaptureZero.Size = new Size(110, 26);
            btnCaptureZero.TabIndex = 5;
            btnCaptureZero.Text = "⬅ Lấy giá trị";
            btnCaptureZero.UseVisualStyleBackColor = true;
            // 
            // txtAdcZero
            // 
            txtAdcZero.Location = new Point(156, 67);
            txtAdcZero.Name = "txtAdcZero";
            txtAdcZero.ReadOnly = true;
            txtAdcZero.Size = new Size(80, 27);
            txtAdcZero.TabIndex = 4;
            txtAdcZero.Text = "0.00";
            // 
            // lblAdcZero
            // 
            lblAdcZero.AutoSize = true;
            lblAdcZero.Location = new Point(12, 70);
            lblAdcZero.Name = "lblAdcZero";
            lblAdcZero.Size = new Size(138, 20);
            lblAdcZero.TabIndex = 3;
            lblAdcZero.Text = "ADC đọc được (V):";
            // 
            // lblUnitZero
            // 
            lblUnitZero.AutoSize = true;
            lblUnitZero.Location = new Point(216, 36);
            lblUnitZero.Name = "lblUnitZero";
            lblUnitZero.Size = new Size(24, 20);
            lblUnitZero.TabIndex = 2;
            lblUnitZero.Text = "°C";
            // 
            // txtRealZero
            // 
            txtRealZero.Cursor = Cursors.IBeam;
            txtRealZero.Location = new Point(130, 33);
            txtRealZero.Name = "txtRealZero";
            txtRealZero.Size = new Size(80, 27);
            txtRealZero.TabIndex = 1;
            txtRealZero.Text = "0";
            // 
            // lblRealZero
            // 
            lblRealZero.AutoSize = true;
            lblRealZero.Location = new Point(12, 36);
            lblRealZero.Name = "lblRealZero";
            lblRealZero.Size = new Size(110, 20);
            lblRealZero.TabIndex = 0;
            lblRealZero.Text = "Giá trị thực tế:";
            // 
            // pnlLive
            // 
            pnlLive.BackColor = Color.AliceBlue;
            pnlLive.BorderStyle = BorderStyle.FixedSingle;
            pnlLive.Controls.Add(lblLiveRealTitle);
            pnlLive.Controls.Add(lblLiveAdcTitle);
            pnlLive.Location = new Point(19, 36);
            pnlLive.Name = "pnlLive";
            pnlLive.Size = new Size(370, 64);
            pnlLive.TabIndex = 1;
            // 
            // lblLiveRealTitle
            // 
            lblLiveRealTitle.AutoSize = true;
            lblLiveRealTitle.Location = new Point(200, 8);
            lblLiveRealTitle.Name = "lblLiveRealTitle";
            lblLiveRealTitle.Size = new Size(153, 20);
            lblLiveRealTitle.TabIndex = 1;
            lblLiveRealTitle.Text = "Giá trị thực (ước tính):";
            // 
            // lblLiveAdcTitle
            // 
            lblLiveAdcTitle.AutoSize = true;
            lblLiveAdcTitle.Location = new Point(12, 8);
            lblLiveAdcTitle.Name = "lblLiveAdcTitle";
            lblLiveAdcTitle.Size = new Size(98, 20);
            lblLiveAdcTitle.TabIndex = 0;
            lblLiveAdcTitle.Text = "Điện áp ADC:";
            // 
            // lblLiveTitle
            // 
            lblLiveTitle.AutoSize = true;
            lblLiveTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLiveTitle.Location = new Point(19, 10);
            lblLiveTitle.Name = "lblLiveTitle";
            lblLiveTitle.Size = new Size(168, 20);
            lblLiveTitle.TabIndex = 0;
            lblLiveTitle.Text = "GIÁ TRỊ ADC HIỆN TẠI";
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(button1);
            pnlRight.Controls.Add(formsPlotCalib);
            pnlRight.Controls.Add(pnlResult);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(417, 3);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(16, 16, 20, 16);
            pnlRight.Size = new Size(408, 422);
            pnlRight.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 364);
            button1.Name = "button1";
            button1.Size = new Size(370, 38);
            button1.TabIndex = 5;
            button1.Text = "Gửi hệ số a, b về MCU";
            button1.UseVisualStyleBackColor = false;
            // 
            // formsPlotCalib
            // 
            formsPlotCalib.Location = new Point(14, 169);
            formsPlotCalib.Name = "formsPlotCalib";
            formsPlotCalib.Size = new Size(379, 180);
            formsPlotCalib.TabIndex = 1;
            // 
            // pnlResult
            // 
            pnlResult.BorderStyle = BorderStyle.FixedSingle;
            pnlResult.Controls.Add(lblCoefB);
            pnlResult.Controls.Add(lblStatus);
            pnlResult.Controls.Add(lblCoefA);
            pnlResult.Controls.Add(lblFormula);
            pnlResult.Location = new Point(14, 22);
            pnlResult.Name = "pnlResult";
            pnlResult.Size = new Size(379, 129);
            pnlResult.TabIndex = 0;
            // 
            // lblCoefB
            // 
            lblCoefB.AutoSize = true;
            lblCoefB.Location = new Point(163, 57);
            lblCoefB.Name = "lblCoefB";
            lblCoefB.Size = new Size(82, 20);
            lblCoefB.TabIndex = 3;
            lblCoefB.Text = "Hệ số b: —";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = SystemColors.ControlDark;
            lblStatus.Location = new Point(15, 95);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(72, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Chưa tính";
            // 
            // lblCoefA
            // 
            lblCoefA.AutoSize = true;
            lblCoefA.Location = new Point(15, 57);
            lblCoefA.Name = "lblCoefA";
            lblCoefA.Size = new Size(81, 20);
            lblCoefA.TabIndex = 1;
            lblCoefA.Text = "Hệ số a: —";
            // 
            // lblFormula
            // 
            lblFormula.AutoSize = true;
            lblFormula.ForeColor = Color.MidnightBlue;
            lblFormula.Location = new Point(15, 17);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new Size(149, 20);
            lblFormula.TabIndex = 0;
            lblFormula.Text = "Chưa có dữ liệu calib";
            // 
            // pnlSensorBar
            // 
            pnlSensorBar.BackColor = Color.AliceBlue;
            pnlSensorBar.Controls.Add(btnSensor3);
            pnlSensorBar.Controls.Add(btnSensor2);
            pnlSensorBar.Controls.Add(btnSensor1);
            pnlSensorBar.Controls.Add(lblSelectSensor);
            pnlSensorBar.Dock = DockStyle.Top;
            pnlSensorBar.Location = new Point(3, 3);
            pnlSensorBar.Name = "pnlSensorBar";
            pnlSensorBar.Size = new Size(828, 46);
            pnlSensorBar.TabIndex = 0;
            // 
            // btnSensor3
            // 
            btnSensor3.Cursor = Cursors.Hand;
            btnSensor3.FlatStyle = FlatStyle.Flat;
            btnSensor3.ForeColor = Color.MidnightBlue;
            btnSensor3.Location = new Point(599, 9);
            btnSensor3.Name = "btnSensor3";
            btnSensor3.Size = new Size(190, 28);
            btnSensor3.TabIndex = 3;
            btnSensor3.Text = "Sensor 3 - Encoder";
            btnSensor3.UseVisualStyleBackColor = true;
            // 
            // btnSensor2
            // 
            btnSensor2.Cursor = Cursors.Hand;
            btnSensor2.FlatStyle = FlatStyle.Flat;
            btnSensor2.ForeColor = Color.MidnightBlue;
            btnSensor2.Location = new Point(367, 9);
            btnSensor2.Name = "btnSensor2";
            btnSensor2.Size = new Size(190, 28);
            btnSensor2.TabIndex = 2;
            btnSensor2.Text = "Sensor 2 - Potentiometer";
            btnSensor2.UseVisualStyleBackColor = true;
            // 
            // btnSensor1
            // 
            btnSensor1.Cursor = Cursors.Hand;
            btnSensor1.FlatStyle = FlatStyle.Flat;
            btnSensor1.ForeColor = Color.MidnightBlue;
            btnSensor1.Location = new Point(134, 9);
            btnSensor1.Name = "btnSensor1";
            btnSensor1.Size = new Size(190, 28);
            btnSensor1.TabIndex = 1;
            btnSensor1.Text = "Sensor 1 - Thermistor";
            btnSensor1.UseVisualStyleBackColor = true;
            btnSensor1.Click += button1_Click;
            // 
            // lblSelectSensor
            // 
            lblSelectSensor.AutoSize = true;
            lblSelectSensor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSelectSensor.Location = new Point(14, 14);
            lblSelectSensor.Name = "lblSelectSensor";
            lblSelectSensor.Size = new Size(100, 20);
            lblSelectSensor.TabIndex = 0;
            lblSelectSensor.Text = "Chọn sensor:";
            // 
            // tabChart
            // 
            tabChart.Controls.Add(tableLayoutPanel1);
            tabChart.Controls.Add(flowLayoutPanel1);
            tabChart.Location = new Point(4, 29);
            tabChart.Name = "tabChart";
            tabChart.Padding = new Padding(3);
            tabChart.Size = new Size(834, 480);
            tabChart.TabIndex = 2;
            tabChart.Text = "Chart";
            tabChart.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 1);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 38);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(828, 439);
            tableLayoutPanel1.TabIndex = 5;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(formsPlot2);
            panel3.Controls.Add(flowLayoutPanel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(417, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(403, 208);
            panel3.TabIndex = 5;
            // 
            // formsPlot2
            // 
            formsPlot2.Dock = DockStyle.Fill;
            formsPlot2.Location = new Point(0, 0);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(403, 173);
            formsPlot2.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(btn_pc_2);
            flowLayoutPanel3.Controls.Add(btn_dts_2);
            flowLayoutPanel3.Controls.Add(btn_csv_2);
            flowLayoutPanel3.Dock = DockStyle.Bottom;
            flowLayoutPanel3.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel3.Location = new Point(0, 173);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(403, 35);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // btn_pc_2
            // 
            btn_pc_2.Location = new Point(306, 3);
            btn_pc_2.Name = "btn_pc_2";
            btn_pc_2.Size = new Size(94, 29);
            btn_pc_2.TabIndex = 0;
            btn_pc_2.Text = "button8";
            btn_pc_2.UseVisualStyleBackColor = true;
            // 
            // btn_dts_2
            // 
            btn_dts_2.Location = new Point(206, 3);
            btn_dts_2.Name = "btn_dts_2";
            btn_dts_2.Size = new Size(94, 29);
            btn_dts_2.TabIndex = 1;
            btn_dts_2.Text = "button9";
            btn_dts_2.UseVisualStyleBackColor = true;
            // 
            // btn_csv_2
            // 
            btn_csv_2.Location = new Point(106, 3);
            btn_csv_2.Name = "btn_csv_2";
            btn_csv_2.Size = new Size(94, 29);
            btn_csv_2.TabIndex = 2;
            btn_csv_2.Text = "button10";
            btn_csv_2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(formsPlot3);
            panel4.Controls.Add(flowLayoutPanel4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(8, 222);
            panel4.Name = "panel4";
            panel4.Size = new Size(403, 209);
            panel4.TabIndex = 6;
            // 
            // formsPlot3
            // 
            formsPlot3.Dock = DockStyle.Fill;
            formsPlot3.Location = new Point(0, 0);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new Size(403, 174);
            formsPlot3.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(btn_pc_3);
            flowLayoutPanel4.Controls.Add(btn_dts_3);
            flowLayoutPanel4.Controls.Add(btn_csv_3);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel4.Location = new Point(0, 174);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(403, 35);
            flowLayoutPanel4.TabIndex = 3;
            // 
            // btn_pc_3
            // 
            btn_pc_3.Location = new Point(306, 3);
            btn_pc_3.Name = "btn_pc_3";
            btn_pc_3.Size = new Size(94, 29);
            btn_pc_3.TabIndex = 0;
            btn_pc_3.Text = "button11";
            btn_pc_3.UseVisualStyleBackColor = true;
            // 
            // btn_dts_3
            // 
            btn_dts_3.Location = new Point(206, 3);
            btn_dts_3.Name = "btn_dts_3";
            btn_dts_3.Size = new Size(94, 29);
            btn_dts_3.TabIndex = 1;
            btn_dts_3.Text = "button12";
            btn_dts_3.UseVisualStyleBackColor = true;
            // 
            // btn_csv_3
            // 
            btn_csv_3.Location = new Point(106, 3);
            btn_csv_3.Name = "btn_csv_3";
            btn_csv_3.Size = new Size(94, 29);
            btn_csv_3.TabIndex = 2;
            btn_csv_3.Text = "button13";
            btn_csv_3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(formsPlot4);
            panel5.Controls.Add(flowLayoutPanel5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(417, 222);
            panel5.Name = "panel5";
            panel5.Size = new Size(403, 209);
            panel5.TabIndex = 7;
            // 
            // formsPlot4
            // 
            formsPlot4.Dock = DockStyle.Fill;
            formsPlot4.Location = new Point(0, 0);
            formsPlot4.Name = "formsPlot4";
            formsPlot4.Size = new Size(403, 174);
            formsPlot4.TabIndex = 4;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(btn_pc_4);
            flowLayoutPanel5.Controls.Add(btn_dts_4);
            flowLayoutPanel5.Controls.Add(btn_csv_4);
            flowLayoutPanel5.Dock = DockStyle.Bottom;
            flowLayoutPanel5.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel5.Location = new Point(0, 174);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(403, 35);
            flowLayoutPanel5.TabIndex = 3;
            // 
            // btn_pc_4
            // 
            btn_pc_4.Location = new Point(306, 3);
            btn_pc_4.Name = "btn_pc_4";
            btn_pc_4.Size = new Size(94, 29);
            btn_pc_4.TabIndex = 0;
            btn_pc_4.Text = "button14";
            btn_pc_4.UseVisualStyleBackColor = true;
            // 
            // btn_dts_4
            // 
            btn_dts_4.Location = new Point(206, 3);
            btn_dts_4.Name = "btn_dts_4";
            btn_dts_4.Size = new Size(94, 29);
            btn_dts_4.TabIndex = 1;
            btn_dts_4.Text = "button15";
            btn_dts_4.UseVisualStyleBackColor = true;
            // 
            // btn_csv_4
            // 
            btn_csv_4.Location = new Point(106, 3);
            btn_csv_4.Name = "btn_csv_4";
            btn_csv_4.Size = new Size(94, 29);
            btn_csv_4.TabIndex = 2;
            btn_csv_4.Text = "button16";
            btn_csv_4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(formsPlot1);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 208);
            panel1.TabIndex = 8;
            // 
            // formsPlot1
            // 
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(0, 0);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(403, 173);
            formsPlot1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(btn_pc_1);
            flowLayoutPanel2.Controls.Add(btn_dts_1);
            flowLayoutPanel2.Controls.Add(btn_csv_1);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(0, 173);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(403, 35);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // btn_pc_1
            // 
            btn_pc_1.Location = new Point(306, 3);
            btn_pc_1.Name = "btn_pc_1";
            btn_pc_1.Size = new Size(94, 29);
            btn_pc_1.TabIndex = 0;
            btn_pc_1.Text = "button5";
            btn_pc_1.UseVisualStyleBackColor = true;
            // 
            // btn_dts_1
            // 
            btn_dts_1.Location = new Point(206, 3);
            btn_dts_1.Name = "btn_dts_1";
            btn_dts_1.Size = new Size(94, 29);
            btn_dts_1.TabIndex = 1;
            btn_dts_1.Text = "button6";
            btn_dts_1.UseVisualStyleBackColor = true;
            // 
            // btn_csv_1
            // 
            btn_csv_1.Location = new Point(106, 3);
            btn_csv_1.Name = "btn_csv_1";
            btn_csv_1.Size = new Size(94, 29);
            btn_csv_1.TabIndex = 2;
            btn_csv_1.Text = "button7";
            btn_csv_1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(btn_chose_1);
            flowLayoutPanel1.Controls.Add(btn_chose_2);
            flowLayoutPanel1.Controls.Add(btn_chose_3);
            flowLayoutPanel1.Controls.Add(btn_chose_4);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(828, 35);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btn_chose_1
            // 
            btn_chose_1.Location = new Point(3, 3);
            btn_chose_1.Name = "btn_chose_1";
            btn_chose_1.Size = new Size(94, 29);
            btn_chose_1.TabIndex = 0;
            btn_chose_1.Text = "button1";
            btn_chose_1.UseVisualStyleBackColor = true;
            // 
            // btn_chose_2
            // 
            btn_chose_2.Location = new Point(103, 3);
            btn_chose_2.Name = "btn_chose_2";
            btn_chose_2.Size = new Size(94, 29);
            btn_chose_2.TabIndex = 1;
            btn_chose_2.Text = "button2";
            btn_chose_2.UseVisualStyleBackColor = true;
            // 
            // btn_chose_3
            // 
            btn_chose_3.Location = new Point(203, 3);
            btn_chose_3.Name = "btn_chose_3";
            btn_chose_3.Size = new Size(94, 29);
            btn_chose_3.TabIndex = 2;
            btn_chose_3.Text = "button3";
            btn_chose_3.UseVisualStyleBackColor = true;
            // 
            // btn_chose_4
            // 
            btn_chose_4.Location = new Point(303, 3);
            btn_chose_4.Name = "btn_chose_4";
            btn_chose_4.Size = new Size(94, 29);
            btn_chose_4.TabIndex = 3;
            btn_chose_4.Text = "button4";
            btn_chose_4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(842, 513);
            Controls.Add(tabControlMain);
            Name = "Form1";
            Text = "Sensor Monitor — HPMR Đo lường CN";
            Load += Form1_Load;
            tabControlMain.ResumeLayout(false);
            tabMonitor.ResumeLayout(false);
            tabCalib.ResumeLayout(false);
            tableLayoutMain.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            grpSpan.ResumeLayout(false);
            grpSpan.PerformLayout();
            grpZero.ResumeLayout(false);
            grpZero.PerformLayout();
            pnlLive.ResumeLayout(false);
            pnlLive.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlResult.ResumeLayout(false);
            pnlResult.PerformLayout();
            pnlSensorBar.ResumeLayout(false);
            pnlSensorBar.PerformLayout();
            tabChart.ResumeLayout(false);
            tabChart.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSensor1;
        private Panel panelSensor2;
        private Panel panelSensor3;
        private Panel panelSensor4;
        private TabControl tabControlMain;
        private TabPage tabMonitor;
        private TabPage tabCalib;
        private TabPage tabChart;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_chose_4;
        private Button btn_chose_1;
        private Button btn_chose_2;
        private Button btn_chose_3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel statusBar;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btn_pc_2;
        private Button btn_dts_2;
        private Button btn_csv_2;
        private ScottPlot.WinForms.FormsPlot formsPlot3;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button btn_pc_3;
        private Button btn_dts_3;
        private Button btn_csv_3;
        private ScottPlot.WinForms.FormsPlot formsPlot4;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button btn_pc_4;
        private Button btn_dts_4;
        private Button btn_csv_4;
        private Panel panel1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btn_pc_1;
        private Button btn_dts_1;
        private Button btn_csv_1;
        private Panel pnlSensorBar;
        private Button btnSensor1;
        private Label lblSelectSensor;
        private Button btnSensor2;
        private TableLayoutPanel tableLayoutMain;
        private Button btnSensor3;
        private Panel pnlLeft;
        private Label lblLiveTitle;
        private Panel pnlLive;
        private Label lblLiveRealTitle;
        private Label lblLiveAdcTitle;
        private GroupBox grpZero;
        private Label lblUnitZero;
        private TextBox txtRealZero;
        private Label lblRealZero;
        private Button btnCaptureZero;
        private TextBox txtAdcZero;
        private Label lblAdcZero;
        private GroupBox grpSpan;
        private Button btnCaptureSpan;
        private TextBox txtAdcSpan;
        private Label lblAdcSpan;
        private Label lblUnitSpan;
        private TextBox txtRealSpan;
        private Label lblRealSpan;
        private Button btnCalc;
        private Panel pnlRight;
        private Panel pnlResult;
        private Label lblCoefB;
        private Label lblStatus;
        private Label lblCoefA;
        private Label lblFormula;
        private ScottPlot.WinForms.FormsPlot formsPlotCalib;
        private Button button1;
    }
}
