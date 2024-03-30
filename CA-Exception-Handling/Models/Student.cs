namespace CA_Exception_Handling.Models;

public abstract class Student(string? studentName)
{
    public string? StudentName { get; } = studentName;
}