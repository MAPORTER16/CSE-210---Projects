using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

public class Resume
{
    public string _name;
    public List<Job> _jobs;

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}



