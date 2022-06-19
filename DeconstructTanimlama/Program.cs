using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeconstructTanimlama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person
            {
                Name = "Esra",
                Age = 23
            };

            
            var (x, y) = person;

        }
    }

    class Person
    {
        public string Name { get; set; }    

        public int Age { get; set; } 

        public void Deconstruct( out string name, out int age)
        {
            name = Name;
            age=Age;    
        }
    }
}
