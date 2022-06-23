using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Generic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();

            //Add :  verilen degeri en son siraya ekle demek
            list.Add("Esra"); 
            list.Add(524);
            list.Add(true);
            list.Add("a");

            //Ortaya şöyle bir dezavantaj çıkıyor. 
            //Tüm değerler add adı altında olduğu için aşağıdaki gibi sıfırıncı indis string bir değerdir şeklinde tanımlama yapmamız gerekiyor.
            string isim=(string)list[0];   
            //Tabi bu yapılan işler kod fazlalaştıkça yine sıkıntı çıkaracaktır. 
            //Buna istinaden daha iyisini yaparak Generic mimariye dayanarak yeni bir List çıkarmışlar.
           
             List<string> isimler = new List<string>();
            isimler.Add("Esra");

            List<int> sayilar = new List<int>();
            sayilar.Add(524);




            Ogrenci o1=new Ogrenci();   
            o1.


        }
    }
}
