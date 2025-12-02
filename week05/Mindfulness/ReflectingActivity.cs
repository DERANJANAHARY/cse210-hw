using System;
using System.Collections.Generic;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Think of a time you did something difficult.",
        "Think of a time you were strong.",
        "Think of a time you were brave."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "How can you apply this today?"
    };

    Random rand = new Random();

    public ReflectingActivity()
        : base("Reflection Activity",
               "This activity helps you think about your strengths.")
    { }

    protected override void DoActivity(int seconds)
    {
        Console.WriteLine();
        Console.WriteLine("Prompt:");
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("Reflect on this...");

        DateTime end = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < end)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine();
            Console.WriteLine(question);
            ShowSpinner(4);
        }
    }
}
