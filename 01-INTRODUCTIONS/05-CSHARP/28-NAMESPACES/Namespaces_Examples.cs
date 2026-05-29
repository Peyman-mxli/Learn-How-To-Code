using System;
using SchoolSystem.Students;
using SchoolSystem.Teachers;
using Company.HR;
using Company.IT;

namespace SchoolSystem.Students
{
    public class Student
    {
        public string Name { get; set; }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying.");
        }
    }
}

namespace SchoolSystem.Teachers
{
    public class Teacher
    {
        public string Name { get; set; }

        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching.");
        }
    }
}

namespace Company.HR
{
    public class Employee
    {
        public string Name { get; set; }

        public void Work()
        {
            Console.WriteLine($"{Name} works in HR.");
        }
    }
}

namespace Company.IT
{
    public class Employee
    {
        public string Name { get; set; }

        public void Work()
        {
            Console.WriteLine($"{Name} works in IT.");
        }
    }
}

namespace NamespacesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== NAMESPACES EXAMPLES =====\n");

            // --------------------------------------------------
            // Example 1: Student Namespace
            // --------------------------------------------------

            Student student = new Student
            {
                Name = "Peyman"
            };

            Console.WriteLine("Example 1");
            student.Study();
            Console.WriteLine();

            // --------------------------------------------------
            // Example 2: Teacher Namespace
            // --------------------------------------------------

            Teacher teacher = new Teacher
            {
                Name = "Professor Smith"
            };

            Console.WriteLine("Example 2");
            teacher.Teach();
            Console.WriteLine();

            // --------------------------------------------------
            // Example 3: HR Employee
            // --------------------------------------------------

            Company.HR.Employee hrEmployee =
                new Company.HR.Employee
                {
                    Name = "Sarah"
                };

            Console.WriteLine("Example 3");
            hrEmployee.Work();
            Console.WriteLine();

            // --------------------------------------------------
            // Example 4: IT Employee
            // --------------------------------------------------

            Company.IT.Employee itEmployee =
                new Company.IT.Employee
                {
                    Name = "John"
                };

            Console.WriteLine("Example 4");
            itEmployee.Work();
            Console.WriteLine();

            // --------------------------------------------------
            // Example 5: Same Class Name
            // --------------------------------------------------

            Console.WriteLine("Example 5");

            Console.WriteLine(
                "Both Employee classes exist because " +
                "they are in different namespaces."
            );

            Console.WriteLine();

            // --------------------------------------------------
            // Example 6: Fully Qualified Names
            // --------------------------------------------------

            Console.WriteLine("Example 6");

            SchoolSystem.Students.Student student2 =
                new SchoolSystem.Students.Student
                {
                    Name = "Maria"
                };

            student2.Study();

            Console.WriteLine();

            // --------------------------------------------------
            // Example 7: Multiple Namespaces
            // --------------------------------------------------

            Console.WriteLine("Example 7");

            Student student3 = new Student
            {
                Name = "Ali"
            };

            Teacher teacher2 = new Teacher
            {
                Name = "Mr. Johnson"
            };

            student3.Study();
            teacher2.Teach();

            Console.WriteLine();

            // --------------------------------------------------
            // Example 8: Nested Namespace Example
            // --------------------------------------------------

            Console.WriteLine("Example 8");

            Console.WriteLine(
                "Company.HR is a nested namespace."
            );

            Console.WriteLine(
                "Company.IT is another nested namespace."
            );

            Console.WriteLine();

            // --------------------------------------------------
            // Example 9: Namespace Organization
            // --------------------------------------------------

            Console.WriteLine("Example 9");

            Console.WriteLine(
                "Students belong in Students namespace."
            );

            Console.WriteLine(
                "Teachers belong in Teachers namespace."
            );

            Console.WriteLine();

            // --------------------------------------------------
            // Example 10: Avoiding Name Conflicts
            // --------------------------------------------------

            Console.WriteLine("Example 10");

            Company.HR.Employee employee1 =
                new Company.HR.Employee
                {
                    Name = "Emma"
                };

            Company.IT.Employee employee2 =
                new Company.IT.Employee
                {
                    Name = "Michael"
                };

            employee1.Work();
            employee2.Work();

            Console.WriteLine();

            // --------------------------------------------------
            // Example 11: Using Directive
            // --------------------------------------------------

            Console.WriteLine("Example 11");

            Console.WriteLine(
                "using SchoolSystem.Students"
            );

            Console.WriteLine(
                "allows Student to be used directly."
            );

            Console.WriteLine();

            // --------------------------------------------------
            // Example 12: File Organization
            // --------------------------------------------------

            Console.WriteLine("Example 12");

            Console.WriteLine(
                "Namespaces help organize large projects."
            );

            Console.WriteLine();

            // --------------------------------------------------
            // Example 13: Project Structure
            // --------------------------------------------------

            Console.WriteLine("Example 13");

            Console.WriteLine(
                "NovaZone.Player"
            );

            Console.WriteLine(
                "NovaZone.Inventory"
            );

            Console.WriteLine(
                "NovaZone.Combat"
            );

            Console.WriteLine();

            // --------------------------------------------------
            // Example 14: Professional Structure
            // --------------------------------------------------

            Console.WriteLine("Example 14");

            Console.WriteLine(
                "OnlineStore.Products"
            );

            Console.WriteLine(
                "OnlineStore.Orders"
            );

            Console.WriteLine(
                "OnlineStore.Customers"
            );

            Console.WriteLine();

            // --------------------------------------------------
            // Example 15: Namespace Benefits
            // --------------------------------------------------

            Console.WriteLine("Example 15");

            Console.WriteLine(
                "Namespaces improve readability,"
            );

            Console.WriteLine(
                "organization, and maintainability."
            );

            Console.WriteLine();

            Console.WriteLine(
                "All Namespaces examples completed."
            );
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
