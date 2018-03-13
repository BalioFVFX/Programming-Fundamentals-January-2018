using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?<day>[0-9]{2})(?<separator>[.|\/|-])(?<month>[A-Z]{1}[a-z]{2})(\k<separator>)(?<year>[0-9]{4})\b";
            List<string> dates = new List<string>();
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

           
        }
    }
}
