using System;

namespace _11._Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
      

            float distanceInMeters = float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int timeFormula = hours * 3600 + minutes * 60 + seconds;

            float metersPerSecond = distanceInMeters / timeFormula;
            float kilometersPerHour = (float)Math.Round((distanceInMeters / 1000) / ((float)timeFormula / 3600),7);
            float milesPerHour = (float)Math.Round((distanceInMeters / 1609) / ((float)timeFormula / 3600), 7);

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
