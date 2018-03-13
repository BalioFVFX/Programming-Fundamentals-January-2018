using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDay = int.Parse(Console.ReadLine());

            string[] daysInWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if(numberOfDay < 1 || numberOfDay > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(daysInWeek[numberOfDay - 1]);
            }
            
        }
    }
}
