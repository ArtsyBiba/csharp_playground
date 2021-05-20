using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Alex";
            char grade = 'A';

            int characterAge = 55;
            double floatAge = 27.5;

            bool isMale = true;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + grade);
            Console.WriteLine("But he didn't like being " + floatAge);
        }
    }
}
