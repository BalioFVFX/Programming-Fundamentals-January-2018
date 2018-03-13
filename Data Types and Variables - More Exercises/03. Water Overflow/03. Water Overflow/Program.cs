using System;

namespace _03._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int liters = 0;

            for (int i = 0; i < n; i++)
            {
                int currentLiters = int.Parse(Console.ReadLine());

                if(liters + currentLiters <= 255)
                {
                    liters += currentLiters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(liters);
            
        }
    }
}
