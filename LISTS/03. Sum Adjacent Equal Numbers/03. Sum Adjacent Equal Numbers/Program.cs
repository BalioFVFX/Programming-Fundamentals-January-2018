﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if(numbers[i] == numbers[i + 1])
                {
                    decimal result = numbers[i] + numbers[i + 1];
                    numbers[i + 1] = result;
                    numbers.RemoveAt(i);
                    i = -1; 
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
