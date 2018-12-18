using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;



// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace NumarPrim
{
    public partial class Corp : Form
    {
        public Corp()
        {
            InitializeComponent();
            BackColor = Color.LightGray;
        }

        public int prim(int n)
        {
            if (n < 2) return 0;
            if (n == 2) return 1;
            if (n % 2 == 0) return 0;
            for (int i = 3; i * i <= n; i += 3)
                if (n % i == 0) return 0;
            return 1;

        }


        public int IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return 0;
            }

            return 1;
        }

        public void textbox_TextChanged(object sender, EventArgs e)
        {
            if (buttonAuto.Text == "Auto:off") return;
            StartButton.PerformClick();


        }
        

        public void StartButton_Click(object sender, EventArgs e)
        {
            string str = textbox.Text;

            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsNumber(str[i]))
                {
                    ResultLabel.Text = "Introduceti un numar mai mic decat 999.";
                    textbox.Text = "";
                    BackColor = Color.Yellow;
                    return;
                }

            }
            try
            {

                int x = int.Parse(textbox.Text);

                if (prim(x) == 1)
                {
                    BackColor = Color.Red;
                    ResultLabel.Text = $"Numărul {x} este prim.";
                }
                else
                {
                    BackColor = Color.Green;
                    ResultLabel.Text = $"Numărul {x} nu este prim.";
                }
            }
            catch
            {
                textbox.Text = "";
                ResultLabel.Text = "Introduceti un numar mai mic decat 999.";
                BackColor = Color.Yellow;
            }

        }

        public void buttonAuto_Click(object sender, EventArgs e)
        {
            StartButton.PerformClick();
            if (buttonAuto.Text == "Auto:on") buttonAuto.Text = "Auto:off";
            else
                buttonAuto.Text = "Auto:on";
        }

        public void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartButton.PerformClick();
            }
        }

        public void textbox_TextChanged_1(object sender, EventArgs e)
        {
            if (buttonAuto.Text == "Auto:on")
                StartButton.PerformClick();
        }

        static string path="in.txt";
        private void buttonBrowse_Click(object sender, EventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All Files (*.*)|*.*";
            file.FilterIndex = 1;
            file.Multiselect = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                string sFileName = file.FileName;
                string[] arrAllFiles = file.FileNames; //used when Multiselect = true     
                path = sFileName;
            }
            MessageBox.Show(path);
            sr = new StreamReader(path);

        }
        StreamReader sr = new StreamReader(path);

        public void buttonFile_Click(object sender, EventArgs e)
        {
            
            string line = sr.ReadLine();
            if (line != null)
                textbox.Text = line;

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(path);
            this.Close();
        }

       

    }
}

