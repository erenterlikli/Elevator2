using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asansör2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                Point a = new Point();
                a.X = 245;
                a.Y = 355;
                pictureBox1.Location = a;
                label8.Text = "0";
            }

            if(radioButton2.Checked==true)
            {
                Point b = new Point();
                b.X = 245;
                b.Y = 256;
                pictureBox1.Location = b;
                label8.Text = "1";
            }

            if(radioButton3.Checked==true)
            {
                Point c = new Point();
                c.X = 245;
                c.Y = 54;
                pictureBox1.Location = c;
                label8.Text = "2";
            }
        }
    }
}
