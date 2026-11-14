using System;
using System.IO;
using System.Collections.Generic;

public class EntryObject
{
    public string _date;
    public string _promtp;
    public string _anwser;

}
public class NewEntry
{
    

    public EntryObject Entry()
    {

        
        List<string> prompts = new List<string>(File.ReadAllLines("prompts.txt"));

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine($"{prompt} ");
        
        EntryObject y = new EntryObject();
        y._date = DateTime.Now.ToString("yyyy-MM-dd");
        y._promtp = prompt;
        y._anwser = Console.ReadLine();

        return y;





    }
    




}