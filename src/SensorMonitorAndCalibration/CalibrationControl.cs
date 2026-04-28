using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorMonitorAndCalibration
{
    public partial class CalibrationControl : UserControl
    {
        public CalibrationControl()
        {
            InitializeComponent();
            var lbl = new Label
            {
                Text = "Calib do Trân phát triển.",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            Controls.Add(lbl);
        }
    }
}
