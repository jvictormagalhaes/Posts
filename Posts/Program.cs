using Posts.Entities;
using System;

namespace Posts
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice day!");
            Comment c2 = new Comment("Wow that's awesome!");
            Comment c3 = new Comment("Good night !");
            Comment c4 = new Comment("May the Force be with you!");

            Post p1 = new Post(DateTime.Parse("21/06/2018 21:22:52"), "Traveling to New Zealend", "I'm going to visit this wonderful country", 12);
            Post p2 = new Post(DateTime.Parse("28/07/2018 21:25:53"), "Good night guys", "See you tomorrow", 5);

            p1.AddComment(c1);
            p1.AddComment(c2);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}