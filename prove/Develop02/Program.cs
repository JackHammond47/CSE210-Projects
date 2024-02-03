using System;
using System.IO;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string filename = "Journal.txt";
        Journal journal = new Journal();
       string userChoice = "1";
       while (userChoice != "6")
       {
        Console.WriteLine("Please type a choice number from 1-6.");
        Console.WriteLine("Choice 1: Write new entry.");
        Console.WriteLine("Choice 2: Display past entries.");
        Console.WriteLine("Choice 3: Save entries to file.");
        Console.WriteLine("Choice 4: Load entries from file.");
        Console.WriteLine("Choice 5: Modify prompt generator.");
        Console.WriteLine("Choice 6: Quit.");
        //I added another choice to add prompts to the prompt generator.
        userChoice = Console.ReadLine();

        switch (userChoice)
        {
            case "1":
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                Entry entry = new Entry();
                entry._prompt = prompt;
                entry._response = response;
                entry._entryDate = DateTime.Now;
                journal._entries.Add(entry);
                break;
            case "2":
                foreach (Entry singleEntry in journal._entries)
                {
                    Console.WriteLine($"{singleEntry._entryDate} {singleEntry._prompt} {singleEntry._response}");
                }
                break;
            case "3":
                using (StreamWriter outputFile = File.AppendText(filename))
                {
                    foreach (Entry singleEntry in journal._entries)
                    {
                        outputFile.WriteLine($"{singleEntry._entryDate} {singleEntry._prompt} {singleEntry._response}");
                    }
                }
                break;
            case "4":
                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                break;
            case "5":
                Console.WriteLine("The current Prompt List is: ");
                promptGenerator.GetPromptList();
                Console.WriteLine("Would you like to add to this list? (y or n)");
                string changePrompts = Console.ReadLine();
                while (changePrompts != "n")
                {
                    Console.WriteLine("What is the new prompt: ");
                    string newPrompt = Console.ReadLine();
                    promptGenerator.addToPrompts(newPrompt);
                    Console.WriteLine("Would you like to add another prompt? (y or n)");
                    changePrompts = Console.ReadLine();  
                } 
                break;
            case "6":
                break;
        }
       }
    }
}