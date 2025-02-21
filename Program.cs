using System;

class Program
{
    public static void Swap<T>(ref T y, ref T x)
    {
        T temp = y;
        y = x;
        x = temp;
    }

    static void Main()
    {
        int y1 = 13;
        int x1 = 100;
        string y2 = "daryna";
        string x2 = "kovalenko";

        Console.WriteLine($"y1 = {y1}, x1 = {x1}");
        Swap(ref y1, ref x1);
        Console.WriteLine($"y1 = {y1}, x1 = {x1}\n");

        Console.WriteLine($"y2 = {y2}, x2 = {x2}");
        Swap(ref y2, ref x2);
        Console.WriteLine($"y2 = {y2}, x2 = {x2}");
    }
}