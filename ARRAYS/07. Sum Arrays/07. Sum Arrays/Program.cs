using System;
using System.Linq;

namespace _07._Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] firstNumbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] secondNumbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            int counter = Math.Max(firstNumbers.Length, secondNumbers.Length);

            for (int i = 0; i < counter; i++)
            {
                Console.Write(firstNumbers[i%firstNumbers.Length] + secondNumbers[i%secondNumbers.Length] + " ");
            }

            Console.WriteLine();
        }
    }
}
