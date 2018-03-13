using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Pokemon_Dont_Go
{
    class Program
    {
        static List<int> Processlist(List<int> input, int selectedNumber)
        {
            List<int> processedList = new List<int>();

            foreach (var number in input)
            {
                int currentNumber = 0;

                if (number <= selectedNumber)
                {
                    currentNumber = number + selectedNumber;
                }
                else
                {
                    currentNumber = number - selectedNumber;
                }
                processedList.Add(currentNumber);
            }

            return processedList;
        }

        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> results = new List<int>();

            while (inputList.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int firstNumber = inputList[0];
                    inputList.RemoveAt(0);
                    results.Add(firstNumber);
                    inputList.Insert(0, inputList[inputList.Count - 1]);
                    inputList = Processlist(inputList, firstNumber);
                    continue;
                }
                if (index > inputList.Count - 1)
                {
                    int lastNumber = inputList[inputList.Count - 1];
                    results.Add(lastNumber);
                    inputList.RemoveAt(inputList.Count - 1);
                    inputList.Add(inputList[0]);
                    inputList = Processlist(inputList, lastNumber);
                    continue;
                }

                int selectedNumber = inputList[index];
                inputList.RemoveAt(index);
                results.Add(selectedNumber);
                inputList = Processlist(inputList, selectedNumber);
            }

            Console.WriteLine(results.Sum());
        }
    }
}
