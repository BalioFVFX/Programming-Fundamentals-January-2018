using System;
using System.Numerics;

namespace _01._Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string result = string.Empty;
            BigInteger decimalNumb = BigInteger.Parse(input[1]);
            BigInteger n = BigInteger.Parse(input[0]);
            BigInteger reminder = 0;
            while (decimalNumb != 0)
            {
                reminder = decimalNumb % n;
                result = reminder + result;
                decimalNumb /= n;
            }
            Console.WriteLine(result);
        }
    }
}
