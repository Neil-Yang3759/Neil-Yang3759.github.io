using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        private int[] ans = new int[4]; 
        public Form1()
        {
            InitializeComponent();
            btnSeeAns.Enabled = false;
            btnCheck.Enabled = false;
            btnReset.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            listBox1.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnSeeAns.Enabled = true;
            btnCheck.Enabled = true;
            btnReset.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
            listBox1.Enabled = true;
            Random rnd = new Random();
            for (int j = 0; j < 4; j++)
            {
                int n = 0;
                do
                {
                    n = rnd.Next(0, 10);
                }
                while (ans.Contains(n));
                ans[j] = n;
            }
        }

        private void btnSeeAns_Click(object sender, EventArgs e)
        {
            string str = string.Empty;
            foreach(int i in ans)
            {
                str += i.ToString();
            }
            MessageBox.Show(str);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int A = 0, B = 0;
            int input = int.Parse(textBox1.Text);
            int[] Input = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Input[3-i] = input % 10;
                input /= 10;
            }
            for (int i = 0; i < 4; i++)                                 //count A
            {
                if (ans[i] == Input[i])
                {
                    A++;
                }
            }
            B = Input.Count(s => ans.Contains(s));               //count B
            B -= A;
            listBox1.Items.Add($"{textBox1.Text} : {A}A{B}B");

            if(A == 4)
                MessageBox.Show("Pass");

            int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;                //auto scroll to bottom
            listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
