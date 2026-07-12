// Async :=  need for operation which take something
//without async := the application waits until the work finish

using System;

using System.Threading.Tasks;

public class AsyncAwaitt
{
    public static async Task Display2()
    {
        Console.WriteLine("loading");

        await LoadEmployee();
        Console.WriteLine("Compleated");
    }

    static async Task LoadEmployee()
    {
        await Task.Delay(3000);

        Console.WriteLine("Employee loaded");
    }
}