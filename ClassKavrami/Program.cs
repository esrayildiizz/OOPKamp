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

            //MyClass m1 = new MyClass(); //MyClass sınıfından m1 adlı bir nesne oluşturduk.
            //m1.a = 20;
            //MyClass m2 = new MyClass();
            //m2.a = 30;

        }

    }
    class MyClass
    {
        int yasi; 
       string b;

        //#region Full Property
        //Property hangi türden bir field'ı temsil ediyorsa o türden olmalıdır.
        //Propertyler temsil ettikleri field'ların isimlerinin başharfi büyük olacak şekilde isimlendirilir.

        public int Yasi
        {
            get
            {
                //Property üzerinde değer talep edildiğinde bu blok tetiklenir.
                //Yani değer buradan gönderilir.
                return yasi;
            }
            set
            {


            }
        }






    }





}

