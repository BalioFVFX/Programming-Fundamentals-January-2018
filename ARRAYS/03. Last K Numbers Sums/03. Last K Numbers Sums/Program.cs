using System;

namespace _03._Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] seq = new long[n];
            seq[0] = 1;

            for (long i = 1; i < n; i++)
            {
                long sum = 0;
                long counter = 0;
              
                    for (long j = 1; j <= k; j++)
                    {
                        counter++;
                        if (i - counter >= 0)
                        {
                            sum += seq[i - counter];
                        }

                    }
                    seq[i] = sum;
            }

            Console.WriteLine(string.Join(" ", seq));
        }
    }
}