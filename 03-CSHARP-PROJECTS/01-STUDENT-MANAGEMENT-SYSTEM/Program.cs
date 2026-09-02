using System;

namespace StudentManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();

            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("========================================");
                Console.WriteLine("     STUDENT MANAGEMENT SYSTEM");
                Console.WriteLine("========================================");
                Console.WriteLine();
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Exit");
                Console.WriteLine();
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudentFromUserInput(studentManager);
                        break;

                    case "2":
                        ViewAllStudents(studentManager);
                        break;

                    case "3":
                        SearchStudentFromUserInput(studentManager);
                        break;

                    case "4":
                        UpdateStudentFromUserInput(studentManager);
                        break;

                    case "5":
                        DeleteStudentFromUserInput(studentManager);
                        break;

                    case "6":
                        isRunning = false;
                        Console.WriteLine();
                        Console.WriteLine("Thank you for using Student Management System.");
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                if (isRunning)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        private static void AddStudentFromUserInput(StudentManager studentManager)
        {
            Console.WriteLine();
            Console.WriteLine("ADD NEW STUDENT");
            Console.WriteLine("----------------------------------------");

            Console.Write("Student ID: ");
            int studentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Full Name: ");
            string fullName = Console.ReadLine();

            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Course: ");
            string course = Console.ReadLine();

            Console.Write("Grade: ");
            double grade = Convert.ToDouble(Console.ReadLine());

            Student student = new Student(
                studentId,
                fullName,
                age,
                email,
                course,
                grade
            );

            studentManager.AddStudent(student);
        }

        private static void ViewAllStudents(StudentManager studentManager)
        {
            Console.WriteLine();
            Console.WriteLine("ALL STUDENTS");
            Console.WriteLine("----------------------------------------");

            studentManager.DisplayAllStudents();
        }

        private static void SearchStudentFromUserInput(StudentManager studentManager)
        {
            Console.WriteLine();
            Console.WriteLine("SEARCH STUDENT");
            Console.WriteLine("----------------------------------------");

            Console.Write("Enter Student ID: ");
            int studentId = Convert.ToInt32(Console.ReadLine());

            Student student = studentManager.SearchStudentById(studentId);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Student found:");
            student.DisplayStudentInformation();
        }

        private static void UpdateStudentFromUserInput(StudentManager studentManager)
        {
            Console.WriteLine();
            Console.WriteLine("UPDATE STUDENT");
            Console.WriteLine("----------------------------------------");

            Console.Write("Enter Student ID to update: ");
            int studentId = Convert.ToInt32(Console.ReadLine());

            Student existingStudent = studentManager.SearchStudentById(studentId);

            if (existingStudent == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Current student information:");
            existingStudent.DisplayStudentInformation();

            Console.WriteLine();
            Console.WriteLine("Enter new student information:");
            Console.WriteLine("----------------------------------------");

            Console.Write("New Full Name: ");
            string fullName = Console.ReadLine();

            Console.Write("New Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("New Email: ");
            string email = Console.ReadLine();

            Console.Write("New Course: ");
            string course = Console.ReadLine();

            Console.Write("New Grade: ");
            double grade = Convert.ToDouble(Console.ReadLine());

            bool isUpdated = studentManager.UpdateStudent(
                studentId,
                fullName,
                age,
                email,
                course,
                grade
            );

            if (isUpdated)
            {
                Console.WriteLine("Student updated successfully.");
            }
            else
            {
                Console.WriteLine("Student update failed.");
            }
        }

        private static void DeleteStudentFromUserInput(StudentManager studentManager)
        {
            Console.WriteLine();
            Console.WriteLine("DELETE STUDENT");
            Console.WriteLine("----------------------------------------");

            Console.Write("Enter Student ID to delete: ");
            int studentId = Convert.ToInt32(Console.ReadLine());

            Student student = studentManager.SearchStudentById(studentId);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Student selected for deletion:");
            student.DisplayStudentInformation();

            Console.WriteLine();
            Console.Write("Are you sure you want to delete this student? (Y/N): ");
            string confirmation = Console.ReadLine();

            if (confirmation.ToUpper() == "Y")
            {
                bool isDeleted = studentManager.DeleteStudent(studentId);

                if (isDeleted)
                {
                    Console.WriteLine("Student deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Student deletion failed.");
                }
            }
            else
            {
                Console.WriteLine("Delete cancelled.");
            }
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
