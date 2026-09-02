namespace StudentManagementSystem;

public sealed class StudentManager
{
    private readonly List<Student> _students = new();

    public IReadOnlyList<Student> Students => _students.AsReadOnly();

    public bool AddStudent(Student student, out string message)
    {
        ArgumentNullException.ThrowIfNull(student);

        if (_students.Any(existing => existing.StudentId == student.StudentId))
        {
            message = $"Student ID {student.StudentId} already exists.";
            return false;
        }

        _students.Add(student);
        message = "Student added successfully.";
        return true;
    }

    public Student? SearchStudentById(int studentId)
    {
        return _students.FirstOrDefault(student => student.StudentId == studentId);
    }

    public IReadOnlyList<Student> SearchStudentsByName(string query)
    {
        if (string.IsNullOrWhiteSpace(query))
            return Array.Empty<Student>();

        return _students
            .Where(student =>
                student.FullName.Contains(
                    query.Trim(),
                    StringComparison.OrdinalIgnoreCase))
            .ToList()
            .AsReadOnly();
    }

    public bool UpdateStudent(
        int studentId,
        string fullName,
        int age,
        string email,
        string course,
        double grade,
        out string message)
    {
        Student? student = SearchStudentById(studentId);

        if (student is null)
        {
            message = "Student not found.";
            return false;
        }

        try
        {
            student.Update(fullName, age, email, course, grade);
            message = "Student updated successfully.";
            return true;
        }
        catch (ArgumentException ex)
        {
            message = ex.Message;
            return false;
        }
    }

    public bool DeleteStudent(int studentId)
    {
        Student? student = SearchStudentById(studentId);
        return student is not null && _students.Remove(student);
    }

    public int GetTotalStudents() => _students.Count;
}
