using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsSamples
{
    class Product
    {
        public int productCode;
        public double price;
        public string productName;
        public string company;


        public Product()
        {
            productCode = 0;
            price = 0d;
            productName = "";
            company = "";
        }

        public Product(int productCode, double price, string productName, string company)
        {
            this.productCode = productCode;
            this.price = price;
            this.productName = productName;
            this.company = company;
        }

        public override string ToString()
        {
            return string.Format("Company Name -: {0}\n Product Code: - {1} \n Product Name: - {2} \n Price:-{3} \n",this.company, this.productCode, this.productName,this.price);
        }

    }


}
