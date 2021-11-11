using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosOOPs
{
   //base class
    public class Person
    {
        protected string fullName;
        protected string gender;
        protected int age;
        protected int contact;
        //default cons
        public Person()
        {
            fullName = "Elina Smith";
            gender = "female";
            age = 25;
            contact = 11224;

        }
        //parametric cons or -------
        public Person(string fullName, string gender, int age, int contact)
        {
            this.fullName = fullName;
            this.age = age;
            this.gender = gender;
            this.contact = contact;
        }

        //public string FullName {
        //    get { return this.fullName; }
        //}
        public string DisplayDetails()
        {
            string str = string.Format("Name={0}\t Age={1}\t Gender={2}\t Contact={3}", this.fullName, this.age, this.gender, this.contact);
            return str;
        }

        public override string ToString()
        {
            return string.Format("Name={0}\t Age={1}\t Gender={2}\t Contact={3}", this.fullName, this.age, this.gender, this.contact);
        }
    }

}
