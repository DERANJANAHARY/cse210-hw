using System;

abstract class Activity
{
    private DateTime _date;
    private double _lengthMinutes; // duration in minutes

    public Activity(DateTime date, double lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    // Encapsulation: public getters
    public DateTime Date => _date;
    public double LengthMinutes => _lengthMinutes;

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance(); // in chosen units (miles or km)
    public abstract double GetSpeed();    // in chosen units (mph or kph)
    public abstract double GetPace();     // min per mile or min per km

    // Summary method using the other methods
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_lengthMinutes} min) - " +
               $"Distance: {GetDistance():0.##}, Speed: {GetSpeed():0.##}, Pace: {GetPace():0.##} min per unit";
    }
}
