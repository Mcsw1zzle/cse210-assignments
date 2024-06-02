public class Word
{
    private string _original;
    private string _current;
    private bool _isHidden;

    public Word(string word)
    {
        _original = word;
        _current = word;
        _isHidden = false;
    }

    public string GetCurrent()
    {
        return _current;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public void Hide()
    {
        if (!_isHidden)
        {
            _current = new string('_', _original.Length);
            _isHidden = true;
        }
    }
}