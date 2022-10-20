
try
{

}
catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex); }
catch (IndexOutOfRangeException ex) { Console.WriteLine(ex); }
catch (StackOverflowException ex) { Console.WriteLine(ex); }
catch (OutOfMemoryException ex) { Console.WriteLine(ex); }
catch (MyException ex) { Console.WriteLine(ex); }


public class MyException : Exception
{
    public MyException() : base()
    {
        Console.WriteLine("Общая ошибка");
    }

}
