using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Video video = new Video("Nephi chapter 1","Nephi", 260);
        video.Addcomment("Sam", "Hi, this is my comment, I believe in Nephi, and fallow the Christ");
        video.Addcomment("Nephi", "Hi, this is my comment, I balieve in my father and i know the God lives.");
        video.Addcomment("Laman", "Hi, this is my comment, I want to be the leader");
        video.Addcomment("Lemuel", "Hi, this is my comment, I follow my brother Laman");
        video.DisplayVideoDetails();
        Console.WriteLine("");
        Console.WriteLine($"Have {video.GetNumberOfComments()} comments");

        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("");


        Video video2 = new Video("King Mosiah","Mosiah", 756);
        video2.Addcomment("Joseph", "He was a good King");
        video2.Addcomment("Alma", "I loved to work with him");
        video2.DisplayVideoDetails();
        Console.WriteLine("");
        Console.WriteLine($"Have {video2.GetNumberOfComments()} comments");

        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("");

        Video video3 = new Video("First Vision","Joseph Smith JR", 116);
        video3.Addcomment("Oliver", "Sorry I lost the pages");
        video3.Addcomment("Emma", "This is the Man, I love you Dude");
        video3.Addcomment("Moroni", "Take care my family's plates");
        video3.DisplayVideoDetails();
        Console.WriteLine("");
        Console.WriteLine($"Have {video3.GetNumberOfComments()} comments");
    }
}