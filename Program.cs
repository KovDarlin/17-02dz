using System;
using System.Collections.Generic;

public class Queue<T>
{
    private List<(T item, int priority)> list;
    public Queue()
    {
        list = new List<(T, int)>();
    }
    public void Insert(T item, int priority)
    {
        var node = (item, priority);
        int index = 0;
        while(index<list.Count && list[index].priority < priority)
        {
            index++;
        }
        list.Insert(index, node);
    }
    public T Pull()
    {
        if (list.Count == 0)
            throw new Exception("Empty!");
        var highest = list[0];
        list.RemoveAt(0);
        return highest.item;
    }
    public bool Empty()
    {
        return list.Count == 0;
    }

}

class Program
{
    static void Main()
    {
        Queue<string> push = new Queue<string>();
        push.Insert("Watch film", 3);
        push.Insert("Make homework", 1);
        push.Insert("Dance", 4);
        push.Insert("Go to bed", 2);
        
        Console.WriteLine($"1: {push.Pull()}");
        Console.WriteLine($"2: {push.Pull()}");
        Console.WriteLine($"3: {push.Pull()}");
        Console.WriteLine($"4: {push.Pull()}");
    }
}
