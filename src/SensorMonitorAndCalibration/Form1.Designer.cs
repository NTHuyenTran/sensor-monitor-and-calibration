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
            tabCalib = new TabPage();
            tabChart = new TabPage();
            btn_chose_1 = new Button();
            btn_chose_2 = new Button();
            btn_chose_3 = new Button();
            btn_chose_4 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            statusBar = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn_pc_1 = new Button();
            btn_dts_1 = new Button();
            btn_csv_1 = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            btn_pc_2 = new Button();
            btn_dts_2 = new Button();
            btn_csv_2 = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            btn_pc_3 = new Button();
            btn_dts_3 = new Button();
            btn_csv_3 = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            btn_pc_4 = new Button();
            btn_dts_4 = new Button();
            btn_csv_4 = new Button();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            formsPlot3 = new ScottPlot.WinForms.FormsPlot();
            formsPlot4 = new ScottPlot.WinForms.FormsPlot();
            tabControlMain.SuspendLayout();
            tabMonitor.SuspendLayout();
            tabChart.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
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
            // tabCalib
            // 
            tabCalib.Location = new Point(4, 29);
            tabCalib.Name = "tabCalib";
            tabCalib.Padding = new Padding(3);
            tabCalib.Size = new Size(834, 480);
            tabCalib.TabIndex = 1;
            tabCalib.Text = "Calib";
            tabCalib.UseVisualStyleBackColor = true;
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
            // formsPlot1
            // 
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(0, 0);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(403, 173);
            formsPlot1.TabIndex = 2;
            // 
            // formsPlot2
            // 
            formsPlot2.Dock = DockStyle.Fill;
            formsPlot2.Location = new Point(0, 0);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(403, 173);
            formsPlot2.TabIndex = 3;
            // 
            // formsPlot3
            // 
            formsPlot3.Dock = DockStyle.Fill;
            formsPlot3.Location = new Point(0, 0);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new Size(403, 174);
            formsPlot3.TabIndex = 4;
            // 
            // formsPlot4
            // 
            formsPlot4.Dock = DockStyle.Fill;
            formsPlot4.Location = new Point(0, 0);
            formsPlot4.Name = "formsPlot4";
            formsPlot4.Size = new Size(403, 174);
            formsPlot4.TabIndex = 4;
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
            tabChart.ResumeLayout(false);
            tabChart.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
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
    }
}
