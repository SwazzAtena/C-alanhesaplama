using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kenar = Convert.ToDouble(textBox1.Text);
            double alan = kenar * kenar;
            double cevre = kenar * 4;
            label10.Text = Convert.ToString(alan);
            label9.Text = Convert.ToString(cevre);
            //Kare Bitiş
            double d = Convert.ToDouble(textBox2.Text);
            double d2 = Convert.ToDouble(textBox3.Text);
            double dalan = d * d2;
            double dcevre = (d * 2) + (d2 * 2);
            label11.Text = Convert.ToString(dalan);
            label12.Text = Convert.ToString(dcevre);
            //Dikdörtgen Bitiş
            double kenar1 = Convert.ToDouble(textBox4.Text);
            double kenar2 = Convert.ToDouble(textBox5.Text);
            double kenar3 = Convert.ToDouble(textBox6.Text);
            double yukseklik = Convert.ToDouble(textBox7.Text);
            double ucgencevre = kenar1 + kenar2 + kenar3;
            double ucgenalan = (kenar2 * yukseklik) / 2;
            label18.Text = Convert.ToString(ucgenalan);
            label19.Text = Convert.ToString(ucgencevre);
            //Üçgen Bitiş
            double yamukyukseklik = Convert.ToDouble(textBox8.Text);
            double yamuktaban = Convert.ToDouble(textBox11.Text);
            double yamukusttaban = Convert.ToDouble(textBox10.Text);
            double yamuksol = Convert.ToDouble(textBox9.Text);
            double yamuksag = Convert.ToDouble(textBox12.Text);
            double yamukalan = (yamuktaban + yamukusttaban) / 2;
            double yamukalannet = yamukalan * yamukyukseklik;
            label28.Text = Convert.ToString(yamukalannet);
            double yamukcevre = yamuksag + yamuksol + yamuktaban + yamukusttaban;
            label29.Text = Convert.ToString(yamukcevre);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
