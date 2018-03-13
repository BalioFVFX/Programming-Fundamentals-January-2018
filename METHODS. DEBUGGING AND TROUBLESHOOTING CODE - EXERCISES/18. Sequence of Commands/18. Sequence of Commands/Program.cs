using System;
using System.Linq;

namespace _18._Sequence_of_Commands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string line = command.Trim();
                int[] args = new int[2];
               
                if (command.Contains("add") ||
                    command.Contains("subtract") ||
                    command.Contains("multiply"))
                {
                    string[] stringParams = line.Split(ArgumentsDelimiter);
                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);
                    args[0] = args[0] - 1;
                    command = command.Substring(0, command.IndexOf(" "));
                    PerformAction(array, command, args);
                }
                else
                {
                    PerformAction(array, command, args);
                }

                

                PrintArray(array);
                Console.Write('\n');

                command = Console.ReadLine();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            //long[] array = arr.Clone() as long[];
            int pos = args[0];
            int value = args[1];
            //action = action.Substring(0, action.IndexOf(" "));
            switch (action)
            {
                
                case "multiply":
                    arr[pos] *= value;
                    break;
                case "add":
                    arr[pos] += value;
                    break;
                case "subtract":
                    arr[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {

           

            long[] newArray = new long[array.Length];
            long lastNumber = array[array.Length - 1];

            newArray[0] = lastNumber;
            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = array[i - 1];
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                array[i] = newArray[i];
            }

            
        }

        private static void ArrayShiftLeft(long[] array)
        {

            long[] newArray = new long[array.Length];
            long firstDigit = array[0];

            
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                newArray[i] = array[i + 1];
            }

            newArray[newArray.Length - 1] = firstDigit;

            for (int i = 0; i < newArray.Length; i++)
            {
                array[i] = newArray[i];
            }
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
