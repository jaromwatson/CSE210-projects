using System;
using System.IO.Enumeration;


public class ManageFile
{

    public static List<EntryObject> Load(string filename)
    {
        List<EntryObject> _loadedFile = new List<EntryObject>();
        
        foreach (string line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split(',');

            EntryObject entry = new EntryObject();

            entry._date = parts[0];
            entry._promtp = parts[1];
            entry._anwser = parts[2];

            _loadedFile.Add(entry);



        }


        








        return _loadedFile;
    }



    public static void Save(List<EntryObject> entires, string filename)
    {
        using (StreamWriter x = new StreamWriter(filename))
        {
            foreach (EntryObject y in entires)
            {
                x.WriteLine($"{y._date},{y._promtp},{y._anwser},");
            }
            







        }
        








    }
    




}
