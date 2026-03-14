using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

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
        // TODO: Implement file saving
    }

    public void LoadFromFile(string file)
    {
        // TODO: Implement file loading
    }
}