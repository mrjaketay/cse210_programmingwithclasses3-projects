using System;

class Program
{
    private static Journal journal = new Journal(); // Instantiate the Journal class

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nWelcome to your Personal Journal");
            Console.WriteLine("********************************\n");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit\n");
            Console.WriteLine("Enter your choice:");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    WriteNewEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.WriteLine("Enter filename to save:");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case 4:
                    Console.WriteLine("Enter filename to load:");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Method to write a new entry
    private static void WriteNewEntry()
    {
        // Get current date
        string date = DateTime.Now.ToString("MM/dd/yyyy");

        // List of prompts
        string[] prompts = 
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        // Randomly select a prompt
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Length)];

        // Ask user for response
        Console.WriteLine("\nPrompt: " + prompt);
        Console.WriteLine("Enter your response:");
        string response = Console.ReadLine();

        // Add entry to journal
        journal.AddEntry(date, prompt, response);
    }
}
