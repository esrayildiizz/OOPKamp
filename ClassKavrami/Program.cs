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





            //#region Property

            //MyClass myClass = new MyClass(); //MyClass sınıfından myClass adlı bir nesne oluşturduk.
            //myClass.Yasi = 55;
            //Console.WriteLine(myClass.Yasi);

            //Console.ReadLine();

        }

    }



    //#Class elemanlarına açıklama satırı nasıl eklenir. MyClass ın üst kısmına gelip üç tane /// eklersen aşağıdaki gibi açıklama satırı eklemiş olursun.
    // Yazdığın açıklamayı görebilmek için class ın üstüne gelmek yeterli olur.




    /// <summary>
    /// Bu bir örnek class tır.
    /// </summary>
    class MyClass 
    {
        //int yasi; 
        //string b;

        //#region Full Property
        //Property hangi türden bir field'ı temsil ediyorsa o türden olmalıdır.
        //Propertyler temsil ettikleri field'ların isimlerinin başharfi büyük olacak şekilde isimlendirilir.

        //public int Yasi
        //{
        //    get
        //    {
        //        //Property üzerinde değer talep edildiğinde bu blok tetiklenir.
        //        //Yani değer buradan gönderilir.
        //        return yasi;
        //    }
        //    set
        //    {
        //        yasi= value;    

        //    }
        //}




        //#region Prop Property

        //public int Yasi { get; set; }   
        //Prop kullanıyorsak kendi field'ımızı kullanmıyoruz.



    }





}

