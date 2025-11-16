class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        int hidden = 0;

        while (hidden < count)
        {
            int index = _random.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }

            if (AllWordsHidden())
                break;
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }

    public void Display()
    {
        Console.Clear();

        Console.WriteLine(_reference.GetDisplayText());
        Console.WriteLine();

        foreach (Word w in _words)
        {
            Console.Write(w.GetDisplayText() + " ");
        }

        Console.WriteLine("\n\nPress Enter to hide more words or type 'quit' to stop.");
    }
}