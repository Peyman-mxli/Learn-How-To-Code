using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagementSystem
{
    public class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Student added successfully.");
        }

        public void DisplayAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            foreach (Student student in students)
            {
                student.DisplayStudentInformation();
            }
        }

        public Student SearchStudentById(int studentId)
        {
            return students.FirstOrDefault(student => student.StudentId == studentId);
        }

        public bool UpdateStudent(
            int studentId,
            string fullName,
            int age,
            string email,
            string course,
            double grade)
        {
            Student student = SearchStudentById(studentId);

            if (student == null)
            {
                return false;
            }

            student.FullName = fullName;
            student.Age = age;
            student.Email = email;
            student.Course = course;
            student.Grade = grade;

            return true;
        }

        public bool DeleteStudent(int studentId)
        {
            Student student = SearchStudentById(studentId);

            if (student == null)
            {
                return false;
            }

            students.Remove(student);
            return true;
        }

        public int GetTotalStudents()
        {
            return students.Count;
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
*/
