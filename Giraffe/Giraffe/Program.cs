using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("JK Rowling", "Harry Potter", 431, "English");
            Console.WriteLine(Book.bookCount);
            Book book2 = new Book("Tolkien", "Lord of The Rings", 645, "Spanish");

            Console.WriteLine(Book.bookCount);
            book2.PrintLanguage();
        }

    }
}
