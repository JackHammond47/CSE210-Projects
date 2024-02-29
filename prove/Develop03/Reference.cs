using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;
    private string _reference;
    private bool _hasEndVerse = false;

    public void SetBook(string book)
    {
        _book = book;
        SetReference();
    }

    public void SetChapter(string chapter)
    {
        _chapter = chapter;
        SetReference();
    }

    public void SetVerse(string verse)
    {
        _verse = verse;
        SetReference();
    }

    public void SetEndVerse(string endVerse)
    {
        _endVerse = endVerse;
        _hasEndVerse = true;
        SetReference();
    }

    public void SetReference()
    {
        if (_hasEndVerse)
        {
            _reference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            _reference = $"{_book} {_chapter}:{_verse}";
        }
    }

    public string GetReference()
    {
        return _reference;
    }
}