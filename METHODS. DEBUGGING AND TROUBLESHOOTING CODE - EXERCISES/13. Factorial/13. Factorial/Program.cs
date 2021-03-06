﻿using System;
using System.Numerics;

namespace _13._Factorial
{
    class Program
    {
        static BigInteger Factorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(n));
        }
    }
}
