using System;

namespace _06._Calculate_Triangle_Area
{
    class Program
    {
        static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetTriangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
        }
    }
}
