using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 5, 8, 2, 4, 3, 7, 6, 1, 9 };

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortWstawianie(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);

        Console.ReadLine();
    }

    static void WypiszTablice(int[] tablica)
    {
        foreach (int element in tablica)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void SortWstawianie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 1; i < n; i++)
        {
            int klucz = tablica[i];
            int j = i - 1;

            while (j >= 0 && tablica[j] > klucz)
            {
                tablica[j + 1] = tablica[j];
                j--;
            }

            tablica[j + 1] = klucz;
        }
    }
}
