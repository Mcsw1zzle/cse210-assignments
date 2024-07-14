using System;

class Program
{ 
    static void Main(string[] args)
    { 
        Video video1 = new Video();
        video1._title = "How to cook safely in the wild";
        video1._author = "Adventure Junction";
        video1._length = 520;
        video1.AddComment("Emma", "I never learned this stuff as a kid, thank you.");
        video1.AddComment("Parker", "Super informative! I feel much less worried about bears now.");
        video1.AddComment("Jimmy", "Going camping next week, thanks for the tips.");

        Video video2 = new Video();
        video2._title = "Why the alphabet is important";
        video2._author = "The Book Club Coalition";
        video2._length = 233;
        video2.AddComment("Micheal", "I learned so much from this!");
        video2.AddComment("Jared", "I had no idea there was so much I did not know.");
        video2.AddComment("Sally", "I should have brought a notepad.");

        Video video3 = new Video();
        video3._title = "5 steps to mastering Spanish";
        video3._author = "Language Lounge";
        video3._length = 326;
        video3.AddComment("Hunter", "This really helped me with mastering my grammar.");
        video3.AddComment("Payton", "I have been at a roadblock for so long until now!");
        video3.AddComment("Talon", "I got to the end and realized I had it muted the whole time.");



        Video videoList = new Video();
        videoList._videos.Add(video1);
        videoList._videos.Add(video2);
        videoList._videos.Add(video3);

        videoList.DisplayList();

    }
}