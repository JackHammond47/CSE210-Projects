using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string _reference;
    private List<Word> _words;
    private string _text; // Add _text field to store the scripture text

    public void SetReference(string reference)
    {
        _reference = reference;
    }
    
    public string GetReference()
    {
        return _reference;
    }
    
    public void SetText(string text)
    {
        _text = text; // Set the scripture text
        _words = new List<Word>();
        foreach (string word in _text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries))
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
    
    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = _words.Count / 4;
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index]._isVisible = false; // Hide the word
        }
    }
    
    public string GetScriptureText()
    {
        // Construct the scripture text by joining the visible words
        // If a word is hidden, replace it with asterisks
        return string.Join(" ", _words.Select(word => word._isVisible ? word._text : new string('_', word._text.Length)));
    }

    // Method to check if all words in the scripture are hidden
    public bool AllWordsHidden()
    {
        // Check if all words are hidden by checking the IsVisible property of each word
        return _words.All(word => !word._isVisible);
    }

    // ShowHints method to display hints with scripture text
    public void ShowHints()
    {
        string[] words = _text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i]._isVisible)
            {
                // Show the first letter of hidden words as hints
                Console.Write(words[i][0] + new string('_', words[i].Length - 1) + " ");
            }
            else
            {
                // Show visible words as they are
                Console.Write(words[i] + " ");
            }
        }
        Console.WriteLine();
    }
}