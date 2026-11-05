using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("What is your grade percentage? ");
       string raw_grade = Console.ReadLine();

       int grade = int.Parse(raw_grade);

       string letter = "";

       if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else
        {
            letter = "F";
        }


        Console.WriteLine($"You got a {letter}");




        if (grade >= 70)
        {
            Console.WriteLine("Congrats, You've Passed!!!");
        }
        else
        {
            Console.WriteLine("Sorry you didn't pass, you'll get them next time");
        }









    }
}