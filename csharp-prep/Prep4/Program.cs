using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List<int> numbers = new List<int>();

        int response = 1;
        while (response != 0)
        {
            Console.Write("Enter a number: ");
            response = int.Parse(Console.ReadLine());
            if (response == 0)
            {
                break;
            }
            numbers.Add(response);
        }

        int sum = 0;
        int maximum = numbers[0];
        foreach (int number in numbers)
        {
            sum += number;
            if (number > maximum)
            {
                maximum = number;
            }
        }

        int average = sum / numbers.Count();

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Maximum: {maximum}");




    }
}