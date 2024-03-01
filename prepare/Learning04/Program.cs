using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment writingAssignment = new WritingAssignment();
        writingAssignment.SetStudentName("Samuel Bennett");
        writingAssignment.SetTopic("History");
        Console.WriteLine(writingAssignment.GetSummary());
        writingAssignment._title = "The Causes of World War II";
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}

class Assigment
{
    private string _studentName;
    private string _topic;
    public void SetStudentName(string studentName)
    {
        _studentName =  studentName;
    }
    public string GetStudentName()
    {
        return _studentName;

    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}

class MathAssignment : Assigment
{
    public string _textbookSection { get; set; }
    public string _problems { get; set; }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}

class WritingAssignment : Assigment
{
    public string _title { get; set; }
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}