using System;
using System.Collections.Generic;

namespace _0._7_Primes_in_Given_Range
{
    class Program
    {
        static List<int> FindPrimesInRage(int startNum, int endNum)
        {
            bool isCurrentNumberPrime = false;
            List<int> primes = new List<int>();

            if (startNum <= 2)
            {
                startNum = 3;
            }
            if (startNum <= 3 && endNum >= 2)
            {
                primes.Add(2);
            }

            for (int i = startNum; i <= endNum; i++)
            {
                isCurrentNumberPrime = true;
                for (long j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isCurrentNumberPrime = false;
                        break;
                    }
                }
                if (isCurrentNumberPrime == true)
                {
                    primes.Add(i);

                }
            }

            return primes;

        }

        static void ListPrinter(List<int> list)
        {
            string result = string.Empty;
            if(list.Count <= 0)
            {
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                result += list[i].ToString() + ", ";
            }

            result = result.Remove(result.Length - 2);

            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            List<int> listOfPrimeNumbers = new List<int>();

            listOfPrimeNumbers = FindPrimesInRage(startNumber, endNumber);

            ListPrinter(listOfPrimeNumbers);
        }
    }
}
