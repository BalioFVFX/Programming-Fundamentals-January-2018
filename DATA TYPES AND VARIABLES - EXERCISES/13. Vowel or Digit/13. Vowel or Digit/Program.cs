using System;

namespace _13._Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine().ToUpper());

            switch (input)
            {
                case 'A':
                    Console.WriteLine("vowel");
                    break;
                case 'E':
                    Console.WriteLine("vowel");
                    break;
                case 'I':
                    Console.WriteLine("vowel");
                    break;
                case 'O':
                    Console.WriteLine("vowel");
                    break;
                case 'U':
                    Console.WriteLine("vowel");
                    break;
                case 'Y':
                    Console.WriteLine("vowel");
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("digit");
                    break;

                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}
