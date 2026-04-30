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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            imageList1 = new ImageList(components);
            btn_dts_2 = new Button();
            btn_csv_2 = new Button();
            panel7 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            formsPlot3 = new ScottPlot.WinForms.FormsPlot();
            flowLayoutPanel4 = new FlowLayoutPanel();
            btn_pc_3 = new Button();
            btn_dts_3 = new Button();
            btn_csv_3 = new Button();
            panel8 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            gr_data = new GroupBox();
            gr_control = new GroupBox();
            btn_all_pc = new Button();
            btn_all_csv = new Button();
            gr_status = new GroupBox();
            label5 = new Label();
            s_rate = new Label();
            status = new Label();
            panel1 = new Panel();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn_pc_1 = new Button();
            btn_dts_1 = new Button();
            btn_csv_1 = new Button();
            panel6 = new Panel();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            btn_chose_3 = new Button();
            btn_chose_2 = new Button();
            btn_chose_1 = new Button();
            label1 = new Label();
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
            gr_control.SuspendLayout();
            gr_status.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelSensor1
            // 
            panelSensor1.BackColor = Color.WhiteSmoke;
            panelSensor1.BorderStyle = BorderStyle.FixedSingle;
            panelSensor1.Location = new Point(42, 25);
            panelSensor1.Name = "panelSensor1";
            panelSensor1.Size = new Size(511, 200);
            panelSensor1.TabIndex = 0;
            // 
            // panelSensor2
            // 
            panelSensor2.BackColor = Color.WhiteSmoke;
            panelSensor2.BorderStyle = BorderStyle.FixedSingle;
            panelSensor2.Location = new Point(591, 25);
            panelSensor2.Name = "panelSensor2";
            panelSensor2.Size = new Size(511, 200);
            panelSensor2.TabIndex = 1;
            // 
            // panelSensor3
            // 
            panelSensor3.BackColor = Color.WhiteSmoke;
            panelSensor3.BorderStyle = BorderStyle.FixedSingle;
            panelSensor3.Location = new Point(42, 248);
            panelSensor3.Name = "panelSensor3";
            panelSensor3.Size = new Size(511, 200);
            panelSensor3.TabIndex = 2;
            // 
            // panelSensor4
            // 
            panelSensor4.BackColor = Color.WhiteSmoke;
            panelSensor4.BorderStyle = BorderStyle.FixedSingle;
            panelSensor4.Location = new Point(591, 248);
            panelSensor4.Name = "panelSensor4";
            panelSensor4.Size = new Size(511, 200);
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
            tabControlMain.Size = new Size(1139, 590);
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
            tabMonitor.Size = new Size(1131, 557);
            tabMonitor.TabIndex = 0;
            tabMonitor.Text = "Monitor";
            // 
            // statusBar
            // 
            statusBar.AutoScroll = true;
            statusBar.BackColor = Color.WhiteSmoke;
            statusBar.BorderStyle = BorderStyle.FixedSingle;
            statusBar.Dock = DockStyle.Bottom;
            statusBar.Location = new Point(3, 473);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(1125, 81);
            statusBar.TabIndex = 4;
            // 
            // tabCalib
            // 
            tabCalib.Controls.Add(tableLayoutMain);
            tabCalib.Controls.Add(pnlSensorBar);
            tabCalib.Location = new Point(4, 29);
            tabCalib.Name = "tabCalib";
            tabCalib.Padding = new Padding(3);
            tabCalib.Size = new Size(1131, 557);
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
            tableLayoutMain.Size = new Size(1125, 505);
            tableLayoutMain.TabIndex = 1;
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
            pnlLeft.Size = new Size(556, 499);
            pnlLeft.TabIndex = 0;
            // 
            // btnCalc
            // 
            btnCalc.BackColor = SystemColors.ActiveCaption;
            btnCalc.Cursor = Cursors.Hand;
            btnCalc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCalc.ForeColor = Color.White;
            btnCalc.Location = new Point(19, 422);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(503, 38);
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
            grpSpan.Location = new Point(19, 279);
            grpSpan.Name = "grpSpan";
            grpSpan.Size = new Size(503, 110);
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
            grpZero.Location = new Point(19, 142);
            grpZero.Name = "grpZero";
            grpZero.Size = new Size(503, 110);
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
            pnlLive.Location = new Point(19, 52);
            pnlLive.Name = "pnlLive";
            pnlLive.Size = new Size(503, 64);
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
            lblLiveTitle.Location = new Point(19, 16);
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
            pnlRight.Location = new Point(565, 3);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(16, 16, 20, 16);
            pnlRight.Size = new Size(557, 499);
            pnlRight.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 422);
            button1.Name = "button1";
            button1.Size = new Size(515, 38);
            button1.TabIndex = 5;
            button1.Text = "Gửi hệ số a, b về MCU";
            button1.UseVisualStyleBackColor = false;
            // 
            // formsPlotCalib
            // 
            formsPlotCalib.Location = new Point(14, 169);
            formsPlotCalib.Name = "formsPlotCalib";
            formsPlotCalib.Size = new Size(520, 236);
            formsPlotCalib.TabIndex = 1;
            // 
            // pnlResult
            // 
            pnlResult.BorderStyle = BorderStyle.FixedSingle;
            pnlResult.Controls.Add(lblCoefB);
            pnlResult.Controls.Add(lblStatus);
            pnlResult.Controls.Add(lblCoefA);
            pnlResult.Controls.Add(lblFormula);
            pnlResult.Location = new Point(19, 22);
            pnlResult.Name = "pnlResult";
            pnlResult.Size = new Size(515, 129);
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
            pnlSensorBar.Size = new Size(1125, 46);
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
            tabChart.Size = new Size(1131, 557);
            tabChart.TabIndex = 2;
            tabChart.Text = "Chart";
            tabChart.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.AliceBlue;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 1);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1125, 499);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(formsPlot2);
            panel3.Controls.Add(flowLayoutPanel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(566, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(549, 235);
            panel3.TabIndex = 5;
            // 
            // formsPlot2
            // 
            formsPlot2.Dock = DockStyle.Fill;
            formsPlot2.Location = new Point(0, 0);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(549, 198);
            formsPlot2.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Controls.Add(btn_pc_2);
            flowLayoutPanel3.Controls.Add(btn_dts_2);
            flowLayoutPanel3.Controls.Add(btn_csv_2);
            flowLayoutPanel3.Controls.Add(panel7);
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Dock = DockStyle.Bottom;
            flowLayoutPanel3.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel3.Location = new Point(0, 198);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(549, 37);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // btn_pc_2
            // 
            btn_pc_2.BackColor = Color.AliceBlue;
            btn_pc_2.Cursor = Cursors.Hand;
            btn_pc_2.ImageList = imageList1;
            btn_pc_2.Location = new Point(508, 3);
            btn_pc_2.Margin = new Padding(10, 3, 10, 3);
            btn_pc_2.Name = "btn_pc_2";
            btn_pc_2.Size = new Size(29, 29);
            btn_pc_2.TabIndex = 0;
            btn_pc_2.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "pause.png");
            imageList1.Images.SetKeyName(1, "lookup.png");
            imageList1.Images.SetKeyName(2, "save.png");
            imageList1.Images.SetKeyName(3, "cont.png");
            // 
            // btn_dts_2
            // 
            btn_dts_2.BackColor = Color.AliceBlue;
            btn_dts_2.Cursor = Cursors.Hand;
            btn_dts_2.ImageIndex = 1;
            btn_dts_2.ImageList = imageList1;
            btn_dts_2.Location = new Point(459, 3);
            btn_dts_2.Margin = new Padding(10, 3, 10, 3);
            btn_dts_2.Name = "btn_dts_2";
            btn_dts_2.Size = new Size(29, 29);
            btn_dts_2.TabIndex = 1;
            btn_dts_2.UseVisualStyleBackColor = false;
            // 
            // btn_csv_2
            // 
            btn_csv_2.BackColor = Color.AliceBlue;
            btn_csv_2.Cursor = Cursors.Hand;
            btn_csv_2.ImageIndex = 2;
            btn_csv_2.ImageList = imageList1;
            btn_csv_2.Location = new Point(410, 3);
            btn_csv_2.Margin = new Padding(10, 3, 10, 3);
            btn_csv_2.Name = "btn_csv_2";
            btn_csv_2.Size = new Size(29, 29);
            btn_csv_2.TabIndex = 2;
            btn_csv_2.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Location = new Point(131, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(266, 29);
            panel7.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(5, 7);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 4;
            label3.Text = "Potentionmeter";
            // 
            // panel4
            // 
            panel4.Controls.Add(formsPlot3);
            panel4.Controls.Add(flowLayoutPanel4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(10, 253);
            panel4.Name = "panel4";
            panel4.Size = new Size(548, 236);
            panel4.TabIndex = 6;
            // 
            // formsPlot3
            // 
            formsPlot3.Dock = DockStyle.Fill;
            formsPlot3.Location = new Point(0, 0);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new Size(548, 199);
            formsPlot3.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel4.Controls.Add(btn_pc_3);
            flowLayoutPanel4.Controls.Add(btn_dts_3);
            flowLayoutPanel4.Controls.Add(btn_csv_3);
            flowLayoutPanel4.Controls.Add(panel8);
            flowLayoutPanel4.Controls.Add(label4);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel4.Location = new Point(0, 199);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(548, 37);
            flowLayoutPanel4.TabIndex = 3;
            // 
            // btn_pc_3
            // 
            btn_pc_3.BackColor = Color.AliceBlue;
            btn_pc_3.Cursor = Cursors.Hand;
            btn_pc_3.ImageList = imageList1;
            btn_pc_3.Location = new Point(507, 3);
            btn_pc_3.Margin = new Padding(10, 3, 10, 3);
            btn_pc_3.Name = "btn_pc_3";
            btn_pc_3.Size = new Size(29, 29);
            btn_pc_3.TabIndex = 0;
            btn_pc_3.UseVisualStyleBackColor = false;
            // 
            // btn_dts_3
            // 
            btn_dts_3.BackColor = Color.AliceBlue;
            btn_dts_3.Cursor = Cursors.Hand;
            btn_dts_3.ImageIndex = 1;
            btn_dts_3.ImageList = imageList1;
            btn_dts_3.Location = new Point(458, 3);
            btn_dts_3.Margin = new Padding(10, 3, 10, 3);
            btn_dts_3.Name = "btn_dts_3";
            btn_dts_3.Size = new Size(29, 29);
            btn_dts_3.TabIndex = 1;
            btn_dts_3.UseVisualStyleBackColor = false;
            // 
            // btn_csv_3
            // 
            btn_csv_3.BackColor = Color.AliceBlue;
            btn_csv_3.Cursor = Cursors.Hand;
            btn_csv_3.ImageIndex = 2;
            btn_csv_3.ImageList = imageList1;
            btn_csv_3.Location = new Point(409, 3);
            btn_csv_3.Margin = new Padding(10, 3, 10, 3);
            btn_csv_3.Name = "btn_csv_3";
            btn_csv_3.Size = new Size(29, 29);
            btn_csv_3.TabIndex = 2;
            btn_csv_3.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Location = new Point(76, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(320, 29);
            panel8.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(5, 7);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 4;
            label4.Text = "Encoder";
            // 
            // panel5
            // 
            panel5.Controls.Add(gr_data);
            panel5.Controls.Add(gr_control);
            panel5.Controls.Add(gr_status);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(566, 253);
            panel5.Name = "panel5";
            panel5.Size = new Size(549, 236);
            panel5.TabIndex = 7;
            // 
            // gr_data
            // 
            gr_data.BackColor = Color.AliceBlue;
            gr_data.Dock = DockStyle.Fill;
            gr_data.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gr_data.ForeColor = Color.MidnightBlue;
            gr_data.Location = new Point(0, 42);
            gr_data.Margin = new Padding(5);
            gr_data.Name = "gr_data";
            gr_data.Padding = new Padding(5);
            gr_data.Size = new Size(549, 140);
            gr_data.TabIndex = 6;
            gr_data.TabStop = false;
            gr_data.Text = "Phân tích tín hiệu";
            // 
            // gr_control
            // 
            gr_control.BackColor = Color.AliceBlue;
            gr_control.Controls.Add(btn_all_pc);
            gr_control.Controls.Add(btn_all_csv);
            gr_control.Dock = DockStyle.Bottom;
            gr_control.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gr_control.ForeColor = Color.MidnightBlue;
            gr_control.Location = new Point(0, 182);
            gr_control.Margin = new Padding(5);
            gr_control.Name = "gr_control";
            gr_control.Padding = new Padding(5);
            gr_control.Size = new Size(549, 54);
            gr_control.TabIndex = 5;
            gr_control.TabStop = false;
            gr_control.Text = "Áp dụng toàn bộ ";
            // 
            // btn_all_pc
            // 
            btn_all_pc.Cursor = Cursors.Hand;
            btn_all_pc.FlatStyle = FlatStyle.Flat;
            btn_all_pc.ForeColor = Color.MidnightBlue;
            btn_all_pc.Location = new Point(419, 18);
            btn_all_pc.Name = "btn_all_pc";
            btn_all_pc.Size = new Size(78, 28);
            btn_all_pc.TabIndex = 3;
            btn_all_pc.Text = "Tiếp tục";
            btn_all_pc.UseVisualStyleBackColor = true;
            // 
            // btn_all_csv
            // 
            btn_all_csv.Cursor = Cursors.Hand;
            btn_all_csv.FlatStyle = FlatStyle.Flat;
            btn_all_csv.ForeColor = Color.MidnightBlue;
            btn_all_csv.Location = new Point(287, 18);
            btn_all_csv.Name = "btn_all_csv";
            btn_all_csv.Size = new Size(103, 28);
            btn_all_csv.TabIndex = 2;
            btn_all_csv.Text = "Lưu vào csv";
            btn_all_csv.UseVisualStyleBackColor = true;
            // 
            // gr_status
            // 
            gr_status.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gr_status.BackColor = Color.AliceBlue;
            gr_status.Controls.Add(label5);
            gr_status.Controls.Add(s_rate);
            gr_status.Controls.Add(status);
            gr_status.Dock = DockStyle.Top;
            gr_status.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gr_status.ForeColor = Color.MidnightBlue;
            gr_status.Location = new Point(0, 0);
            gr_status.Margin = new Padding(5);
            gr_status.Name = "gr_status";
            gr_status.Padding = new Padding(5);
            gr_status.Size = new Size(549, 42);
            gr_status.TabIndex = 4;
            gr_status.TabStop = false;
            gr_status.Text = "Kết nối tín hiệu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(147, 16);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 2;
            label5.Text = "Trạng thái kết nối:";
            // 
            // s_rate
            // 
            s_rate.AutoSize = true;
            s_rate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            s_rate.Location = new Point(343, 16);
            s_rate.Name = "s_rate";
            s_rate.Size = new Size(118, 20);
            s_rate.TabIndex = 1;
            s_rate.Text = "Tần số lấy mẫu:";
            // 
            // status
            // 
            status.BackColor = Color.Red;
            status.Location = new Point(288, 15);
            status.Name = "status";
            status.Size = new Size(20, 20);
            status.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(formsPlot1);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 235);
            panel1.TabIndex = 8;
            // 
            // formsPlot1
            // 
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(0, 0);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(548, 198);
            formsPlot1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(btn_pc_1);
            flowLayoutPanel2.Controls.Add(btn_dts_1);
            flowLayoutPanel2.Controls.Add(btn_csv_1);
            flowLayoutPanel2.Controls.Add(panel6);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(0, 198);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(548, 37);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // btn_pc_1
            // 
            btn_pc_1.BackColor = Color.AliceBlue;
            btn_pc_1.Cursor = Cursors.Hand;
            btn_pc_1.ImageList = imageList1;
            btn_pc_1.Location = new Point(507, 3);
            btn_pc_1.Margin = new Padding(10, 3, 10, 3);
            btn_pc_1.Name = "btn_pc_1";
            btn_pc_1.Size = new Size(29, 29);
            btn_pc_1.TabIndex = 0;
            btn_pc_1.UseVisualStyleBackColor = false;
            // 
            // btn_dts_1
            // 
            btn_dts_1.BackColor = Color.AliceBlue;
            btn_dts_1.Cursor = Cursors.Hand;
            btn_dts_1.ImageIndex = 1;
            btn_dts_1.ImageList = imageList1;
            btn_dts_1.Location = new Point(458, 3);
            btn_dts_1.Margin = new Padding(10, 3, 10, 3);
            btn_dts_1.Name = "btn_dts_1";
            btn_dts_1.Size = new Size(29, 29);
            btn_dts_1.TabIndex = 1;
            btn_dts_1.UseVisualStyleBackColor = false;
            // 
            // btn_csv_1
            // 
            btn_csv_1.BackColor = Color.AliceBlue;
            btn_csv_1.Cursor = Cursors.Hand;
            btn_csv_1.ImageIndex = 2;
            btn_csv_1.ImageList = imageList1;
            btn_csv_1.Location = new Point(409, 3);
            btn_csv_1.Margin = new Padding(10, 3, 10, 3);
            btn_csv_1.Name = "btn_csv_1";
            btn_csv_1.Size = new Size(29, 29);
            btn_csv_1.TabIndex = 2;
            btn_csv_1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Location = new Point(101, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(295, 29);
            panel6.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(8, 7);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 3;
            label2.Text = "Thermistor";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1125, 52);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_chose_3);
            panel2.Controls.Add(btn_chose_2);
            panel2.Controls.Add(btn_chose_1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1120, 46);
            panel2.TabIndex = 4;
            // 
            // btn_chose_3
            // 
            btn_chose_3.Cursor = Cursors.Hand;
            btn_chose_3.FlatStyle = FlatStyle.Flat;
            btn_chose_3.ForeColor = Color.MidnightBlue;
            btn_chose_3.Location = new Point(599, 9);
            btn_chose_3.Name = "btn_chose_3";
            btn_chose_3.Size = new Size(190, 28);
            btn_chose_3.TabIndex = 3;
            btn_chose_3.Text = "Sensor 3 - Encoder";
            btn_chose_3.UseVisualStyleBackColor = true;
            // 
            // btn_chose_2
            // 
            btn_chose_2.Cursor = Cursors.Hand;
            btn_chose_2.FlatStyle = FlatStyle.Flat;
            btn_chose_2.ForeColor = Color.MidnightBlue;
            btn_chose_2.Location = new Point(367, 9);
            btn_chose_2.Name = "btn_chose_2";
            btn_chose_2.Size = new Size(190, 28);
            btn_chose_2.TabIndex = 2;
            btn_chose_2.Text = "Sensor 2 - Potentiometer";
            btn_chose_2.UseVisualStyleBackColor = true;
            // 
            // btn_chose_1
            // 
            btn_chose_1.Cursor = Cursors.Hand;
            btn_chose_1.FlatStyle = FlatStyle.Flat;
            btn_chose_1.ForeColor = Color.MidnightBlue;
            btn_chose_1.Location = new Point(134, 9);
            btn_chose_1.Name = "btn_chose_1";
            btn_chose_1.Size = new Size(190, 28);
            btn_chose_1.TabIndex = 1;
            btn_chose_1.Text = "Sensor 1 - Thermistor";
            btn_chose_1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Chọn sensor:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1139, 590);
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
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            panel4.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            panel5.ResumeLayout(false);
            gr_control.ResumeLayout(false);
            gr_status.ResumeLayout(false);
            gr_status.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
        private Button btn_chose_3;
        private Button btn_chose_2;
        private Button btn_all_csv;
        private Button btn_all_pc;
        private Button btn_chose_1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox gr_status;
        private GroupBox gr_control;
        private Label s_rate;
        private Label status;
        private GroupBox gr_data;
        private ImageList imageList1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Panel panel7;
        private Panel panel8;
        private Panel panel6;
        private Label label5;
    }
}
