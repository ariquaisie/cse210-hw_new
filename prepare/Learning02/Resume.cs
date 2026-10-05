using System; 
public class Resume{
    public string _name;
    public List<Job> _job = new List<Job>();
    public void Display()
        {
            Console.WriteLine($"Name:{_name} \nJobs:{_job}:");

            foreach (Job jobs in _job)
        {
            jobs.Display();
        }
        }
}