using System;
using System.Linq;

namespace _05._Compare_Char_Arrays
{
    class Program
    {
        static void printArray(char[] arr)
        {
            foreach (char word in arr){
                Console.Write(word);
            }
        }

        static void Main(string[] args)
        {
            bool equalArrays = false;

            char[] firstWords = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondWords = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int firstWordsCounter = 0;
            int secondWordsCounter = 0;
            
            if(firstWords.Length < secondWords.Length)
            {
                printArray(firstWords);
                Console.WriteLine();
                printArray(secondWords);
                Console.WriteLine();
                return;
            }
            else if(firstWords.Length == secondWords.Length)
            {
                for (int i = 0; i <firstWords.Length; i++)
                {
                    if(firstWords[i] < secondWords[i])
                    {
                        firstWordsCounter++;
                    }
                    else
                    {
                        secondWordsCounter++;
                    }
                }

                if(firstWordsCounter >= secondWordsCounter)
                {
                    printArray(firstWords);
                    Console.WriteLine();
                    printArray(secondWords);
                    Console.WriteLine();
                }
                else
                {
                    printArray(secondWords);
                    Console.WriteLine();
                    printArray(firstWords);
                    Console.WriteLine();
                }
                return;
            }
            else if(secondWords.Length < firstWords.Length)
            {
                printArray(secondWords);
                Console.WriteLine();
                printArray(firstWords);
                Console.WriteLine();
                return;
            }


        }
    }
}
