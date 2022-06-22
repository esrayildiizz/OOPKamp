using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    internal class Ogrenci
    {
        public string Adi { get; set; } 
        public string Soyadi { get; set; }  
        public  Alan  Alani  { get; set; }  
        
    }

   
    // String şeklinde enumların içerisine değer yazılmaz.
    // Enum içerisindeki seçenek bir kelimeden fazla olsa bile kelimeler arasında boşluk bırakamaz.

    public enum Alan
    {
        Sayısal,
        Sözel,
        EşitAgırlık,
        dil,

    }
}
