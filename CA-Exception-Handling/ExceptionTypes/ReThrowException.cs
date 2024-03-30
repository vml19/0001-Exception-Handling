namespace CA_Exception_Handling.ExceptionTypes;

public class ReThrowException
{
    public void Caller()
    {
        try
        {
            Method1();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.StackTrace);
        }
    }
    
    private void Method1()
    {
        try
        {
            Method2();
        }
        catch (Exception e)
        {
            //Best practise is to catch the exception and re-throw it.
            Console.WriteLine(e);
            throw;
        }
    }

    private void Method2()
    {
        try
        {
            string str = null;
            Console.WriteLine(str[0]);
        }
        catch (Exception e)
        {
            //Best practise is to catch the exception and re-throw it.
            Console.WriteLine(e);
            throw;
        }
    }
}