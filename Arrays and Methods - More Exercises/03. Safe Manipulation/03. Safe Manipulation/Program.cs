using System;

namespace _03._Safe_Manipulation
{
    class Program
    {
        static bool hasMatch(string[] arr1, string word)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == word)
                {
                    return true;
                }
            }
            return false;
        }

        static int numberOfMatches(string[] arr)
        {
            int matches = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        matches++;
                        break;
                    }
                }
            }
            return matches;
        }
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');


            string[] command = Console.ReadLine().Split(' ');
            while (command[0] != "END")
            {

                if (command[0] == "Distinct" || command[0] == "Reverse" || command[0] == "Replace")
                {
                    if (command.Length == 1)
                    {
                        if (command[0] == "Distinct")
                        {
                            int matchings = numberOfMatches(words);


                            if (matchings != 0)
                            {
                                string[] newArray = new string[words.Length - matchings];

                                int indexCounter = 0;
                                for (int k = 0; k < words.Length; k++)
                                {
                                    if (hasMatch(newArray, words[k]) == false)
                                    {
                                        newArray[indexCounter] = words[k];
                                        indexCounter++;
                                    }

                                }

                                words = newArray;
                            }

                        }

                        if (command[0] == "Reverse")
                        {
                            int counter = 0;
                            for (int j = words.Length - 1; j >= words.Length / 2; j--)
                            {

                                string lastWord = words[counter];
                                words[counter] = words[j];
                                words[j] = lastWord;
                                counter++;

                            }
                        }
                    }
                    if (command[0] == "Replace")
                    {
                        int positoin = int.Parse(command[1]);
                        if (positoin >= words.Length || positoin < 0)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            words[positoin] = command[2];
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine().Split(' ');
            }
        
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
