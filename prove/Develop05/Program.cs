using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Goals;

//look up satic functions after sleeping

class Program
{
    static readonly List<Goal> goals = new();
    static void Main(string[] args)
    {
        int points = 0;
        int tacos = 0;
        while (true)
        {
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine($"You have {tacos} tacos, you can use them buy tacos. But they'll disappear when the session ends.");
            Console.WriteLine();
            if (points > 100)
            {
                Console.WriteLine("Would you like to redeem your points for tacos? ");
                string tacoChoice = Console.ReadLine();
                if (tacoChoice.ToLower() == "yes" || tacoChoice.ToLower() == "y")
                {
                    tacos += points / 100;
                    points %= 100;
                }
                else
                {
                    Console.WriteLine("You made a bad choice buddy...");
                }
                continue;
            }

            Console.WriteLine("\nMenu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit\n");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            if (choice == "6")
            {
                break;
            }
            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    Console.WriteLine("List of Goals: ");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        goals[i].ListGoal(i);
                    }
                    break;
                case "3":
                    Console.WriteLine("What is the filename for the goal file? ");
                    string savefilename = Console.ReadLine();
                    using (StreamWriter outputFile = new(savefilename))
                    {
                        outputFile.WriteLine(points);
                        foreach (Goal goal in goals)
                            outputFile.WriteLine(goal.Save());
                    }
                    break;
                case "4":
                    Console.WriteLine("What is the filename for the goal file? ");
                    string loadfilename = Console.ReadLine();
                    string[] lines = File.ReadAllLines(loadfilename);
                    points = int.Parse(lines[0]);
                    lines = lines.Skip(1).ToArray();
                    foreach (string line in lines)
                    {
                        string[] goal = line.Split(':');
                        switch(goal[0])
                        {
                            case "SimpleGoal":
                                goals.Add(SimpleGoal.Load(goal[1]));
                                break;
                            case "EternalGoal":
                                goals.Add(EternalGoal.Load(goal[1]));
                                break;
                            case "ChecklistGoal":
                                goals.Add(ChecklistGoal.Load(goal[1]));
                                break;
                            default:
                                continue;
                        }
                    }
                    break;
                case "5":
                    Console.WriteLine("List of Goals: ");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        goals[i].ListGoal(i);
                    }
                    Console.WriteLine("What goal did you accomplish? ");
                    int goalAccomplished = 0;
                    while (!int.TryParse(Console.ReadLine(), out goalAccomplished))
                    {
                        Console.WriteLine("ERROR. Please enter an integer.");
                        Console.WriteLine("What goal did you accomplish? ");
                    }
                    points+= goals[goalAccomplished - 1].RecordEvent();
                    break;
                default:
                    continue;
            }
        }
    }

    static void CreateNewGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("What type of goal would you like to create? ");
        string choice2 = Console.ReadLine();
        Console.WriteLine("what is the name of this goal? ");
        string goalName = Console.ReadLine();
        Console.WriteLine("what is a short description of it? ");
        string goalDesc = Console.ReadLine();
        Console.WriteLine("How many points are associated with this goal? ");
        int goalPoints = 0;
        while (!int.TryParse(Console.ReadLine(), out goalPoints))
        {
            Console.WriteLine("ERROR. Please enter an integer.");
            Console.WriteLine("How many points are associated with this goal? ");
        }
        switch (choice2)
        {
            case "1":
                goals.Add(new SimpleGoal(goalName, goalDesc, goalPoints));
                break;
            case "2":
                goals.Add(new EternalGoal(goalName, goalDesc, goalPoints));
                break;
            case "3":
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                int goalAmount = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                int goalBonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(goalName, goalDesc, goalPoints, goalAmount, goalBonus));
                break;
            default:
                break;
        }
        

    }
}