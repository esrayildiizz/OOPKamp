using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Bir class tanımlamasında tanımlanan yerde aynı isimde birden fazla class tanımlanamaz.

            //Bir class tanımlandığında o class adı bir türdür. Haliyle o türü kullanabilmek için direkt olarak class adını kullanmamız yeterlidir.


            //#region Field
            //Nesne içerisinde değer tutmamızı sağlayan alanlardır.

            MyClass m1 = new MyClass(); //MyClass sınıfından m1 adlı bir nesne oluşturduk.
            

        }

    }
    class MyClass
    {
       public int a;
       public string b; 
    }




   
}

