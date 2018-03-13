using System;

namespace _12._Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSumBoundary = int.Parse(Console.ReadLine());
            int combinations = 0;
            int sum = n;
            int totalSum = 0;

            for (int firstNumber = n; firstNumber >= 1 ; firstNumber--)
            {
                for (int secondNumber = 1; secondNumber <= m; secondNumber++)
                {
                    sum = firstNumber * secondNumber;
                    sum *= 3;
                    totalSum += sum;
                    combinations++;

                    if (totalSum >= maxSumBoundary)
                    {
                        Console.WriteLine(combinations + " combinations");
                        Console.WriteLine("Sum: " + totalSum + " >= " + maxSumBoundary);
                        return;
                    }
                }
            }
            Console.WriteLine(combinations + " combinations");
            Console.WriteLine("Sum: " + totalSum);
        } 
    }
}
