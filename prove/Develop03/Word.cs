using System;

public class Word
{
        public Word(string text)
    {
        _text = text;
        _isVisible = true;
    }
    public string _text { get; set; }
    public bool _isVisible { get; set; }
}