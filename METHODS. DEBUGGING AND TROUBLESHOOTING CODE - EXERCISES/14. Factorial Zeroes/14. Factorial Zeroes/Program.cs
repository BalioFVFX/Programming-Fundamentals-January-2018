using System;
using System.Numerics;

namespace _14._Factorial_Zeroes
{
    class Program
    {

        static int GetZeroes(BigInteger number)
        {
            string numberStr = number.ToString();
            int zeroCounter = 0;
            while (true)
            {
                if(numberStr.EndsWith("0") == true)
                {
                    numberStr = numberStr.Remove(numberStr.Length - 1);
                    zeroCounter++;
                }
                else
                {
                    break;
                }
            }
            return zeroCounter;
        }

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
            BigInteger factorial = Factorial(n);
            int numberOfZeroes = GetZeroes(factorial);
            Console.WriteLine(numberOfZeroes);
        }
    }
}
