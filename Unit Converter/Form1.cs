using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 單位轉換器
{
    public partial class Form1 : Form
    {
        float cm,inch = 0.0f;
        double 坪數, 平方公尺 = 0.0;
        double myKg, myPound = 0.0;
        bool is轉換成功 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn公分轉英寸_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt公分.Text))
            {
                if (float.TryParse(txt公分.Text, out cm))
                {
                    inch = cm * 0.3937f;
                    txt英吋.Text = inch.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Invalid input for centimeters");
                    txt英吋.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in centimeters");
                txt英吋.Text = "";
            }
        }
         
        private void btn英吋轉公分_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt英吋.Text))
            {
                if (float.TryParse(txt英吋.Text, out inch))
                {
                    cm = inch * 2.54f;
                    txt公分.Text = cm.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Invalid input for inches");
                    txt公分.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in inches");
                txt公分.Text = "";
            }
        }

        private void btn坪數轉平方公尺_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt坪數.Text))
            {
                if (double.TryParse(txt坪數.Text, out 坪數))
                {
                    平方公尺 = 坪數 * 3.3058;
                    txt平方公尺.Text = 平方公尺.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Invalid input for square feet");
                    txt平方公尺.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in square feet");
                txt坪數.Text = "";
            }
        }

        private void btn平方公尺轉坪數_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt平方公尺.Text))
            {
                if (double.TryParse(txt平方公尺.Text, out 平方公尺))
                {
                    坪數 = 平方公尺 * 0.3025;
                    txt坪數.Text = 坪數.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Invalid input for square meters");
                    txt坪數.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in square meters");
                txt坪數.Text = "";
            }
        }

        private void btn公斤轉磅_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt公斤.Text))
            {
                if (double.TryParse(txt公斤.Text, out myKg))
                {
                    myPound = myKg * 2.2046;
                    txt磅.Text = myPound.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Invalid input for kilograms");
                    txt磅.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in kilograms");
                txt磅.Text = "";
            }
        }

        private void btn磅轉公斤_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt磅.Text))
            {
                if (double.TryParse(txt磅.Text, out myPound))
                {
                    myKg = myPound * 0.4536;
                    txt公斤.Text = myKg.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Invalid input for pounds");
                    txt公斤.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in pounds");
                txt公斤.Text = "";
            }
        }
    }
}
