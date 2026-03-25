using System;
using System.Collections.Generic;

public class ScriptureCollection
{
    private List<Scripture> _scriptures;

    public ScriptureCollection()
    {
        _scriptures = new List<Scripture>();
    }

    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }

    public void RemoveScripture(Scripture scripture)
    {
        _scriptures.Remove(scripture);
    }

    public List<Scripture> GetAllScriptures()
    {
        return _scriptures;
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
            return null;

        Random rand = new Random();
        int index = rand.Next(_scriptures.Count);
        return _scriptures[index];
    }

    public string GetDisplayText()
    {
        string result = "";
        foreach (var scripture in _scriptures)
        {
            result += scripture.GetDisplayText() + "\n\n";
        }
        return result.Trim();
    }
}