using System;

public class MainProgram<T>
{
    private class Listed
    {
        public T Data;
        public Listed Next;
        public Listed(T data) => Data = data;
    }

    private Listed boss;
    private int count;

    public int Count => count;

    public void AddLast(T data)
    {
        var newListed = new Listed(data);
        if (boss == null)
            boss = newListed;
        else
        {
            var now = boss;
            while (now.Next != null)
                now = now.Next;
            now.Next = newListed;
        }
        count++;
    }

    public void AddFirst(T data)
    {
        var newListed = new Listed(data) { Next = boss };
        boss = newListed;
        count++;
    }

    public bool DelFirst()
    {
        if (boss == null) return false;
        boss = boss.Next;
        count--;
        return true;
    }

    public bool DelLast()
    {
        if (boss == null) return false;
        if (boss.Next == null)
        {
            boss = null;
        }
        else
        {
            var now = boss;
            while (now.Next?.Next != null)
                now = now.Next;
            now.Next = null;
        }
        count--;
        return true;
    }

    public void Print()
    {
        var current = boss;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        var list = new MainProgram<int>();
        list.AddLast(100);
        list.AddFirst(99);
        list.AddLast(45);
        list.AddLast(20);
        list.AddLast(13);
        list.Print(); 

        list.DelFirst();
        list.Print(); 
        
        list.DelLast();
        list.Print(); 
    }
}