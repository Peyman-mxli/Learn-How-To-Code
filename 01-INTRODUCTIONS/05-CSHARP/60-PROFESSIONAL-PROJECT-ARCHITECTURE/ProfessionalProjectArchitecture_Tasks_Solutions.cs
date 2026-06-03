using System;
using System.Collections.Generic;
using System.Linq;

/*
=========================================
PROFESSIONAL PROJECT ARCHITECTURE TASKS SOLUTIONS
=========================================
*/

namespace ProfessionalProjectArchitectureTaskSolutions
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime CreatedAt { get; set; }
    }

    public class StudentDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public interface IStudentRepository
    {
        List<Student> GetAll();

        Student GetById(int id);

        void Add(Student student);

        void Update(Student student);

        void Delete(int id);
    }

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
            return students.FirstOrDefault(student => student.Id == id);
        }

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Update(Student updatedStudent)
        {
            Student student = GetById(updatedStudent.Id);

            if (student != null)
            {
                student.Name = updatedStudent.Name;
                student.Email = updatedStudent.Email;
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

    public class StudentService
    {
        private readonly IStudentRepository repository;

        public StudentService(IStudentRepository repository)
        {
            this.repository = repository;
        }

        public List<StudentDto> GetStudents()
        {
            return repository
                .GetAll()
                .Select(student => new StudentDto
                {
                    Id = student.Id,
                    Name = student.Name
                })
                .ToList();
        }

        public void CreateStudent(string name, string email)
        {
            Student student = new Student
            {
                Id = repository.GetAll().Count + 1,
                Name = name,
                Email = email,
                CreatedAt = DateTime.Now
            };

            repository.Add(student);
        }
    }

    public class StudentController
    {
        private readonly StudentService service;

        public StudentController(StudentService service)
        {
            this.service = service;
        }

        public void GetStudents()
        {
            List<StudentDto> students = service.GetStudents();

            foreach (StudentDto student in students)
            {
                Console.WriteLine($"{student.Id} - {student.Name}");
            }
        }

        public void CreateStudent(string name, string email)
        {
            service.CreateStudent(name, email);

            Console.WriteLine("Student created successfully.");
        }
    }

    class Program
    {
        static void Main()
        {
            ExplainProjectArchitecture();
            ExplainWhyArchitectureMatters();
            ExplainSeparationOfResponsibilities();
            ExplainPresentationLayer();
            ExplainApplicationLayer();
            ExplainDomainLayer();
            ExplainInfrastructureLayer();

            CreateStudentEntityExample();
            CreateStudentDtoExample();
            CreateRepositoryExample();

            ExplainRepositoryPattern();
            ExplainServiceLayer();
            ExplainControllerLayer();
            ExplainDependencyInjection();
            ExplainDtos();
            PlanFolderStructure();
            ExplainDataFlow();
            ExplainMaintainability();
            ExplainScalability();
            DesignProfessionalProject();
        }

        static void ExplainProjectArchitecture()
        {
            Console.WriteLine("Project architecture means how code, folders, classes, and responsibilities are organized.");
            Console.WriteLine("It helps separate responsibilities and keeps the project clean.");
        }

        static void ExplainWhyArchitectureMatters()
        {
            Console.WriteLine("Architecture matters because it improves readability, maintainability, testing, teamwork, and scalability.");
        }

        static void ExplainSeparationOfResponsibilities()
        {
            Console.WriteLine("Separation of responsibilities means each class should have one clear job.");
            Console.WriteLine("Bad example: one class handles database, emails, validation, and reports.");
            Console.WriteLine("Good example: Repository handles database, Service handles business logic, EmailService handles emails.");
        }

        static void ExplainPresentationLayer()
        {
            Console.WriteLine("The presentation layer interacts with users through controllers, endpoints, views, or UI.");
        }

        static void ExplainApplicationLayer()
        {
            Console.WriteLine("The application layer contains services, business rules, workflows, and coordination logic.");
        }

        static void ExplainDomainLayer()
        {
            Console.WriteLine("The domain layer contains core business entities such as Student, Product, Order, and Customer.");
        }

        static void ExplainInfrastructureLayer()
        {
            Console.WriteLine("The infrastructure layer handles external systems such as databases, email services, file systems, and third-party APIs.");
        }

        static void CreateStudentEntityExample()
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Peyman",
                Email = "peyman@example.com",
                CreatedAt = DateTime.Now
            };

            Console.WriteLine($"{student.Id} - {student.Name} - {student.Email} - {student.CreatedAt}");
        }

        static void CreateStudentDtoExample()
        {
            StudentDto dto = new StudentDto
            {
                Id = 1,
                Name = "Peyman"
            };

            Console.WriteLine($"{dto.Id} - {dto.Name}");
            Console.WriteLine("The DTO does not include Email because DTOs can hide sensitive or unnecessary data.");
        }

        static void CreateRepositoryExample()
        {
            IStudentRepository repository = new StudentRepository();

            repository.Add(new Student
            {
                Id = 1,
                Name = "Peyman",
                Email = "peyman@example.com",
                CreatedAt = DateTime.Now
            });

            Console.WriteLine("Repository created and student added.");
        }

        static void ExplainRepositoryPattern()
        {
            Console.WriteLine("The repository pattern handles data access and isolates database operations from the service layer.");
        }

        static void ExplainServiceLayer()
        {
            Console.WriteLine("The service layer contains business logic, validation rules, and coordinates between repository and controller.");
        }

        static void ExplainControllerLayer()
        {
            Console.WriteLine("Controllers should receive requests, call services, and return responses.");
            Console.WriteLine("Controllers should not contain large business logic or direct database access.");
        }

        static void ExplainDependencyInjection()
        {
            Console.WriteLine("Dependency Injection provides required dependencies automatically.");
            Console.WriteLine("It reduces tight coupling, improves testing, and keeps code cleaner.");
        }

        static void ExplainDtos()
        {
            Console.WriteLine("DTO means Data Transfer Object.");
            Console.WriteLine("DTOs transfer data between layers and protect sensitive data by exposing only needed fields.");
        }

        static void PlanFolderStructure()
        {
            Console.WriteLine("Professional folder structure:");
            Console.WriteLine("Controllers/");
            Console.WriteLine("Services/");
            Console.WriteLine("Repositories/");
            Console.WriteLine("Models/");
            Console.WriteLine("DTOs/");
            Console.WriteLine("Interfaces/");
            Console.WriteLine("Data/");
            Console.WriteLine("Configuration/");
            Console.WriteLine("Tests/");
        }

        static void ExplainDataFlow()
        {
            Console.WriteLine("Client sends request to Controller.");
            Console.WriteLine("Controller calls Service.");
            Console.WriteLine("Service calls Repository.");
            Console.WriteLine("Repository communicates with Database.");
            Console.WriteLine("Data returns from Database to Repository, Service, Controller, then Client.");
        }

        static void ExplainMaintainability()
        {
            Console.WriteLine("Maintainability means the code is easy to update, debug, refactor, and work on with a team.");
        }

        static void ExplainScalability()
        {
            Console.WriteLine("Scalability means the project can grow with more users, more features, more developers, and more system needs.");
        }

        static void DesignProfessionalProject()
        {
            Console.WriteLine("Project Name: Student Management API");
            Console.WriteLine("Purpose: Manage student information professionally.");
            Console.WriteLine("Main Entities: Student, Course, Teacher.");
            Console.WriteLine("DTOs: StudentDto, CourseDto, TeacherDto.");
            Console.WriteLine("Services: StudentService, CourseService, TeacherService.");
            Console.WriteLine("Repositories: StudentRepository, CourseRepository, TeacherRepository.");
            Console.WriteLine("Controllers: StudentController, CourseController, TeacherController.");
            Console.WriteLine("Folder Structure: Controllers, Services, Repositories, Models, DTOs, Interfaces, Data, Configuration, Tests.");
            Console.WriteLine("This architecture is professional because responsibilities are separated, code is organized, and the project is easier to maintain.");
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
