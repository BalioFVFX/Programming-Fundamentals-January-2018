﻿using System;
using System.Linq;

namespace _11._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;

            if(numbers.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }


            for (int i = 0; i < numbers.Length; i++)
            {
                    for (int j = 0; j < i; j++)
                    {
                        leftSum += numbers[j];
                    }
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        rightSum += numbers[j];
                    }
                    if (leftSum == rightSum)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                    leftSum = 0;
                    rightSum = 0;
            }

            Console.WriteLine("no");
        }
    }
}
