using System.Runtime.CompilerServices;

public class Word
{
    // hold each word and make a list of word objects in the scriptures and use Bolean to hide or not hide scripture
    private string _word;
    private string _wordFinal;
    private Boolean _hidden = false;

    public Word(string x)
    {
        _word = x;
        _wordFinal = x;
    }

    public bool IsHidden()
    {
        return _hidden;
    }


    public void HideWord()
    {
        _hidden = true;
        WhatIsWord();
    }


    public void WhatIsWord()
    {

        _wordFinal = "_word";
        
    if (_hidden == true)
        {
            _wordFinal = new string('_', _word.Length);
        }
    }


    public void ShowWord()
    {
        Console.Write($"{_wordFinal} ");




    }

}