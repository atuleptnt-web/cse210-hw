using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        var videos = new List<Video>
        {
            new Video("Exploring Accra Landmarks", "Paul Tetteh", 420),
            new Video("Building Accessible Web Apps", "Paanii", 600),
            new Video("CSS Grid Explained", "PTNT Solutions", 480)
        };

        videos[0].AddComment(new Comment("Ama", "Loved the visuals!"));
        videos[0].AddComment(new Comment("Kwesi", "Very informative."));
        videos[0].AddComment(new Comment("Esi", "Can’t wait to visit Accra!"));

        videos[1].AddComment(new Comment("John", "Accessibility is key."));
        videos[1].AddComment(new Comment("Linda", "Great explanation."));
        videos[1].AddComment(new Comment("Kojo", "Helpful for my project."));

        videos[2].AddComment(new Comment("Sarah", "Finally understood grid areas."));
        videos[2].AddComment(new Comment("Michael", "Clear and concise."));
        videos[2].AddComment(new Comment("Nana", "Perfect for beginners."));

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}