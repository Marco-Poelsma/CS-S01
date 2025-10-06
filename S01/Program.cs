using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Thread nouThread = new Thread(EscriureA);
        nouThread.Start();

        Thread T1 = new Thread(EscriureB);
        Thread T2 = new Thread(EscriureC);
        T1.Start();
        T2.Start();

        Console.WriteLine("Tasca 2");
    }

    public static void EscriureA()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("A");
            Thread.Sleep(10);
        }
    }

    public static void EscriureB()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("B");
            Thread.Sleep(5);
        }
    }

    public static void EscriureC()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("C");
            Thread.Sleep(20);
        }
    }
}