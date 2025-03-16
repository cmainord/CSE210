public class Word
{
    private string _text;
    private string _blankText;
    private bool _isHidden;

    public Word(string text, bool isHidden = false)
    {
        _text = text;
        _isHidden = isHidden;
        _blankText = GenerateBlankText(text);
   
    }

    public string GenerateBlankText(string wordText)
    {
        string blankText = "";

        for(int i = 0; i < wordText.Length; i++)
        {
            if(wordText[i] == ',' | wordText[i] == '.' | wordText[i] == '!')
            {
                blankText += wordText[i];
            }

            else
            {
                blankText += "_";
            }
        }

        return blankText;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetWord(bool ignoreHidden = false)
    {
        if(!_isHidden | ignoreHidden)
        {
            return _text;
        }
        else
        {
            return _blankText;
        }
    }

}