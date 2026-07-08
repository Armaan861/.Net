//Object - Physical entity ,used class properties and function
using System;

public class CLass_Object
{
    public static void display1()
    {
        Student student = new Student();

        student.rollno = 39;
        student.name = "Armaan";
        student.institute = "SSGMCE";
        student.branch = "CSE";
        student.gender = 'M';
        student.height = 5.6f;
        student.dob = 20050101;

        student.display();
    }
}