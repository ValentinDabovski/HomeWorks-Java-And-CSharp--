using System;
using System.Globalization;

class DifferencebetweenDates
{
    static void Main()
    {
        string dateStringFirst = Console.ReadLine();
        string dateStringSecond = Console.ReadLine();
        string format = "d.MM.yyyy";
        DateTime firstDate = DateTime.ParseExact(dateStringFirst, format,
        CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(dateStringSecond, format,
        CultureInfo.InvariantCulture);
        int difference = CalculateNumberDifferenceDates(firstDate, secondDate);
        Console.WriteLine("Days between: {0} ", difference);
    }
    private static int CalculateNumberDifferenceDates(DateTime firstDate, DateTime secondDate)
    {
        // Difference in days, hours, and minutes.
        TimeSpan ts = secondDate - firstDate;
        // Difference in days.
        int differenceInDays = ts.Days;
        return differenceInDays;
    }
}