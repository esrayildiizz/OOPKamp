using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Urun
    {

        private string adi;
      
        public string Adi
        {
            get
            {
                return adi;
            }
            set
            {
                adi= value; 
            }
        }

        private string soyadi;

        public string Soyadi
        {
            get
            {
                return soyadi;
            }
            set
            {
                soyadi= value;
            }
        }

    }

}
