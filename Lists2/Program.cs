using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> kahveler = new List<string>();

        Console.WriteLine("Lütfen 5 kahve ismi girin:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Kahve " + (i + 1) + ": ");
            string kahveIsmi = Console.ReadLine();
            kahveler.Add(kahveIsmi);
        }

        Console.WriteLine("\nGirdiğiniz kahveler:");
        foreach (string kahve in kahveler)
        {
            Console.WriteLine("- " + kahve);
        }
    }
}
