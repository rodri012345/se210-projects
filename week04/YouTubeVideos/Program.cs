using System;

class Program{
    static void Main(string[] args){
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 10 Minutes", "TechAcademy", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very clear and concise."));
        video1.AddComment(new Comment("Charlie", "I learned a lot, thanks!"));

        Video video2 = new Video("Cooking Pasta 101", "ChefMaster", 480);
        video2.AddComment(new Comment("Dave", "Yummy recipe!"));
        video2.AddComment(new Comment("Eva", "I tried it and it worked perfectly."));
        video2.AddComment(new Comment("Frank", "Can you do a vegetarian version?"));

        Video video3 = new Video("Top 10 Programming Languages 2025", "CodeWorld", 900);
        video3.AddComment(new Comment("Grace", "Nice insights."));
        video3.AddComment(new Comment("Hank", "Why no love for Rust?"));
        video3.AddComment(new Comment("Ivy", "Very informative!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos){
            video.DisplayVideoInfo();
        }
    }
}