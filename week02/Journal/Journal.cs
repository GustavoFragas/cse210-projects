using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        var sb = new System.Text.StringBuilder();
        foreach (Entry entry in _entries)
        {
            sb.AppendLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
        }
        File.WriteAllText(file, sb.ToString());
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                entry._date = parts[0].Trim();
                entry._promptText = parts[1].Trim();
                entry._entryText = parts[2].Trim();

                _entries.Add(entry);
            }
        }
    }
}
