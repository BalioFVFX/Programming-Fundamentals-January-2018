using System;
using System.Linq;

namespace _09._Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long counter = 0;
            long sum = 0;
            long lastNumber = 0;
            long lastPosition = 0;
            long position = 0;
            while (true)
            {
                counter = numbers[counter];

                try
                {
                    
                    for (long i = lastPosition; i <= numbers[counter] + 1; i++)
                    {
                        lastNumber = numbers[i];
                        position++;
                    }
                    counter = lastNumber;
                    lastPosition = position;
                }
                catch (Exception)
                {

                    for (long i = lastPosition; i >= numbers[counter] + 1; i--)
                    {
                        lastNumber = numbers[i];
                        position++;
                    }
                    counter = lastNumber;
                    lastPosition = position;
                }
            }
            }
        }
    }
}
