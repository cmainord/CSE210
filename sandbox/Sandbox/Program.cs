using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("Hello");


        int counter = 10;
        while(counter > 0)
        {
            Console.Clear();
            Console.Write(counter);
            Thread.Sleep(1000);
            counter -= 1;
        }
        
        
    }
}

/*

Console.WriteLine() prints, then moves to next line
Console.Write() prints and doesn't move to next line
Console.ReadLine() returns what is written in the current line of the console, then moves to the next line
Console.Read() returns what is written in the current line of the console

public void WriteToFile(string filename)
public void ReadFromFile(string filename)

*/