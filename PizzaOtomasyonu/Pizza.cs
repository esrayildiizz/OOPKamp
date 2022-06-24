using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOtomasyonu
{
    internal class Pizza
    {
        public string Adi { get; set; }    
        public decimal Fiyat { get; set; }  
        public Ebat Ebati { get; set; } 
        public KenarTip KenarTipi { get; set; } 
        public List<string> Malzemeler { get; set; }

    }
}
