using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 5, 8, 2, 4, 3, 7, 6, 1, 9 };

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowanieBabelkowe(tablica);

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

    static void SortowanieBabelkowe(int[] tablica)
    {
        int n = tablica.Length;
        bool zmiana;

        for (int i = 0; i < n - 1; i++)
        {
            zmiana = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (tablica[j] > tablica[j + 1])
                {
                    int temp = tablica[j];
                    tablica[j] = tablica[j + 1];
                    tablica[j + 1] = temp;

                    zmiana = true;
                }
            }

            if (!zmiana)
            {
                break;
            }
        }
    }
}
