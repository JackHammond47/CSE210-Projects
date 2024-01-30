using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int randNum = rand.Next(1,100);
        string guess = "0";
        int guessInt = int.Parse(guess);
        while (guessInt != randNum)
        {
            Console.Write("Guess a number between 1 and 100: ");
            guess = Console.ReadLine();
            guessInt = int.Parse(guess);
            if (guessInt > randNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guessInt < randNum)
            {
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("You've guessed it! ");
            }
        }
    }
}