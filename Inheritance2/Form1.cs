using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EtYemekleri etyemek = new EtYemekleri();
            MessageBox.Show(etyemek.SunumSekli());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SebzeYemekleri sebzeyemek = new SebzeYemekleri();    
            MessageBox.Show(sebzeyemek.SunumSekli());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AraSicaklar arasicak=new AraSicaklar();
            MessageBox.Show(arasicak.SunumSekli());
        }
    }
}
