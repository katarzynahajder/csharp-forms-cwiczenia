using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";

            label1.Text = textBox1.Text;

            if (checkBox1.Checked == true) label2.Text = checkBox1.Text;
            if ((checkBox1.Checked == true) && (checkBox2.Checked == true)) label2.Text += ", " + checkBox2.Text;
            else if (checkBox2.Checked == true) label2.Text += checkBox2.Text;
            if (((checkBox1.Checked == true) || (checkBox2.Checked == true)) && (checkBox3.Checked == true)) label2.Text += ", " + checkBox3.Text;
            else if (checkBox3.Checked == true) label2.Text = checkBox3.Text;

            if (radioButton1.Checked == true) label3.Text = radioButton1.Text;
            else label3.Text = radioButton2.Text;

            label4.Text = comboBox1.Text;
        }
    }
}
