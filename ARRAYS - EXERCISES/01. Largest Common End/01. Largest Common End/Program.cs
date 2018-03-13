using System;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstWords = Console.ReadLine().Split(' ');
            string[] secondWords = Console.ReadLine().Split(' ');
            bool hasSequence = false;
            int counterLeft = 0;
            int counterRight = 0;

            if (secondWords.Length > firstWords.Length)
            {
                string[] tempArr = secondWords;
                secondWords = firstWords;
                firstWords = tempArr;

            }
            if (firstWords[0] == secondWords[0])
            {


                for (int i = 0; i < Math.Max(firstWords.Length, secondWords.Length); i++)
                {
                    for (int j = 0; j < Math.Min(firstWords.Length, secondWords.Length); j++)
                    {
                        if (i >= Math.Max(firstWords.Length, secondWords.Length))
                        {
                            break;
                        }

                        if (hasSequence == true && firstWords[i] != secondWords[j])
                        {
                            break;
                        }
                        hasSequence = false;
                        if (firstWords[i] == secondWords[j] && hasSequence == false)
                        {
                            counterLeft++;
                            if (j != Math.Min(firstWords.Length, secondWords.Length) - 1)
                            {
                                i++;
                            }

                            hasSequence = true;
                        }
                    }
                }

                hasSequence = false;
            }
            if (firstWords[firstWords.Length - 1] == secondWords[secondWords.Length - 1])
            {


                for (int i = Math.Max(firstWords.Length, secondWords.Length) - 1; i >= 0; i--)
                {
                    for (int j = Math.Min(firstWords.Length, secondWords.Length) - 1; j >= 0; j--)
                    {
                        if (i < 0)
                        {
                            break;
                        }

                        if (hasSequence == true && firstWords[i] != secondWords[j])
                        {
                            break;
                        }
                        hasSequence = false;
                        if (firstWords[i] == secondWords[j] && hasSequence == false)
                        {
                            counterRight++;
                            hasSequence = true;
                            if (j != 0)
                            {
                                i--;
                            }
                        }
                    }
                }
            }
            if (counterLeft > counterRight)
            {
                Console.WriteLine(counterLeft);
            }
            else
            {
                Console.WriteLine(counterRight);
            }
        }
    }
}
