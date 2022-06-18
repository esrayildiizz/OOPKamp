using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region this Keyword
            #region 1-Sınıfın nesnesini temsil eder.

            MyClass m1 = new MyClass();
            MyClass m2 = new MyClass();  


            #region 2-Aynı isimde field ile metot parametrelerini ayırmak için kullanılır.
            #region 3-Bir Constructer'dan başka bir Constructer'ı çağırmak için kullanılır.
        }
    }
    class MyClass
    {
        public void X()
        {
            this.X();
        }
    }
}
