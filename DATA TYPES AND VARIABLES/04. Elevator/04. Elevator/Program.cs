using System;

namespace _04._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double courses = numberOfPeople / capacity;

            if (numberOfPeople % capacity != 0)
            {
                courses++;
            }
            
            Console.WriteLine(courses);
        }
    }
}
