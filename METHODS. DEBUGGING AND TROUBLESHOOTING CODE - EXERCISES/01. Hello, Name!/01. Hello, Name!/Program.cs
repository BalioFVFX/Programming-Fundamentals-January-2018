using System;

namespace _01._Hello__Name_
{
    class Program
    {
        static void GreetByName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static void Main(string[] args)
        {
            GreetByName(Console.ReadLine());
        }
    }
}
