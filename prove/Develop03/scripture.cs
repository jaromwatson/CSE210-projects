using System.Dynamic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

public class Scriputre
{
    // Hold a list of word objects, 
    private string _verse;
    private string[] x;
    private List<Word> _MainList = new List<Word>();
    private int _wordCount;
    

    Random random = new Random();

    public Scriputre(string y)

    {
        _verse = y;
    }

    public void SetScriputre()
    {
        
        _wordCount = _verse.Split(' ').Length;
        x = _verse.Split(' ');

        foreach(string i in x)
        {
            Word w = new Word(i);
            _MainList.Add(w);
        }
    }

    public void HideWords()
    {
        int i = 0;

        
        while(i < 4)
        {
            
            int _whatOne = random.Next(0, _wordCount);
            _MainList[_whatOne].HideWord();


            i++;
        }
    }


    public void ShwoScripture()
    {
       foreach (Word w in _MainList)
        {
            w.ShowWord();   

        }




    }

    public bool AllHidden()
    {
        foreach (Word w in _MainList)
        {
            if (w.IsHidden() == false)
            {
                return false;
            }

            return true;
        }


        return true;
    }

    









}