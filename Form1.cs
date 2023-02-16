using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
            redButton.FlatStyle = FlatStyle.Flat;
            blueButton.FlatStyle = FlatStyle.Flat;
            yellowButton.FlatStyle = FlatStyle.Flat;
            orangeButton.FlatStyle = FlatStyle.Flat;
            greenButton.FlatStyle = FlatStyle.Flat;
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            clockTimer.Start();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clocklabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            clocklabel.ForeColor = Color.Red;
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            clocklabel.ForeColor = Color.Orange;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            clocklabel.ForeColor = Color.Yellow;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            clocklabel.ForeColor = Color.Blue;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            clocklabel.ForeColor = Color.Green;
        }

        private void styleButton1_Click(object sender, EventArgs e)
        {
            clocklabel.Font = new Font("Impact", 90, FontStyle.Regular);
        }

        private void Stylebutton2_Click(object sender, EventArgs e)
        {
            clocklabel.Font = new Font("Consolas", 90, FontStyle.Regular);
        }

        private void styleButton3_Click(object sender, EventArgs e)
        {
            clocklabel.Font = new Font("Sitka Display", 90, FontStyle.Regular);
        }
    }
}
