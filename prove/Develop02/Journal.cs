using System;
using System.Collections.Generic;

// Entry class to represent each journal entry
public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
}

// Journal class to manage entries
public class Journal
{
    private List<Entry> entries = new List<Entry>();

    // Add a new entry
    public void AddEntry(string date, string prompt, string response)
    {
        entries.Add(new Entry { Date = date, Prompt = prompt, Response = response });
    }

    // Display all entries
    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    // Save the journal to a file
    public void SaveToFile(string filename)
    {
        try
        {
            Console.WriteLine("Enter file extension (e.g., txt):");
            string extension = Console.ReadLine();

            string fullFilename = $"{filename}.{extension}";

            using (StreamWriter writer = new StreamWriter(fullFilename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Date} - {entry.Prompt}: {entry.Response}");
                }
            }
            Console.WriteLine("\nJournal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    // Load the journal from a file
    public void LoadFromFile(string filename)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string date = parts[0];
                        string prompt = parts[1];
                        string response = parts[2];
                        AddEntry(date, prompt, response);
                    }
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}
