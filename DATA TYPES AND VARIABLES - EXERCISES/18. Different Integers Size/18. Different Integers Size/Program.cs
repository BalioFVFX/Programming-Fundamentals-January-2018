using System;

namespace _18._Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            try
            {
                long input = long.Parse(n);
                Console.WriteLine($"{input} can fit in:");

                if (input <= -0)
                {
                    if(input <= sbyte.MaxValue && input >= sbyte.MinValue)
                    {
                        Console.WriteLine("* sbyte");
                    }
                    if(input <= short.MaxValue && input >= short.MinValue)
                    {
                        Console.WriteLine("* short");
                    }
                    if(input <= int.MaxValue && input >= int.MinValue)
                    {
                        Console.WriteLine("* int");
                    }
                    if(input <= long.MaxValue && input >= long.MinValue)
                    {
                        Console.WriteLine("* long");
                    }
                }
                else
                {
                    if(input <= sbyte.MaxValue)
                    {
                        Console.WriteLine("* sbyte");
                    }
                    if (input <= byte.MaxValue)
                    {
                        Console.WriteLine("* byte");
                    }
                    if (input <= short.MaxValue)
                    {
                        Console.WriteLine("* short");
                    }
                    if (input <= ushort.MaxValue)
                    {
                        Console.WriteLine("* ushort");
                    }
                    if (input <= int.MaxValue)
                    {
                        Console.WriteLine("* int");
                    }
                    if (input <= uint.MaxValue)
                    {
                        Console.WriteLine("* uint");
                    }
                    if (input <= long.MaxValue)
                    {
                        Console.WriteLine("* long");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"{n} can't fit in any type");
                
            }

        
        }
    }
}
