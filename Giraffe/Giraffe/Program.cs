using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int count = 5;
            bool isWinner = true;

            while (guess != secretWord) 
            {
                if (guess == "" && count > 0)
                {
                    Console.WriteLine("Guess an animal: ");
                } else if (guess != "" && count > 0)
                {
                    Console.WriteLine($"Try again, you have {count} guesses left: ");
                } else
                {
                    isWinner = false;
                    break;
                }
                
                guess = Console.ReadLine();
                count--;
            }
            
            if (isWinner)
            {
                Console.WriteLine("Cograts, you guessed it right!");
            } else
            {
                Console.WriteLine("Sorry, you ran out of guesses!");
            }
            
        }

    }
}
