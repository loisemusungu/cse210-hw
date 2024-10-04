using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHidden = 0;
    
    while (wordsHidden < numberToHide)
    {
        // Find a random index
        int index = random.Next(_words.Count);
        
        // Only hide the word if it's not already hidden
        if (!_words[index].IsHidden())
        {
            _words[index].Hide();
            wordsHidden++; // Count how many words we've hidden
        }

        // If all words are hidden, we should stop trying to hide more
        if (IsCompletelyHidden())
        {
            break;
        }
    }
}

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public string GetFullDisplayText()
    {
        return _reference.GetDisplayText() + " " + GetDisplayText();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}