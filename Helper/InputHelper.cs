using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Helper
{
    public static class InputHelper
    {
        public static (string? name, double? gpa) GetStudentInfo()
        {
            Console.WriteLine("Enter student name:");
            string inputName = Console.ReadLine();

            if (inputName.ToLower() == "n")
            {
                Console.WriteLine("Finish Adding...");
                return (null, null);
            }
            if (string.IsNullOrWhiteSpace(inputName)) 
            {
            Console.WriteLine("name can not be null");
            }

            Console.WriteLine("Enter GPA:");
            string inputGPA = Console.ReadLine();

            if (inputGPA.ToLower() == "n")
            {
                Console.WriteLine("Finish Adding...");
                return (null, null);
            }

            if (string.IsNullOrWhiteSpace(inputGPA))
            {
                Console.WriteLine("Grade can not be null");
                return (null, null);
            }

            if (!double.TryParse(inputGPA, out double gpa) || gpa < 0 || gpa > 20)
            {
                Console.WriteLine("Invalid GPA. Please enter a number between 0 and 20.");
                return (null, null);
            }
            

            return (inputName, gpa);
        }

        //public static string Getstudentname(string prompt)
        //{
        //    string name = Console.ReadLine();
        //    if (string.IsNullOrEmpty(name))
        //    {
        //        Console.WriteLine("Name cannot be empty. Please enter a valid name.");
        //        return Getstudentname(prompt);
        //    }
        //    return name;
        //}

        //public static double Getstudengrade(string prompt)
        //{
        //    if (string.IsNullOrEmpty(prompt))
        //    {
        //        Console.WriteLine("Grade cannot be empty. Please enter a valid Grade.");
        //    }
        //    double grade = Convert.ToDouble(Console.ReadLine());
        //    return grade;
        //}
    }
}
