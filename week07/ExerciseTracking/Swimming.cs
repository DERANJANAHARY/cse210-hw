class Swimming : Activity
{
    private int _laps; // number of 50m laps
    private const double LapLengthKm = 0.05; // 50 meters = 0.05 km

    public Swimming(DateTime date, double lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * LapLengthKm; // distance in km
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthMinutes) * 60; // km/h
    }

    public override double GetPace()
    {
        return LengthMinutes / GetDistance(); // min per km
    }
}
