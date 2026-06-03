using System;
using System.Collections.Generic;
using System.Linq;

/*
==================================================
ENTITY FRAMEWORK EXAMPLES
==================================================

IMPORTANT:

These examples simulate how Entity Framework works.

A real Entity Framework project requires:

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

Since this course focuses on learning concepts,
the examples below demonstrate EF behavior in a
simple Console Application style.
*/

namespace EntityFrameworkExamples
{
    // ==========================================
    // ENTITY
    // ==========================================

    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Example1_CreateEntity();

            Example2_AddData();

            Example3_ReadData();

            Example4_UpdateData();

            Example5_DeleteData();

            Example6_WhereQuery();

            Example7_OrderBy();

            Example8_Count();

            Example9_Any();

            Example10_First();

            Example11_Projection();

            Example12_OneToManyRelationship();
        }

        // ==========================================
        // EXAMPLE 1
        // CREATE ENTITY OBJECT
        // ==========================================

        static void Example1_CreateEntity()
        {
            Console.WriteLine("========== Example 1 ==========");

            Student student = new Student
            {
                Id = 1,
                Name = "Peyman",
                Age = 25
            };

            Console.WriteLine($"Id: {student.Id}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 2
        // ADD DATA
        // ==========================================

        static void Example2_AddData()
        {
            Console.WriteLine("========== Example 2 ==========");

            List<Student> students = new List<Student>();

            students.Add(new Student
            {
                Id = 1,
                Name = "Peyman",
                Age = 25
            });

            Console.WriteLine("Student added.");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 3
        // READ DATA
        // ==========================================

        static void Example3_ReadData()
        {
            Console.WriteLine("========== Example 3 ==========");

            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Peyman", Age = 25 },
                new Student { Id = 2, Name = "Ali", Age = 22 }
            };

            foreach (Student student in students)
            {
                Console.WriteLine(
                    $"{student.Id} - {student.Name} - {student.Age}");
            }

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 4
        // UPDATE DATA
        // ==========================================

        static void Example4_UpdateData()
        {
            Console.WriteLine("========== Example 4 ==========");

            Student student = new Student
            {
                Id = 1,
                Name = "Peyman",
                Age = 25
            };

            student.Name = "Ali";

            Console.WriteLine("Updated Name:");
            Console.WriteLine(student.Name);

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 5
        // DELETE DATA
        // ==========================================

        static void Example5_DeleteData()
        {
            Console.WriteLine("========== Example 5 ==========");

            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Peyman", Age = 25 },
                new Student { Id = 2, Name = "Ali", Age = 22 }
            };

            Student studentToRemove = students.First();

            students.Remove(studentToRemove);

            Console.WriteLine("Student removed.");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 6
        // WHERE QUERY
        // ==========================================

        static void Example6_WhereQuery()
        {
            Console.WriteLine("========== Example 6 ==========");

            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Peyman", Age = 25 },
                new Student { Id = 2, Name = "Ali", Age = 17 },
                new Student { Id = 3, Name = "Sara", Age = 30 }
            };

            var adults =
                students.Where(student => student.Age >= 18);

            foreach (var student in adults)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 7
        // ORDER BY
        // ==========================================

        static void Example7_OrderBy()
        {
            Console.WriteLine("========== Example 7 ==========");

            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Sara", Age = 30 },
                new Student { Id = 2, Name = "Ali", Age = 22 },
                new Student { Id = 3, Name = "Peyman", Age = 25 }
            };

            var orderedStudents =
                students.OrderBy(student => student.Name);

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 8
        // COUNT
        // ==========================================

        static void Example8_Count()
        {
            Console.WriteLine("========== Example 8 ==========");

            List<Student> students = new List<Student>
            {
                new Student(),
                new Student(),
                new Student()
            };

            int count = students.Count();

            Console.WriteLine($"Students: {count}");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 9
        // ANY
        // ==========================================

        static void Example9_Any()
        {
            Console.WriteLine("========== Example 9 ==========");

            List<Student> students = new List<Student>
            {
                new Student { Name = "Peyman" },
                new Student { Name = "Ali" }
            };

            bool exists =
                students.Any(student => student.Name == "Peyman");

            Console.WriteLine(exists);

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 10
        // FIRST
        // ==========================================

        static void Example10_First()
        {
            Console.WriteLine("========== Example 10 ==========");

            List<Student> students = new List<Student>
            {
                new Student { Name = "Peyman" },
                new Student { Name = "Ali" }
            };

            Student firstStudent = students.First();

            Console.WriteLine(firstStudent.Name);

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 11
        // SELECT PROJECTION
        // ==========================================

        static void Example11_Projection()
        {
            Console.WriteLine("========== Example 11 ==========");

            List<Student> students = new List<Student>
            {
                new Student { Name = "Peyman", Age = 25 },
                new Student { Name = "Ali", Age = 22 }
            };

            var names =
                students.Select(student => student.Name);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 12
        // ONE TO MANY RELATIONSHIP
        // ==========================================

        static void Example12_OneToManyRelationship()
        {
            Console.WriteLine("========== Example 12 ==========");

            Teacher teacher = new Teacher
            {
                Id = 1,
                Name = "Professor Smith",
                Students = new List<Student>
                {
                    new Student
                    {
                        Id = 1,
                        Name = "Peyman",
                        Age = 25
                    },

                    new Student
                    {
                        Id = 2,
                        Name = "Ali",
                        Age = 22
                    }
                }
            };

            Console.WriteLine(teacher.Name);

            foreach (Student student in teacher.Students)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine();
        }
    }

    // ==========================================
    // TEACHER ENTITY
    // ==========================================

    public class Teacher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Student> Students { get; set; }
    }
}

/*
👤 Author Peyman Miyandashti
📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
