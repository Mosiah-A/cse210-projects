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
    public void AddEntry( Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine();
        
    }
    public void DisplayAll()
    {
        Console.WriteLine("Entries:");
        foreach (var entry in _entries)
        {
            Console.WriteLine($"Data: {entry._date} Prompt:{entry._promptText} {entry._entryText}");
        }


    }
    public void SaveToFile(String file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"Data: {entry._date} Prompt:{entry._promptText} {entry._entryText}");;
            }
        }
    }
    public void LoadFromFile(string file)
    {
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('~');
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
} 

