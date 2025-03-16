public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private string _fullText;

    public Scripture(string text, string book, int chapter, int startVerse, int endVerse = 0)
    {
        //Console.WriteLine("Acquiring full text...");
        _fullText = text;

        //Console.WriteLine("Creating reference...");
        _reference = new Reference(book, chapter, startVerse, endVerse);

        //Console.WriteLine("Splitting text...");
        SplitText(text);

        //Console.WriteLine("SCRIPTURE GENERATED");
    }

    public void SplitText(string text)
    {
        for(int i = 0; i < text.Length ; i++)
        {
            if(i == 0 | text[i] == ' ')
            {
                Word word;
                //Console.WriteLine("--Extracting word and adding to word list...");
                if (i == 0)
                {
                    word = new Word(ExtractWord(text, i));
                }
                else
                {
                    word = new Word(ExtractWord(text, i + 1));
                }
                
                _words.Add(word);
                //Console.WriteLine($"----Word added to word list; word list size: {_words.Count}");
            }
        }
    }

    public string ExtractWord(string text, int stringIndex)
    {
        string wordText = "";
        int i = stringIndex;
        //Console.Write("----Extracting characters: ");
        while(i < text.Length && !(text[i] == ' '))
        {
            //Console.Write($"{text[i]} ");
            wordText += text[i];
            i += 1;
        }
        //Console.WriteLine($"Word: {wordText}");

        return wordText;
    }

    public string GetReferenceText()
    {
        return _reference.GetReferenceText();
    }

    public void UpdateFullText()
    {
        string fullText = "";
        foreach(Word word in _words)
        {
            fullText += $"{word.GetWord()} ";
        }

        _fullText = fullText;
    }

    public void HideWords(int quantity)
    {
        //_words[0].Hide();

        Random rng = new Random();

        int i = 0;
        int rand;

        int remainingWords = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                remainingWords++;
            }
        }

        while (i < quantity && remainingWords > 0)
        {
            rand = rng.Next(_words.Count);
            if (!_words[rand].IsHidden())
            {   
                //Console.WriteLine($"Hiding word {rand}...");
                _words[rand].Hide();

                i++;
                remainingWords--;
            }

            else
            {
                //Console.WriteLine($"Word {rand} already hidden. Moving on...");
            }
            
        }

        UpdateFullText();
    }

    public void Display()
    {
        //Console.WriteLine("DISPLAYING TEST SCRIPTURE");
        string referenceText = _reference.GetReferenceText();
        Console.WriteLine(referenceText);
        Console.WriteLine(_fullText);
    }


}