using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your second number ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your operator ");
            string oper = Console.ReadLine();

            if (oper == "*") 
            {
                Console.WriteLine(firstNumber * secondNumber);
            } else if (oper == "/")
            {
                Console.WriteLine(firstNumber / secondNumber);
            } else if (oper == "+")
            {
                Console.WriteLine(firstNumber + secondNumber);
            } else if (oper == "-")
            {
                Console.WriteLine(firstNumber - secondNumber);
            } else
            {
                Console.WriteLine("One of your inputs was invalid");
            }
            
        }
    }
}
