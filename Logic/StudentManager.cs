using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Model;

namespace StudentManagement.Logic
{
    public class StudentManager
    {
        List<Student> students = new List<Student>();

        public void AddStudent(string name, double grade)
        {
            Student student = new Student(name, grade);
            students.Add(student);
        }

        public void displayall()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }
            else
            {
                foreach (var student in students)
                {
                    Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}");
                }
            }
        }

        public Student TopStudent()
        {
            return students.OrderByDescending(s => s.Grade).FirstOrDefault();
        }

        public bool IsEmpty()
        {
            return !students.Any();
        }
    }
}
