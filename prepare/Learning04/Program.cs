using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Student Name", "Topic");
        Console.WriteLine(a.GetSummary());
        
        MathAssignment na = new MathAssignment("Student Name","Topic", "Section" ,"Problem");
        Console.WriteLine(na.GetSummary());

        Console.WriteLine(na.GetHomeworkList());
        WritingAssignment w = new WritingAssignment("Student Name", "Topico", "Title");
        Console.WriteLine(w.GetSummary());
        Console.WriteLine(w.GetWritingInformation());
        
    }
}