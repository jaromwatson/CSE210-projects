using System.ComponentModel;

public class Refrence
{
    // Just to hold the refrence that is entered (John 2:16 or John 2:6-12)
    private string _book;
    private string _chapter;
    private string _verse;

    public void SetBook()
    {
        Console.WriteLine("What Book?");
        _book = Console.ReadLine();   
    }

    public void SetChapter()
    {
        Console.WriteLine("What chapter?");
        _chapter = Console.ReadLine();
    }

    public void SetVerse()
    {
        Console.WriteLine("What Verse/Verses?");
        _verse = Console.ReadLine();


    }


    public void getRef()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse} - ");
    }

}