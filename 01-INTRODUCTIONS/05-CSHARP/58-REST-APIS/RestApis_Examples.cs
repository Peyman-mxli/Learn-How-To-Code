using System;
using System.Collections.Generic;
using System.Linq;

/*
==================================================
REST APIS EXAMPLES
==================================================

IMPORTANT:

These examples simulate REST API behavior using
a Console Application.

In a real ASP.NET Core project, requests would
come from browsers, mobile apps, or other systems.

The goal here is to understand the concepts
before building real APIs.
*/

namespace RestApisExamples
{
    // ==========================================
    // MODEL
    // ==========================================

    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }

    // ==========================================
    // SERVICE
    // ==========================================

    public class StudentService
    {
        private readonly List<Student> students =
            new List<Student>
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
                    Name = "Sara",
                    Age = 22
                },

                new Student
                {
                    Id = 3,
                    Name = "Ali",
                    Age = 19
                }
            };

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(student => student.Id == id);
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void UpdateStudent(int id, Student updatedStudent)
        {
            Student student = GetStudentById(id);

            if (student != null)
            {
                student.Name = updatedStudent.Name;
                student.Age = updatedStudent.Age;
            }
        }

        public void DeleteStudent(int id)
        {
            Student student = GetStudentById(id);

            if (student != null)
            {
                students.Remove(student);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Example1_GetAllStudents();

            Example2_GetStudentById();

            Example3_PostStudent();

            Example4_PutStudent();

            Example5_DeleteStudent();

            Example6_JsonObject();

            Example7_JsonArray();

            Example8_RouteParameter();

            Example9_QueryParameter();

            Example10_StatusCodes();

            Example11_RequestResponse();

            Example12_ApiVersioning();
        }

        // ==========================================
        // EXAMPLE 1
        // GET ALL STUDENTS
        // ==========================================

        static void Example1_GetAllStudents()
        {
            Console.WriteLine("========== Example 1 ==========");

            Console.WriteLine("GET /api/students");

            StudentService service =
                new StudentService();

            foreach (Student student in service.GetAllStudents())
            {
                Console.WriteLine(
                    $"{student.Id} - {student.Name}");
            }

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 2
        // GET STUDENT BY ID
        // ==========================================

        static void Example2_GetStudentById()
        {
            Console.WriteLine("========== Example 2 ==========");

            Console.WriteLine("GET /api/students/1");

            StudentService service =
                new StudentService();

            Student student =
                service.GetStudentById(1);

            if (student != null)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 3
        // POST
        // ==========================================

        static void Example3_PostStudent()
        {
            Console.WriteLine("========== Example 3 ==========");

            Console.WriteLine("POST /api/students");

            StudentService service =
                new StudentService();

            service.AddStudent(
                new Student
                {
                    Id = 4,
                    Name = "David",
                    Age = 21
                });

            Console.WriteLine("201 Created");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 4
        // PUT
        // ==========================================

        static void Example4_PutStudent()
        {
            Console.WriteLine("========== Example 4 ==========");

            Console.WriteLine("PUT /api/students/1");

            StudentService service =
                new StudentService();

            service.UpdateStudent(
                1,
                new Student
                {
                    Name = "Updated Peyman",
                    Age = 30
                });

            Student student =
                service.GetStudentById(1);

            Console.WriteLine(student.Name);

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 5
        // DELETE
        // ==========================================

        static void Example5_DeleteStudent()
        {
            Console.WriteLine("========== Example 5 ==========");

            Console.WriteLine("DELETE /api/students/1");

            StudentService service =
                new StudentService();

            service.DeleteStudent(1);

            Console.WriteLine("Student deleted.");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 6
        // JSON OBJECT
        // ==========================================

        static void Example6_JsonObject()
        {
            Console.WriteLine("========== Example 6 ==========");

            Console.WriteLine(
@"{
  ""id"": 1,
  ""name"": ""Peyman"",
  ""age"": 25
}");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 7
        // JSON ARRAY
        // ==========================================

        static void Example7_JsonArray()
        {
            Console.WriteLine("========== Example 7 ==========");

            Console.WriteLine(
@"[
  {
    ""id"": 1,
    ""name"": ""Peyman""
  },
  {
    ""id"": 2,
    ""name"": ""Sara""
  }
]");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 8
        // ROUTE PARAMETER
        // ==========================================

        static void Example8_RouteParameter()
        {
            Console.WriteLine("========== Example 8 ==========");

            Console.WriteLine(
                "GET /api/students/5");

            Console.WriteLine(
                "Route Parameter = 5");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 9
        // QUERY PARAMETER
        // ==========================================

        static void Example9_QueryParameter()
        {
            Console.WriteLine("========== Example 9 ==========");

            Console.WriteLine(
                "GET /api/students?age=25");

            Console.WriteLine(
                "Query Parameter = age=25");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 10
        // STATUS CODES
        // ==========================================

        static void Example10_StatusCodes()
        {
            Console.WriteLine("========== Example 10 ==========");

            Console.WriteLine("200 OK");

            Console.WriteLine("201 Created");

            Console.WriteLine("400 Bad Request");

            Console.WriteLine("401 Unauthorized");

            Console.WriteLine("403 Forbidden");

            Console.WriteLine("404 Not Found");

            Console.WriteLine("500 Internal Server Error");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 11
        // REQUEST / RESPONSE
        // ==========================================

        static void Example11_RequestResponse()
        {
            Console.WriteLine("========== Example 11 ==========");

            Console.WriteLine("Client");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("GET /api/students");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("Server");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("200 OK");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("JSON Data");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 12
        // API VERSIONING
        // ==========================================

        static void Example12_ApiVersioning()
        {
            Console.WriteLine("========== Example 12 ==========");

            Console.WriteLine(
                "/api/v1/students");

            Console.WriteLine(
                "/api/v2/students");

            Console.WriteLine(
                "Different API versions can exist together.");

            Console.WriteLine();
        }
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
