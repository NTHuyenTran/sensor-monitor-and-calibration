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
            btn_csv_2 = new Button();
            panel7 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            formsPlot3 = new ScottPlot.WinForms.FormsPlot();
            flowLayoutPanel4 = new FlowLayoutPanel();
            btn_pc_3 = new Button();
            btn_csv_3 = new Button();
            panel8 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            gr_control = new GroupBox();
            btn_all_pc = new Button();
            btn_all_csv = new Button();
            gr_status = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            s_rate = new Label();
            status = new Label();
            panel1 = new Panel();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn_pc_1 = new Button();
            btn_csv_1 = new Button();
            panel6 = new Panel();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panel4.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            panel5.SuspendLayout();
            gr_control.SuspendLayout();
            gr_status.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
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
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1141, 640);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(formsPlot2);
            panel3.Controls.Add(flowLayoutPanel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(574, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(557, 306);
            panel3.TabIndex = 5;
            // 
            // formsPlot2
            // 
            formsPlot2.Dock = DockStyle.Fill;
            formsPlot2.Location = new Point(0, 0);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(557, 269);
            formsPlot2.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Controls.Add(btn_pc_2);
            flowLayoutPanel3.Controls.Add(btn_csv_2);
            flowLayoutPanel3.Controls.Add(panel7);
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Dock = DockStyle.Bottom;
            flowLayoutPanel3.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel3.Location = new Point(0, 269);
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
            // btn_csv_2
            // 
            btn_csv_2.BackColor = Color.AliceBlue;
            btn_csv_2.Cursor = Cursors.Hand;
            btn_csv_2.ImageIndex = 3;
            btn_csv_2.ImageList = imageList1;
            btn_csv_2.Location = new Point(467, 3);
            btn_csv_2.Margin = new Padding(10, 3, 10, 3);
            btn_csv_2.Name = "btn_csv_2";
            btn_csv_2.Size = new Size(29, 29);
            btn_csv_2.TabIndex = 2;
            btn_csv_2.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Location = new Point(221, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(233, 29);
            panel7.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(39, 2);
            label3.Name = "label3";
            label3.Size = new Size(176, 30);
            label3.TabIndex = 4;
            label3.Text = "Potentionmeter";
            // 
            // panel4
            // 
            panel4.Controls.Add(formsPlot3);
            panel4.Controls.Add(flowLayoutPanel4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(10, 324);
            panel4.Name = "panel4";
            panel4.Size = new Size(556, 306);
            panel4.TabIndex = 6;
            // 
            // formsPlot3
            // 
            formsPlot3.Dock = DockStyle.Fill;
            formsPlot3.Location = new Point(0, 0);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new Size(556, 269);
            formsPlot3.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel4.Controls.Add(btn_pc_3);
            flowLayoutPanel4.Controls.Add(btn_csv_3);
            flowLayoutPanel4.Controls.Add(panel8);
            flowLayoutPanel4.Controls.Add(label4);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel4.Location = new Point(0, 269);
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
            // btn_csv_3
            // 
            btn_csv_3.BackColor = Color.AliceBlue;
            btn_csv_3.Cursor = Cursors.Hand;
            btn_csv_3.ImageIndex = 3;
            btn_csv_3.ImageList = imageList1;
            btn_csv_3.Location = new Point(466, 3);
            btn_csv_3.Margin = new Padding(10, 3, 10, 3);
            btn_csv_3.Name = "btn_csv_3";
            btn_csv_3.Size = new Size(29, 29);
            btn_csv_3.TabIndex = 2;
            btn_csv_3.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Location = new Point(133, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(320, 29);
            panel8.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(30, 2);
            label4.Name = "label4";
            label4.Size = new Size(97, 30);
            label4.TabIndex = 4;
            label4.Text = "Encoder";
            // 
            // panel5
            // 
            panel5.Controls.Add(gr_control);
            panel5.Controls.Add(gr_status);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(574, 324);
            panel5.Name = "panel5";
            panel5.Size = new Size(557, 306);
            panel5.TabIndex = 7;
            // 
            // gr_control
            // 
            gr_control.BackColor = Color.AliceBlue;
            gr_control.Controls.Add(btn_all_pc);
            gr_control.Controls.Add(btn_all_csv);
            gr_control.Dock = DockStyle.Bottom;
            gr_control.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            gr_control.ForeColor = Color.MidnightBlue;
            gr_control.Location = new Point(0, 163);
            gr_control.Margin = new Padding(5);
            gr_control.Name = "gr_control";
            gr_control.Padding = new Padding(5);
            gr_control.Size = new Size(557, 143);
            gr_control.TabIndex = 5;
            gr_control.TabStop = false;
            gr_control.Text = "Áp dụng toàn bộ ";
            // 
            // btn_all_pc
            // 
            btn_all_pc.Cursor = Cursors.Hand;
            btn_all_pc.FlatStyle = FlatStyle.Flat;
            btn_all_pc.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_all_pc.ForeColor = Color.MidnightBlue;
            btn_all_pc.Location = new Point(345, 56);
            btn_all_pc.Name = "btn_all_pc";
            btn_all_pc.Size = new Size(141, 50);
            btn_all_pc.TabIndex = 3;
            btn_all_pc.Text = "Tiếp tục";
            btn_all_pc.UseVisualStyleBackColor = true;
            // 
            // btn_all_csv
            // 
            btn_all_csv.Cursor = Cursors.Hand;
            btn_all_csv.FlatStyle = FlatStyle.Flat;
            btn_all_csv.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_all_csv.ForeColor = Color.MidnightBlue;
            btn_all_csv.Location = new Point(159, 56);
            btn_all_csv.Name = "btn_all_csv";
            btn_all_csv.Size = new Size(164, 50);
            btn_all_csv.TabIndex = 2;
            btn_all_csv.Text = "Lưu vào csv";
            btn_all_csv.UseVisualStyleBackColor = true;
            // 
            // gr_status
            // 
            gr_status.BackColor = Color.AliceBlue;
            gr_status.Controls.Add(tableLayoutPanel2);
            gr_status.Dock = DockStyle.Top;
            gr_status.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            gr_status.ForeColor = Color.MidnightBlue;
            gr_status.Location = new Point(0, 0);
            gr_status.Margin = new Padding(5);
            gr_status.Name = "gr_status";
            gr_status.Padding = new Padding(5);
            gr_status.Size = new Size(557, 110);
            gr_status.TabIndex = 4;
            gr_status.TabStop = false;
            gr_status.Text = "Kết nối tín hiệu";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.37993F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.6200714F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 295F));
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(s_rate, 2, 0);
            tableLayoutPanel2.Controls.Add(status, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(5, 39);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(547, 66);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label5.Location = new Point(3, 18);
            label5.Name = "label5";
            label5.Size = new Size(211, 30);
            label5.TabIndex = 2;
            label5.Text = "Trạng thái kết nối:";
            // 
            // s_rate
            // 
            s_rate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            s_rate.AutoSize = true;
            s_rate.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            s_rate.Location = new Point(254, 18);
            s_rate.Name = "s_rate";
            s_rate.Size = new Size(290, 30);
            s_rate.TabIndex = 1;
            s_rate.Text = "Tần số lấy mẫu:";
            // 
            // status
            // 
            status.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            status.BackColor = Color.DarkRed;
            status.Location = new Point(220, 18);
            status.Name = "status";
            status.Size = new Size(28, 30);
            status.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(formsPlot1);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 306);
            panel1.TabIndex = 8;
            // 
            // formsPlot1
            // 
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(0, 0);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(556, 269);
            formsPlot1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(btn_pc_1);
            flowLayoutPanel2.Controls.Add(btn_csv_1);
            flowLayoutPanel2.Controls.Add(panel6);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(0, 269);
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
            // btn_csv_1
            // 
            btn_csv_1.BackColor = Color.AliceBlue;
            btn_csv_1.Cursor = Cursors.Hand;
            btn_csv_1.ImageIndex = 3;
            btn_csv_1.ImageList = imageList1;
            btn_csv_1.Location = new Point(466, 3);
            btn_csv_1.Margin = new Padding(10, 3, 10, 3);
            btn_csv_1.Name = "btn_csv_1";
            btn_csv_1.Size = new Size(29, 29);
            btn_csv_1.TabIndex = 2;
            btn_csv_1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Location = new Point(158, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(295, 29);
            panel6.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(25, 2);
            label2.Name = "label2";
            label2.Size = new Size(127, 30);
            label2.TabIndex = 3;
            label2.Text = "Thermistor";
            // 
            // ChartControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btn_pc_2;
        private Button btn_csv_2;
        private Label label3;
        private Panel panel4;
        private ScottPlot.WinForms.FormsPlot formsPlot3;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button btn_pc_3;
        private Button btn_csv_3;
        private Panel panel8;
        private Label label4;
        private Panel panel5;
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
        private Button btn_csv_1;
        private Panel panel6;
        private Label label2;
        private ImageList imageList1;
        private Panel panel7;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
