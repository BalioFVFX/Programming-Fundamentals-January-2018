using System;
using System.Globalization;
namespace _01._Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endtDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime[] holidays = new DateTime[11];

            int workingDaysCounter = 0;
            bool isHoliday = false;

            holidays[0] = new DateTime(2018, 1, 1);
            holidays[1] = new DateTime(2018, 3, 3);
            holidays[2] = new DateTime(2018, 5, 1);
            holidays[3] = new DateTime(2018, 5, 6);
            holidays[4] = new DateTime(2018, 5, 24);
            holidays[5] = new DateTime(2018, 9, 6);
            holidays[6] = new DateTime(2018, 9, 22);
            holidays[7] = new DateTime(2018, 11, 1);
            holidays[8] = new DateTime(2018, 12, 24);
            holidays[9] = new DateTime(2018, 12, 25);
            holidays[10] = new DateTime(2018, 12, 26);

            for (DateTime date = startDate; date <= endtDate; date = date.AddDays(1))
            {
                for (int j = 0; j < 11; j++)
                {
                    if (date.Day == holidays[j].Day && date.Month == holidays[j].Month || date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (isHoliday == false)
                {
                    workingDaysCounter++;
                }

                isHoliday = false;

            }

            Console.WriteLine(workingDaysCounter);
        }

    }
}
