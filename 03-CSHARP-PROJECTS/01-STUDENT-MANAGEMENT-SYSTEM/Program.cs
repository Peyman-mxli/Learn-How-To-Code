namespace StudentManagementSystem;

public static class Program
{
    public static void Main()
    {
        var manager = new StudentManager();

        while (true)
        {
            PrintMenu();
            string? choice = Console.ReadLine()?.Trim();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    AddStudent(manager);
                    break;
                case "2":
                    ViewStudents(manager);
                    break;
                case "3":
                    SearchStudent(manager);
                    break;
                case "4":
                    UpdateStudent(manager);
                    break;
                case "5":
                    DeleteStudent(manager);
                    break;
                case "6":
                    Console.WriteLine("Thank you for using Student Management System.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Choose a number from 1 to 6.");
                    break;
            }

            Console.WriteLine();
            Console.Write("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }

    private static void PrintMenu()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("     STUDENT MANAGEMENT SYSTEM");
        Console.WriteLine("========================================");
        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. View All Students");
        Console.WriteLine("3. Search Student");
        Console.WriteLine("4. Update Student");
        Console.WriteLine("5. Delete Student");
        Console.WriteLine("6. Exit");
        Console.Write("Choose an option: ");
    }

    private static void AddStudent(StudentManager manager)
    {
        Console.WriteLine("ADD STUDENT");
        Console.WriteLine("----------------------------------------");

        int id = ReadInt("Student ID", min: 1);
        string name = ReadRequired("Full Name");
        int age = ReadInt("Age", min: 1, max: 130);
        string email = ReadEmail("Email");
        string course = ReadRequired("Course");
        double grade = ReadDouble("Grade", min: 0, max: 100);

        try
        {
            var student = new Student(id, name, age, email, course, grade);
            manager.AddStudent(student, out string message);
            Console.WriteLine(message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Validation error: {ex.Message}");
        }
    }

    private static void ViewStudents(StudentManager manager)
    {
        Console.WriteLine("ALL STUDENTS");
        Console.WriteLine("----------------------------------------");

        if (manager.Students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        foreach (Student student in manager.Students)
            Console.WriteLine(student);

        Console.WriteLine($"Total: {manager.GetTotalStudents()}");
    }

    private static void SearchStudent(StudentManager manager)
    {
        Console.WriteLine("SEARCH STUDENT");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("1. Search by ID");
        Console.WriteLine("2. Search by name");
        Console.Write("Choose: ");

        string? searchChoice = Console.ReadLine()?.Trim();

        if (searchChoice == "1")
        {
            int id = ReadInt("Student ID", min: 1);
            Student? student = manager.SearchStudentById(id);
            Console.WriteLine(student is null ? "Student not found." : student);
            return;
        }

        if (searchChoice == "2")
        {
            string name = ReadRequired("Name or partial name");
            IReadOnlyList<Student> matches = manager.SearchStudentsByName(name);

            if (matches.Count == 0)
            {
                Console.WriteLine("No matching students found.");
                return;
            }

            foreach (Student student in matches)
                Console.WriteLine(student);

            return;
        }

        Console.WriteLine("Invalid search option.");
    }

    private static void UpdateStudent(StudentManager manager)
    {
        Console.WriteLine("UPDATE STUDENT");
        Console.WriteLine("----------------------------------------");

        int id = ReadInt("Student ID to update", min: 1);
        Student? existing = manager.SearchStudentById(id);

        if (existing is null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        Console.WriteLine($"Current: {existing}");

        string name = ReadRequired("New Full Name");
        int age = ReadInt("New Age", min: 1, max: 130);
        string email = ReadEmail("New Email");
        string course = ReadRequired("New Course");
        double grade = ReadDouble("New Grade", min: 0, max: 100);

        manager.UpdateStudent(
            id,
            name,
            age,
            email,
            course,
            grade,
            out string message);

        Console.WriteLine(message);
    }

    private static void DeleteStudent(StudentManager manager)
    {
        Console.WriteLine("DELETE STUDENT");
        Console.WriteLine("----------------------------------------");

        int id = ReadInt("Student ID to delete", min: 1);
        Student? student = manager.SearchStudentById(id);

        if (student is null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        Console.WriteLine(student);
        Console.Write("Delete this student? (Y/N): ");
        string confirmation = Console.ReadLine()?.Trim() ?? "";

        if (!confirmation.Equals("Y", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Delete cancelled.");
            return;
        }

        Console.WriteLine(
            manager.DeleteStudent(id)
                ? "Student deleted successfully."
                : "Student deletion failed.");
    }

    private static string ReadRequired(string label)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            string value = Console.ReadLine()?.Trim() ?? "";

            if (!string.IsNullOrWhiteSpace(value))
                return value;

            Console.WriteLine($"{label} cannot be empty.");
        }
    }

    private static string ReadEmail(string label)
    {
        while (true)
        {
            string value = ReadRequired(label);

            if (value.Contains('@') && value.Contains('.'))
                return value;

            Console.WriteLine("Enter a valid email address.");
        }
    }

    private static int ReadInt(string label, int min, int? max = null)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            string? raw = Console.ReadLine();

            if (int.TryParse(raw, out int value) &&
                value >= min &&
                (!max.HasValue || value <= max.Value))
            {
                return value;
            }

            string range = max.HasValue ? $"{min}-{max.Value}" : $">= {min}";
            Console.WriteLine($"Enter a valid integer ({range}).");
        }
    }

    private static double ReadDouble(string label, double min, double max)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            string? raw = Console.ReadLine();

            if (double.TryParse(raw, out double value) &&
                value >= min &&
                value <= max)
            {
                return value;
            }

            Console.WriteLine($"Enter a number between {min} and {max}.");
        }
    }
}
