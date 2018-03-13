using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static double GetCubeProperties(double side, string property)
        {
            switch (property)
            {
                case "face":
                    return Math.Sqrt(2 *(Math.Pow(side, 2)));
                case "space":
                    return Math.Sqrt((Math.Pow(side, 2)) * 3);
                case "volume":
                    return Math.Pow(side, 3);
                case "area":
                    return Math.Pow(side, 2) * 6;
                default:
                    return side;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"{GetCubeProperties(double.Parse(Console.ReadLine()), Console.ReadLine()):f2}");
        }
    }
}
