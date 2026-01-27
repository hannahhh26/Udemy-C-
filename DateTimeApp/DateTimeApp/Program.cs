using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace DateTimeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2001, 2, 26);


            Console.WriteLine($"My birtday is {dateTime}");

            // Write today on screen
            Console.WriteLine(DateTime.Today);

            // Write current time on screen
            Console.WriteLine(DateTime.Now);

            // Write tomorrow on screen
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine(tomorrow);

            // Write what day of the week it is
            Console.WriteLine(DateTime.Today.DayOfWeek);

            // Write first day of the year
            Console.WriteLine(GetFirstDayOfYear(2026));

            // Write current minute
            DateTime now = DateTime.Now;
            Console.WriteLine(now.Minute);

            // Format time output
            Console.WriteLine($"{now.Hour} o'clock {now.Minute} minutes and {now.Second} seconds ");

            Console.WriteLine("Write a date in the format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine($"Days passed since: {daysPassed.Days}");
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

                Console.ReadKey();
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
