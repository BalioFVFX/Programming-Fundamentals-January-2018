using System;
using System.Linq;

namespace _06._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long start = 0;
            long position = 0;

            long bestStart = 0;
            long bestPosition = 0;
            long length = 0;
            long bestLength = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        start = i;
                        position = j;
                        length++;
                    }
                    else
                    {
                        break;
                    }
                }
                if(length > bestLength)
                {
                    bestStart = start;
                    bestPosition = position;
                    bestLength = length;
                }
                length = 0;
            }

            for (long i = bestStart; i <= bestPosition; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
