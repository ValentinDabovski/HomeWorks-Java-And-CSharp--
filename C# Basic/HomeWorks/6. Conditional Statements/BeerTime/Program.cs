using System;
using System.Globalization;

    class Program
    {
        static void Main()
        {
        Console.WriteLine(" Enter Time in format 'hh:mm tt:' ");
        string sTime = Console.ReadLine();
        string format = "h:mm tt";
        DateTime enterTime = DateTime.ParseExact(sTime,
        format, CultureInfo.InvariantCulture);
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("2:59 AM");
        if (enterTime >= startTime || enterTime <= enterTime)
        {
            Console.WriteLine("Beer Time :) ");
        }

        else
        {
            Console.WriteLine("Non-Beer Time :(");        
        }


        }
        
	      
        
    }

