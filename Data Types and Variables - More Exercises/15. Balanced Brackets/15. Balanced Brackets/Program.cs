using System;

namespace _15._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            string lastInput = string.Empty;

            for (byte i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    if (lastInput == "(")
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }

                    lastInput = input;
                }
                if (input == ")")
                {
                    if (lastInput == ")")
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }

                    lastInput = input;

                }
            }
            if (lastInput == "(")
            {
                Console.WriteLine("UNBALANCED");
                return;
            }
            Console.WriteLine("BALANCED");
        }
    }
}
