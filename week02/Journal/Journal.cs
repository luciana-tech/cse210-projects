using System;
using System.Collections.Generic;
using System.Text.Json;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void WriteNewEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Entry entry = new Entry(prompt, response);
        _entries.Add(entry);
        Console.WriteLine("Entry added!\n");
    }

    public void DisplayEntries()
    {
        Console.WriteLine("\n--- Journal Entries ---\n");
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filename, json);
        Console.WriteLine("Journal saved to JSON successfully.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string json = File.ReadAllText(filename);
        _entries = JsonSerializer.Deserialize<List<Entry>>(json);
        Console.WriteLine("Journal loaded from JSON successfully.");
    }
}