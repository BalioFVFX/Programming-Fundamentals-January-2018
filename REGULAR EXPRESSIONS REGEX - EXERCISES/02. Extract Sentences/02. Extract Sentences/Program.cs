using System;
using System.Text.RegularExpressions;

namespace _02._Extract_Sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string spaceKeyword = Console.ReadLine();
            string[] input = Console.ReadLine().Split('.', '!', '?');
            string pattern = $@"\b[\w\W]*\b{spaceKeyword}\b[\w\W]*\b";

            foreach (var sentence in input)
            {
                if(Regex.IsMatch(sentence, pattern) == true)
                {
                    Console.WriteLine(sentence.Trim());
                }
            }


        }
    }
}
