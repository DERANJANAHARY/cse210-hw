using System;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($">>> {_name} <<<");
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        DoActivity(_duration);

        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(2);

        Console.WriteLine($"You completed {_duration} seconds of {_name}.");
        ShowSpinner(3);

        Console.WriteLine("Press Enter to return to menu...");
        Console.ReadLine();
    }

    protected virtual void DoActivity(int seconds)
    {
        // Implemented by child classes
    }

    // Simple spinner animation
    protected void ShowSpinner(int seconds)
    {
        char[] frames = { '|', '/', '-', '\\' };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < end)
        {
            Console.Write(frames[index]);
            System.Threading.Thread.Sleep(200);
            Console.Write("\b");
            index = (index + 1) % frames.Length;
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
