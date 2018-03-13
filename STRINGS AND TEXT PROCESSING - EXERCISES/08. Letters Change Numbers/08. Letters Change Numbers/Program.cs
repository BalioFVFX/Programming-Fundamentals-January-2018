using System;
using System.Linq;
namespace _08._Letters_Change_Numbers
{
    class Program
    {



        static void Main(string[] args)
        {
            char[] alphabetUpper = new char[26];
            string upperCaseAlphabet = string.Empty;
            string lowerCaseAlphabet = string.Empty;
            string numberStr = string.Empty;
            decimal sum = 0.0m;
            for (int i = 65; i <= 90; i++)
            {
                upperCaseAlphabet += (char)i;
            }

            lowerCaseAlphabet = upperCaseAlphabet.ToLower();



            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int counter = 0;
            int letterPosition = 0;
            bool canCollectLetters = true;
            bool doLastCalculation = false;
            string lastLetter = string.Empty;
            int arrayCounter = 0;
            decimal totalSum = 0m;

            while (true)
            {
                if (doLastCalculation == true)
                {
                    if (upperCaseAlphabet.Contains(lastLetter) == true)
                    {
                        letterPosition = upperCaseAlphabet.IndexOf(lastLetter);
                        letterPosition++;
                        sum -= letterPosition;
                    }
                    else
                    {
                        letterPosition = lowerCaseAlphabet.IndexOf(lastLetter);
                        letterPosition++;
                        sum += letterPosition;
                    }
                    letterPosition = 0;
                    arrayCounter++;
                    doLastCalculation = false;
                    canCollectLetters = true;
                    counter = 0;
                    numberStr = string.Empty;
                    totalSum += sum;
                    sum = 0;
                    if(arrayCounter == input.Length)
                    {
                        Console.WriteLine($"{totalSum:f2}");
                        break;
                    }
                }

                if (upperCaseAlphabet.Contains(input[arrayCounter][counter]))
                {
                    if (canCollectLetters == false && lowerCaseAlphabet.Contains(lastLetter))
                    {
                        sum = decimal.Parse(numberStr) * letterPosition;

                        letterPosition = 0;

                        doLastCalculation = true;
                    }
                    else if (canCollectLetters == false && upperCaseAlphabet.Contains(lastLetter))
                    {
                        sum = decimal.Parse(numberStr) / letterPosition;
                       
                        letterPosition = 0;

                        doLastCalculation = true;
                    }

                    letterPosition = upperCaseAlphabet.IndexOf(input[arrayCounter][counter]);
                    letterPosition++;
                    lastLetter = input[arrayCounter][counter].ToString();


                }
                else if (lowerCaseAlphabet.Contains(input[arrayCounter][counter]))
                {
                    if (canCollectLetters == false && lowerCaseAlphabet.Contains(lastLetter))
                    {
                        sum = int.Parse(numberStr) * letterPosition;

                        letterPosition = 0;

                        doLastCalculation = true;
                    }
                    else if (canCollectLetters == false && upperCaseAlphabet.Contains(lastLetter))
                    {
                        sum = int.Parse(numberStr) / letterPosition;

                        letterPosition = 0;

                        doLastCalculation = true;
                    }
                    letterPosition = lowerCaseAlphabet.IndexOf(input[arrayCounter][counter]);
                    letterPosition++;
                    lastLetter = input[arrayCounter][counter].ToString();
                }
                else
                {
                    numberStr += input[arrayCounter][counter];
                    canCollectLetters = false;
                }
                counter++;
            }

        }
    }
}
