using System;

namespace _12._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
          
            string modelOfBiggestKeg = string.Empty;
            double biggestKeg = 0;

            for (byte i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if(biggestKeg < volume)
                {
                    biggestKeg = volume;
                    modelOfBiggestKeg = model;
                }
            }

            Console.WriteLine(modelOfBiggestKeg);
        }
    }
}
