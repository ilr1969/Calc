using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calc : Form
    {
        double v;
        string a;
        public Calc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            v = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            a = "+";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0,";
            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double sv = Convert.ToDouble(textBox1.Text);
            double res;

            if (a == "+")
            {
                res = v + sv;
                textBox1.Text = Convert.ToString(res);
                v = res;
            }

            if (a == "-")
            {
                res = v - sv;
                textBox1.Text = Convert.ToString(res);
                v = res;
            }

            if (a == "*")
            {
                res = v * sv;
                textBox1.Text = Convert.ToString(res);
                v = res;
            }

            if (a == "/")
            {
                res = v / sv;
                textBox1.Text = Convert.ToString(res);
                v = res;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            v = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            a = "*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            v = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            a = "-";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            v = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            a = "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}
