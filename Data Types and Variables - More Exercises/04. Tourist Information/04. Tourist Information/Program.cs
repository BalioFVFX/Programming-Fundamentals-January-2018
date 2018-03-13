using System;

namespace _04._Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            switch (imperialUnit)
            {
                case "miles":
                    Console.WriteLine("{0} {1} = {2:f2} kilometers", value, imperialUnit, value * 1.6);
                    break;
                case "inches":
                    Console.WriteLine("{0} {1} = {2:f2} centimeters", value, imperialUnit, value * 2.54);
                    break;
                case "feet":
                    Console.WriteLine("{0} {1} = {2:f2} centimeters", value, imperialUnit, value * 30);
                    break;
                case "yards":
                    Console.WriteLine("{0} {1} = {2:f2} meters", value, imperialUnit, value * 0.91);
                    break;
                case "gallons":
                    Console.WriteLine("{0} {1} = {2:f2} liters", value, imperialUnit, value * 3.8);
                    break;
                default:
                    break;
            }


        }
    }
}
