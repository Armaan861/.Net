
using System;
string empname = "ARMAAN";
Console.WriteLine(empname.ProperCase());


string empname1 = "GUpta";
Console.WriteLine(empname1.ProperCase());



AsyncAwaitt.Display2();
FileHandling.Display3();
Serilazation.Display4();
/*using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        while (true)
        {
            Console.WriteLine("Welcome to Employee System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2 .View EMployee");
            Console.WriteLine("3. Search for employee by id");
            Console.WriteLine("4. View");


            Console.WriteLine("Enter choice from 1 - 4");


            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                    Console.Write("Enter id :");
                    int id = Convert.ToInt32(Console.ReadLine());
                    bool exiets = false;
                    foreach(Employee emp in employees)
                }
            }

            catch
        }
    }
}using System;
using System.Collections.Generic;
using System.ComponentModel;


class Program
{
    static void Main(string[] args)
    {
        List<Employee> employee = new List<Employee>();
        List<Manager1> manager1s = new List<Manager1>();
        while (true)
        {
            Console.WriteLine("Welcome to Employee System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Add Manager");

            Console.WriteLine("3. View Employee");
            Console.WriteLine("4. View Manager");

            Console.WriteLine("5. Search Employee");
            Console.WriteLine("6. Exit");

            Console.Write("Enter a choice");


            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter id =");
                        int id = Convert.ToInt32(Console.ReadLine());
                        bool exists = false;
                        foreach (Employee emp in employee)
                        {
                            if (emp.Id == id)
                            {
                                exists = true;
                                break;
                            }
                        }
                        if (exists)
                        {
                            Console.WriteLine("Employee already Exist");
                            break;
                        }
                        Console.WriteLine("Enter name =");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter salary =");
                        double salary = Convert.ToInt32(Console.ReadLine());
                        Employee employees = new Employee(id, name, salary);

                        //add collection
                        employee.Add(employees);
                        Console.WriteLine("Employee added successfully");
                        break;
                    case 2:
                        Console.WriteLine("ENter Manager ID");
                        int mid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ENter Name :");
                        string mname = Console.ReadLine();
                        Console.WriteLine("Enter Department :");
                        string mdept = Console.ReadLine();
                        Manager1 manager1 = new Manager1(mid, mname, mdept);
                        break;
                    case 3:
                        if (employee.Count == 0)
                        {
                            Console.WriteLine("No employees in the system");
                        }
                        else
                        {
                            foreach (Employee emp in employee)
                            {
                                emp.Display();
                            }
                        }
                        break;
                    /*
                     case 4:
                        if (Manager1.Count == 0)
                        {
                            Console.WriteLine("No Manager in the system");
                        }
                        else
                        {
                            foreach (Manager1 emp in Manager1)
                            {
                                emp.Display();
                            }
                        }
                        break;
                    //

                    case 5:
                        Console.WriteLine("Enter Empoyee id =");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        bool found = false;
                        foreach (Employee emp in employee)
                        {
                            if (emp.Id == searchId)
                            {
                                emp.Display();
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Employee not found");
                            break;
                        }
                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please a number only");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}*/