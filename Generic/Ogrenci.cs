using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{


    //Bir sınıfı generic hale aşağıdaki gibi getiririz.
    //Temsili yazdığımız yere istediğimizi yazabiliriz.
    internal class Ogrenci<Temsili>
    {
        public string Adi { get; set; }    
        public string Soyadi { get; set; }
        public string OkulNo { get; set; }  
        public string Okulu { get; set; }   

    }
}
