using System;

public class Manager1 : Employee
{
    public int mid;
    public string? mname;
    public string? mdept;

    public Manager1(int mid, string mname, string mdept)
    {
        this.mid = mid;
        this.mname = mname;
        this.mdept = mdept;
    }

    public Manager1(int i, String s, String d, double b) : base(i, s, b)
    {
        mdept = d;
        //Bonus = s;

    }

    public void DisplayManager()
    {
        Display();
        Console.WriteLine("Dept :" + mdept);
        Console.WriteLine("Bonus:" + Bonus);
        Console.WriteLine("-----------------");
    }
}