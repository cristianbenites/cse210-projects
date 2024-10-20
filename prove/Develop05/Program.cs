using System;

// This system exceeds requirements.
// It never repeats the same question in reflecting activity until they all have been used in that session.

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            string menuOption = GetMenuOptionFromUser();

            if (menuOption == "4")
            {
                break;
            }

            if (menuOption == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
            }

            if (menuOption == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity(
                    "Reflection Activity",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
                );

                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
            }

            if (menuOption == "3")
            {
                ListingActivity listingActivity = new ListingActivity(
                    "Listing Activity",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
                );

                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }
        }
    }

    private static string GetMenuOptionFromUser()
    {
        Console.WriteLine("Menu Options:");

        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");

        Console.Write("Select a choice from the menu: ");

        return Console.ReadLine();
    }
}