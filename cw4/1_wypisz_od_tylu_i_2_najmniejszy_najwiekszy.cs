using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    //zadanie1
    {
        int wielkosc = 10;

        int[] tablica = new int[wielkosc];
        Random random = new Random();
        for (int i = 0; i < wielkosc; i++)
        {
            tablica[i] = random.Next(100);
        }

        Console.WriteLine("Zawartość tablicy:");
        WypiszTabele(tablica);

        Console.WriteLine("Zawartość tablicy od tyłu:");
        WypiszOdTylu(tablica);

        //zadanie2
        int min = ZnajdzMin(tablica);
        int max = ZnajdzMax(tablica);

        Console.WriteLine("Najmniejszy element: " + min);
        Console.WriteLine("Największy element: " + max);
        Console.ReadLine();
    }
    static void WypiszTabele(int[] tablica)
    {
        foreach (int element in tablica)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void WypiszOdTylu(int[] tablica)
    {
        for (int i = tablica.Length - 1; i >= 0; i--)
        {
            Console.Write(tablica[i] + " ");
        }
        Console.WriteLine();
    }
    static int ZnajdzMin(int[] tablica)
    {
        int min = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < min)
            {
                min = tablica[i];
            }
        }
        return min;
    }

    static int ZnajdzMax(int[] tablica)
    {
        int max = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] > max)
            {
                max = tablica[i];
            }
        }
        return max;
    }
}
