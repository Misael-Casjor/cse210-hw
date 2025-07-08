using System.ComponentModel.DataAnnotations;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;


    public void displayJobDetails() {
        Console.WriteLine($"Company: {_company}");
        Console.WriteLine($"Job Title: {_jobTitle}");
        Console.WriteLine($"Start year: {_startYear}");
        Console.WriteLine($"End year: {_endYear}");
    }
}
