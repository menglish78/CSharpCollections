using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student() { Name = "Sally", GradeLevel = 3 },
                new Student() { Name = "Bob", GradeLevel = 3 },
                new Student() { Name = "Sally", GradeLevel = 2 }
            };

            SchoolRoll schoolRoll = new SchoolRoll();
            schoolRoll.AddStudents(students);

            schoolRoll.Students.RemoveAt(0);
            schoolRoll.Students.Sort();

            schoolRoll.Students.AddRange(students);

            foreach(Student student in schoolRoll.Students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }

            Console.ReadLine();
        }
    }
}
