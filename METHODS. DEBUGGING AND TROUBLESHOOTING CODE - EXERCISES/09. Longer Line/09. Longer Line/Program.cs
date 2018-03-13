using System;

namespace _09._Longer_Line
{
    class Program
    {
        static void PrintClosesetPoint(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double distance1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double distance2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

            if(distance1 >= distance2)
            {
                if (Math.Abs(x1 + y1) > Math.Abs(x2 + y2))
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                    
                }
                else
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
            }
            else
            {
                if(Math.Abs(x3 + y3) > Math.Abs(x4 + y4))
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                else
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                
            }

        }

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintClosesetPoint(x1, y1, x2, y2, x3, y3, x4, y4);
        }
    }
}
