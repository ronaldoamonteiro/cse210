using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade in percentage? ");
        string answer = Console.ReadLine();
        int gradePercent = int.Parse(answer);

        string letterGrade = "";

        if (gradePercent >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercent >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercent >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercent >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        string sign = "";

        if (letterGrade != "F")
        {
            int lastDigit = gradePercent % 10;

            if (letterGrade == "A" && lastDigit >= 7)
            {
                sign = ""; // No A+
            }
            else
            {
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }
        }
        else // letterGrade == "F"
        {
            sign = ""; // No F+ or F-
        }
        Console.WriteLine($"Your grade letter is: {letterGrade}{sign}");
        
        if (gradePercent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass this time but you can tray again next semester.");
        }
    }
}