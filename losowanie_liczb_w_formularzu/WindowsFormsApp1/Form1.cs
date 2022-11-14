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
        }
        private void button_losuj_Click(object sender, EventArgs e)
        {
            int wynik = Convert.ToInt32(label_wynik.Text);
            int proby = Convert.ToInt32(label_proby.Text);
            button_losuj.Visible = false;
            proby += 1;
            label_proby.Text = proby.ToString();
            Random generator = new Random();
            int wylosowana_liczba = generator.Next(11);
            label_wylosowana.Text = wylosowana_liczba.ToString();
            if (Convert.ToInt32(textBox_wpisana_liczba.Text) == wylosowana_liczba)
            {
                wynik += 1;
                label_wynik.Text = wynik.ToString();
                textBox_wpisana_liczba.Text = "";
                label_wygrana_czy.ForeColor = Color.Green;
                label_wygrana_czy.Text = "WYGRAŁEŚ ZA "+ label_proby.Text+". RAZEM";
            }
            else
            {
                textBox_wpisana_liczba.Text = "";
                label_wygrana_czy.ForeColor = Color.Red;
                label_wygrana_czy.Text = "PRZEGRAŁEŚ";
            }
        }
        private void textBox_wpisana_liczba_KeyUp(object sender, KeyEventArgs e)
        {
            label_wygrana_czy.Text = "";
            if (textBox_wpisana_liczba.Text != "") button_losuj.Visible = true;
        }
    }
}
