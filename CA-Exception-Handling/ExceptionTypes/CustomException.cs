namespace CA_Exception_Handling.ExceptionTypes;

public class CustomException
{
    public static void Caller()
    {
        try
        {
            Method1();
        }
        catch (Exception e)
        {
            //Throw a new exception with additional details
            throw new MoreDescriptiveException("Caller thrown an exception while invoking Method1", e);
        }
    }

    private static void Method1()
    {
        string name = null;
        Console.WriteLine(name.Equals(""));
    }
}

public class MoreDescriptiveException(string moreDetailsAboutTheException, Exception exception)
    : Exception(moreDetailsAboutTheException, exception);