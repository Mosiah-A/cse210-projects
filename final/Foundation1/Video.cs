
using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Video
{
    private string _title;

    private string _author;
    private int _length;
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _author = author;
        _title = title;
        _length = length;
    }
    public int GetNumberOfComments()
    {
        return comments.Count;
    }
    public void Addcomment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        comments.Add(comment);
    }
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Titulo: {_title}");
    
        Console.WriteLine($"Author: {_author}");
    
        Console.WriteLine($"Length in sec.: {_length}");
        Console.WriteLine("");
        

        foreach (var item in comments)
        {
            item.DisplayCommentDetail();
        }
    }
}