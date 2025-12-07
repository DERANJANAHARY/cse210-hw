using System;

namespace EternalQuest
{
    // Eternal goal: never completes; awards points every time.
    public class EternalGoal : Goal
    {
        public EternalGoal(string shortName, string description, int points)
            : base(shortName, description, points)
        {
        }

        public override int RecordEvent()
        {
            // Always award points.
            return Points;
        }

        public override bool IsComplete() => false;

        public override string GetDetailsString()
        {
            return "[∞] " + ShortName + " - " + Description;
        }

        public override string ToSaveString()
        {
            // ETERNAL|ShortName|Description|Points
            return $"ETERNAL|{ShortName}|{Description}|{Points}";
        }
    }
}
