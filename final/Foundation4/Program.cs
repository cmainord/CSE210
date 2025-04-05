using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        Date today = new Date(4, 5, 2025);
        Time genericDuration = new Time(30, 6, 0);

        List<Activity> activities = 
        [
            new RunningActivity
            (
                today,
                new Time(0, 0, 1),
                1
            ),

            new CyclingActivity
            (
                today,
                new Time(0, 0, 1),
                25.32f
            ),

            new SwimmingActivity
            (
                today,
                new Time(0, 0, 1),
                20
            )
        ];

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"\n{activity.GetSummary()}");
        }
    }
}