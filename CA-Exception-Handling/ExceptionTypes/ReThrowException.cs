using System.Runtime.ExceptionServices;

namespace CA_Exception_Handling.ExceptionTypes;

public class ReThrowException
{
    public static void Caller()
    {
        try
        {
            Method1();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    
    private static void Method1()
    {
        try
        {
            Method2();
        }
        catch (Exception e)
        {
            //Best practise is to catch the exception and re-throw it.
            //Console.WriteLine(e);
            
            //Capture an exception and re-throw it without changing the stack-trace
            ExceptionDispatchInfo.Capture(e.InnerException ?? e).Throw();
            throw;
        }
    }

    private static void Method2()
    {
        string str = null;
        Console.WriteLine(str[0]);
    }
}