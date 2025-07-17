using System;
using System.Collections.Generic;

// Exceeding requirements: Program chooses scriptures at random to present to the user.
class Program
{
    static void Main()
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("2 Timothy", 1, 7), "For the Spirit God gave us does not make us timid, but gives us power, love and self-discipline.")
        };

        Random rand = new Random();
        Scripture currentScripture = scriptures[rand.Next(scriptures.Count)];

        bool userQuit = false;

        while (!currentScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.Write(currentScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
           
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                userQuit = true;
                break;
            }

            currentScripture.HideRandomWords(3);
        }

        // Final display
        Console.Clear();
        Console.Write(currentScripture.GetDisplayText());
        if (userQuit)
        {
            Console.WriteLine("\nUser quit. Program ended.");
        }
        else
        {
            Console.WriteLine("\nAll words hidden. Program ended.");
        }
    }
}
