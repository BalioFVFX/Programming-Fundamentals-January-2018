using System;
using System.Linq;

namespace _08._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = 0;
            int maxLength = 0;
            int currentNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        length++;
                    }
                }

                if(length > maxLength)
                {
                    currentNumber = numbers[i];
                    maxLength = length;
                }
                length = 0;
            }

            Console.WriteLine(currentNumber);
        }
    }
}
