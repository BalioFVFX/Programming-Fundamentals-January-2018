using System;
using System.Linq;
namespace _09._Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string pattern = Console.ReadLine();

            int counter = 0;
            while (true)
            {
                counter = 0;



                    if (firstLine.Contains(pattern) == true)
                    {
                        while (firstLine.Contains(pattern) == true && pattern != "")
                        {
                            firstLine = firstLine.Remove(firstLine.IndexOf(pattern), pattern.Length);
                            counter++;
                              
                        }

                    }
                 
                if(counter >= 2)
                {
                    Console.WriteLine("Shaked it.");
                    pattern = pattern.Remove(pattern.Length / 2);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(firstLine);
                    return;
                }

                
            }

        }
    }
}
