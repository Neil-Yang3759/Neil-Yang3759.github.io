using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;
            string s = string.Empty;
            labelResult.Text = "你的星座是 ";
            if ((month == 12) && (31>=day && day >= 23) || (month == 1) && (20>= day &&day >= 1))
            {
                labelResult.Text += "魔羯座";
                s = Result("魔羯", LifeNum(year, month, day));
            }
            else if((month == 1) && (31>=day && day >= 21) || (month == 2) && (19 >= day && day >= 1))
            {
                labelResult.Text += "水瓶座";
                s = Result("水瓶", LifeNum(year, month, day));
            }
            else if ((month == 2) && (29 >= day && day >= 20) || (month == 3) && (20 >= day && day >= 1))
            {
                labelResult.Text += "雙魚座";
                s = Result("雙魚", LifeNum(year, month, day));
            }
            else if ((month == 3) && (31 >= day && day >= 21) || (month == 4) && (20 >= day && day >= 1))
            {
                labelResult.Text += "牡羊座";
                s = Result("牡羊", LifeNum(year, month, day));
            }
            else if ((month == 4) && (30 >= day && day >= 21) || (month == 5) && (21 >= day && day >= 1))
            {
                labelResult.Text += "金牛座";
                s = Result("金牛", LifeNum(year, month, day));
            }
            else if ((month == 5) && (31 >= day && day >= 22) || (month == 6) && (21 >= day && day >= 1))
            {
                labelResult.Text += "雙子座";
                s = Result("雙子", LifeNum(year, month, day));
            }
            else if ((month == 6) && (30 >= day && day >= 22) || (month == 7) && (23 >= day && day >= 1))
            {
                labelResult.Text += "巨蟹座";
                s = Result("巨蟹", LifeNum(year, month, day));
            }
            else if ((month == 7) && (31 >= day && day >= 24) || (month == 8) && (23 >= day && day >= 1))
            {
                labelResult.Text += "獅子座";
                s = Result("獅子", LifeNum(year, month, day));
            }
            else if ((month == 8) && (31 >= day && day >= 24) || (month == 9) && (23 >= day && day >= 1))
            {
                labelResult.Text += "處女座";
                s = Result("處女", LifeNum(year, month, day));
            }
            else if ((month == 9) && (30 >= day && day >= 24) || (month == 10) && (23 >= day && day >= 1))
            {
                labelResult.Text += "天秤座";
                s = Result("天秤", LifeNum(year, month, day));
            }
            else if ((month == 10) && (31 >= day && day >= 24) || (month == 11) && (22 >= day && day >= 1))
            {
                labelResult.Text += "天蠍";
                s = Result("天蠍", LifeNum(year, month, day));
            }
            else if ((month == 11) && (30 >= day && day >= 23) || (month == 12) && (22 >= day && day >= 1))
            {
                labelResult.Text += "射手座";
                s = Result("射手", LifeNum(year, month, day));
            }
            
            labelResult.Text += "\n" + s.TrimStart('　');
            labelResult.Visible = true;
        }
        public static int LifeNum(int year, int month, int day)
        {
            int sum = 0;
            string input = year.ToString() + month.ToString() + day.ToString();
            foreach(char i in input)
                sum += int.Parse(i.ToString());
            int tenth = 0, numth = 0;
            while(sum>9)
            {
                numth = sum % 10;
                tenth = sum / 10;
                sum = numth + tenth;
            }
            return sum;
        }
        public static string Result(string sign, int num)
        {
            var text = File.ReadAllLines(@"C:\Users\cloud\OneDrive - 中華大學\BuildSchool\Hackathon\1\生命靈數.txt");
            //var Text = text.First(t => t.Contains(sign));
            var tt = Array.FindIndex(text, t => t.Contains(sign));
            return text[tt+num*2];
        }
    }
}
