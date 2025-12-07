using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    // Manager that holds goals, score, and provides menu actions (save/load, record event).
    public class GoalManager
    {
        public List<Goal> Goals { get; private set; } = new List<Goal>();
        public int Score { get; private set; } = 0;

        public void AddGoal(Goal g) => Goals.Add(g);

        // Record event by index (0-based). Adds points returned by goal.
        public void RecordEvent(int index)
        {
            if (index < 0 || index >= Goals.Count)
            {
                Console.WriteLine("Invalid goal number.");
                return;
            }

            Goal g = Goals[index];
            int earned = g.RecordEvent();
            Score += earned;
            Console.WriteLine($"You earned {earned} points.");
        }

        // List goals with their details
        public void ListGoals()
        {
            if (Goals.Count == 0)
            {
                Console.WriteLine("(No goals)");
                return;
            }

            for (int i = 0; i < Goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {Goals[i].GetDetailsString()}");
            }
        }

        // Save goals and score to a text file (simple format)
        public void SaveToFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine(Score);
                foreach (var g in Goals)
                {
                    sw.WriteLine(g.ToSaveString());
                }
            }
            Console.WriteLine($"Saved to {filename}");
        }

        // Load goals and score from a text file
        public void LoadFromFile(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found: " + filename);
                return;
            }

            var lines = File.ReadAllLines(filename);
            if (lines.Length == 0) return;

            Goals.Clear();
            Score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                if (string.IsNullOrEmpty(line)) continue;
                Goals.Add(Goal.FromSaveString(line));
            }

            Console.WriteLine($"Loaded from {filename}");
        }
    }
}