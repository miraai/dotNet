using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class Games
    {
        public static void TestGame()
        {
            Console.WriteLine("What are the spaceships made of?");
            var answer = Console.ReadLine();
            if (answer.ToLower() == "love")
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Sorry, your answer doesn't have any love in it.");
            }
        }

        public static void GuessGame()
        {
            Console.WriteLine("Guess the correct number: ");

            int correctNumber = new Random().Next(5) + 1;
            int guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber == correctNumber)
            {
                Console.WriteLine("Yes.");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine($"Correct number is: {correctNumber}");

            Console.ReadLine();
        }

        public static void WhileGuess()
        {

            int numberToGuess = new Random().Next(1, 51);
            Console.WriteLine($"Number is {numberToGuess}");
            int currentGuess = 0;

            while (currentGuess != numberToGuess)
            {
                Console.WriteLine("Guess the correct number: ");
                currentGuess = int.Parse(Console.ReadLine());
                if (currentGuess < numberToGuess)
                {
                    Console.WriteLine("Cold more. Try again.");
                }
                if (currentGuess > numberToGuess)
                {
                    Console.WriteLine("Hot more. Try again.");
                }
            }

            Console.WriteLine("And the red cloud swallowed the sky!");
            Console.ReadLine();
        }
    }
}
