using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffe
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string author, string title, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        public void PrintTitle()
        {
            Console.WriteLine(title);
        }
    }
}
