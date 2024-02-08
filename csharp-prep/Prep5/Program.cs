using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program");
        }
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }
        static int SquareNumber(int number)
        {
            int numberSquared = number * number;
            return numberSquared;
        }
        static void DisplayResult(string name, int numberSquared)
        {
            Console.WriteLine($"{name}, the square of your number is {numberSquared}");
        }
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int numberSquared = SquareNumber(number);
        DisplayResult(name, numberSquared);
    }
}