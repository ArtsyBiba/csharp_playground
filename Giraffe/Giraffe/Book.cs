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
        private string language;
        public static int bookCount = 0;

        public Book(string author, string title, int pages, string language)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            Language = language;
            bookCount++;
        }

        public string Language
        {
            get { return language; }
            set
            {
                if(value == "English" || value == "French")
                {
                    language = value;
                } else
                {
                    language = "n/a";
                }
            }
        }

        public void PrintLanguage()
        {
            Console.WriteLine(language);
        }
    }
}
