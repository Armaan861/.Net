using System.Collections.Generic;
using System.Numerics;


class HW04
{
    public static void display4()
    {
        List<string> Book = new List<string>();
        Book.Add("JAVA");
        Book.Add("Spring boot");
        Book.Add("Html");
        Book.Add("C#");
        Book.Add("Python");
        Book.Add("DBMS");
        Book.Add("OS");

        foreach (var item in Book)
        {
            Console.WriteLine("Total Book : " + item);

        }
        //ADDED BOOK
        Book.Add("DCN");
        foreach (var item1 in Book)
        {
            Console.WriteLine("\nAfter Adding Book : " + item1);
        }
        //Remove BOOK

        Book.Remove("Html");
        foreach (var item2 in Book)
        {
            Console.WriteLine("\nAfter Removing Book : " + item2);
        }
        //Total count of book
        Console.WriteLine("\nTotal no of Book : " + Book.Count);

    }
}