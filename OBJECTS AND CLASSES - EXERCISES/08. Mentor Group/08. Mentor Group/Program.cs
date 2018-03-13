using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace _08._Mentor_Group
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }

        public Student(string name)
        {
            Name = name;
            Comments = new List<string>();
            Dates = new List<DateTime>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            string commandStr = Console.ReadLine();
            
            string comment = string.Empty;

            while(commandStr != "end of dates")
            {
                string[] command = commandStr.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student(command[0]);
                for (int i = 1; i < command.Length; i++)
                {
                    DateTime date = DateTime.ParseExact(command[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    student.Dates.Add(date);
                }
                if(students.ContainsKey(student.Name) == false)
                {
                    students.Add(student.Name, student);
                }
                else
                {
                    students[student.Name].Dates.Add(student.Dates[0]);
                }
                

                commandStr = Console.ReadLine();
            }

            comment = Console.ReadLine();

            while (comment != "end of comments")
            {
                string[] user = comment.Split('-');
                string currentComment = string.Empty;

                
                if(students.ContainsKey(user[0]) == true)
                {
                    List<string> commentCurrent = new List<string>();
                    commentCurrent.Add(user[1]);
                    comment = comment.Remove(0, comment.IndexOf('-') + 1);
                    students[user[0]].Comments.AddRange(commentCurrent);
                }

                comment = Console.ReadLine();
            }

            foreach (var student in students.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");
                foreach (var comments in student.Value.Comments)
                {
                    Console.WriteLine("- " + comments);
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Value.Dates.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date.Day:d2}/{date.Month:d2}/{date.Year}");
                }
            }
        }
    }
}
