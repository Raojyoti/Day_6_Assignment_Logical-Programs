using System;

namespace Gregorian_calendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter day: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Week.DayOfWeek();
        }
    }
}
