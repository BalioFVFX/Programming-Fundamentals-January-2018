using System;

namespace _02._Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                long number = long.Parse(input);
                Console.WriteLine("integer");
            }
            catch (FormatException)
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
