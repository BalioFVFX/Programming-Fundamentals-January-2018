using System;

namespace _03._Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employeeID = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Name: {age}");
            Console.WriteLine($"Name: {employeeID:d8}");
            Console.WriteLine($"Name: {salary:f2}");
        }
    }
}
