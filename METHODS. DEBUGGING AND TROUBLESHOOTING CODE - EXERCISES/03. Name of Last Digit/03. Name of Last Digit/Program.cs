using System;

namespace _03._Name_of_Last_Digit
{
    class Program
    {
        static long GetLastDigit(long number)
        {
            return Math.Abs(number % 10);
        }

        static string IntegerToText(long number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "NaN";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IntegerToText(GetLastDigit(long.Parse(Console.ReadLine()))));
        }
    }
}
