using System;

namespace _01._Blank_Receipt
{
    class Program
    {
        static void PrintRecipetHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintRecipetBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintRecipetFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }

        static void PrintRecipet()
        {
            PrintRecipetHeader();
            PrintRecipetBody();
            PrintRecipetFooter();
        }

        static void Main(string[] args)
        {
            PrintRecipet();
        }
    }
}
