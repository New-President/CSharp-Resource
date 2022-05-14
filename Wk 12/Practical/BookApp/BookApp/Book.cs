using System;
using System.Collections.Generic;
using System.Text;

namespace BookApp
{
    internal class Book
    {
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Qty { get; set; }

        public Book() { }

        public override string ToString()
        {
            return "Id: " + Id + "\tIsbn: " + Isbn +
                   "\tTitle: " + Title + "\tAuthor: " + Author +
                   "\tPages: " + Pages + "\tQty: " + Qty;
        }
    }
}
