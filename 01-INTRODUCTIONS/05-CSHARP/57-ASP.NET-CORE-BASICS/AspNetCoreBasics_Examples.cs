using System;
using System.Collections.Generic;
using System.Linq;

/*
==================================================
ASP.NET CORE BASICS EXAMPLES
==================================================

IMPORTANT:

Real ASP.NET Core applications require:

- ASP.NET Core Runtime
- Controllers
- Routing
- Dependency Injection
- Middleware

This file demonstrates the concepts
using simple Console Application examples
so they can be understood before building
real web applications.
*/

namespace AspNetCoreBasicsExamples
{
    // ==================================================
    // MODEL
    // ==================================================

    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }

    // ==================================================
    // SERVICE
    // ==================================================

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
    }

    // ==================================================
    // CONTROLLER
    // ==================================================

    public class StudentController
    {
        private readonly StudentService studentService;

        public StudentController(StudentService studentService)
        {
            this.studentService = studentService;
        }

        public void GetStudents()
        {
            Console.WriteLine("GET /api/students");

            List<Student> students =
                studentService.GetAllStudents();

            foreach (Student student in students)
            {
                Console.WriteLine(
                    $"{student.Id} - {student.Name} - {student.Age}");
            }

            Console.WriteLine();
        }

        public void GetStudent(int id)
        {
            Console.WriteLine($"GET /api/students/{id}");

            Student student =
                studentService.GetStudentById(id);

            if (student != null)
            {
                Console.WriteLine(
                    $"{student.Id} - {student.Name} - {student.Age}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

            Console.WriteLine();
        }

        public void CreateStudent(Student student)
        {
            Console.WriteLine("POST /api/students");

            studentService.AddStudent(student);

            Console.WriteLine("Student created.");

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Example1_Model();

            Example2_Service();

            Example3_Controller();

            Example4_GetRequest();

            Example5_PostRequest();

            Example6_RouteExamples();

            Example7_HttpMethods();

            Example8_StatusCodes();

            Example9_DependencyInjection();

            Example10_RequestResponseFlow();
        }

        // ==================================================
        // EXAMPLE 1
        // MODEL
        // ==================================================

        static void Example1_Model()
        {
            Console.WriteLine("========== Example 1 ==========");

            Student student = new Student
            {
                Id = 1,
                Name = "Peyman",
                Age = 25
            };

            Console.WriteLine(student.Name);

            Console.WriteLine();
        }

        // ==================================================
        // EXAMPLE 2
        // SERVICE
        // ==================================================

        static void Example2_Service()
        {
            Console.WriteLine("========== Example 2 ==========");

            StudentService service =
                new StudentService();

            List<Student> students =
                service.GetAllStudents();

            Console.WriteLine(
                $"Students Loaded: {students.Count}");

            Console.WriteLine();
        }

        // ==================================================
        // EXAMPLE 3
        // CONTROLLER
        // ==================================================

        static void Example3_Controller()
        {
            Console.WriteLine("========== Example 3 ==========");

            StudentService service =
                new StudentService();

            StudentController controller =
                new StudentController(service);

            controller.GetStudents();
        }

        // ==================================================
        // EXAMPLE 4
        // GET REQUEST
        // ==================================================

        static void Example4_GetRequest()
        {
            Console.WriteLine("========== Example 4 ==========");

            StudentService service =
                new StudentService();

            StudentController controller =
                new StudentController(service);

            controller.GetStudent(1);
        }

        // ==================================================
        // EXAMPLE 5
        // POST REQUEST
        // ==================================================

        static void Example5_PostRequest()
        {
            Console.WriteLine("========== Example 5 ==========");

            StudentService service =
                new StudentService();

            StudentController controller =
                new StudentController(service);

            Student newStudent =
                new Student
                {
                    Id = 4,
                    Name = "David",
                    Age = 21
                };

            controller.CreateStudent(newStudent);

            controller.GetStudents();
        }

        // ==================================================
        // EXAMPLE 6
        // ROUTES
        // ==================================================

        static void Example6_RouteExamples()
        {
            Console.WriteLine("========== Example 6 ==========");

            Console.WriteLine("/");

            Console.WriteLine("/home");

            Console.WriteLine("/about");

            Console.WriteLine("/contact");

            Console.WriteLine("/api/students");

            Console.WriteLine("/api/products");

            Console.WriteLine();
        }

        // ==================================================
        // EXAMPLE 7
        // HTTP METHODS
        // ==================================================

        static void Example7_HttpMethods()
        {
            Console.WriteLine("========== Example 7 ==========");

            Console.WriteLine("GET    -> Read Data");

            Console.WriteLine("POST   -> Create Data");

            Console.WriteLine("PUT    -> Update Data");

            Console.WriteLine("DELETE -> Delete Data");

            Console.WriteLine();
        }

        // ==================================================
        // EXAMPLE 8
        // STATUS CODES
        // ==================================================

        static void Example8_StatusCodes()
        {
            Console.WriteLine("========== Example 8 ==========");

            Console.WriteLine("200 OK");

            Console.WriteLine("201 Created");

            Console.WriteLine("400 Bad Request");

            Console.WriteLine("401 Unauthorized");

            Console.WriteLine("404 Not Found");

            Console.WriteLine("500 Internal Server Error");

            Console.WriteLine();
        }

        // ==================================================
        // EXAMPLE 9
        // DEPENDENCY INJECTION
        // ==================================================

        static void Example9_DependencyInjection()
        {
            Console.WriteLine("========== Example 9 ==========");

            StudentService service =
                new StudentService();

            StudentController controller =
                new StudentController(service);

            Console.WriteLine(
                "StudentService injected into StudentController.");

            Console.WriteLine();
        }

        // ==================================================
        // EXAMPLE 10
        // REQUEST / RESPONSE FLOW
        // ==================================================

        static void Example10_RequestResponseFlow()
        {
            Console.WriteLine("========== Example 10 ==========");

            Console.WriteLine("Client");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("Request");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("ASP.NET Core");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("Controller");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("Response");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("Client");

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
