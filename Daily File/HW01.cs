using System;
class HW01
{
    public static void display()
    {
        int total = 0;
        int quality = 0;
        int pirority = 0;
        int normal = 0;

        for (int packetId = 1001; packetId <= 1020; packetId++)
        {
            total++;
            if (packetId % 4 == 0)
            {
                quality++;

            }
            else if (packetId % 5 == 0)
            {
                pirority++;
            }
            else
            {
                normal++;
            }


        }
        Console.WriteLine("Total Number of Packets :- " + total);

        Console.WriteLine("Quality check Required - " + quality);

        Console.WriteLine("Priority Shipment - " + pirority);

        Console.WriteLine("Normal Processing - " + normal);
    }
}