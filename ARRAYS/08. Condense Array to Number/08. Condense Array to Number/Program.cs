using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] condensed = new long[numbers.Length - 1];
            int counter = 0;
            int lengthCounter = numbers.Length - 1;
            long sum = 0;

            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0] + " is already condensed to number");
                return;
            }

            while(numbers.Length - 1> 1)
            {
                
                condensed[counter] = numbers[counter] + numbers[counter + 1];
                counter++;
                if(counter + 1 == numbers.Length)
                {
                    counter = 0;
                    numbers = condensed;
                    lengthCounter--;
                    condensed = new long[lengthCounter];
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
