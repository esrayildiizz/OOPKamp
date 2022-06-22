using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumeration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogr= new Ogrenci();
            ogr.Adi = " Esra";
            ogr.Soyadi = "YILDIZ";
            ogr.Alani = Alan.Sayısal;



            Ogrenci ogr2 =new Ogrenci();
            ogr2.Alani = Alan.Sayısal;



        }
    }
}
