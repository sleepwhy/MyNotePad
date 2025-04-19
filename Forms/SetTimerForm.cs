using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad
{
    public partial class SetTimerForm : Form
    {
        Timer timer;
        public SetTimerForm(Timer timer)
        {
            InitializeComponent();
            this.timer = timer;

            if(Properties.Settings.Default.autoSaveTime > 0 && Properties.Settings.Default.autoSaveTime <= 3599)
            {
                int minute = Properties.Settings.Default.autoSaveTime / 60;
                int second = Properties.Settings.Default.autoSaveTime % 60;

                trackBarMin.Value = minute;
                trackBarSec.Value = second;
                labelMinValue.Text = minute.ToString();
                labelSecValue.Text = second.ToString();
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;


            int totalSecond = (trackBarMin.Value * 60) + trackBarSec.Value;

            Properties.Settings.Default.autoSaveTime = totalSecond;

            timer.Start();

            Properties.Settings.Default.isAutoSaveOpen = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void trackBarSec_Scroll(object sender, EventArgs e)
        {
            labelSecValue.Text = trackBarSec.Value.ToString();
        }

        private void trackBarMin_Scroll(object sender, EventArgs e)
        {
            labelMinValue.Text = trackBarMin.Value.ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            timer.Stop();
            Properties.Settings.Default.isAutoSaveOpen = false;
        }
    }
}
