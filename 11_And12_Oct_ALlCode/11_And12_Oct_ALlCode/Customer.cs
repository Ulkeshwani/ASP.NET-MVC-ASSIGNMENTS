using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosOOPs
{
    public class Customer : Person
    {
        private string qualification;

        public Customer():base()
        {
            this.qualification = "Mtech";
        }
        public Customer(string fullName, string gender, int age, int contact, string qualification) : base(fullName, gender, age, contact)
        {
            this.qualification = qualification;
        }

        public override string ToString()
        {
            return base.ToString() + "\tQualification =" + this.qualification;
        }
    }
}
