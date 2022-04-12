using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spamma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
            label1.Text = "HIZ:" + trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{Enter}");
        }
    }
}
