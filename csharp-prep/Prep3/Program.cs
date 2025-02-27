using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //Console.Write("Enter the magic number: ");
        //int magicNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        int guessNumber = magicNumber-1;

        while (magicNumber != guessNumber)
        {
            Console.Write("Guess the magic number: ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber == magicNumber)
            {
                Console.WriteLine("You guessed the number.");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        }

        
    }
}