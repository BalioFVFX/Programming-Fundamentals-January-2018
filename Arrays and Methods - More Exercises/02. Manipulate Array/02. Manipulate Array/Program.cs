using System;

namespace _02._Manipulate_Array
{
    class Program
    {
        static bool hasMatch(string[] arr1, string word)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] == word)
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
                    if(arr[i] == arr[j])
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
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                if(command.Length == 1)
                {
                    if(command[0] == "Distinct")
                    {
                        int matchings = numberOfMatches(words);

                        
                        if(matchings != 0)
                        {
                            string[] newArray = new string[words.Length - matchings];
                            
                            int indexCounter = 0;
                            for (int k = 0; k < words.Length; k++)
                            {
                              if(hasMatch(newArray, words[k]) == false)
                                {
                                    newArray[indexCounter] = words[k];
                                    indexCounter++;
                                }
                                
                            }
                            
                            words = newArray;
                        }

                    }

                    if(command[0] == "Reverse")
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
                else
                {
                    int positoin = int.Parse(command[1]);
                    words[positoin] = command[2];
                }
            }

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
