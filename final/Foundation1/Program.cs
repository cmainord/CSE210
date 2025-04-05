using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = 
        [
            new Video
            (
                "man punches cat",
                "neature_walker",
                new Time(13),
                [
                    new Comment
                    (
                        "steve97",
                        "wtf did I just watch?"
                    ),

                    new Comment
                    (
                        "maddest lad",
                        "I see the algorithm has brought us together once again. See you all again in 10 years!"
                    ),

                    new Comment
                    (
                        "onlyfans.com/hunnybuns",
                        "Wow! This is so funny!"
                    ),
                ]
            ),

            new Video
            (
                "Why a Theocratic Communist Monarchy is the Most Efficient Form of Government",
                "Suckrates",
                new Time(26, 47),
                [
                    new Comment
                    (
                        "obamalover44",
                        "nice"
                    ),

                    new Comment
                    (
                        "Greg23",
                        "@obamalover44 nice"
                    ),

                    new Comment
                    (
                        "AtheistGamer69",
                        "lol imagine thinking religion is the basis for a serious government."
                    ),

                    new Comment
                    (
                        "sk8erdudebro",
                        "@AtheistGamer69 touch grass"
                    )

                ]
            ),

            new Video
            (
                "The Duct Tape Iceberg Explained",
                "Mikey2424",
                new Time(32, 21, 3),
                [
                    new Comment
                    (
                        "DiNgUsAuRuS",
                        "First"
                    ),

                    new Comment
                    (
                        "darkshadow87",
                        "23:31 made me lol. edit: 51:03 so true"
                    ),

                    new Comment
                    (
                        "Sir Chaddicus III",
                        "I am a simple man, I see a Mikey2424 video with duct tape in the thumbnail, I click."
                    ),

                ]
            )
        ];

        Console.Clear();
        foreach(Video video in videos)
        {
            Console.WriteLine();
            video.Display();
        }
        Console.ReadLine();
        Console.Clear();
    }
}