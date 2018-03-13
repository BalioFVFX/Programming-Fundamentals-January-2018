using System;
using System.Linq;

namespace _03._Fold_and_Sum
{
    class Program
    {

        static int[] combineArrays(int[] arr1, int[] arr2)
        {
            int[] arr = new int[arr1.Length * 2];
            int counter = arr1.Length;
            for (int i = 0; i < arr1.Length; i++)
            {
                arr[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr[counter] = arr2[i];
                counter++;
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int formula = numbers.Length / 4;
            int[] middleNumbers = new int[formula * 2];
            int[] startNumbers = new int[(numbers.Length - formula * 2) - formula];
            int[] endNumbers = new int[startNumbers.Length];
            int[] finalArray = new int[middleNumbers.Length];
            int[] sumArray = new int[middleNumbers.Length];
            int counter = formula;
            for (int i = 0; i < middleNumbers.Length; i++)
            {
                middleNumbers[i] = numbers[counter];
                counter++;
            }

            for (int i = 0; i < formula; i++)
            {
                startNumbers[i] = numbers[i];
            }
            counter = 0;
            for (int i = middleNumbers.Length + startNumbers.Length; i < numbers.Length; i++)
            {
                endNumbers[counter] = numbers[i];
                counter++;
            }

            Array.Reverse(startNumbers);
            Array.Reverse(endNumbers);

            finalArray = combineArrays(startNumbers, endNumbers);

            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = finalArray[i] + middleNumbers[i];
            }


            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
