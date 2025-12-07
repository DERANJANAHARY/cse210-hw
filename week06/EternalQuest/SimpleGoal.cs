using System;

namespace EternalQuest
{
    // Simple one-time goal: complete once, then done.
    public class SimpleGoal : Goal
    {
        // Public for easy beginner access (but still safe because it's simple)
        public bool IsCompleted;

        public SimpleGoal(string shortName, string description, int points)
            : base(shortName, description, points)
        {
            IsCompleted = false;
        }

        // When recorded, award points once and mark complete.
        public override int RecordEvent()
        {
            if (!IsCompleted)
            {
                IsCompleted = true;
                return Points;
            }
            return 0;
        }

        public override bool IsComplete() => IsCompleted;

        public override string GetDetailsString()
        {
            return (IsCompleted ? "[X] " : "[ ] ") + ShortName + " - " + Description;
        }

        public override string ToSaveString()
        {
            // SIMPLE|ShortName|Description|Points|IsCompleted
            return $"SIMPLE|{ShortName}|{Description}|{Points}|{IsCompleted}";
        }
    }
}
