using System;

namespace RepositarGitHubProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = false;
            bool y = false;
            while (!x || !y)
            {
                Console.Clear();
                Console.Write("Zadej první číslo: ");
                x = int.TryParse(Console.ReadLine(), out int prvniCislo);
                Console.Write("Zadej druhé číslo: ");
                y = int.TryParse(Console.ReadLine(), out int druheCislo);
                Console.WriteLine((prvniCislo == druheCislo) ? "Obě čísla jsou stejně velká" : $"Větší číslo: {Math.Max(prvniCislo, druheCislo)}, Menší číslo: {Math.Min(prvniCislo, druheCislo)}");

            }




        }
    }
}
