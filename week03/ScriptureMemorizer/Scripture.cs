using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor accepts reference and raw text string
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split text into words and wrap each in a Word object
        string[] splitWords = text.Split(' ');
        foreach (string w in splitWords)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";
        foreach (Word w in _words)
        {
            result += w.GetDisplayText() + " ";
        }
        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}