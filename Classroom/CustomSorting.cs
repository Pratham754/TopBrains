using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace _20CustomSorting
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }
    class StudentComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {

            int markCompare = y.Marks.CompareTo(x.Marks);
            if (markCompare != 0)
                return markCompare;

            return x.Age.CompareTo(y.Age);
        }
    }
    class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>
        {
            new Student { Name = "A", Age = 22, Marks = 90 },
            new Student { Name = "B", Age = 20, Marks = 90 },
            new Student { Name = "C", Age = 21, Marks = 85 },
            new Student { Name = "D", Age = 19, Marks = 95 }
        };

            students.Sort(new StudentComparer());

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Marks: {student.Marks}");
            }
        }
    }
}