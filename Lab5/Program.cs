using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            String userGuess;
            int randomNumber;
            int guess;
            int total = 1, low = 0, high = 0;

            Random ranNum = new Random();

            for (int i = 0; i < 5; i++)
            {
                randomNumber = ranNum.Next(0, 101);
                Console.WriteLine(randomNumber);

                Console.WriteLine("Enter with your guess: ");
                userGuess = Console.ReadLine();
                guess = Convert.ToInt32(userGuess);

                while (guess != randomNumber)
                {
                    while (guess < randomNumber)
                    {
                        Console.WriteLine("Your guess is lower.");
                        Console.WriteLine("Enter with your new guess: ");
                        userGuess = Console.ReadLine();
                        guess = Convert.ToInt32(userGuess);
                        ++total;
                        ++low;
                    }
                    while (guess > randomNumber)
                    {
                        Console.WriteLine("Your guess is higher.");
                        Console.WriteLine("Enter with your new guess: ");
                        userGuess = Console.ReadLine();
                        guess = Convert.ToInt32(userGuess);
                        ++total;
                        ++high;
                    }
                    while (guess == randomNumber) 
                    {
                    Console.WriteLine("Your guess is right");
                        break;
                   }
                    Console.WriteLine("You tried {0} guesses to get {1}", total, randomNumber);
                }
            }
        }
    }
}

