using System;

namespace EternalQuest
{
    // Base class for all goals.
    // Uses private fields with public read-only properties for safe access.
    public abstract class Goal
    {
        // Private fields
        private string _shortName;
        private string _description;
        private int _points;

        // Constructor
        protected Goal(string shortName, string description, int points)
        {
            _shortName = shortName;
            _description = description;
            _points = points;
        }

        // Public read-only properties so other classes can read them safely
        public string ShortName => _shortName;
        public string Description => _description;
        public int Points => _points;

        // When user records this goal, return points awarded by this event.
        public abstract int RecordEvent();

        // Whether the goal is complete (some goals never complete).
        public abstract bool IsComplete();

        // Small string for lists (e.g., "[X]" or "[3/5]" or "[∞]").
        public abstract string GetDetailsString();

        // Convert to one-line string for saving
        public abstract string ToSaveString();

        // Factory to create concrete Goal from a saved line.
        public static Goal FromSaveString(string line)
        {
            // Format:
            // SIMPLE|ShortName|Description|Points|IsCompleted
            // ETERNAL|ShortName|Description|Points
            // CHECK|ShortName|Description|Points|Target|Current|Bonus|IsCompleted

            string[] parts = line.Split('|');
            string type = parts[0];

            if (type == "SIMPLE")
            {
                var g = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                g.IsCompleted = bool.Parse(parts[4]);
                return g;
            }
            else if (type == "ETERNAL")
            {
                return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
            }
            else if (type == "CHECK")
            {
                var g = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[6]));
                g.Current = int.Parse(parts[5]);
                g.IsCompleted = bool.Parse(parts[7]);
                return g;
            }
            else
            {
                throw new Exception("Unknown goal type in save file: " + type);
            }
        }
    }
}
