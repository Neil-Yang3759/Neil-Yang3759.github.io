using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn0.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnDot.Text;
        }

        private void btnTurn_Click(object sender, EventArgs e)
        {
            double temperature;
            if(radioBtnC_F.Checked)
            {
                temperature = (double.Parse(textBox1.Text) * 1.8) + 32;
                label1.Text = $"結果 : {textBox1.Text}°C = " + temperature.ToString() + "°F";
            }
            else
            {
                temperature = (double.Parse(textBox1.Text) - 32) * 5 / 9;
                label1.Text = $"結果 : {textBox1.Text}°F = " + temperature.ToString() + "°C";
            }
            label1.Visible = true;   
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }
    }
}
