using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter your grade percentage: ");
        float gradePercent = float.Parse(Console.ReadLine());
        
        string gradeLetter = "";
        bool pass = false;
        
        if (gradePercent <= 60)
        {
            gradeLetter = "F";
        }
        else if (gradePercent <= 70)
        {
            gradeLetter = "D";
        }
        else if (gradePercent <= 80)
        {
            pass = true;
            gradeLetter = "C";
        }
        else if (gradePercent <=90)
        {
            pass = true;
            gradeLetter = "B";
        }
        else
        {
            pass = true;
            gradeLetter = "A";
        }

        Console.Write($"Your grade is {gradeLetter}. ");

        if (pass)
        {
            Console.Write("You passed the course.");
        }
        else
        {
            Console.Write("You failed the course.");
        }
    }
}