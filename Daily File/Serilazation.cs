//Serilazation = convert an object into form (JSon) so it can be saved ans Shared

using System;
using System.Text.Json;


class Serilazation
{

    public static void Display4()
    {
        Employee e = new Employee(101, "abc", 4500);

        string json = JsonSerializer.Serialize(e);
    }
}