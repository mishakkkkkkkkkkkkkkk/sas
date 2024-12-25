using System;

public class Program
{
    public static void Main(string[] args)
    {
        string ee = "поздровляю ты написал:";
        while (true)
        {
            Console.WriteLine("привит");
            string gg = Console.ReadLine();
            Console.WriteLine(ee + gg);
        }
    }
}