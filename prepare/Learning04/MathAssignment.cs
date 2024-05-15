using System;

public class MathAssignment : Assignment
{

// variable scoop

    //private string _studentName, _textbookSection, _topic, _problem;
    private string  _textbookSection, _problem;

// Constructor
    /*public MathAssignment(string studentName, string topic, string textbookSectio, string problem )
    {
        _studentName = studentName;
        _topic = topic;
        _textbookSection = textbookSection;
        _problem = problem;
    }*/
    public MathAssignment(string studentName, string topic, string textbookSection, string problem  ) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problem = problem;
    }

// Method

    /*public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }*/

    public string GetHomeworkList()
    {
        return $"Sections {_textbookSection} Problems {_problem}";
    }

}