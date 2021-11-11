using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace DemosOOPs
{
    public class Book
    {
        //data members
        private string isbn;
        private string bookTitle;
        private string author;
        private int price;
        //default  constructor
        public Book()
        {
            //deafult values
            this.isbn = "A11";
            this.bookTitle = "Python programming";
            this.author = "Jonatahan Wright";
            this.price = 975;
        }
        //parametric constructor
        public Book(string isbn, string bookTitle, string author, int price)
        {
            this.isbn = isbn;
            this.bookTitle = bookTitle;
            this.author = author;
            this.price = price;
        }

        //fucntions

        public string DisplayBookDetails()
        {
            string bookDetails = string.Format("ISBN- {0}  , Name - {1}  Author - {2}  Price -  {3}", this.isbn, this.bookTitle, this.author, this.price);
            return bookDetails;
        }
    }
}
