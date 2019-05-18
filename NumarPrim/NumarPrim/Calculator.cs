using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumarPrim
{
    public partial class Calculator : UserControl
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SendToBack();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TitleLabel.Text= TitleLabel.Text+"7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = TitleLabel.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = TitleLabel.Text + "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = TitleLabel.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = TitleLabel.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = TitleLabel.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = TitleLabel.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = TitleLabel.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = TitleLabel.Text + "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = TitleLabel.Text + "0";
        }
    }
}
