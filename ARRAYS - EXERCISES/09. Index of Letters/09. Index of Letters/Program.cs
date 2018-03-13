using System;

namespace _09._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alphabetLetters = new string[26];
            int counter = 0;
            string word = Console.ReadLine();
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                alphabetLetters[counter] = letter.ToString();
                counter++;
            }

            for (int i = 0; i < word.Length; i++)
            {
                string currentWord = word[i].ToString();
                for (int j = 0; j < alphabetLetters.Length; j++)
                {
                    
                    if(currentWord == alphabetLetters[j])
                    {
                        Console.WriteLine(word[i] + " -> " + j);
                        break;
                    }
                }
            }
        }
    }
}
