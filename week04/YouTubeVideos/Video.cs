using System;
using System.Collections.Generic;

class Video{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int lengthInSeconds){
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment){
        Comments.Add(comment);
    }

    public int GetNumberOfComments(){
        return Comments.Count;
    }

    public void DisplayVideoInfo(){
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        foreach (var comment in Comments){
            Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
        }

        Console.WriteLine();
    }
}
