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

            for (int i = 0; i < lines.Length; i += 4)  
            {
                if (i + 2 < lines.Length)
                {
                    DateTime date = DateTime.Parse(lines[i]);
                    string prompt = lines[i + 1];
                    string response = lines[i + 2];

                    Entry entry = new Entry(prompt, response)
                    {
                        _date = date  
                    };

                    _entries.Add(entry);  
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
                
    }   
}