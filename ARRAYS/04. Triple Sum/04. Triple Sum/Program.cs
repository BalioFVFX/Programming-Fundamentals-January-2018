using System;
using System.Linq;

namespace _04._Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long[] numbers = input.Split(' ').Select(long.Parse).ToArray();
            int sumCounter = 1;
            bool hasNoSum = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumCounter = i + 1;
                for (int j = 0; j < numbers.Length; j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        
                        if(sumCounter >= numbers.Length)
                        {
                            break;
                        }
                        else
                        {
                            if (numbers[i] + numbers[sumCounter] == numbers[k] && numbers[i] + numbers[sumCounter] != 0)
                            {
                                hasNoSum = false;
                                Console.WriteLine($"{numbers[i]} + {numbers[sumCounter]} == {numbers[k]}");
                                //break;
                                
                            }
                        }
                    }
                    sumCounter++;
                }
            }
            
            if(hasNoSum == true)
            {
                Console.WriteLine("No");
            }
        }
    }
}
