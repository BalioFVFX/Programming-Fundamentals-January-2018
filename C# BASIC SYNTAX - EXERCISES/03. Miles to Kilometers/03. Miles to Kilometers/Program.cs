using System;

namespace _03._Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometer = 1.60934;

            double miles = double.Parse(Console.ReadLine());

            double kilometers = kilometer * miles;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
