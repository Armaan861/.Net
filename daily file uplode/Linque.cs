/*// LINQ - Language Integrated Query
// Used to query collections like arrays, List
// .Where(), .Select(), .OrderBy(), .OrderByDescending()
// .First(), .Count(), .Min(), .Max(), .Sum()

using System;
using System.Linq;

class Linqeg
{
    static void Main()
    {
        int[] numbers = { 8, 7, 6, 4, 1, 8, 7, 8, 3, 9 };
        var even = numbers.Where(x => x % 2 == 0);

        foreach (var n in even)
        {
            Console.WriteLine(n);
        }
        Exception.Main();
    }
}*/