using System;
using System.Collections.Generic;
using System.Linq;

/*
==================================================
PROFESSIONAL PROJECT ARCHITECTURE EXAMPLES
==================================================

These examples demonstrate how a professional
application can be organized using layers.

The goal is to understand responsibilities
and data flow between components.
*/

namespace ProfessionalProjectArchitectureExamples
{
    // ==================================================
    // DOMAIN LAYER
    // ==================================================

    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }

    // ==================================================
    // DTO LAYER
    // ==================================================

    public class StudentDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    // ==================================================
    // REPOSITORY INTERFACE
    // ==================================================

    public interface IStudentRepository
    {
        List<Student> GetAll();

        Student GetById(int id);

        void Add(Student student);

        void Update(Student student);

        void Delete(int id);
    }

    // ==================================================
    // REPOSITORY IMPLEMENTATION
    // ==================================================

    public class StudentRepository : IStudentRepository
    {
        private readonly List<Student> students =
            new List<Student>();

        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetById(int id)
        {
            return students.FirstOrDefault(
                student => student.Id == id);
        }

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Update(Student updatedStudent)
        {
            Student existingStudent =
                GetById(updatedStudent.Id);

            if (existingStudent != null)
            {
                existingStudent.Name =
                    updatedStudent.Name;

                existingStudent.Email =
                    updatedStudent.Email;
            }
        }

        public void Delete(int id)
        {
            Student student = GetById(id);

            if (student != null)
            {
                students.Remove(student);
            }
        }
    }

    // ==================================================
    // SERVICE LAYER
    // ==================================================

    public class StudentService
    {
        private readonly IStudentRepository repository;

        public StudentService(
            IStudentRepository repository)
        {
            this.repository = repository;
        }

        public List<StudentDto> GetStudents()
        {
            return repository
                .GetAll()
                .Select(student =>
                    new StudentDto
                    {
                        Id = student.Id,
                        Name = student.Name
                    })
                .ToList();
        }

        public void CreateStudent(
            string name,
            string email)
        {
            Student student = new Student
            {
                Id = repository.GetAll().Count + 1,
                Name = name,
                Email = email
            };

            repository.Add(student);
        }
    }

    // ==================================================
    // PRESENTATION LAYER
    // ==================================================

    public class StudentController
    {
        private readonly StudentService service;

        public StudentController(
            StudentService service)
        {
            this.service = service;
        }

        public void GetStudents()
        {
            Console.WriteLine(
                "GET /api/students");

            List<StudentDto> students =
                service.GetStudents();

            foreach (StudentDto student in students)
            {
                Console.WriteLine(
                    $"{student.Id} - {student.Name}");
            }

            Console.WriteLine();
        }

        public void CreateStudent(
            string name,
            string email)
        {
            Console.WriteLine(
                "POST /api/students");

            service.CreateStudent(
                name,
                email);

            Console.WriteLine(
                "Student Created");

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Example1_LayeredArchitecture();

            Example2_DependencyInjection();

            Example3_CreateStudent();

            Example4_GetStudents();

            Example5_DtoConcept();

            Example6_RepositoryPattern();

            Example7_ServiceLayer();

            Example8_ControllerLayer();

            Example9_DataFlow();

            Example10_ProfessionalStructure();
        }

        // ==================================================
        // EXAMPLE 1
        // LAYERED ARCHITECTURE
        // ==================================================

        static void Example1_LayeredArchitecture()
        {
            Console.WriteLine(
                "========== Example 1 ==========");

            Console.WriteLine(
                "Presentation Layer");

            Console.WriteLine(
                "Application Layer");

            Console.WriteLine(
                "Domain Layer");

            Console.WriteLine(
                "Infrastructure Layer");

            Console.WriteLine();
        }

        // ==================================================
        // EXAMPLE 2
        // DEPENDENCY INJECTION
        // ==================================================

        static void Example2_DependencyInjection()
        {
            Console.WriteLine(
                "========== Example 2 ==========");

            IStudentRepository repository =
                new StudentRepository();

            StudentService service =
                new StudentService(repository);

            Console.WriteLine(
                "Repository injected into Service.");

            Console.WriteLine();
        }

        // ==================================================
        // EXAMPLE 3
        // CREATE STUDENT
        // ==================================================

        static void Example3_CreateStudent()
        {
            Console.WriteLine(
                "========== Example 3 ==========");

            IStudentRepository repository =
                new StudentRepository();

            StudentService service =
                new StudentService(repository);

            service.CreateStudent(
                "Peyman",
                "peyman@example.com");

            Console.WriteLine(
                "Student Added.");

            Console.WriteLine();
        }

        // ==================================================
        // EXAMPLE 4
        // GET STUDENTS
        // ==================================================

        static void Example4_GetStudents()
        {
            Console.WriteLine(
                "========== Example 4 ==========");

            IStudentRepository repository =
                new StudentRepository();

            StudentService service =
                new StudentService(repository);

            service.CreateStudent(
                "Peyman",
                "peyman@example.com");

            List<StudentDto> students =
                service.GetStudents();

            foreach (StudentDto student in students)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine();
        }

        // ==================================================
        // EXAMPLE 5
        // DTO CONCEPT
        // ==================================================

        static void Example5_DtoConcept()
        {
            Console.WriteLine(
                "========== Example 5 ==========");

            StudentDto dto =
                new StudentDto
                {
                    Id = 1,
                    Name = "Peyman"
                };

            Console.WriteLine(dto.Name);

            Console.WriteLine();
        }

        // ==================================================
        // EXAMPLE 6
        // REPOSITORY PATTERN
        // ==================================================

        static void Example6_RepositoryPattern()
        {
            Console.WriteLine(
                "========== Example 6 ==========");

            Console.WriteLine(
                "Repository handles data access.");

            Console.WriteLine();

        }

        // ==================================================
        // EXAMPLE 7
        // SERVICE LAYER
        // ==================================================

        static void Example7_ServiceLayer()
        {
            Console.WriteLine(
                "========== Example 7 ==========");

            Console.WriteLine(
                "Service contains business rules.");

            Console.WriteLine();

        }

        // ==================================================
        // EXAMPLE 8
        // CONTROLLER LAYER
        // ==================================================

        static void Example8_ControllerLayer()
        {
            Console.WriteLine(
                "========== Example 8 ==========");

            Console.WriteLine(
                "Controller receives requests and returns responses.");

            Console.WriteLine();

        }

        // ==================================================
        // EXAMPLE 9
        // DATA FLOW
        // ==================================================

        static void Example9_DataFlow()
        {
            Console.WriteLine(
                "========== Example 9 ==========");

            Console.WriteLine("Client");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("Controller");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("Service");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("Repository");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("Database");

            Console.WriteLine();

        }

        // ==================================================
        // EXAMPLE 10
        // PROFESSIONAL STRUCTURE
        // ==================================================

        static void Example10_ProfessionalStructure()
        {
            Console.WriteLine(
                "========== Example 10 ==========");

            Console.WriteLine("Controllers");

            Console.WriteLine("Services");

            Console.WriteLine("Repositories");

            Console.WriteLine("Models");

            Console.WriteLine("DTOs");

            Console.WriteLine("Interfaces");

            Console.WriteLine("Configuration");

            Console.WriteLine("Tests");

            Console.WriteLine();
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
*/using System;
using System.Collections.Generic;
using System.Linq;

/*
==================================================
PROFESSIONAL PROJECT ARCHITECTURE EXAMPLES
==================================================

These examples demonstrate how a professional
application can be organized using layers.

The goal is to understand responsibilities
and data flow between components.
*/

namespace ProfessionalProjectArchitectureExamples
{
    // ==================================================
    // DOMAIN LAYER
    // ==================================================

    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }

    // ==================================================
    // DTO LAYER
    // ==================================================

    public class StudentDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    // ==================================================
    // REPOSITORY INTERFACE
    // ==================================================

    public interface IStudentRepository
    {
        List<Student> GetAll();

        Student GetById(int id);

        void Add(Student student);

        void Update(Student student);

        void Delete(int id);
    }

    // ==================================================
    // REPOSITORY IMPLEMENTATION
    // ==================================================

    public class StudentRepository : IStudentRepository
    {
        private readonly List<Student> students =
            new List<Student>();

        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetById(int id)
        {
            return students.FirstOrDefault(
                student => student.Id == id);
        }

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Update(Student updatedStudent)
        {
            Student existingStudent =
                GetById(updatedStudent.Id);

            if (existingStudent != null)
            {
                existingStudent.Name =
                    updatedStudent.Name;

                existingStudent.Email =
                    updatedStudent.Email;
            }
        }

        public void Delete(int id)
        {
            Student student = GetById(id);

            if (student != null)
            {
                students.Remove(student);
            }
        }
    }

    // ==================================================
    // SERVICE LAYER
    // ==================================================

    public class StudentService
    {
        private readonly IStudentRepository repository;

        public StudentService(
            IStudentRepository repository)
        {
            this.repository = repository;
        }

        public List<StudentDto> GetStudents()
        {
            return repository
                .GetAll()
                .Select(student =>
                    new StudentDto
                    {
                        Id = student.Id,
                        Name = student.Name
                    })
                .ToList();
        }

        public void CreateStudent(
            string name,
            string email)
        {
            Student student = new Student
            {
                Id = repository.GetAll().Count + 1,
                Name = name,
                Email = email
            };

            repository.Add(student);
        }
    }

    // ==================================================
    // PRESENTATION LAYER
    // ==================================================

    public class StudentController
    {
        private readonly StudentService service;

        public StudentController(
            StudentService service)
        {
            this.service = service;
        }

        public void GetStudents()
        {
            Console.WriteLine(
                "GET /api/students");

            List<StudentDto> students =
                service.GetStudents();

            foreach (StudentDto student in students)
            {
                Console.WriteLine(
                    $"{student.Id} - {student.Name}");
            }

            Console.WriteLine();
        }

        public void CreateStudent(
            string name,
            string email)
        {
            Console.WriteLine(
                "POST /api/students");

            service.CreateStudent(
                name,
                email);

            Console.WriteLine(
                "Student Created");

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Example1_LayeredArchitecture();

            Example2_DependencyInjection();

            Example3_CreateStudent();

            Example4_GetStudents();

            Example5_DtoConcept();

            Example6_RepositoryPattern();

            Example7_ServiceLayer();

            Example8_ControllerLayer();

            Example9_DataFlow();

            Example10_ProfessionalStructure();
        }

        // ==================================================
        // EXAMPLE 1
        // LAYERED ARCHITECTURE
        // ==================================================

        static void Example1_LayeredArchitecture()
        {
            Console.WriteLine(
                "========== Example 1 ==========");

            Console.WriteLine(
                "Presentation Layer");

            Console.WriteLine(
                "Application Layer");

            Console.WriteLine(
                "Domain Layer");

            Console.WriteLine(
                "Infrastructure Layer");

            Console.WriteLine();
        }

        // ==================================================
        // EXAMPLE 2
        // DEPENDENCY INJECTION
        // ==================================================

        static void Example2_DependencyInjection()
        {
            Console.WriteLine(
                "========== Example 2 ==========");

            IStudentRepository repository =
                new StudentRepository();

            StudentService service =
                new StudentService(repository);

            Console.WriteLine(
                "Repository injected into Service.");

            Console.WriteLine();
        }

        // ==================================================
        // EXAMPLE 3
        // CREATE STUDENT
        // ==================================================

        static void Example3_CreateStudent()
        {
            Console.WriteLine(
                "========== Example 3 ==========");

            IStudentRepository repository =
                new StudentRepository();

            StudentService service =
                new StudentService(repository);

            service.CreateStudent(
                "Peyman",
                "peyman@example.com");

            Console.WriteLine(
                "Student Added.");

            Console.WriteLine();
        }

        // ==================================================
        // EXAMPLE 4
        // GET STUDENTS
        // ==================================================

        static void Example4_GetStudents()
        {
            Console.WriteLine(
                "========== Example 4 ==========");

            IStudentRepository repository =
                new StudentRepository();

            StudentService service =
                new StudentService(repository);

            service.CreateStudent(
                "Peyman",
                "peyman@example.com");

            List<StudentDto> students =
                service.GetStudents();

            foreach (StudentDto student in students)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine();
        }

        // ==================================================
        // EXAMPLE 5
        // DTO CONCEPT
        // ==================================================

        static void Example5_DtoConcept()
        {
            Console.WriteLine(
                "========== Example 5 ==========");

            StudentDto dto =
                new StudentDto
                {
                    Id = 1,
                    Name = "Peyman"
                };

            Console.WriteLine(dto.Name);

            Console.WriteLine();
        }

        // ==================================================
        // EXAMPLE 6
        // REPOSITORY PATTERN
        // ==================================================

        static void Example6_RepositoryPattern()
        {
            Console.WriteLine(
                "========== Example 6 ==========");

            Console.WriteLine(
                "Repository handles data access.");

            Console.WriteLine();

        }

        // ==================================================
        // EXAMPLE 7
        // SERVICE LAYER
        // ==================================================

        static void Example7_ServiceLayer()
        {
            Console.WriteLine(
                "========== Example 7 ==========");

            Console.WriteLine(
                "Service contains business rules.");

            Console.WriteLine();

        }

        // ==================================================
        // EXAMPLE 8
        // CONTROLLER LAYER
        // ==================================================

        static void Example8_ControllerLayer()
        {
            Console.WriteLine(
                "========== Example 8 ==========");

            Console.WriteLine(
                "Controller receives requests and returns responses.");

            Console.WriteLine();

        }

        // ==================================================
        // EXAMPLE 9
        // DATA FLOW
        // ==================================================

        static void Example9_DataFlow()
        {
            Console.WriteLine(
                "========== Example 9 ==========");

            Console.WriteLine("Client");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("Controller");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("Service");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("Repository");

            Console.WriteLine(" ↓ ");

            Console.WriteLine("Database");

            Console.WriteLine();

        }

        // ==================================================
        // EXAMPLE 10
        // PROFESSIONAL STRUCTURE
        // ==================================================

        static void Example10_ProfessionalStructure()
        {
            Console.WriteLine(
                "========== Example 10 ==========");

            Console.WriteLine("Controllers");

            Console.WriteLine("Services");

            Console.WriteLine("Repositories");

            Console.WriteLine("Models");

            Console.WriteLine("DTOs");

            Console.WriteLine("Interfaces");

            Console.WriteLine("Configuration");

            Console.WriteLine("Tests");

            Console.WriteLine();
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
