public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return IsHidden()
            ? GetHiddenText()
            : _text;
    }

    public string GetVisibleText()
    {
        return _text;
    }

    private string GetHiddenText()
    {
        return new string('_', _text.Length);
    }
}