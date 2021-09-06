using System;

namespace Karcher_ParsingAndFormatting
{
    class Program
    {
        /* Author: Jonathan Karcher
         * Purpose: This is a number guessing game where the player has 8 trys to guess the unknown number between 0 and 100 and will be notified if their guess was to high or to low
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            // Create a new random object
            Random rand = new Random();
            // This is a newly generated number that the player will try to guess
            int number = rand.Next(0, 101);
            // This is the number of guesses the player has used
            int guesses = 0;
            // This is the players guess once parsed to an int
            int guess = 0;
            // This is the players input
            string input;

            // If we have not made 8 guesses
            while (guesses < 8)
            {
                // Tell the player what turn they are on and prompt the user for input
                Console.Write("Turn #"+(guesses + 1)+": Enter your guess: ");
                input = Console.ReadLine();
                // Check if the player entered a valid entery
                if(Int32.TryParse(input, out guess) && ( guess >= 0 ) && ( guess < 101 ))
                {
                    // If the player entered the correct number
                    if(guess == number)
                    {
                        // If the player entered the right number on the first prompt
                        if (guesses == 0)
                        {
                            // Congradualte the player and tell them how many guesses it took
                            Console.WriteLine("Correct! You won in " + (guesses + 1) + " turn.");
                        }
                        else
                        {
                            Console.WriteLine("Correct! You won in " + (guesses + 1) + " turns.");
                        }
                        break;
                    }
                    // If the guess that they entered wasnt the number stored
                    else
                    {
                        // If the guess was any value lower than the number stored
                        if(guess < number)
                        {
                            Console.WriteLine("Too low");
                        }
                        // If the guess was any value higher than the number stored
                        else
                        {
                            Console.WriteLine("Too high");
                        }
                        // Remove one of the guesses
                        guesses++;
                    }
                }
                // If they didnt enter a valid responce
                else
                {
                    Console.WriteLine("Invalid guess – try again");
                }
            }
            // If they ran out of guesses and didnt guess the correct number
            if(guesses == 8)
            {
                // tell them that they ran out of guesses and tell them what the number stored was
                Console.WriteLine("You ran out of turns. The number was " + number + ".");
            }

        }
    }
}
