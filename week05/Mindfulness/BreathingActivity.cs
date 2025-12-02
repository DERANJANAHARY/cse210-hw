using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity helps you relax by guiding slow breathing patterns.")
    { }

    protected override void DoActivity(int seconds)
    {
        DateTime end = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < end)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.WriteLine();

            Console.Write("Breathe out... ");
            Countdown(4);
            Console.WriteLine();
        }
    }
}
