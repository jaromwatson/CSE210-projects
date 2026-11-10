using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._endYear = 2026;
        job1._startYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Jr. Software Engineer";
        job2._company = "Apple";
        job2._endYear = 2027;
        job2._startYear = 2023;


        Resume resumeX = new Resume();
        resumeX._listOfJobs.Add(job1);
        resumeX._listOfJobs.Add(job2);

        resumeX.display();

        


























    }
}