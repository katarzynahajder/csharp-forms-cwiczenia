using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter zapis = new StreamWriter("zaproszenie.txt");
            zapis.WriteLine("Serdecznie zapraszamy Państwo "+textBox1.Text+" "+textBox2.Text+" na inauguracyjną uroczystość :)");
            zapis.Close();
        }
    }
}
