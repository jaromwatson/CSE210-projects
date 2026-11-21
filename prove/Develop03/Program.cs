using System;
using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        // Scriputre Memorizing Program
        //for the reach I made it so the program can take scriptures before it starts
        Console.WriteLine("Welcome to the scripture Memorizer");
        Console.WriteLine("Press Enter to start");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Enter the text of the Verse/Verses you want to use here: ");
        Scriputre x = new Scriputre(Console.ReadLine());
        x.SetScriputre();
        Console.Clear();

        Refrence y = new Refrence();
        y.SetBook();
        Console.Clear();
        y.SetChapter();
        Console.Clear();
        y.SetVerse();
        Console.Clear();


        string input;
        Console.WriteLine("Hit enter to hide more words, and type 'quit' to end program...");
        y.getRef();
        x.ShwoScripture();

        Console.WriteLine();
        Console.WriteLine();
        input = Console.ReadLine();
        

        while (input != "quit")
        {
            if(input == "")
            {
                Console.Clear();
                x.HideWords();
                y.getRef();
                x.ShwoScripture();

                if (x.AllHidden())
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("All the words are hidden, press Enter to finsih... ");
                    Console.ReadLine();
                    break;
                }
            }
            input = Console.ReadLine();    
        }





            Console.Clear();
            Console.WriteLine("Thanks for playing");



        
        
        










    }
}