using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }
        string wpisywanaliczba;
        double wpisanaliczba1 = 0;
        double wpisanaliczba2 = 0;
        double wynik = 0;
        char znak;
        private void button1_Click(object sender, EventArgs e)
        {
            wpisywanaliczba += "1";
            textBox1.Text = wpisywanaliczba;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            wpisywanaliczba += "2";
            textBox1.Text = wpisywanaliczba;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            wpisywanaliczba += "3";
            textBox1.Text = wpisywanaliczba;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            wpisywanaliczba += "4";
            textBox1.Text = wpisywanaliczba;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            wpisywanaliczba += "5";
            textBox1.Text = wpisywanaliczba;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            wpisywanaliczba += "6";
            textBox1.Text = wpisywanaliczba;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            wpisywanaliczba += "7";
            textBox1.Text = wpisywanaliczba;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            wpisywanaliczba += "8";
            textBox1.Text = wpisywanaliczba;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            wpisywanaliczba += "9";
            textBox1.Text = wpisywanaliczba;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            wpisywanaliczba += "0";
            textBox1.Text = wpisywanaliczba;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            wpisanaliczba1 = double.Parse(textBox1.Text);
            znak = '+';
            textBox1.Text = "+";
            wpisywanaliczba = "";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            wpisanaliczba1 = double.Parse(textBox1.Text);
            znak = '-';
            textBox1.Text = "-";
            wpisywanaliczba = "";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            wpisanaliczba1 = double.Parse(textBox1.Text);
            znak = '*';
            textBox1.Text = "*";
            wpisywanaliczba = "";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            wpisanaliczba1 = double.Parse(textBox1.Text);
            znak = '/';
            textBox1.Text = "/";
            wpisywanaliczba = "";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            wpisywanaliczba = "";
            wpisanaliczba1 = 0;
            wpisanaliczba2 = 0;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            wpisanaliczba2 = double.Parse(textBox1.Text);
            if (wpisanaliczba1 == 0 && wpisanaliczba2 == 0) textBox1.Text = "0";
            switch (znak)
            {
                case '+':
                    textBox1.Text = (wpisanaliczba1 + wpisanaliczba2).ToString();
                    wpisywanaliczba = "";
                    break;
                case '-':
                    textBox1.Text = (wpisanaliczba1 - wpisanaliczba2).ToString();
                    wpisywanaliczba = "";
                    break;
                case '*':
                    textBox1.Text = (wpisanaliczba1 * wpisanaliczba2).ToString();
                    wpisywanaliczba = "";
                    break;
                case '/':
                    if (wpisanaliczba2 == 0) textBox1.Text = "Nie można dzielić przez 0";
                    else textBox1.Text = (wpisanaliczba1 / wpisanaliczba2).ToString();
                    wpisywanaliczba = "";
                    break;
                case '^':
                    wynik = 1;
                    if (wpisanaliczba2 < 0)
                    {
                        wpisanaliczba1 = 1 / wpisanaliczba1;
                        wpisanaliczba2 *= (-1);
                        for (int i = 0; i < wpisanaliczba2; i++)
                        {
                            wynik *= wpisanaliczba1;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < wpisanaliczba2; i++)
                        {
                            wynik *= wpisanaliczba1;
                        }
                    }
                    textBox1.Text = wynik.ToString();
                    wpisywanaliczba = "";
                    break;
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            wpisanaliczba1 = double.Parse(textBox1.Text);
            textBox1.Text = (wpisanaliczba1 * wpisanaliczba1).ToString();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            wpisanaliczba1 = double.Parse(textBox1.Text);
            znak = '^';
            textBox1.Text = "^";
            wpisywanaliczba = "";
        }
        private void button19_Click(object sender, EventArgs e)
        {
            wpisanaliczba1 = double.Parse(textBox1.Text);
            textBox1.Text = (Math.Sqrt(wpisanaliczba1)).ToString();
        }
        private void button20_Click(object sender, EventArgs e)
        {
            wpisanaliczba1 = double.Parse(textBox1.Text);
            wpisywanaliczba = "";
            for (; ; )
            {
                if (wpisanaliczba1 == 0) break;
                else
                {
                    if (wpisanaliczba1 % 2 == 0)
                    {
                        wpisywanaliczba = "0" + wpisywanaliczba;
                        wpisanaliczba1 *= 0.5;
                    }
                    else
                    {
                        wpisywanaliczba = "1" + wpisywanaliczba;
                        wpisanaliczba1 -= 1;
                        wpisanaliczba1 *= 0.5;
                    }
                }
            }
            textBox1.Text = wpisywanaliczba;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            wpisanaliczba1 = double.Parse(textBox1.Text);
            wpisywanaliczba = "";
            for (; ; )
            {
                if (wpisanaliczba1 == 0) break;
                else
                {
                    for (; ; )
                    {
                        if (wpisanaliczba1 % 16 >= 10)
                        {
                            switch (wpisanaliczba1 % 16)
                            {
                                case 10:
                                    wpisywanaliczba = "A" + wpisywanaliczba;
                                    break;
                                case 11:
                                    wpisywanaliczba = "B" + wpisywanaliczba;
                                    break;
                                case 12:
                                    wpisywanaliczba = "C" + wpisywanaliczba;
                                    break;
                                case 13:
                                    wpisywanaliczba = "D" + wpisywanaliczba;
                                    break;
                                case 14:
                                    wpisywanaliczba = "E" + wpisywanaliczba;
                                    break;
                                case 15:
                                    wpisywanaliczba = "F" + wpisywanaliczba;
                                    break;
                            }
                            wpisanaliczba1 -= wpisanaliczba1 % 16;
                            wpisanaliczba1 /= 16;
                        }
                        else if (wpisanaliczba1 % 16 <= 10) break;
                    }
                    if (wpisanaliczba1 == 0) break;
                    wpisywanaliczba = (wpisanaliczba1 % 16).ToString() + wpisywanaliczba;
                    wpisanaliczba1 -= wpisanaliczba1 % 16;
                    wpisanaliczba1 /= 16;
                }
            }
            textBox1.Text = wpisywanaliczba;
        }
    }
}
