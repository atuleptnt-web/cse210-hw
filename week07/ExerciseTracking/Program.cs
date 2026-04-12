using System;

class Program
{
    static void Main(string[] args)
    {
      List<Activity> activities = new List<Activity>
        {
            new RunningActivity(new DateTime(2022, 11, 3), 30, 4.8),
            new CyclingActivity(new DateTime(2022, 11, 3), 40, 20.0),
            new SwimmingActivity(new DateTime(2022, 11, 3), 25, 30)
        };

        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }
    }

}