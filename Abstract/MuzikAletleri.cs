using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    //Eğerki metodumuz abstract ise;
    //Sınıfı da Abstract olarak değiştirmek zorundayız.
    internal  abstract class MuzikAletleri
    {
        /*
         * Abstract(soyut):
         * 
         * Abstract sınıflar sadece miras verilmek için tasarlanan sınıflardır.
         * 
         * Abstractlar sınıfa özel değil, bir property , bir metot veya herhangi bir eleman abstract olabilir
         * .
         * Bir metodun abstract olması o metot miras verilen sınıflarda ezilmek zorundadır.
         * 
         * Abstract metotların gövdesi olmaz.
         * 
         * Abstract metotlar abstract olmayan sınıfta bulunamaz.
         * 
         * Abstract sınıflar içerisinde abstract olan property veya metotların gövdesi olmadığı için bu metotlara erişilmesin diye abstract sınıflardan instance üretilmez.
         * 
         * Sınıf abstract olsa da içerisinde abstract olmayan metot veya property bulunabilir.
         * Ancak abstract bir metot veya property abstract olmayan bir sınıfta bulunamaz.
         */

        public abstract string Cal();

        //Sınıf abstract diye içerisinde abstract olmayan metot veya property bulunabilir.

        public string Mensei { get; set; }  
        public DateTime UretimTarihi { get; set; }  
        




    }
}
