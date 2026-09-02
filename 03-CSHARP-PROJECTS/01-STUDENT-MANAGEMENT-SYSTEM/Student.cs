using System;

namespace StudentManagementSystem
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string Course { get; set; }

        public double Grade { get; set; }

        public Student()
        {
        }

        public Student(
            int studentId,
            string fullName,
            int age,
            string email,
            string course,
            double grade)
        {
            StudentId = studentId;
            FullName = fullName;
            Age = age;
            Email = email;
            Course = course;
            Grade = grade;
        }

        public void DisplayStudentInformation()
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Student ID : {StudentId}");
            Console.WriteLine($"Name       : {FullName}");
            Console.WriteLine($"Age        : {Age}");
            Console.WriteLine($"Email      : {Email}");
            Console.WriteLine($"Course     : {Course}");
            Console.WriteLine($"Grade      : {Grade}");
            Console.WriteLine("========================================");
        }
    }
}

/*
👤 Author Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161

