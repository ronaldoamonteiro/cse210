public class Resume
{
    //Variables
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    //Functions
    public void DisplayResume()
    {
        Console.WriteLine($"Name : {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }

        
    }


}