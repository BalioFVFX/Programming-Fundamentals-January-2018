using System;

namespace _12._Master_Number
{
    class Program
    {
        static bool isPalindrome(long number)
        {
            int num = (int)number;
            int digit = 0;
            int reverse = 0;

            while (num > 0)
            {
                digit = num % 10;
                reverse = reverse * 10 + digit;
                num = num / 10;
            }

            if(reverse == number)
            {
                return true;
            }
            return false;
        }
            

        static bool isDivisibleBySeven(long number)
        {
            int sum = 0;
            while(number > 0)
            {
                sum += (int)number % 10;
                number /= 10;
            }
            if(sum % 7 == 0)
            {
                //Console.WriteLine("True");
                return true;
            }
            return false;
        }

        static bool hasOneEvenDigit2(long number)
        {
            int currentDigit = 0;
            while(number > 0)
            {
                currentDigit = (int)number % 10;
                if(currentDigit % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        static void PrintMasterNumbers(long number)
        {
            
            for (int i = 1; i <= number; i++)
            {
                if(isPalindrome(i) == true && isDivisibleBySeven(i) == true && hasOneEvenDigit2(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            PrintMasterNumbers(long.Parse(Console.ReadLine()));
        }
    }
}
