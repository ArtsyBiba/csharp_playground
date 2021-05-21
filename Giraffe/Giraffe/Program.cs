using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "There once was a man named";

            string[] subs = phrase.Split(' ');

            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
            }
        }
    }
}
