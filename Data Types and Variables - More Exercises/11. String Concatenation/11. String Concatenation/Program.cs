using System;

namespace _11._String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            bool isEven = Console.ReadLine() == "even";
            byte n = byte.Parse(Console.ReadLine());

            string message = string.Empty;

            for (byte i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();

                if(isEven == true)
                {
                    if(i % 2 == 0)
                    {
                        message += word + delimiter;
                    }
                }
                else
                {
                    if(i % 2 != 0)
                    {
                        message += word + delimiter;
                    }
                }
            }

            message = message.Remove(message.Length - 1);
            Console.WriteLine(message);
        }
    }
}
