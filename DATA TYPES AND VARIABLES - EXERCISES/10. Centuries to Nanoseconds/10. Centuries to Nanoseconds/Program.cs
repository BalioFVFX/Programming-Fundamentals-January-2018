using System;
using System.Numerics;

namespace _10._Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int)Math.Truncate(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            long seconds = (long)minutes * 60;
            ulong millisecond = (ulong)seconds * 1000;
            ulong microseconds = millisecond * 1000;
            BigInteger nanoseconds = (BigInteger)microseconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {millisecond} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
