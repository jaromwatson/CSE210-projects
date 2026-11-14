using System;
using System.IO.Compression;


public class Display
{

    public static string Menu()
    {

        string option = ""; 



        Console.WriteLine("Welcome to Jarom's Journal Program!");
        Console.WriteLine("Please pick one of the following:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");

        option = Console.ReadLine();

        return option;

    }



    public static void Journal(List<EntryObject> entries)
    {
        foreach (EntryObject x in entries)
        {
            Console.WriteLine($"Date: {x._date}");
            Console.WriteLine($"Prompt: {x._promtp}");
            Console.WriteLine($"Answer: {x._anwser}");
            Console.WriteLine();
        }






    }





}