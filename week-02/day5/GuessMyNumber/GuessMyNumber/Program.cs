using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess My Number");
            Console.WriteLine("Give me the value of the range!");

            Console.WriteLine("Write down the start of the range:");
            int LowerLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Write down the end of the range:");
            int UpperLimit = int.Parse(Console.ReadLine());

            Random r = new Random();

            int val = r.Next(LowerLimit, UpperLimit);
            int Attempts = 5;
            int guess = 0;
            bool correct = false;
            Console.WriteLine("I'm thinking of a number between" + " " + LowerLimit + " " + "and" + " " + UpperLimit + ", be cautios you only have 5 lives" + ".");

            while (!correct)
            {
                Console.WriteLine("Guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("That's not a number dummy!");
                }

                if (guess < val)
                {
                    Attempts--;
                    Console.WriteLine("No, my number is higher than that! You have {0} lives left.",Attempts);
                }
                else if (guess > val)
                {
                    Attempts--;
                    Console.WriteLine("No, my number is lower than that! You have {0} lives left.",Attempts);
                }
                else
                {
                    correct = true;
                    Console.WriteLine("Congratulation, you guessed it right, have an awesome day! :)");
                }
                if (Attempts == 0)
                {
                    Console.WriteLine("You are dead, dumbass ! You suck :3");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}