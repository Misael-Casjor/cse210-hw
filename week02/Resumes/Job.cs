using System.ComponentModel.DataAnnotations;

class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJob()
    {
        Console.WriteLine($"company:{_company} job:{_jobTitle}  start year:{_startYear}  end Year:{_endYear}");
    }
}