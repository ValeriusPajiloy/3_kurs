using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for(int i=1;i<=numericUpDown1.Value; i++)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(i) + " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(comboBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox5.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) - Convert.ToDouble(textBox5.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox5.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) / Convert.ToDouble(textBox5.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double num;
            comboBox2.Items.Clear();
            foreach(string line in textBox7.Lines)
            {
                if(double.TryParse(line, out num))
                {
                    comboBox2.Items.Add(line);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            double _delta_ = Convert.ToDouble(numericUpDown2.Value);
            double summ = 0;
            double lastSumm = 0;
            double x = 1;
            
            for(; ;)
            {
                summ += 1 / (x * x);
                if (Math.Abs(summ - lastSumm) <= _delta_)
                {
                    textBox8.Text += "\r\nAnswer: " + Convert.ToString(summ);
                    break;
                }
                else
                {
                    lastSumm = summ;
                    textBox8.Text += "\r\nX = " + Convert.ToString(x) + " Summ = " + Convert.ToString(summ);
                    x++;
                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            double num;
            foreach(string line in textBox9.Lines)
            {
                if (!double.TryParse(line,out num))
                {
                    textBox10.Text = line + "\r\n" + textBox10.Text;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox14.Text = "f(x) = sin(x)/(|x|+1) ";
            double a = Convert.ToDouble(textBox11.Text);
            double b = Convert.ToDouble(textBox12.Text);
            double h = Convert.ToDouble(textBox13.Text);

            double x = a;
            double y = 0;

            for(; ;)
            {
                if(a<b)
                {
                    if (x > b) break;
                    y = (Math.Sin(x) / (Math.Abs(x) + 1));
                    textBox14.Text += "\r\nx = " + Convert.ToString(x) + "\tf(x) = " + Convert.ToString(y);
                    x += h;
                }
                else
                {
                    if (x < b) break;
                    y = (Math.Sin(x) / (Math.Abs(x) + 1));
                    textBox14.Text += "\r\nx = " + Convert.ToString(x) + "\tf(x) = " + Convert.ToString(y);
                    x -= h;
                }
            }
        }
    }
}
