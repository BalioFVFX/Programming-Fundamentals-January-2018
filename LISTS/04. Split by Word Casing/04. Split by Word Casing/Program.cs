using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Split_by_Word_Casing
{
    class Program
    {
        static bool isLower(string word)
        {
            bool isLower = false;
            for (int i = 0; i < word.Length; i++)
            {
               
                if (word[i] >= 'a' && word[i] <= 'z')
                {
                    isLower = true;
                }
                else
                {
                    return false;
                }
            }
            return isLower;
        }

        static bool isUpper(string word)
        {
            bool isUpper = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'A' && word[i] <= 'Z')
                {
                    isUpper = true; ;
                }
                else
                {
                    return false;
                }
            }
            return isUpper;
        }

        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                string word = text[i];
                if (isLower(word))
                {
                    lowerCase.Add(word);
                }
                else if (isUpper(word))
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }
    }
}
