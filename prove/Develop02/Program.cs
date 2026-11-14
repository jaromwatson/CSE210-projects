using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        List<EntryObject> entries = new List<EntryObject>();
        string choice = "";

        while (choice != "5")
        {
            choice = Display.Menu();

            if (choice == "1")
            {
                NewEntry x = new NewEntry();
                EntryObject entry = x.Entry();
                entries.Add(entry);
            }

            else if (choice == "2")
            {
                Display.Journal(entries);                
            }

            else if (choice == "3")
            {
                string filename = "";

                Console.WriteLine("What is the file name?");
                filename = Console.ReadLine();
                entries = ManageFile.Load(filename);
                
            }

            else if (choice == "4")
            {
                string filename = "";

                Console.WriteLine("What is the file name?");
                filename = Console.ReadLine();
                ManageFile.Save(entries, filename);                
            }

            else if (choice == "5")
            {
                Console.WriteLine("Thank you for using the program!");
                
            }

        } 
        

        

















    }
}