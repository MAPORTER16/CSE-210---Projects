using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Embark Studios";
        job1._startYear = 2018;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Gameplay Engineer";
        job2._company = "Hexwork";
        job2._startYear = 2023;
        job2._endYear = 2025;



        Resume Resume = new Resume();
        Resume._name = "Mike";

        Resume._jobs = new List<Job>();
        Resume._jobs.Add(job1);
        Resume._jobs.Add(job2);

        Resume.Display();


        
    }
}