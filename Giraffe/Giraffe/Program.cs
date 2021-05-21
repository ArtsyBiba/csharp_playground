using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter first number: ");  
            string first = Console.ReadLine();

            Console.Write("Please, enter second number: ");
            string second = Console.ReadLine();

            Console.WriteLine("The sum is " + (Convert.ToDouble(first) + Convert.ToDouble(second)));  
        }
    }
}
