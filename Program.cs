// See https://aka.ms/new-console-template for more information
using StudentManagement.Helper;
using StudentManagement.Logic;
using StudentManagement.Model;

bool run = true;
bool runprogram = true;
StudentManager studentManager = new StudentManager();
Console.WriteLine("Welcome to the Student Management System!");
while (runprogram)
{
    Console.WriteLine("1.Add Student 2.Show Students List 3.See Top Student OR type 'exit' to quit");
    string choice = Console.ReadLine();
    if (choice == "exit")
    {
        Console.WriteLine("exiting program...");
        break;
    }
    if (choice == "1")
    {
        Console.WriteLine("To Finish Adding Students Press 'n'");
        while (run)
        {
            var (name, gpa) = InputHelper.GetStudentInfo();

            if (name == null || gpa == null)
                break;
            else
                studentManager.AddStudent(name, gpa.Value);
            Console.WriteLine("Student added successfully.");

        }
    }
    else if (choice == "2")
    {
        if (studentManager.IsEmpty())
        {
            Console.WriteLine("No students in the list yet.");
        }
        else
        {
            Console.WriteLine("Student List:");
            studentManager.displayall();
        }
    }
    else if (choice == "3")
    {
        if (studentManager.IsEmpty())
        {
            Console.WriteLine("No students in the list yet.");
        }
        else
        {
            Student st = studentManager.TopStudent();
            Console.WriteLine($"Top student: {st.Name}, {st.Grade}");
        }
    }
    else

        Console.WriteLine("Invalid choice. Please try again.");
}








