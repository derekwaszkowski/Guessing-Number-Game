using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
This simple program prompts the use to guess a number between 1 and 10.
If the user is incorrect they will be guided by told if they were to high or to low. 
Once the correct number has been guessed the program will close.
 */

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int number = rnd.Next(1, 11);
            bool run = false;

            int[] guesses = new int[9];

            while (!run)
            {
                try
                {
                    Console.WriteLine("Please guess a number between 1 and 10.");
                    int guess = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < guesses.Length; i++)
                    {
                        guesses[i] = guess;
                    }
                    if (number == guess)
                    {
                        Console.WriteLine($"Congrats {guess} was the correct answer!");
                        run = true;
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine($"Sorry {guess} is too low.");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine($"Sorry {guess} is too high.");
                    }
                }

                catch (FormatException fex)
                {
                    Console.WriteLine("This is not a number. Please try again.");
                }


            }

            Console.Read();
        }
    }
}
