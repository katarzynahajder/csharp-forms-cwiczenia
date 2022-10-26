using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string haslo = textBox1.Text;
            int cyfry = 0;
            bool m_litera = false;
            bool d_litera = false;
            //bool s_znak = false;
            for(int i=0; i<haslo.Length; i++)
            {
                if (haslo[i] == '0' || haslo[i] == '1' || haslo[i] == '2' || haslo[i] == '3' || haslo[i] == '4' || haslo[i] == '5' || haslo[i] == '6' || haslo[i] == '7' || haslo[i] == '8' || haslo[i] == '9')
                {
                    cyfry++;
                    continue;
                }

                string cd_znak = haslo[i].ToString();
                cd_znak = cd_znak.ToUpper();
                char d_znak = char.Parse(cd_znak);
                if (haslo[i] == d_znak)
                {
                    d_litera = true;
                    continue;
                }
                //else s_znak = true;

                string cm_znak = haslo[i].ToString();
                cm_znak = cm_znak.ToLower();
                char m_znak = char.Parse(cm_znak);
                if (haslo[i] == m_znak) m_litera = true;
                //else s_znak = true;
            }
            if (haslo.Length >= 8) label1.Text = "";
            else label1.Text = "długość ma wynosić co najmniej 8 znaków";

            if (cyfry >= 3) label4.Text = "";
            else label4.Text = "ma zawierać co najmniej 3 cyfry";

            if (m_litera) label5.Text = "";
            else label5.Text = "ma zawierac co najmniej 1 małą literę";

            if (d_litera) label2.Text = "";
            else label2.Text = "ma zawierac co najmniej 1 dużą literę";

            //if (s_znak) label3.Text = "";
            //else label3.Text = "ma zawierac co najmniej 1 znak specjalny";
        }
    }
}
