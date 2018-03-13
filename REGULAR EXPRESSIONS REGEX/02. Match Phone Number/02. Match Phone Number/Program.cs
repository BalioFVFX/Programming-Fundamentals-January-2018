using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^\+359| [+]359)(?<delimeter>[ |-])[2](\k<delimeter>)([\d]{3})(\k<delimeter>)([\d]{4})\b";
            List<string> numbers = new List<string>();
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                numbers.Add(match.Value.Trim(' ', ','));
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
