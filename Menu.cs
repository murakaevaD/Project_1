using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Menu : Form
    {
        public Menu(string str)
        {
            InitializeComponent();

            string lg2 = str;
            label6.Text = str;

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile(label6.Text);
            profile.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.labelTime.Text = DateTime.Now.ToString("hh:mm:ss");
            int hours = int.Parse(DateTime.Now.ToString("HH"));
            if (hours > 12)
            {
                labelAMPM.Text = "PM";
            }
            else
            {
                labelAMPM.Text = "AM";
            }
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.RosyBrown;
            panel2.BackColor = Color.AntiqueWhite;
        }
    }
}
