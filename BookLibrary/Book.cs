using System;

namespace BookLibrary
{
    public class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return Title + " " + Price;
        }
    }
}
