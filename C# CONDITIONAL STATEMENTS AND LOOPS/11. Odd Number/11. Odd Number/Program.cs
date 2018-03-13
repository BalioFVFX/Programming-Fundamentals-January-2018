using System;

namespace _11._Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            while (number % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                number = Math.Abs(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("The number is: " + number);
        }
    }
}
