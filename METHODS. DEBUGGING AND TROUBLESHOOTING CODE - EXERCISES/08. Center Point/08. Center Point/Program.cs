﻿using System;

namespace _08._Center_Point
{
    class Program
    {
        static void PrintClosesetPoint(double x1, double y1, double x2, double y2)
        {
            double sum1 = Math.Abs(x1) + Math.Abs(y1);
            double sum2 = Math.Abs(x2) + Math.Abs(y2);

            if (Math.Min(sum1, sum2) >= sum1)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosesetPoint(x1, y1, x2, y2);
        }
    }
}
