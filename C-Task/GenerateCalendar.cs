// ========================================================
// Generate calendar based on current month
// ========================================================
//
// Expected result
//   Januari 2020
//   S    S    R    K    J    S    M
//             1    2    3    4    5
//   6    7    8    9    10   11   12
//   13   14   15   16   17   18   19
//   20   21   22   23   24   25   26
//   27   28   29   30   31

using System;

namespace ChallengeApp
{
    public class GenerateCalendar
    {
        public static string Run(int year,int months) {
        var month = new DateTime(year, months, 1);
     
        var headingSpaces = new string(' ', 16 - month.ToString("MMMM").Length);
        Console.WriteLine($"{month.ToString("MMMM")}{headingSpaces}{month.Year}");
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Su Mo Tu We Th Fr Sa");

        string print = $"{month.ToString("MMMM")}{headingSpaces}{month.Year}";
        print += new string('-', 20);
        print += "Su Mo Tu We Th Fr Sa";

        var padLeftDays = (int)month.DayOfWeek;
        var currentDay = month;

        var iterations = DateTime.DaysInMonth(month.Year, month.Month) + padLeftDays;
        for (int j = 0; j < iterations; j++)
        {
            if (j < padLeftDays)
            {
                Console.Write("   ");
                print += "   ";
            }
            else
            {

                Console.Write($"{currentDay.Day.ToString().PadLeft(2, ' ')} ");
                print += $"{currentDay.Day.ToString().PadLeft(2, ' ')} ";
                if ((j + 1) % 7 == 0)
                {
                    Console.WriteLine();
                    print += "\n";
                }

                currentDay = currentDay.AddDays(1);
            }
        }

        Console.WriteLine(); 
        print += "\n";
        return print;
         }
    }
}
