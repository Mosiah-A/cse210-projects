using System;

public class WritingAssignment : Assignment
{

// variable scoop

    //private string _studentName, _topic, _title;
    private string _title;

// Constructor
    /*public WritingAssignment(string studentName, string topic, string title ) 
    {
        _studentName = studentName;
        _topic = topic;
        _title = title;
    }*/
    public WritingAssignment(string studentName, string topic, string title ) : base(studentName, topic)
    {
        _title = title;
    }

// Method

    /*public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }*/

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName} ";
    }

}