using System;
using System.Text.RegularExpressions;

namespace _03._Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string surfacePattern = @"[^a-zA-Z0-9]+";
            string mantlePattern = @"[0-9_]+";
            string corePattern = @"[A-Za-z]+";

            int validInputs = 0;
            int coreLength = 0;

            for (int i = 0; i < 2; i++)
            {
                if (i % 2 == 0)
                {
                    string surfaceInput = Console.ReadLine();
                    if (Regex.IsMatch(surfaceInput, surfacePattern))
                    {
                        validInputs++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                        return;
                    }
                }
                else
                {
                    string mantleInput = Console.ReadLine();
                    if (Regex.IsMatch(mantleInput, mantlePattern))
                    {
                        validInputs++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                        return;
                    }
                }
            }

            string middleInput = Console.ReadLine();
            string middlePattern = @"([^a-zA-Z0-9]+)([0-9_]+)([A-Za-z]+)([0-9_]+)([^a-zA-Z0-9]+)";
            if (Regex.IsMatch(middleInput, middlePattern))
            {
                Match coreMatch = Regex.Match(middleInput, corePattern);
                coreLength = coreMatch.Value.Length;
                validInputs++;
            }
            else
            {
                Console.WriteLine("Invalid input");
                return;
            }

            for (int i = 0; i < 2; i++)
            {
                if (i % 2 == 0)
                {
                    string mantleInput = Console.ReadLine();
                    if (Regex.IsMatch(mantleInput, mantlePattern))
                    {
                        validInputs++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                        return;
                    }
                }
                else
                {
                    string surfaceInput = Console.ReadLine();
                    if (Regex.IsMatch(surfaceInput, surfacePattern))
                    {
                        validInputs++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                        return;
                    }

                }
            }

            Console.WriteLine("Valid");
            Console.WriteLine(coreLength);


        }
    }
}
