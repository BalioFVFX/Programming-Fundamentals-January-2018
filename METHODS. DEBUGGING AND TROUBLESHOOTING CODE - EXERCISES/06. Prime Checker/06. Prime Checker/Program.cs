using System;

namespace _06._Prime_Checker
{
    class Program
    {
        static bool isPrime(long n)
        {
            if(n == 0 || n == 1)
            {
                return false;
            }
            if(n % 2 == 0)
            {
                return false;
            }
            for (long i = 3; i <= Math.Sqrt(n); i+= 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(isPrime(n));
        }
    }
}
