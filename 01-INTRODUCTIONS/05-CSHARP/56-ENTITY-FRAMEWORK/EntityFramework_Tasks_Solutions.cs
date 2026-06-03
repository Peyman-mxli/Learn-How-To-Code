using System;
using System.Collections.Generic;
using System.Linq;

/*
=========================================
ENTITY FRAMEWORK TASKS SOLUTIONS
=========================================

These solutions simulate Entity Framework concepts
using C# classes and collections.

In a real EF Core project, I would use:

- DbContext
- DbSet
- SaveChanges()
- Migrations
- Database provider packages
*/

namespace EntityFrameworkTaskSolutions
{
    public class Student
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();
    }

    public class Course
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();
    }

    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public decimal Salary { get; set; }

        public DateTime CreatedAt { get; set; }
    }

    public class SchoolContext
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public List<Course> Courses { get; set; } = new List<Course>();

        public List<Employee> Employees { get; set; } = new List<Employee>();

        public void SaveChanges()
        {
            Console.WriteLine("Changes saved successfully.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            SchoolContext context = new SchoolContext();

            AddStudent(context);
            ReadStudents(context);
            FindStudent(context);
            UpdateStudent(context);
            DeleteStudent(context);

            FilterStudents(context);
            OrderStudents(context);
            CountStudents(context);
            CheckStudentExists(context);

            CreateRelationship(context);

            UseAsNoTrackingConcept();

            CreateEmployee(context);
            ReadEmployees(context);
            UpdateEmployee(context);
            DeleteEmployee(context);

            RealWorldQuery(context);

            ExplainEntityFramework();
        }

        public static void AddStudent(SchoolContext context)
        {
            Student student = new Student
            {
                Id = 1,
                FullName = "Peyman Miyandashti",
                Age = 25,
                Email = "peyman@example.com"
            };

            context.Students.Add(student);
            context.SaveChanges();
        }

        public static void ReadStudents(SchoolContext context)
        {
            foreach (Student student in context.Students)
            {
                Console.WriteLine($"{student.Id} - {student.FullName} - {student.Age} - {student.Email}");
            }
        }

        public static void FindStudent(SchoolContext context)
        {
            Student student = context.Students.FirstOrDefault(s => s.Id == 1);

            if (student != null)
            {
                Console.WriteLine(student.FullName);
            }
        }

        public static void UpdateStudent(SchoolContext context)
        {
            Student student = context.Students.FirstOrDefault(s => s.Id == 1);

            if (student != null)
            {
                student.Email = "updated@example.com";
                context.SaveChanges();
            }
        }

        public static void DeleteStudent(SchoolContext context)
        {
            Student student = context.Students.FirstOrDefault(s => s.Id == 1);

            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }

        public static void FilterStudents(SchoolContext context)
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, FullName = "Ali", Age = 17, Email = "ali@example.com" },
                new Student { Id = 2, FullName = "Sara", Age = 20, Email = "sara@example.com" },
                new Student { Id = 3, FullName = "Peyman", Age = 25, Email = "peyman@example.com" }
            };

            var adults = students.Where(s => s.Age > 18);

            foreach (Student student in adults)
            {
                Console.WriteLine(student.FullName);
            }
        }

        public static void OrderStudents(SchoolContext context)
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, FullName = "Sara" },
                new Student { Id = 2, FullName = "Ali" },
                new Student { Id = 3, FullName = "Peyman" }
            };

            var orderedStudents = students.OrderBy(s => s.FullName);

            foreach (Student student in orderedStudents)
            {
                Console.WriteLine(student.FullName);
            }
        }

        public static void CountStudents(SchoolContext context)
        {
            int totalStudents = context.Students.Count;

            Console.WriteLine($"Total students: {totalStudents}");
        }

        public static void CheckStudentExists(SchoolContext context)
        {
            bool exists = context.Students.Any(s => s.Email == "peyman@example.com");

            Console.WriteLine(exists);
        }

        public static void CreateRelationship(SchoolContext context)
        {
            Student student = new Student
            {
                Id = 1,
                FullName = "Peyman Miyandashti"
            };

            Course course = new Course
            {
                Id = 1,
                Title = "C# Programming",
                Credits = 5
            };

            student.Courses.Add(course);
            course.Students.Add(student);

            context.Students.Add(student);
            context.Courses.Add(course);

            context.SaveChanges();
        }

        /*
        Migration command:

        Add-Migration InitialCreate

        Update database command:

        Update-Database
        */

        public static void UseAsNoTrackingConcept()
        {
            Console.WriteLine("AsNoTracking() is useful when I only want to read data.");
            Console.WriteLine("It improves performance because Entity Framework does not track changes.");
        }

        public static void CreateEmployee(SchoolContext context)
        {
            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "Peyman",
                LastName = "Miyandashti",
                Email = "peyman@example.com",
                Salary = 15000,
                CreatedAt = DateTime.Now
            };

            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public static void ReadEmployees(SchoolContext context)
        {
            foreach (Employee employee in context.Employees)
            {
                Console.WriteLine($"{employee.Id} - {employee.FirstName} {employee.LastName} - {employee.Email} - {employee.Salary}");
            }
        }

        public static void UpdateEmployee(SchoolContext context)
        {
            Employee employee = context.Employees.FirstOrDefault(e => e.Id == 1);

            if (employee != null)
            {
                employee.Salary = 18000;
                context.SaveChanges();
            }
        }

        public static void DeleteEmployee(SchoolContext context)
        {
            Employee employee = context.Employees.FirstOrDefault(e => e.Id == 1);

            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
        }

        public static void RealWorldQuery(SchoolContext context)
        {
            context.Employees.Add(new Employee
            {
                Id = 2,
                FirstName = "Sara",
                LastName = "Lopez",
                Email = "sara@example.com",
                Salary = 12000,
                CreatedAt = DateTime.Now
            });

            context.Employees.Add(new Employee
            {
                Id = 3,
                FirstName = "Ali",
                LastName = "Ahmadi",
                Email = "ali@example.com",
                Salary = 9000,
                CreatedAt = DateTime.Now
            });

            var employees = context.Employees
                .Where(e => e.Salary > 10000)
                .OrderBy(e => e.LastName);

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.LastName}, {employee.FirstName} - {employee.Salary}");
            }
        }

        public static void ExplainEntityFramework()
        {
            Console.WriteLine("Entity Framework is an ORM used to work with databases using C# objects.");
            Console.WriteLine("ORM means Object Relational Mapper.");
            Console.WriteLine("DbContext represents the connection between the application and the database.");
            Console.WriteLine("DbSet represents a table inside the database.");
            Console.WriteLine("SaveChanges() is important because it saves pending changes to the database.");
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
