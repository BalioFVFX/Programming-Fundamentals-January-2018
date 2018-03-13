using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bestStart = 0;
            int bestLength = 0;
            int counter = 0;
            int bestCounter = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if(counter > bestCounter)
                {
                    bestStart = i;
                    bestLength = counter;
                    bestCounter = counter;
                    i += counter;
                }
                counter = 0;
            }

            for (int i = bestStart; i <= bestStart + bestLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }

    }
}
