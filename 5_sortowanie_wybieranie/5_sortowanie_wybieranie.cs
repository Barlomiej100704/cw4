using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 5, 8, 2, 4, 3, 7, 6, 1, 9 };

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortWybieranie(tablica);

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

    static void SortWybieranie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < n; j++)
            {
                if (tablica[j] < tablica[min])
                {
                    min = j;
                }
            }

            int temp = tablica[min];
            tablica[min] = tablica[i];
            tablica[i] = temp;
        }
    }
}
