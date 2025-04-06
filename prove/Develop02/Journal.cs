using System.IO;

public class Journal
{
    private string _fileName;
    private List<Entry> _entries;

    public Journal(string fileName)
    {
        _fileName = fileName;
        _entries = [];
    }

    public string GetFileName()
    {
        return _fileName;
    }

    public void AddEntry(string prompt, string response)
    {
        string date = DateTime.Now.ToShortDateString();

        _entries.Add(new Entry(date, prompt, response));
    }

    public string Compile()
    {
        string page = "";

        foreach (Entry entry in _entries)
        {
            page += $"{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}\n\n";
        }

        return page;
    }

    public void Save()
    {
        using (StreamWriter writer = File.CreateText(_fileName))
        {
            foreach(Entry entry in _entries)
            {
                writer.Write($"{entry.GetDate()}|");
                writer.Write($"{entry.GetPrompt()}|");
                writer.WriteLine($"{entry.GetResponse()}");
            }
        }
    }
    public void Load()
    {
        using (StreamReader reader = new StreamReader(_fileName))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split("|");

                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                _entries.Add(new Entry(parts[0], parts[1], parts[2]));
            }
        }
    }
}