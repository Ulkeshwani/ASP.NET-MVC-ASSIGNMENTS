//Import Classes 
using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;

namespace DayOneDemo
{

    class Algorithm
    {
        public virtual void Print()
        {
            Console.WriteLine("This is Algo Class");
        }
    }
    class Program: Algorithm
    {
        public string name { get; set; }
        public Program(string name)
        {
            this.name = name;
        }
        public override void Print()
        {
            Console.WriteLine("This is Program Class and Value is {0}",this.name);
        }
        //static void Main(string[] Args)
        //{
        //    Console.WriteLine("Enter The Number To Calculate Factorial");
        //    int Num = Convert.ToInt32(Console.ReadLine());
        //    int result = FindFactorial(Num);
        //    Console.WriteLine("Factorial of {0} is {1}", Num, result);
        //    Console.WriteLine($"Number - {Num}: Factorial - {result}");
        //    Console.WriteLine("Done");
        //}
        public static void FindMaxValue()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int maxValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                    maxValue = arr[i];
            }
            Console.Write(maxValue);
        }

        public static int FindFactorial(int Num)
        {
            int factorial = 1;
            if (Num == 0)
            {
                Console.WriteLine("Factorial of {0} is {0}",1);
            }else if(Num < 0)
            {
                Console.WriteLine("You have Entered Negative Number");
            }else
            {
               for(int i = 2; i<=Num; i++)
                {
                    factorial *= i;
                }
            }

            return factorial;
        }

        public static void Main()
        {
            Seller se = new Seller();

            se.DisplayDetails();
        }
    }
}
