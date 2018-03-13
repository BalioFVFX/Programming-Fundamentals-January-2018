using System;
using System.Text.RegularExpressions;

namespace _01._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(^|(?<=\s))([a-z0-9\.-]+[0-9]*)@([a-z-]+[a-z\.]+\.[a-z]+)\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches) 
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
