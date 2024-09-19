using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        int number = new Random().Next(1, 100);
        int numberOfGuesses = 0;

        bool found = false;

        do
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            int guess = int.Parse(userInput);
            numberOfGuesses++;

            if(guess == number)
            {
                found = true;
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"Number of guesses: {numberOfGuesses}");
            }
            else if(guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if(guess > number)
            {
                Console.WriteLine("Lower");
            }
        } while (!found);
    }
}