using System;

class Program
{
    static List<Scripture> scriptures = new List<Scripture>();

    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello Develop03 World!");
        PopulateScriptures();
        Scripture scripture = SelectScripture();
        Run(scripture);
    }

    static void PopulateScriptures()
    {
        scriptures.Add(new Scripture("this is test scripture number one, which has only one verse", "Steve", 3, 5));
        scriptures.Add(new Scripture("this is test scripture number two, which has two verses. Here is the second one.", "Bob", 5, 10, 11));
        scriptures.Add(new Scripture("this is test scripture number three, which has three verses.This is the second one. This is the third one.", "George", 12, 2, 4));
    }


    static Scripture SelectScripture()
    {
        Random rng = new Random();
        int rand;

        rand = rng.Next(scriptures.Count);

        return scriptures[rand];
    }

    static void Run(Scripture scripture)
    {
        bool keepRunning = true;
        while(keepRunning)
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("\nPress enter to hide some words, enter Q to quit.");
            
            string userInput = Console.ReadLine();
            
            if (userInput == "q")
            {
                keepRunning = false;
                Console.Clear();
            }

            else
            {
                scripture.HideWords(2);
            }
            
            
        }
    }
}