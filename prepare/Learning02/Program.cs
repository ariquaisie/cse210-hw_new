using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Computer engineer";
        job1._startYear = 2012;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "J3Harris";
        job2._jobTitle = "Software engineer";
        job2._startYear = 2017;
        job2._endYear = 2025;

        Resume resume = new Resume();
        resume._name = "Ari Quaisie";
        resume._job.Add(job1);
        resume._job.Add(job2);

        resume.Display();
    }
}