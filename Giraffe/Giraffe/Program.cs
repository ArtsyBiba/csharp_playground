using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name ");
            string userName = Console.ReadLine();
            Console.WriteLine(PrintName(userName));
        }

        static string PrintName(string name)
        {
            string greeting = "Hello " + name;

            return greeting;
        }
    }
}
