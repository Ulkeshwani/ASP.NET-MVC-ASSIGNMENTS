using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsSamples
{
    class Program
    {
        public static void Main(string[] args)
        {

            string companyName, productName;
            float price;
            int productCode, count;

            List<Product> products = new List<Product>();

            Console.WriteLine("How many Products Do You Wants? :-");
            count = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter Product Code :");
                productCode = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Product Name :");
                productName = Console.ReadLine();

                Console.WriteLine("Enter Product Price :");
                price = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Product Company :");
                companyName = Console.ReadLine();

                products.Add(new Product(productCode, price, productName, companyName));
            }

            Console.WriteLine("\nThe Products Details are -:");

            foreach (Product product in products)
            {
                Console.WriteLine("==============================================");
                Console.WriteLine(product);
            }

            //Program[] products = new Program[5];
            //for(int i = 0; i < 5; i++)
            //{
            //    products[i] = new Program();
            //    Console.WriteLine("Enter {0} product Detail", i+1);
            //    products[i].SetDetails();
            //    Console.WriteLine("===============================");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Product {0} Details", i + 1);
            //    products[i].DisplayDetails();
            //}
        }
    }
}
