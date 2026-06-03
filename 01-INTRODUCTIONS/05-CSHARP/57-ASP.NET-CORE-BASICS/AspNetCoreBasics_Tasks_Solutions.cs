using System;
using System.Collections.Generic;
using System.Linq;

/*
ASP.NET CORE BASICS TASKS SOLUTIONS
*/

namespace AspNetCoreBasicsTaskSolutions
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    public class StudentService
    {
        private readonly List<Student> students = new List<Student>();

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
                student.Email = updatedStudent.Email;
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

    public class StudentController
    {
        private readonly StudentService studentService;

        public StudentController(StudentService studentService)
        {
            this.studentService = studentService;
        }

        public void GetStudents()
        {
            foreach (Student student in studentService.GetAllStudents())
            {
                Console.WriteLine($"{student.Id} - {student.Name} - {student.Age} - {student.Email}");
            }
        }

        public void GetStudent(int id)
        {
            Student student = studentService.GetStudentById(id);

            if (student != null)
            {
                Console.WriteLine($"{student.Id} - {student.Name}");
            }
            else
            {
                Console.WriteLine("404 Not Found");
            }
        }

        public void CreateStudent(Student student)
        {
            studentService.AddStudent(student);
            Console.WriteLine("201 Created");
        }
    }

    class Program
    {
        static void Main()
        {
            ExplainAspNetCore();
            ExplainClientServer();
            ExplainFrontendBackend();
            ExplainRoutes();
            ExplainHttpMethods();
            ExplainRequestResponse();
            ExplainMvc();
            ExplainWebApi();
            ExplainJson();
            ExplainMiddleware();
            ExplainDependencyInjection();
            ExplainProgramCs();
            ExplainStatusCodes();
            SimpleEndpointConcept();
            StudentApiPlan();
            ExplainSecurityBasics();
            RealWorldProjectIdea();
        }

        static void ExplainAspNetCore()
        {
            Console.WriteLine("ASP.NET Core is a Microsoft framework used to build web applications, APIs, and backend systems using C#.");
        }

        static void ExplainClientServer()
        {
            Console.WriteLine("The client sends requests. The server receives requests and sends responses.");
        }

        static void ExplainFrontendBackend()
        {
            Console.WriteLine("Frontend is what the user sees. Backend is the logic, database, security, and API side.");
        }

        static void ExplainRoutes()
        {
            Console.WriteLine("Routes are URLs that connect a request to code, such as /home, /about, or /api/students.");
        }

        static void ExplainHttpMethods()
        {
            Console.WriteLine("GET reads data.");
            Console.WriteLine("POST creates data.");
            Console.WriteLine("PUT updates data.");
            Console.WriteLine("DELETE removes data.");
        }

        static void ExplainRequestResponse()
        {
            Console.WriteLine("Client sends a request to the server. The server processes it and returns a response.");
        }

        static void ExplainMvc()
        {
            Console.WriteLine("Model stores data.");
            Console.WriteLine("View displays data.");
            Console.WriteLine("Controller handles requests.");
        }

        static void ExplainWebApi()
        {
            Console.WriteLine("A Web API allows applications to communicate using endpoints and usually returns JSON data.");
        }

        static void ExplainJson()
        {
            Console.WriteLine("{ \"id\": 1, \"name\": \"Peyman\", \"age\": 25 }");
        }

        static void ExplainMiddleware()
        {
            Console.WriteLine("Middleware runs during the request pipeline, such as authentication, logging, routing, and error handling.");
        }

        static void ExplainDependencyInjection()
        {
            Console.WriteLine("Dependency Injection gives classes the services they need instead of creating them manually.");
        }

        static void ExplainProgramCs()
        {
            Console.WriteLine("Program.cs configures services, middleware, routing, and application startup.");
        }

        static void ExplainStatusCodes()
        {
            Console.WriteLine("200 OK");
            Console.WriteLine("201 Created");
            Console.WriteLine("400 Bad Request");
            Console.WriteLine("401 Unauthorized");
            Console.WriteLine("404 Not Found");
            Console.WriteLine("500 Internal Server Error");
        }

        static void SimpleEndpointConcept()
        {
            Console.WriteLine("GET /hello -> Hello from ASP.NET Core");
        }

        static void StudentApiPlan()
        {
            Console.WriteLine("GET /api/students -> Get all students");
            Console.WriteLine("GET /api/students/{id} -> Get one student");
            Console.WriteLine("POST /api/students -> Create student");
            Console.WriteLine("PUT /api/students/{id} -> Update student");
            Console.WriteLine("DELETE /api/students/{id} -> Delete student");
        }

        static void ExplainSecurityBasics()
        {
            Console.WriteLine("Authentication checks who the user is.");
            Console.WriteLine("Authorization checks what the user can do.");
            Console.WriteLine("HTTPS protects data.");
            Console.WriteLine("Input validation prevents dangerous or invalid data.");
        }

        static void RealWorldProjectIdea()
        {
            Console.WriteLine("Project Name: Student Management API");
            Console.WriteLine("Purpose: Manage student information.");
            Console.WriteLine("Models: Student, Course, Teacher.");
            Console.WriteLine("Endpoints: GET, POST, PUT, DELETE students.");
            Console.WriteLine("Useful because schools need organized student data.");
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
