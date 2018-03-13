using System;

namespace _13._Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int firstCombination = 0;
            int secondCombination = 0;
            int combinations = 0;

            for (int firstNumber = n; firstNumber <= m; firstNumber++)
            {
                for (int secondNumber = n; secondNumber <= m; secondNumber++)
                {
                    if(firstNumber + secondNumber == magicalNumber)
                    {
                        firstCombination = firstNumber;
                        secondCombination = secondNumber;
                    }
                    combinations++;
                }
            }
            if(firstCombination != 0 && secondCombination != 0)
            {
                Console.WriteLine($"Number found! {firstCombination} + {secondCombination} = {magicalNumber}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicalNumber}");
            }
            
        }
    }
}
