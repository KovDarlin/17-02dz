using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static object Median<T>(IEnumerable<T> collection) where T : IComparable<T>
    {
        if (collection == null || !collection.Any())
        {
            throw new ArgumentException("Empty it's not good!");
        }

        var sorted = collection.OrderBy(x => x).ToList();
        Console.WriteLine("Sorted: " + string.Join(", ", sorted)); 

        int count = sorted.Count;
        if (count % 2 == 1)
        {
            return sorted[count / 2];
        }
        else
        {
            if (typeof(T) == typeof(string))
            {
                return sorted[count / 2 - 1];
            }
            else
            {
                dynamic left = sorted[count / 2 - 1];
                dynamic right = sorted[count / 2];
                double median = (left + right) / 2.0;
                return Math.Round(median, 1);
            }
        }
    }

    public static void Main()
    {
        var num = new List<int> { 5, 2, 9, 1, 6 };
        Console.WriteLine("Median: " + Median(num));

        var words = new List<string> { "apple", "banana", "cherry", "date", "fig" };
        Console.WriteLine("Median: " + Median(words));

        var Num = new List<int> { 4, 1, 7, 9, 3, 8 };
        Console.WriteLine("Median: " + Median(Num));

        var Words = new List<string> { "apple", "banana", "cherry", "date" };
        Console.WriteLine("Median: " + Median(Words));
    }
}