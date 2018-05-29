using System;

namespace TimeSpanDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating
            var timeSpan =  new TimeSpan(1, 2, 3);
            Console.WriteLine("imeSpan: " + timeSpan);

            var timeSpan1 =  new TimeSpan(1, 0, 0); // 1h
            var timeSpan2 = TimeSpan.FromHours(1);  // 1h

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start; // result is a TimeSpan

            Console.WriteLine("Start: " + start);
            Console.WriteLine("End: " + end);
            Console.WriteLine("Duration: " + duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);  // Minutes component of timespan object
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);   // convert the timespan object into minutes

            // Add / Sub
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); // Add 8 minutes to timeSpan
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2))); // Add 8 minutes to timeSpan

            // ToString
            Console.WriteLine("ToString" + timeSpan.ToString());    // ToString is used by default by Console.WriteLine

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
