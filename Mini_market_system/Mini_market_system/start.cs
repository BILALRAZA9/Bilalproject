using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_market_system
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void CircleProgressBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            STARTPOINT += 2;
            CircleProgressBar.Value = STARTPOINT;
            if (CircleProgressBar.Value == 100)
            {
                CircleProgressBar.Value = 0;
                timer1.Stop();
                LoginForm L = new LoginForm();
                this.Hide();
                L.Show();

            }
        }
        int STARTPOINT = 0;
        private void start_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
