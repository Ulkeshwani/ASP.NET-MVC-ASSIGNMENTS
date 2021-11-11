using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneDemo
{
    public class Customer
    {
        public string Name = "Default";
        public int Age = 10;
        public  string Address = "Default";

        public Customer() { }

        public Customer(string Name,int Age,string Address)
        {
            this.Name = Name;
            this.Age = Age;
            this.Address = Address;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Name {0} , Age {1}, Address {3}", Name, Age, Address);
        }
    }
}
