using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int numbersquared = SquareNumber(number);
        DisplayResult(name, numbersquared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int numbersquared = number * number;
        return numbersquared;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}.");
    }


}