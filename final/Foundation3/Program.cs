using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        
        Lecture lecture = new Lecture
        (
            "He Who Hath Smelt It is He Who Hath Dealt It",
            "In this lecture, Dr. Doofenheimer will explore the application of game theory to everyday life, using, as a frame of reference, the timeless dictum: 'he who smelt it dealt it'. ",
            new Date(4, 1, 2167),
            new Time(0,30,16),
            new Address("123 University Blvd.", "Yew Nork", "Yew Nork", "USA"),
            "Hansel Doofenheimer, MD, PhD, DMA, MFA",
            50000
        );

        Reception reception = new Reception
        (
            "My Sister Got Married, Yay.",
            "Join us to celebrate yet another wedding, this time of Mikhail Slavikovskikoff and Jane Berryapple. We celebrate the joining of two families, though only one of us actually gets a husband out of it. There will be a meal and refreshments, provided entirely by the lovely and college educated sister of the bride, but for what? Hope to see you there!",
            new Date(7, 10, 2025),
            new Time(0,30,12),
            new Address("59 Happy St.", "Boise", "Idaho","USA"),
            "penelopeberryapple@gmail.com"
        );

        OutdoorGathering outdoorGathering = new OutdoorGathering
        (
            "The Footrace of Destiny",
            "Witness the most glorious battle of our generation, a clash of legends, a showdown between rivals prophesied long ago and which will be told of in song and story for generations to come. It has all come to this: Jimmy James and Bobby Barnes will face each other, one on one, man to man, at the Madison High School Track and decide, once and for all, who can run faster. Come and bear witness to history.",
            new Date(1, 20, 2020),
            new Time(0,0,2),
            new Address("12 Whatever St.", "Rexburg", "Idaho", "USA"),
            "Overcast, windy, and below freezing"
        );

        Console.Write("\nEVENT 1 - ");
        lecture.DisplayDetails();
        Console.Write("\nEVENT 2 - ");
        reception.DisplayDetails();
        Console.Write("\nEVENT 3 - ");
        outdoorGathering.DisplayDetails();
    }
    
}