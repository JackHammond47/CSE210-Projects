using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade Percentage");
        string gradeFloat = Console.ReadLine();
        int gradeInt = int.Parse(gradeFloat);
        string grade = "F";
        string pass = "N";
        if (gradeInt >= 90)
        {
            grade = "A";
            pass = "Y";
        }
        else if (gradeInt >= 80)
        {
            grade = "B";
            pass = "Y";
        }
        else if (gradeInt >= 70)
        {
            grade = "C";
            pass = "Y";
        }
        else if (gradeInt >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        Console.WriteLine(grade);
        if (pass == "Y")
        {
            Console.WriteLine("Congrats! You passed the class!");
        }
        else
        {
            Console.WriteLine("Oh no, You've failed big time buddy!");
        }
    }
}