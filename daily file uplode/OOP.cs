using System;

class OOP
{
    static void Main()
    {
        Employee e = new Employee();

        e.EmpName = "Armaan";
        e.Salary = 1000;

        Console.WriteLine(e.EmpName + " " + e.Salary);
    }
}