using System;

class Queue
{
    private const int N = 10; 
    private int[] buffer = new int[N]; 
    private int writeIndex = 0;
    private int readIndex = 0; 

    public bool Put(int item)
    {
        if ((writeIndex + 1) % N == readIndex) 
        {
            return false;
        }

        buffer[writeIndex] = item;
        writeIndex = (writeIndex + 1) % N;
        return true;
    }

    public bool Get(out int value)
    {
        if (readIndex == writeIndex) 
        {
            value = 0;
            return false;
        }

        value = buffer[readIndex];
        readIndex = (readIndex + 1) % N;
        return true;
    }

    public bool Empty()
    {
        return readIndex == writeIndex;
    }

    public bool Full()
    {
        return (writeIndex + 1) % N == readIndex;
    }
}

class Program
{
    static void Main()
    {
        Queue queue = new Queue();
        int n = 2025;
        while (queue.Put(n++)) ;
        while (queue.Get(out n))
        {
            Console.WriteLine($"Live in {n}");
        }
    }
}
