using System;
using System.Threading;

public class RutinaMatutina
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Inici de la rutina matutina");
        Thread aixecarThread = new Thread(Aixecarme);
        Thread dutxarThread = new Thread(Dutxarme);
        Thread musicaThread = new Thread(EscoltarMusica);
        Thread vestirThread = new Thread(Vestirme);
        Thread esmorzarThread = new Thread(Esmorzar);

        aixecarThread.Start();
        aixecarThread.Join(); // Espera que el thread aixecarThread acabi abans de continuar
        dutxarThread.Start();
        musicaThread.Start();
        dutxarThread.Join(); // Espera que el thread dutxarThread acabi abans de continuar
        vestirThread.Start();
        vestirThread.Join(); // Espera que el thread vestirThread acabi abans de continuar
        musicaThread.Join(); // Espera que el thread musicaThread acabi abans de continuar
        esmorzarThread.Start();
        esmorzarThread.Join(); // Espera que el thread esmorzarThread acabi abans de continuar

        Console.WriteLine("Final de la rutina matutina");
    }

    public static void Aixecarme()
    {
        Console.WriteLine("M'aixeco...");
        Thread.Sleep(2000);
        Console.WriteLine("M'he aixecat.");
    }

    public static void Dutxarme()
    {
        Console.WriteLine("Em dutxo...");
        Thread.Sleep(3000);
        Console.WriteLine("He acabat la dutxa.");
    }

    public static void EscoltarMusica()
    {
        Console.WriteLine("Escolto música mentre em dutxo i em vesteixo...");
        
    }

    public static void Vestirme()
    {
        Console.WriteLine("Em vesteixo...");
        Thread.Sleep(1000);
        Console.WriteLine("Ja estic vestit.");
    }

    public static void Esmorzar()
    {
        Console.WriteLine("Esmorzo...");
        Thread.Sleep(1500);
        Console.WriteLine("He acabat d'esmorzar.");
    }
}