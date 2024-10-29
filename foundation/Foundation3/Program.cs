using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity1 = new RunningActivity("27 Oct 2024", 60, 1.5);
        Activity activity2 = new CyclingActivity("27 Oct 2024", 60, 20);
        Activity activity3 = new SwimmingActivity("28 Oct 2024", 60, 10);
        Activity activity4 = new RunningActivity("29 Oct 2024", 35, 2.6);
        Activity activity5 = new CyclingActivity("29 Oct 2024", 180, 23);
        Activity activity6 = new SwimmingActivity("30 Oct 2024", 120, 32);

        List<Activity> activities = new List<Activity>();
        activities.Add(activity1);
        activities.Add(activity2);
        activities.Add(activity3);
        activities.Add(activity4);
        activities.Add(activity5);
        activities.Add(activity6);

        activities.ForEach(activity => Console.WriteLine(activity.GetSummary()));
    }
}