using System;

class Program
{
    static void Main()
    {
        Console.Write("1. not: ");
        int not1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("2. not: ");
        int not2 = Convert.ToInt32(Console.ReadLine());

        double ort = (not1 + not2) / 2.0;
        Console.WriteLine("Ortalama: " + ort);
    }
}
