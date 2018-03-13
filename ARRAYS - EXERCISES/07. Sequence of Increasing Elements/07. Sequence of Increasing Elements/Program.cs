using System;
using System.Linq;

namespace _07._Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long firstNumberIterator = 0;

            long length = 0;

            long bestStart = 0;
            long bestLength = 0;

            bool skip = false;

            for (long i = 0; i < numbers.Length; i++)
            {
                firstNumberIterator = i;
                for (long j = i + 1; j < numbers.Length; j++)
                {

                    if (numbers[firstNumberIterator] < numbers[j])
                    {
                        length++;
                        firstNumberIterator++;
                    }
                    else
                    {
                        skip = true;
                    }
                    if (length > bestLength)
                    {
                        bestStart = i;
                        bestLength = length;
                    }
                    if (skip == true)
                    {
                        firstNumberIterator = 0;
                        length = 0;
                        skip = false;
                        break;
                    }
                }

                firstNumberIterator = 0;
                length = 0;
            }
            long startIndex = bestStart;
            long stopIndex = bestStart;
            while (startIndex <= (stopIndex + bestLength))
            {
                Console.Write(numbers[startIndex] + " ");
                startIndex++;
            }
            Console.WriteLine();
        }
    }
}


