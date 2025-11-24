using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store all videos
        List<Video> videos = new List<Video>();

        // ADD VIDEO 1 
        Video v1 = new Video("Learn C# in 10 Minutes", "CodeMaster", 600);
        v1.AddComment(new Comment("Alice", "Very helpful tutorial!"));
        v1.AddComment(new Comment("Bob", "Thanks, I learned a lot."));
        v1.AddComment(new Comment("Clara", "Perfect explanation."));
        videos.Add(v1);

        // ADD VIDEO 2
        Video v2 = new Video("Madagascar Vlog", "Njanahary", 480);
        v2.AddComment(new Comment("Mira", "Beautiful video!"));
        v2.AddComment(new Comment("Leo", "I love the scenery."));
        v2.AddComment(new Comment("Paul", "Amazing editing!"));
        videos.Add(v2);

        // ADD VIDEO 3
        Video v3 = new Video("How to Cook Pasta", "ChefLino", 300);
        v3.AddComment(new Comment("Tom", "Delicious recipe!"));
        v3.AddComment(new Comment("Sarah", "I tried it—so good!"));
        v3.AddComment(new Comment("Elise", "Easy to follow."));
        videos.Add(v3);

        // ADD VIDEO 4 
        Video v4 = new Video("Beginner Piano Tutorial", "MusicPro", 720);
        v4.AddComment(new Comment("Anna", "Great lesson!"));
        v4.AddComment(new Comment("Mike", "This helped me a lot."));
        v4.AddComment(new Comment("Rita", "Please make more videos!"));
        videos.Add(v4);


        // DISPLAY ALL VIDEOS WITH THEIR COMMENTS

        foreach (Video video in videos)
        {
            // Print video info
            video.DisplayVideo();
            video.PrintNumberOfComments();
            Console.WriteLine("Comments:");

            // Print each comment using the void DisplayComment()
            foreach (var comment in video._comments) 
            {
                Console.Write(" - ");
                comment.DisplayComment();
            }

            Console.WriteLine(); // blank line between videos
        }
    }
}
