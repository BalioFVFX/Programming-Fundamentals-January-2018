using System;

namespace _07._Math_Power
{
    class Program
    {
        static double RaiseToPower(double number, int power)
        {
            return Math.Pow(number, power);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RaiseToPower(double.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
    }
}
