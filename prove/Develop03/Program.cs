using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        Scripture scripture = new Scripture();
        Console.Clear();
        Console.Write("Please enter the book name: ");
        string bookName = Console.ReadLine();
        Console.Write("Please enter the chapter number: ");
        string chapNum = Console.ReadLine();
        Console.Write("Please enter the starting verse number: ");
        string verseNum = Console.ReadLine();
        Console.Write("Please enter the ending verse number (if blank hit ENTER): ");
        string endVerseNum = Console.ReadLine();
        reference.SetBook(bookName);
        reference.SetChapter(chapNum);
        reference.SetVerse(verseNum);
        if (!string.IsNullOrWhiteSpace(endVerseNum))
        {
            reference.SetEndVerse(endVerseNum);
        }
        reference.SetReference();
        scripture.SetReference(reference.GetReference());
        Console.Write("Please Enter the text of the scripture: ");
        string text = Console.ReadLine();
        scripture.SetText(text);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"{scripture.GetReference()}: {scripture.GetScriptureText()}");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Press ENTER to hide random words, 'hint' for a hint on hiddent words, or 'quit' to quit: ");
        string choice = Console.ReadLine();
        while (choice != "quit")
        {
            if (choice.ToLower() == "hint")
            {
                scripture.ShowHints();
                Console.WriteLine();
                Console.WriteLine();
            }
            else
            {
                scripture.HideRandomWords();
                Console.WriteLine($"{scripture.GetReference()}: {scripture.GetScriptureText()}");
                Console.WriteLine();
                Console.WriteLine();
            }
            if (scripture.AllWordsHidden())
            {
                break;
            }
            Console.Write("Press ENTER to hide random words, 'hint' for a hint on hiddent words, or 'quit' to quit: ");
            choice = Console.ReadLine();
        }
        Console.WriteLine("Thanks for using the Scripture Memorizer Tool!");
    }
}
// For behold, this is my work and my glory—to bring to pass the immortality and eternal elife of man.