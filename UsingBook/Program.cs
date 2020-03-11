using System;
using BookLibrary;

namespace UsingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Book book = new Book();
            book.Title = "lal";
            book.Price = 20;

            Console.WriteLine(book.ToString());
            
        }
    }
}
