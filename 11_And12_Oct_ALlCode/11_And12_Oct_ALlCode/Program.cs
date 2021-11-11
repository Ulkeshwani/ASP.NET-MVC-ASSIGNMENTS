using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosOOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started");
            //  BooksDemo();
            // StudentsClassDemo();
            //InheritanceDemo();
            PolymorphismDemo();
            Console.WriteLine("Done....................");
            Console.WriteLine("Hit any key to exit............!!!");
            Console.ReadLine();
        }

        public static void BooksDemo()
        {

            Console.WriteLine("Enter Book Details as below");
            Console.WriteLine("Enter ISBN");
            string ISBN = Console.ReadLine();

            Console.WriteLine("Enter Book Name");
            string bookname = Console.ReadLine();

            Console.WriteLine("Enter Author Name");
            string authorName = Console.ReadLine();

            Console.WriteLine("Enter Price");
            string price = Console.ReadLine();

            Book objbook1 = new Book();//default constructor
            Console.WriteLine("The first Book Details are ");
            Console.WriteLine(objbook1.DisplayBookDetails());
         
            Book objbook2 = new Book("B11", "MS Azure Development", "Scott Guthrie", 1500);
            Console.WriteLine("The second Book Details are ");
            Console.WriteLine(objbook2.DisplayBookDetails());

      
           

        }


        //Student Class
        public static void StudentsClassDemo()
        {
            Student objFirstStudent = new Student();
            objFirstStudent.FullName = "Megan Craig";
            objFirstStudent.Gender = "Female";
            objFirstStudent.Qualification = "MS-CSC ";
            Console.WriteLine(objFirstStudent.DisplayStudentDetails());
            //object initializer syntax - only if properties are defined
            Student objSecondStudent = new Student()
            {   FullName="Bella Smith",
                Gender="Female",
                Qualification="MS-Data Science"
            };
            Console.WriteLine(objSecondStudent.DisplayStudentDetails());

            //for auto implemnetd prop demo
            Student objThirdStudent = new Student()
            {
                FullName = "Jen Smith",
                Gender = "Male",
                Qualification = "MS-Instrumental En"
            };
            Console.WriteLine(objThirdStudent.DisplayStudentDetails());

            Student objFourthStudent = new Student()
            {
                FullName = "ABC",
                Gender = "Male",
                Qualification = "MS-Orthopad"
            };
            //only for ToString()
            Console.WriteLine(objFourthStudent);
            Console.WriteLine(objFourthStudent.DisplayStudentDetails());
        }

        //ingeritance demo
        public static void InheritanceDemo()
        {
            Customer objCustomer = new Customer("ABC", "Male", 16, 12345, "9 th grade");
            Console.WriteLine(objCustomer);

        }

        public static void PolymorphismDemo()
        {
            Square squareObj = new Square();
            Console.WriteLine("Area={0}", squareObj.Area());

            Rectangle rectObj = new Rectangle();
            rectObj.Height = 4;
            rectObj.Width = 3;
            Console.WriteLine(rectObj.Area());

            Circle Circleobj = new Circle();
            Console.WriteLine(Circleobj.Area());
        }
    }
}
