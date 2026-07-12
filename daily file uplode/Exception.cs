using System;

class Exception
{
    public static void Main()
    {
        try
        {
            int a = 50;
            int b = 0;
            int c = a / b;
            Console.WriteLine(c);
        }

        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}