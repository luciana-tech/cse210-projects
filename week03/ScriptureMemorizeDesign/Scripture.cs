using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        
    }

    public string GetDisplayText()
    {
        return string.Empty;
    }

    public void HideRandomWords(int count)
    {
        
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}
