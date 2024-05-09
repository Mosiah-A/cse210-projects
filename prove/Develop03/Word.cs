using System;

class Word
{
    public string Text { get; set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public void Show()
    {
        IsHidden = false;
    }

    public bool IsCompletelyHidden()
    {
        return IsHidden;
    }

    public string GetDisplayText()
    {
        return IsHidden ? "_____" : Text;
    }
}
