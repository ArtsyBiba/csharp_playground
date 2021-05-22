using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("JK Rowling", "Harry Potter", 431);
            Book book2 = new Book("Tolkien", "Lord of The Rings", 645);

            book1.PrintTitle();
            book2.PrintTitle();
        }

    }
}
