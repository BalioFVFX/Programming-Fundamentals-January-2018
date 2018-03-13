using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Sum_Reversed_Numbers
{
    class Program
    {
        static int Reverse(string numberStr)
        {
            string number = string.Empty;
            for (int i = numberStr.Length - 1; i >= 0; i--)
            {
                number += numberStr[i];
            }
           
            return int.Parse(number);
        }
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] reversedNumbers = new int[numbers.Count];
            int sum = 0;
            for (int i = 0; i < reversedNumbers.Length; i++)
            {
                reversedNumbers[i] = Reverse(numbers[i].ToString());
            }
            for (int i = 0; i < reversedNumbers.Length; i++)
            {
                sum += reversedNumbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
