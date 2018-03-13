using System;

namespace _06._Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            object obj = input1 + " " + input2;

            string output = (string)obj;

            Console.WriteLine(output);
        }
    }
}
