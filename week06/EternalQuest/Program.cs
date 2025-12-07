using System;

namespace EternalQuest
{
    // Simple console UI that uses GoalManager.
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new GoalManager();
            bool exit = false;

            Console.WriteLine("Welcome to Eternal Quest");

            while (!exit)
            {
                ShowMenu();
                string choice = Console.ReadLine()?.Trim();

                switch (choice)
                {
                    case "1":
                        CreateGoal(manager);
                        break;
                    case "2":
                        manager.ListGoals();
                        break;
                    case "3":
                        RecordEvent(manager);
                        break;
                    case "4":
                        Console.WriteLine("Score: " + manager.Score);
                        break;
                    case "5":
                        Save(manager);
                        break;
                    case "6":
                        Load(manager);
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please enter 1-7.");
                        break;
                }
            }

            Console.WriteLine("Goodbye!");
        }

        static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Create goal");
            Console.WriteLine("2) List goals");
            Console.WriteLine("3) Record event (complete a goal)");
            Console.WriteLine("4) Show score");
            Console.WriteLine("5) Save goals");
            Console.WriteLine("6) Load goals");
            Console.WriteLine("7) Exit");
            Console.Write("Choose: ");
        }

        static void CreateGoal(GoalManager manager)
        {
            Console.WriteLine("Choose type: 1) Simple  2) Eternal  3) Checklist");
            string type = Console.ReadLine()?.Trim();

            Console.Write("Short name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Description: ");
            string desc = Console.ReadLine() ?? "";

            Console.Write("Points (per event): ");
            if (!int.TryParse(Console.ReadLine(), out int points)) points = 0;

            if (type == "1")
            {
                var g = new SimpleGoal(name, desc, points);
                manager.AddGoal(g);
                Console.WriteLine("Simple goal added.");
            }
            else if (type == "2")
            {
                var g = new EternalGoal(name, desc, points);
                manager.AddGoal(g);
                Console.WriteLine("Eternal goal added.");
            }
            else if (type == "3")
            {
                Console.Write("Target count: ");
                if (!int.TryParse(Console.ReadLine(), out int target)) target = 1;

                Console.Write("Bonus on completion: ");
                if (!int.TryParse(Console.ReadLine(), out int bonus)) bonus = 0;

                var g = new ChecklistGoal(name, desc, points, target, bonus);
                manager.AddGoal(g);
                Console.WriteLine("Checklist goal added.");
            }
            else
            {
                Console.WriteLine("Unknown type. No goal created.");
            }
        }

        static void RecordEvent(GoalManager manager)
        {
            manager.ListGoals();
            Console.Write("Enter goal number to record: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                manager.RecordEvent(n - 1);
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }

        static void Save(GoalManager manager)
        {
            Console.Write("Filename to save (e.g. goals.txt): ");
            string file = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(file)) file = "goals.txt";
            manager.SaveToFile(file);
        }

        static void Load(GoalManager manager)
        {
            Console.Write("Filename to load: ");
            string file = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(file)) file = "goals.txt";
            manager.LoadFromFile(file);
        }
    }
}
