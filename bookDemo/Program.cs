/*Create an application named BookDemo that declares and demonstrates objects of the Book class and its descendents. 
 * The Book class includes auto-implemented properties for:
    - ISBN 
   - title 
   - author
   - price
 Create a child class named TextBook that includes a grade level and a CoffeeTableBook child class
 that contains no additional fields or properties. 
  In the child classes, override the accessor that sets a Book price so that TextBooks
  - priced at or below $20 cost $10 more 
  - priced at or above $80 cost

 CoffeeTable Books
  - priced at or below $35 cost $5 less
 - priced at or above $100 cost $10 more
*/

using System;
using static System.Console;
namespace Chapter10BookDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Book NewNovel = new Book();
            Book Novel = new Book("48577-XC", "Moby Dick", "Herman Melville", 15);
            TextBook History = new TextBook("567756-DD", "This is History", "James Washington", 125, 5);
            CoffeeTableBook Airplanes = new CoffeeTableBook("33190-CC", "Boeing ", "Betty Gravison", 35);

            WriteLine(Novel.ToString());
            WriteLine(History.ToString());
            WriteLine(Airplanes.ToString());
        }
    }//end program
    class Book
    {
       public string ISBN { get; set; }
       public string Title { get; set; }
       public string Author { get; set; }
       public double price;

       public virtual double Price
       {
            set { price = value; }
            get { return price; }
       }
        //constructor parameterless
        public Book()
        { }
        //constructor
        public Book(string code, string title, string author, double price)
        {
            ISBN = code;
            Title = title;
            Author = author;
            this.price = price;
        }
        public override string ToString()
        {
            return ("\n" + GetType().Name + "\n ISBN: "+ ISBN + "\n Book Title: " + Title + "\n Author: " + Author + "\n Price: " + Price.ToString("c"));
        }
    }//Book
    class TextBook : Book
    {
        public int Grade { get; set; }
        public override double Price
        {
            get
            {
                if (base.Price <= 20)
                    this.price = base.Price + 10;
                if (base.Price >= 80)
                    price = base.Price + 20;
                return price;
            }
        }
        //constructor
        public TextBook(string code, string title, string author, double price, int grade) : base(code, title, author, price)
        {
            Grade = grade;
        }

        public override string ToString()
        {
            return (base.ToString() + "\n This book intended for Grade: " + Grade);
        }
    }//end TextBook

    class CoffeeTableBook : Book
    {
        public override double Price
        {
            get
            { 
                if (base.Price <= 35)
                    price = base.Price - 5;
                if (base.Price >= 100)
                        price = base.Price + 10;
                return price;
            }
        }
        //constructor
        public CoffeeTableBook(string code, string title, string author, double price) : base(code, title, author, price)
        {
            ISBN = code;
            Title = title;
            Author = author;
            this.price = price;
        }

    }//end CoffeeTableBook
}
