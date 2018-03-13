using System;

namespace _05._Fibonacci_Numbers
{
    class Program
    {
        static long Fib(long n)
        {
            if(n == 0 || n == 1)
            {
                return 1;
            }

            long lastNumber = 1;
            long currentNumber = 1;

            long counter = 1;
            long sum = 0;
            while(counter != n)
            {
                sum = lastNumber + currentNumber;
                lastNumber = currentNumber;
                currentNumber = sum;
                counter++;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(long.Parse(Console.ReadLine())));
        }
    }
}
