class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        if (!_isHidden) return _text;

        string hidden = "";
        for (int i = 0; i < _text.Length; i++)
        {
            char c = _text[i];
            if (char.IsLetter(c))
                hidden += "_";
            else
                hidden += c;
        }
        return hidden;
    }
}
