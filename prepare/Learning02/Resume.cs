using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Resume
{


    public string name = "jarom";
    public List<Job> _listOfJobs = new List<Job>();

    public void display()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs: ");
        foreach (Job jobs in _listOfJobs)
        {
            
            jobs.Display();

        }



    }


}
