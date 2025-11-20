using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a few videos and add comments to each
        var video1 = new Video("Learning C# Basics", "Alice", 420);
        video1.AddComment(new Comment("Bob", "Great explanation!"));
        video1.AddComment(new Comment("Carol", "Helped me a lot, thanks."));
        video1.AddComment(new Comment("Dave", "Can you cover events next?"));

        var video2 = new Video("Intro to LINQ", "Eve", 600);
        video2.AddComment(new Comment("Frank", "Nice examples."));
        video2.AddComment(new Comment("Grace", "I prefer query syntax."));
        video2.AddComment(new Comment("Heidi", "Clear and concise."));

        var video3 = new Video("Building Console Apps", "Ivan", 300);
        video3.AddComment(new Comment("Judy", "Good tips."));
        video3.AddComment(new Comment("Mallory", "What about async?"));
        video3.AddComment(new Comment("Niaj", "Helpful for beginners."));

        var video4 = new Video("Advanced Generics", "Oscar", 900);
        video4.AddComment(new Comment("Peggy", "This was challenging but worth it."));
        video4.AddComment(new Comment("Trent", "Can you provide more examples?"));
        video4.AddComment(new Comment("Victor", "Excellent content."));

        var videos = new List<Video> { video1, video2, video3, video4 };

        // Display information for each video
        foreach (var v in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {v.Title}");
            Console.WriteLine($"Author: {v.Author}");
            Console.WriteLine($"Length (seconds): {v.LengthSeconds}");
            Console.WriteLine($"Number of comments: {v.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var c in v.Comments)
            {
                Console.WriteLine($" - {c}");
            }
            Console.WriteLine();
        }
    }
}