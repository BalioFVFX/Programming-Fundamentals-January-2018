using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
namespace _02._Convert2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            BigInteger baseNum = BigInteger.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            
            List<BigInteger> result = new List<BigInteger>();
            int powCounter = 0;
            while(number != 0)
            {
                BigInteger lastDigit = number % 10;
                BigInteger convertedNum = lastDigit * BigInteger.Pow(baseNum, powCounter);
                number /= 10;
                result.Add(convertedNum);
                powCounter++;
            }
            BigInteger finalResult = 0;

            foreach (var item in result)
            {
                finalResult += item;
            }

            Console.WriteLine(finalResult);
        }
    }
}
