class Running : Activity
{
    private double _distance; // distance in miles (or km)

    public Running(DateTime date, double lengthMinutes, double distance)
        : base(date, lengthMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / LengthMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthMinutes / _distance;
    }
}
