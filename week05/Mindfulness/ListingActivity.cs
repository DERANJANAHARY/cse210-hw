using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List people you appreciate:",
        "List your strengths:",
        "List people you helped recently:",
        "List things that make you happy:"
    };

    Random rand = new Random();

    public ListingActivity()
        : base("Listing Activity",
               "This activity helps you list positive things in your life.")
    { }

    protected override void DoActivity(int seconds)
    {
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        Console.WriteLine("You may begin in...");
        Countdown(3);

        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
                items.Add(item);
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items!");
    }
}
