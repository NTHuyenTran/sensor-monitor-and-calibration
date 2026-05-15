namespace SensorMonitorAndCalibration
{
    partial class ChartControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartControl));
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
            label1 = new Label();
            btn_chose_1 = new Button();
            btn_chose_2 = new Button();
            btn_chose_3 = new Button();
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
            SuspendLayout();
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
            tableLayoutPanel1.Location = new Point(0, 34);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1141, 606);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(formsPlot2);
            panel3.Controls.Add(flowLayoutPanel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(574, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(557, 289);
            panel3.TabIndex = 5;
            // 
            // formsPlot2
            // 
            formsPlot2.Dock = DockStyle.Fill;
            formsPlot2.Location = new Point(0, 0);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(557, 252);
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
            flowLayoutPanel3.Location = new Point(0, 252);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(557, 37);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // btn_pc_2
            // 
            btn_pc_2.BackColor = Color.AliceBlue;
            btn_pc_2.Cursor = Cursors.Hand;
            btn_pc_2.ImageList = imageList1;
            btn_pc_2.Location = new Point(516, 3);
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
            imageList1.Images.SetKeyName(1, "cont.png");
            imageList1.Images.SetKeyName(2, "lookup.png");
            imageList1.Images.SetKeyName(3, "save.png");
            // 
            // btn_dts_2
            // 
            btn_dts_2.BackColor = Color.AliceBlue;
            btn_dts_2.Cursor = Cursors.Hand;
            btn_dts_2.ImageIndex = 2;
            btn_dts_2.ImageList = imageList1;
            btn_dts_2.Location = new Point(467, 3);
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
            btn_csv_2.ImageIndex = 3;
            btn_csv_2.ImageList = imageList1;
            btn_csv_2.Location = new Point(418, 3);
            btn_csv_2.Margin = new Padding(10, 3, 10, 3);
            btn_csv_2.Name = "btn_csv_2";
            btn_csv_2.Size = new Size(29, 29);
            btn_csv_2.TabIndex = 2;
            btn_csv_2.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Location = new Point(139, 3);
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
            label3.Location = new Point(13, 7);
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
            panel4.Location = new Point(10, 307);
            panel4.Name = "panel4";
            panel4.Size = new Size(556, 289);
            panel4.TabIndex = 6;
            // 
            // formsPlot3
            // 
            formsPlot3.Dock = DockStyle.Fill;
            formsPlot3.Location = new Point(0, 0);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new Size(556, 252);
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
            flowLayoutPanel4.Location = new Point(0, 252);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(556, 37);
            flowLayoutPanel4.TabIndex = 3;
            // 
            // btn_pc_3
            // 
            btn_pc_3.BackColor = Color.AliceBlue;
            btn_pc_3.Cursor = Cursors.Hand;
            btn_pc_3.ImageList = imageList1;
            btn_pc_3.Location = new Point(515, 3);
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
            btn_dts_3.ImageIndex = 2;
            btn_dts_3.ImageList = imageList1;
            btn_dts_3.Location = new Point(466, 3);
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
            btn_csv_3.ImageIndex = 3;
            btn_csv_3.ImageList = imageList1;
            btn_csv_3.Location = new Point(417, 3);
            btn_csv_3.Margin = new Padding(10, 3, 10, 3);
            btn_csv_3.Name = "btn_csv_3";
            btn_csv_3.Size = new Size(29, 29);
            btn_csv_3.TabIndex = 2;
            btn_csv_3.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Location = new Point(84, 3);
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
            label4.Location = new Point(13, 7);
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
            panel5.Location = new Point(574, 307);
            panel5.Name = "panel5";
            panel5.Size = new Size(557, 289);
            panel5.TabIndex = 7;
            // 
            // gr_data
            // 
            gr_data.BackColor = Color.AliceBlue;
            gr_data.Dock = DockStyle.Fill;
            gr_data.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gr_data.ForeColor = Color.MidnightBlue;
            gr_data.Location = new Point(0, 47);
            gr_data.Margin = new Padding(5);
            gr_data.Name = "gr_data";
            gr_data.Padding = new Padding(5);
            gr_data.Size = new Size(557, 188);
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
            gr_control.Location = new Point(0, 235);
            gr_control.Margin = new Padding(5);
            gr_control.Name = "gr_control";
            gr_control.Padding = new Padding(5);
            gr_control.Size = new Size(557, 54);
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
            gr_status.Size = new Size(557, 47);
            gr_status.TabIndex = 4;
            gr_status.TabStop = false;
            gr_status.Text = "Kết nối tín hiệu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(149, 18);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 2;
            label5.Text = "Trạng thái kết nối:";
            // 
            // s_rate
            // 
            s_rate.AutoSize = true;
            s_rate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            s_rate.Location = new Point(345, 18);
            s_rate.Name = "s_rate";
            s_rate.Size = new Size(118, 20);
            s_rate.TabIndex = 1;
            s_rate.Text = "Tần số lấy mẫu:";
            // 
            // status
            // 
            status.BackColor = Color.Red;
            status.Location = new Point(288, 18);
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
            panel1.Size = new Size(556, 289);
            panel1.TabIndex = 8;
            // 
            // formsPlot1
            // 
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(0, 0);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(556, 252);
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
            flowLayoutPanel2.Location = new Point(0, 252);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(556, 37);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // btn_pc_1
            // 
            btn_pc_1.BackColor = Color.AliceBlue;
            btn_pc_1.Cursor = Cursors.Hand;
            btn_pc_1.ImageList = imageList1;
            btn_pc_1.Location = new Point(515, 3);
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
            btn_dts_1.ImageIndex = 2;
            btn_dts_1.ImageList = imageList1;
            btn_dts_1.Location = new Point(466, 3);
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
            btn_csv_1.ImageIndex = 3;
            btn_csv_1.ImageList = imageList1;
            btn_csv_1.Location = new Point(417, 3);
            btn_csv_1.Margin = new Padding(10, 3, 10, 3);
            btn_csv_1.Name = "btn_csv_1";
            btn_csv_1.Size = new Size(29, 29);
            btn_csv_1.TabIndex = 2;
            btn_csv_1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Location = new Point(109, 3);
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
            label2.Location = new Point(16, 7);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 3;
            label2.Text = "Thermistor";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.AliceBlue;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(btn_chose_1);
            flowLayoutPanel1.Controls.Add(btn_chose_2);
            flowLayoutPanel1.Controls.Add(btn_chose_3);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1141, 34);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(15, 7);
            label1.Margin = new Padding(15, 0, 15, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 5;
            label1.Text = "Chọn sensor:";
            // 
            // btn_chose_1
            // 
            btn_chose_1.Cursor = Cursors.Hand;
            btn_chose_1.FlatStyle = FlatStyle.Flat;
            btn_chose_1.ForeColor = Color.MidnightBlue;
            btn_chose_1.Location = new Point(145, 3);
            btn_chose_1.Margin = new Padding(15, 3, 15, 3);
            btn_chose_1.Name = "btn_chose_1";
            btn_chose_1.Size = new Size(190, 28);
            btn_chose_1.TabIndex = 6;
            btn_chose_1.Text = "Sensor 1 - Thermistor";
            btn_chose_1.UseVisualStyleBackColor = true;
            // 
            // btn_chose_2
            // 
            btn_chose_2.Cursor = Cursors.Hand;
            btn_chose_2.FlatStyle = FlatStyle.Flat;
            btn_chose_2.ForeColor = Color.MidnightBlue;
            btn_chose_2.Location = new Point(365, 3);
            btn_chose_2.Margin = new Padding(15, 3, 15, 3);
            btn_chose_2.Name = "btn_chose_2";
            btn_chose_2.Size = new Size(190, 28);
            btn_chose_2.TabIndex = 7;
            btn_chose_2.Text = "Sensor 2 - Potentiometer";
            btn_chose_2.UseVisualStyleBackColor = true;
            // 
            // btn_chose_3
            // 
            btn_chose_3.Cursor = Cursors.Hand;
            btn_chose_3.FlatStyle = FlatStyle.Flat;
            btn_chose_3.ForeColor = Color.MidnightBlue;
            btn_chose_3.Location = new Point(585, 3);
            btn_chose_3.Margin = new Padding(15, 3, 15, 3);
            btn_chose_3.Name = "btn_chose_3";
            btn_chose_3.Size = new Size(190, 28);
            btn_chose_3.TabIndex = 8;
            btn_chose_3.Text = "Sensor 3 - Encoder";
            btn_chose_3.UseVisualStyleBackColor = true;
            // 
            // ChartControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            Name = "ChartControl";
            Size = new Size(1141, 640);
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
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btn_pc_2;
        private Button btn_dts_2;
        private Button btn_csv_2;
        private Panel panel7;
        private Label label3;
        private Panel panel4;
        private ScottPlot.WinForms.FormsPlot formsPlot3;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button btn_pc_3;
        private Button btn_dts_3;
        private Button btn_csv_3;
        private Panel panel8;
        private Label label4;
        private Panel panel5;
        private GroupBox gr_data;
        private GroupBox gr_control;
        private Button btn_all_pc;
        private Button btn_all_csv;
        private GroupBox gr_status;
        private Label label5;
        private Label s_rate;
        private Label status;
        private Panel panel1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btn_pc_1;
        private Button btn_dts_1;
        private Button btn_csv_1;
        private Panel panel6;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button btn_chose_1;
        private Button btn_chose_2;
        private Button btn_chose_3;
        private ImageList imageList1;
    }
}
