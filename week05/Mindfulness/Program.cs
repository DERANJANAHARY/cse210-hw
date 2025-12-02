using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Activity activity = null;

            if (choice == "1") activity = new BreathingActivity();
            else if (choice == "2") activity = new ReflectingActivity();
            else if (choice == "3") activity = new ListingActivity();
            else if (choice == "4") return;

            if (activity != null)
            {
                activity.StartActivity();
            }
        }
    }
}
