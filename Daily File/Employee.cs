using System;
using System.Threading.Channels;

public class Employee
{
    public int Id;
    public string EmpName;
    public double MontlySalary;
    public Employee(int i, string e, double s)
    {
        Id = i;
        EmpName = e;
        MontlySalary = s;


    }

    double CalculateAnnualSalary()
    {
        return MontlySalary = 12;
    }


    public void Display()
    {
        Console.WriteLine("Id :" + Id);
        Console.WriteLine("Name :" + EmpName);
        Console.WriteLine("Mountly :" + MontlySalary);
        Console.WriteLine("Anuall :" + CalculateAnnualSalary());


    }
}