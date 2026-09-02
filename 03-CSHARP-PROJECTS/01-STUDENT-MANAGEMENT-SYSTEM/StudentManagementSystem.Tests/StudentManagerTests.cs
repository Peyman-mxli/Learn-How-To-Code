using StudentManagementSystem;

namespace StudentManagementSystem.Tests;

public class StudentManagerTests
{
    [Fact]
    public void AddStudent_RejectsDuplicateId()
    {
        var manager = new StudentManager();
        var first = new Student(1, "Alex Rivera", 20, "alex@example.com", "IT", 90);
        var duplicate = new Student(1, "Sam Lee", 21, "sam@example.com", "CS", 88);

        Assert.True(manager.AddStudent(first, out _));
        Assert.False(manager.AddStudent(duplicate, out _));
        Assert.Single(manager.Students);
    }

    [Fact]
    public void SearchStudentsByName_IsCaseInsensitive()
    {
        var manager = new StudentManager();
        manager.AddStudent(
            new Student(1, "Alex Rivera", 20, "alex@example.com", "IT", 90),
            out _);

        var results = manager.SearchStudentsByName("alex");

        Assert.Single(results);
        Assert.Equal(1, results[0].StudentId);
    }

    [Fact]
    public void DeleteStudent_RemovesExistingStudent()
    {
        var manager = new StudentManager();
        manager.AddStudent(
            new Student(1, "Alex Rivera", 20, "alex@example.com", "IT", 90),
            out _);

        Assert.True(manager.DeleteStudent(1));
        Assert.Empty(manager.Students);
    }
}
