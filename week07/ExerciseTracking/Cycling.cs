class Cycling : Activity
{
    private double _speed; // speed in mph or kph

    public Cycling(DateTime date, double lengthMinutes, double speed)
        : base(date, lengthMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * LengthMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}
