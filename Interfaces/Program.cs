using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Esra", LastName = "Yıldız", Address = "Sakarya" });

            Console.ReadLine();
        }
    }

    interface IPerson 

    {
         int Id { get; set; }
         string FirstName { get; set; }    
         string LastName { get; set; }  


    }

    class Customer : IPerson

    {
        public int Id { get ; set ; }
        public string FirstName { get; set; }
        public string LastName { get ; set; }


        public string Address { get; set; } 
    }


    class Student : IPerson

    {
        public int Id { get ; set ; }
        public string FirstName { get  ; set ; }
        public string LastName { get; set ; }


        public string Departmant { get; set; }
    }


    class PersonManager

    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName);
        }
    }
}
