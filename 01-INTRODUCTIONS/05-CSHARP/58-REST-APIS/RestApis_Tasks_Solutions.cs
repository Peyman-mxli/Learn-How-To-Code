using System;
using System.Collections.Generic;
using System.Linq;

/*
=========================================
REST APIS TASKS SOLUTIONS
=========================================

These solutions explain and simulate REST API concepts
using simple C# examples.

In a real ASP.NET Core REST API project, I would use:

- Controllers
- Routes
- HTTP methods
- IActionResult
- Models
- Services
- JSON responses
*/

namespace RestApisTaskSolutions
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }
    }

    public class StudentApiService
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

    public class Program
    {
        public static void Main()
        {
            ExplainApi();
            ExplainRest();
            ExplainResources();
            ExplainEndpoints();
            ExplainHttpMethods();

            CreateStudentModelExample();

            PlanGetEndpoints();
            PlanPostEndpoint();
            PlanPutEndpoint();
            PlanPatchEndpoint();
            PlanDeleteEndpoint();

            ExplainRequest();
            ExplainResponse();

            CreateJsonObject();
            CreateJsonArray();

            ExplainStatusCodes();
            ExplainRouteParameters();
            ExplainQueryParameters();
            ExplainApiSecurity();

            DesignRestApiProject();
        }

        public static void ExplainApi()
        {
            Console.WriteLine("API means Application Programming Interface.");
            Console.WriteLine("An API allows different applications to communicate with each other.");
            Console.WriteLine("For example, a mobile app can send a request to an API and receive data from a server.");
        }

        public static void ExplainRest()
        {
            Console.WriteLine("REST means Representational State Transfer.");
            Console.WriteLine("REST APIs are popular because they are simple, scalable, and use standard HTTP methods.");
            Console.WriteLine("REST APIs use HTTP because HTTP is the standard communication protocol of the web.");
        }

        public static void ExplainResources()
        {
            Console.WriteLine("A resource is something the API manages.");
            Console.WriteLine("Examples: Student, Product, Order, User.");
        }

        public static void ExplainEndpoints()
        {
            Console.WriteLine("Endpoints are URLs used to access resources.");
            Console.WriteLine("Examples: /api/students, /api/products, /api/orders.");
        }

        public static void ExplainHttpMethods()
        {
            Console.WriteLine("GET reads data.");
            Console.WriteLine("POST creates new data.");
            Console.WriteLine("PUT updates an entire resource.");
            Console.WriteLine("PATCH updates part of a resource.");
            Console.WriteLine("DELETE removes data.");
        }

        public static void CreateStudentModelExample()
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Peyman",
                Age = 25,
                Email = "peyman@example.com"
            };

            Console.WriteLine($"{student.Id} - {student.Name} - {student.Age} - {student.Email}");
        }

        public static void PlanGetEndpoints()
        {
            Console.WriteLine("GET /api/students returns all students.");
            Console.WriteLine("GET /api/students/{id} returns one student by Id.");
        }

        public static void PlanPostEndpoint()
        {
            Console.WriteLine("POST /api/students creates a new student.");
            Console.WriteLine("It receives student data in the request body.");
            Console.WriteLine("It should return 201 Created.");
        }

        public static void PlanPutEndpoint()
        {
            Console.WriteLine("PUT /api/students/{id} updates an existing student.");
            Console.WriteLine("It receives full student data in the request body.");
            Console.WriteLine("It should return 200 OK or 204 No Content.");
        }

        public static void PlanPatchEndpoint()
        {
            Console.WriteLine("PATCH /api/students/{id} partially updates an existing student.");
            Console.WriteLine("PATCH is different from PUT because PATCH changes only selected fields.");
        }

        public static void PlanDeleteEndpoint()
        {
            Console.WriteLine("DELETE /api/students/{id} deletes one student by Id.");
            Console.WriteLine("It should return 204 No Content after successful deletion.");
        }

        public static void ExplainRequest()
        {
            Console.WriteLine("A request contains a URL, HTTP method, headers, and sometimes a body.");
        }

        public static void ExplainResponse()
        {
            Console.WriteLine("A response contains a status code, headers, and data.");
        }

        public static void CreateJsonObject()
        {
            Console.WriteLine(
@"{
  ""id"": 1,
  ""name"": ""Peyman"",
  ""age"": 25,
  ""email"": ""peyman@example.com""
}");
        }

        public static void CreateJsonArray()
        {
            Console.WriteLine(
@"[
  {
    ""id"": 1,
    ""name"": ""Peyman"",
    ""age"": 25,
    ""email"": ""peyman@example.com""
  },
  {
    ""id"": 2,
    ""name"": ""Sara"",
    ""age"": 22,
    ""email"": ""sara@example.com""
  },
  {
    ""id"": 3,
    ""name"": ""Ali"",
    ""age"": 19,
    ""email"": ""ali@example.com""
  }
]");
        }

        public static void ExplainStatusCodes()
        {
            Console.WriteLine("200 OK means the request was successful.");
            Console.WriteLine("201 Created means a new resource was created.");
            Console.WriteLine("204 No Content means the request succeeded but returns no body.");
            Console.WriteLine("400 Bad Request means the request is invalid.");
            Console.WriteLine("401 Unauthorized means the user is not authenticated.");
            Console.WriteLine("403 Forbidden means the user does not have permission.");
            Console.WriteLine("404 Not Found means the resource does not exist.");
            Console.WriteLine("500 Internal Server Error means something failed on the server.");
        }

        public static void ExplainRouteParameters()
        {
            Console.WriteLine("/api/students/5 contains a route parameter.");
            Console.WriteLine("The value 5 usually represents the student Id.");
        }

        public static void ExplainQueryParameters()
        {
            Console.WriteLine("/api/students?age=25 contains a query parameter.");
            Console.WriteLine("age=25 means the API should filter students by age.");
        }

        public static void ExplainApiSecurity()
        {
            Console.WriteLine("API security protects users, data, and systems.");
            Console.WriteLine("Authentication checks who the user is.");
            Console.WriteLine("Authorization checks what the user is allowed to do.");
            Console.WriteLine("HTTPS encrypts communication.");
            Console.WriteLine("Input validation prevents invalid or dangerous data.");
        }

        public static void DesignRestApiProject()
        {
            Console.WriteLine("Project Name: Student REST API");
            Console.WriteLine("Purpose: Manage student information.");
            Console.WriteLine("Main Resource: Student");

            Console.WriteLine("Endpoints:");
            Console.WriteLine("GET /api/students");
            Console.WriteLine("GET /api/students/{id}");
            Console.WriteLine("POST /api/students");
            Console.WriteLine("PUT /api/students/{id}");
            Console.WriteLine("PATCH /api/students/{id}");
            Console.WriteLine("DELETE /api/students/{id}");

            Console.WriteLine("Example JSON Response:");

            Console.WriteLine(
@"{
  ""id"": 1,
  ""name"": ""Peyman"",
  ""age"": 25,
  ""email"": ""peyman@example.com""
}");
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
