using System.Collections.Generic;

public class Collection
{
    public static void display()
    {
        List<string> name = new List<String>();

        name.Add("Armaan");

        foreach (string f in name)
        {
            Console.WriteLine(f);
        }
    }
}
