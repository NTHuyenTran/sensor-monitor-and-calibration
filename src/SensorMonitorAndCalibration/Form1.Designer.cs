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
            statusBar = new Panel();
            tabControlMain = new TabControl();
            tabMonitor = new TabPage();
            tabCalib = new TabPage();
            tabChart = new TabPage();
            tabControlMain.SuspendLayout();
            tabMonitor.SuspendLayout();
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
            // statusBar
            // 
            statusBar.AutoScroll = true;
            statusBar.BackColor = Color.WhiteSmoke;
            statusBar.BorderStyle = BorderStyle.FixedSingle;
            statusBar.Dock = DockStyle.Bottom;
            statusBar.Location = new Point(0, 459);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(842, 54);
            statusBar.TabIndex = 4;
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
            tabChart.Location = new Point(4, 29);
            tabChart.Name = "tabChart";
            tabChart.Padding = new Padding(3);
            tabChart.Size = new Size(834, 480);
            tabChart.TabIndex = 2;
            tabChart.Text = "Chart";
            tabChart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(842, 513);
            Controls.Add(statusBar);
            Controls.Add(tabControlMain);
            Name = "Form1";
            Text = "Sensor Monitor — HPMR Đo lường CN";
            Load += Form1_Load;
            tabControlMain.ResumeLayout(false);
            tabMonitor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSensor1;
        private Panel panelSensor2;
        private Panel panelSensor3;
        private Panel panelSensor4;
        private Panel statusBar;
        private TabControl tabControlMain;
        private TabPage tabMonitor;
        private TabPage tabCalib;
        private TabPage tabChart;
    }
}
