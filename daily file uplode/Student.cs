//Class - Logical entity ,it defined proprrties(data) and function that object will have
//
//{} - similar code  
//[] - SIze of variable

using System;

public class Student
{
    public int rollno;
    public string name = "";
    public string institute = "";
    public string branch = "";
    public char gender;
    public float height;
    public long dob;

    public void display()
    {
        Console.WriteLine("Roll No   : " + rollno);
        Console.WriteLine("Name      : " + name);
        Console.WriteLine("Institute : " + institute);
        Console.WriteLine("Branch    : " + branch);
        Console.WriteLine("Gender    : " + gender);
        Console.WriteLine("Height    : " + height);
        Console.WriteLine("DOB       : " + dob);
    }
}