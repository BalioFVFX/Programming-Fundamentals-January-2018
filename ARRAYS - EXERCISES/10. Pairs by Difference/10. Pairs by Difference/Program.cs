using System;
using System.Linq;

namespace _10._Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int differences = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if(Math.Abs(numbers[i] - numbers[j]) == difference)
                    {
                        differences++;
                    }
                }
            }
            Console.WriteLine(differences);
        }
    }
}
