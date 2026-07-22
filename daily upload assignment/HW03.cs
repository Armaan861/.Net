using System;

class HW03
{
    public static void display()
    {
        int[] sales = { 35000, 20000, 25000, 60000, 55000, 90000 };
        int Total = 0;
        int Average = 0;
        int higest = 35000;// Assume the first value is both highest and lowest initially.
        int lowest = 35000;


        foreach (var item in sales)//Usig this for array item read
        {
            Total += item;
            if (item > higest)
            {
                higest = item;
            }

            if (item < lowest)
            {
                lowest = item;
            }
        }

        Average = Total / sales.Length;
        Console.WriteLine("TOtal sales : " + Total);
        Console.WriteLine("Higest sales : " + higest);
        Console.WriteLine("Avrerage sales : " + lowest);
        Console.WriteLine("Lowest sales : " + Average);


    }
}