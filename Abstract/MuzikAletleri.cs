using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class MuzikAletleri
    {
        /*
         * Abstract(soyut):
         * Abstract sınıflar sadece miras verilmek için tasarlanan sınıflardır.
         * Abstractlar sınıfa özel değil, bir property , bir metot veya herhangi bir eleman abstract olabilir.
         *
         */

        public virtual string Cal()
        {
            return "Müzik Aleti çalınıyor.";
        }




    }
}
