public class Reference
{
    string _referenceText;
    string _book;
    int _chapter;
    int _startVerse;
    int _endVerse;

    public Reference(string book, int chapter, int startVerse, int endVerse = 0)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        if(endVerse == 0)
        {
            _endVerse = startVerse;
            _referenceText = $"{book} {chapter}:{startVerse}";
        }
        else
        {
            _endVerse = endVerse;
            _referenceText = $"{book} {chapter}:{startVerse}-{endVerse}";
        }

        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        
    }

    public string GetReferenceText()
    {
        return _referenceText;
    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetStartVerse()
    {
        return _startVerse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

    
}