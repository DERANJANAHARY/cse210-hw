class Program
{
    static void Main(string[] args)
    {
        // Activity examples
        Activity run = new Running(new DateTime(2025, 12, 3), 30, 2.7);   
        Activity cycle = new Cycling(new DateTime(2025, 12, 9), 45, 12.0); 
        Activity swim = new Swimming(new DateTime(2025, 12, 9), 60, 39);  

        // Create a list of activities
        Activity[] activities = { run, cycle, swim };

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
