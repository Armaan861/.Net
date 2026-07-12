// Fole handling means reading data from file or writing data to file
using System;
using System.IO;

public class FileHandling
{
    public static void Display3()
    {
        File.WriteAllText("emp.txt", "Name Armaan");


        string data = File.ReadAllText("emp.txt");
        Console.WriteLine(data);
    }
}