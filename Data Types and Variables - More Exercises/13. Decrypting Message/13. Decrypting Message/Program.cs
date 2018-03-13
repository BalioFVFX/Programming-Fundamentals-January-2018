using System;

namespace _13._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());
            string message = string.Empty;

            for (byte i = 0; i < n; i++)
            {
                char character = char.Parse(Console.ReadLine());
                character += (char)key;

                message += character;
            }

            Console.WriteLine(message);
        }
    }
}
