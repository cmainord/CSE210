using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        Menu mainMenu = new Menu
        (
            "Goal Tracker (ENTER to select, ESC to quit)",
            [
                "1. Create New Goal",
                "2. List Goals",
                "3. Save Goals",
                "4. Load Goals",
                "5. Record Event"
            ]
        );

        bool run = true;
        while(run)
        {   
            switch(mainMenu.Run())
            {
                case 0:
                    Console.Clear();
                    Goal goal = new Goal();
                    goal.Display();
                    Console.Read();
                    break;
                case 1:
                    //option
                    break;
                case 2:
                    //option
                    break;
                case 3:
                    //option
                    break;
                case 4:
                    //option
                    break;
                case -1:
                    //option
                    run = false;
                    Console.Clear();
                    break;
            }
        }

    }
}