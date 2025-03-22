using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
    
        Menu mainMenu = new Menu("Select an Activity", ["Breathing", "Listing", "Reflection"]);

        BreathingActivity breathingActivity = new BreathingActivity
        (
            "Breathing Activity",
            "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
            [30, 60, 90]
        );

        ListingActivity listingActivity = new ListingActivity
        (
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", [60, 120, 180],
            [
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            ]
        );

        ReflectionActivity reflectionActivity = new ReflectionActivity
        (
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
            [60, 120, 180],
            [
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            ],
            [
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different from other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            ]
        );

        bool run = true;
        while(run)
        {   
            switch(mainMenu.Run())
            {
                case 0:
                    breathingActivity.Run();
                    break;
                case 1:
                    listingActivity.Run();
                    break;
                case 2:
                    reflectionActivity.Run();
                    break;
            }
        }
    }
}