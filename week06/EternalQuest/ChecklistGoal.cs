using System;

namespace EternalQuest
{
    // Checklist goal: do something N times; on final time you get a bonus.
    public class ChecklistGoal : Goal
    {
        // Private fields with public getters for safe external access
        private int _current;
        private int _target;
        private int _bonus;
        private bool _isCompleted;

        public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
            : base(shortName, description, points)
        {
            _target = Math.Max(1, target);
            _bonus = Math.Max(0, bonus);
            _current = 0;
            _isCompleted = false;
        }

        // Public properties to allow GoalManager to read values without touching private fields
        public int Current
        {
            get => _current;
            set => _current = value; // used by loader
        }

        public int Target => _target;
        public int Bonus => _bonus;

        // Loader-friendly property (used by FromSaveString)
        public bool IsCompleted
        {
            get => _isCompleted;
            set => _isCompleted = value;
        }

        public override int RecordEvent()
        {
            if (_isCompleted) return 0;

            _current++;
            int awarded = Points;

            if (_current >= _target)
            {
                _isCompleted = true;
                awarded += _bonus;
            }

            return awarded;
        }

        public override bool IsComplete() => _isCompleted;

        public override string GetDetailsString()
        {
            return $"[{_current}/{_target}] " + ShortName + " - " + Description + (_isCompleted ? " (Completed)" : "");
        }

        public override string ToSaveString()
        {
            // CHECK|ShortName|Description|Points|Target|Current|Bonus|IsCompleted
            return $"CHECK|{ShortName}|{Description}|{Points}|{_target}|{_current}|{_bonus}|{_isCompleted}";
        }
    }
}
