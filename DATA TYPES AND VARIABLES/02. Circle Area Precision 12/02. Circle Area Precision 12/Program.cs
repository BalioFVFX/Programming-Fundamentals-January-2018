﻿using System;

namespace _02._Circle_Area_Precision_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"{area:f12}");
        }
    }
}
