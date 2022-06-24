using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ebat kucuk = new Ebat { Adi = "Küçük", Carpan = 1 };
            Ebat orta = new Ebat { Adi = "Orta", Carpan = 1.25 };
            Ebat buyuk = new Ebat { Adi = "Büyük", Carpan = 1.75 };
            Ebat maxi= new Ebat { Adi="Maxi" , Carpan = 2 };

            cmbEbat.Items.Add(kucuk);
            cmbEbat.Items.Add(orta);    
            cmbEbat.Items.Add(buyuk);   
            cmbEbat.Items.Add(maxi);    

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
