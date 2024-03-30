using CA_Exception_Handling.Models;

namespace CA_Exception_Handling.ExceptionTypes;

public class ManualException
{
    public void Caller()
    {
        Student std = null!;
        try
        {
            PrintStudentName(std);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }

    private static void PrintStudentName(Student std)
    {
        if (std == null)
            //Creates an object of Exception using new keyword
            throw new NullReferenceException("Student object is null.");
        Console.WriteLine(std.StudentName);
    }
}