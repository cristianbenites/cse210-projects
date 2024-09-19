using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";

        string message = "Sorry! You didn't pass the class. But don't give up, you will get it next time!";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else {
            letter = "F";
        }

        if(grade >= 60)
        {
            if(grade % 10 >= 7)
            {
                if(grade < 90)
                {
                    letter += "+";
                }
            }
            else
            {
                letter += "-";
            }

        }

        if(grade >= 70)
        {
            message = "Congratulations on your approval! You passed the course.";
        }

        Console.WriteLine($"Your grade is {letter}");
        Console.WriteLine(message);
    }
}