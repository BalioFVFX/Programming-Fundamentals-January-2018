using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { '!', ' ', '.', '?', ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();
            List<string> uniquePalindromes = new List<string>();
            bool isPalindrome = false;
            for (int i = 0; i < input.Length; i++)
            {
                int startWordIndex = 0;
                int endWordIndex = input[i].Length - 1;
                int counter = 0;
                isPalindrome = false;
                while(counter != input[i].Length - 1)
                {
                    if(input[i][startWordIndex] != input[i][endWordIndex])
                    {
                        if(input[i].Length == 1)
                        {
                            isPalindrome = true;
                            break;
                        }
                        isPalindrome = false;
                        break;
                    }
                    isPalindrome = true;
                    startWordIndex++;
                    endWordIndex--;
                    counter++;
                }
                if (isPalindrome == true || input[i].Length == 1)
                {
                    if (palindromes.Contains(input[i]))
                    {
                        uniquePalindromes.Add(input[i]);
                    }
                    palindromes.Add(input[i]);
                }
            }

            palindromes.Sort();
            foreach (var uniquePalindrome in uniquePalindromes)
            {
                palindromes.Remove(uniquePalindrome);
            }
            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
