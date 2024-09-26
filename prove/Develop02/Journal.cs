using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

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
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} ~ {entry._promptText} ~ {entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        try
        {
            string[] lines = File.ReadAllLines(file);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('~');
                DateTime date = DateTime.Parse(parts[0].Trim());
                string promptText = parts[1].Trim();
                string entryText = parts[2].Trim();

                Entry entry = new Entry(promptText, entryText);
                entry._date = date;
                _entries.Add(entry);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
                
    }   
}