using System;
using System.Net;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number = 1;
        List <int> numbers = new List<int>();
        while (number != 0)
        {
            Console.WriteLine("Please enter a number, enter 0 when finished.");
            string input = Console.ReadLine();
            number = int.Parse(input);
            numbers.Add(number);
        }
        int sum = 0;
        int length = numbers.Count - 1;
        int maxNum = 0;
        foreach (int num in numbers)
        {
            sum += num;
            if (num > maxNum)
            {
                maxNum = num;
            }
        }
        float mean = ((float)sum) / length;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {mean}");
        Console.WriteLine($"The largest number is: {maxNum}");
    }
}