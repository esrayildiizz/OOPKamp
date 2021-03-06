using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm
{
    internal class Yemek
    {
        public string PismeSuresi { get; set; } 
        public string Malzemeler { get; set; }  
        public string AciTipi { get; set; } 
        public string Asci { get; set; }    
        public string PismeSekli { get; set; }  
        public string PismeYeri { get; set; }   


         public  virtual string SunumSekli()
        {
            return "Yanında az pilav ve salata ile.";
         }

        /*
         
         * virtual: virtual komutu ile işaretlenmiş metot isteğe bağlı olarak türetilen 
         sınıflarda değiştirilebilir anlamına gelmektedir. Yani bu metot ezilebilir denilmiş olur.
        
         */
    }
}
