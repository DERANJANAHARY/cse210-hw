using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();


        while (true)
        {
            Console.WriteLine("1- Write entry");        
            Console.WriteLine("2- Display all");
            Console.WriteLine("3- Save");
            Console.WriteLine("4- Load");
            Console.WriteLine("5- Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();

                Entry entry = new Entry
                {
                    _date = date,
                    _promptText = prompt,
                    _entryText = response
                };

                journal.AddEntry(entry);
                Console.WriteLine("Entry added!\n");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
                Console.WriteLine("Journal saved!\n");
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
                Console.WriteLine("Journal loaded!\n");
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option.\n");
            }
        }
    }
}
