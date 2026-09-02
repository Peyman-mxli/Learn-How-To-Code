namespace StudentManagementSystem;

public sealed class Student
{
    public int StudentId { get; }
    public string FullName { get; private set; }
    public int Age { get; private set; }
    public string Email { get; private set; }
    public string Course { get; private set; }
    public double Grade { get; private set; }

    public Student(
        int studentId,
        string fullName,
        int age,
        string email,
        string course,
        double grade)
    {
        Validate(studentId, fullName, age, email, course, grade);

        StudentId = studentId;
        FullName = fullName.Trim();
        Age = age;
        Email = email.Trim();
        Course = course.Trim();
        Grade = grade;
    }

    public void Update(
        string fullName,
        int age,
        string email,
        string course,
        double grade)
    {
        Validate(StudentId, fullName, age, email, course, grade);

        FullName = fullName.Trim();
        Age = age;
        Email = email.Trim();
        Course = course.Trim();
        Grade = grade;
    }

    public override string ToString()
    {
        return $"ID: {StudentId} | Name: {FullName} | Age: {Age} | " +
               $"Email: {Email} | Course: {Course} | Grade: {Grade:F2}";
    }

    private static void Validate(
        int studentId,
        string fullName,
        int age,
        string email,
        string course,
        double grade)
    {
        if (studentId <= 0)
            throw new ArgumentOutOfRangeException(nameof(studentId), "Student ID must be greater than zero.");

        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("Full name is required.", nameof(fullName));

        if (age <= 0 || age > 130)
            throw new ArgumentOutOfRangeException(nameof(age), "Age must be between 1 and 130.");

        if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
            throw new ArgumentException("A valid email address is required.", nameof(email));

        if (string.IsNullOrWhiteSpace(course))
            throw new ArgumentException("Course is required.", nameof(course));

        if (grade < 0 || grade > 100)
            throw new ArgumentOutOfRangeException(nameof(grade), "Grade must be between 0 and 100.");
    }
}
