using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades;
        public double averageGrade { get; }

        public Student(string[] input)
        {
            Name = input[0];
            Grades = new List<double>();
            for (int i = 1; i < input.Length; i++)
            {
                
                Grades.Add(double.Parse(input[i]));
            }
            averageGrade = Grades.Average();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Student student = new Student(input);
                if (student.averageGrade >= 5.00)
                {
                    students.Add(student);
                }
            }

            // Mark ordering
            students = students.OrderByDescending(x => x.averageGrade).ToList();

            // Forach with name order
            foreach (var student in students.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{student.Name} -> {student.averageGrade:f2}");
            }

        }
    }
}
