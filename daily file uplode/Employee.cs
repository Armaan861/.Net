// This is an example of an Encapuslation  FIle 1 Employee 2 OOPS
//  Encapsulation : -Encapsulation is the process of wrapping data and methods into a single class and protecting the data by making it private while providing controlled access through properties or methods.
using System;

class Employee
{
    private string _empName = "";
    private double _salary;

    public string EmpName
    {
        get { return _empName; }
        set { _empName = value; }
    }

    public double Salary
    {
        get { return _salary; }
        set
        {
            if (value >= 100)
            {
                _salary = value;
            }
        }
    }
}