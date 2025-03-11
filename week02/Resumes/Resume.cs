public class Resume
{
    public string _name;
    public List<Job> _job = new List<Job>();

    public void DisplayResume(){
        Console.WriteLine($"Name :{_name}");
        Console.WriteLine("Jobs:");
        foreach (Job jobinfo in _job){ 
        jobinfo.Display(); // personal notes to not forget Job used for (Job jobinfo) because we are getting info from that file
                            
        }
    }
}