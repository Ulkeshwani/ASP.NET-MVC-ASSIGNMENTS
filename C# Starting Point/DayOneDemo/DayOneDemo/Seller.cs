using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneDemo
{
    public class Seller : Customer
    {
        public string SellerName;
        public int ContactNo;
        public string ShopName;

        public Seller()
        {
            this.SellerName = "Default";
            this.ShopName = "Defult";
            this.ContactNo = 0;
        }

        public Seller(string SellerName, int ContactNo, string ShopName):base()
        {
            this.SellerName = SellerName;
            this.ContactNo = ContactNo;
            this.ShopName = ShopName;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Seller Name- {0},\n Phone Number- {1},\n Shop Name- {2} \n", SellerName, ContactNo, ShopName);
        }
    }
}
