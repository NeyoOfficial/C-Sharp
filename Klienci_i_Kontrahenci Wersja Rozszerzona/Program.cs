using System;
using System.Collections.Generic;
using System.Linq;

namespace Klienci_i_Kontrahenci_Wersja_Rozszerzona
{
    class Program
    {
        static void Main(string[] args)
        {
            Kontrahent kontrahent1 = new Kontrahent { ID = 1, Imi� = "Ania", Nazwisko = "Kowalska", Zadania = new List<Zadanie>() };
            Kontrahent kontrahent2 = new Kontrahent { ID = 2, Imi� = "Maciek", Nazwisko = "Nowak", Zadania = new List<Zadanie>() };
            Kontrahent kontrahent3 = new Kontrahent { ID = 3, Imi� = "Julia", Nazwisko = "Wi�niewska", Zadania = new List<Zadanie>() };

            while (true)
            {
                Console.WriteLine("Wybierz opcj�:");
                Console.WriteLine("1. Dodaj zadanie");
                Console.WriteLine("2. Usu� zadanie");
                Console.WriteLine("3. Przegl�daj zadania");
                Console.Write("Wprowad� opcj�: ");
                int opcja = Convert.ToInt32(Console.ReadLine());

                switch (opcja)
                {
                    case 1:
                        DodajZadanie(kontrahent1);
                        DodajZadanie(kontrahent2);
                        DodajZadanie(kontrahent3);
                        break;
                    case 2:
                        UsunZadanie(kontrahent1);
                        UsunZadanie(kontrahent2);
                        UsunZadanie(kontrahent3);
                        break;
                    case 3:
                        PrzegladajZadania(kontrahent1);
                        PrzegladajZadania(kontrahent2);
                        PrzegladajZadania(kontrahent3);
                        break;
                    default:
                        Console.WriteLine("B��dna opcja");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void DodajZadanie(Kontrahent kontrahent)
        {
            Console.Write("Podaj imi�: ");
            string imie = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();

            if (kontrahent.Imi�.Equals(imie, StringComparison.OrdinalIgnoreCase) && kontrahent.Nazwisko.Equals(nazwisko, StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Podaj nazw� zadania: ");
                string nazwa = Console.ReadLine();
                Console.Write("Podaj opis: ");
                string opis = Console.ReadLine();

                Zadanie zadanie = new Zadanie { Nazwa = nazwa ?? string.Empty, Opis = opis ?? string.Empty };
                kontrahent.Zadania.Add(zadanie);
                Console.WriteLine("Zadanie dodane pomy�lnie.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono takiego kontrahenta.");
            }
        }

        static void UsunZadanie(Kontrahent kontrahent)
        {
            if (kontrahent == null || kontrahent.Zadania.Count == 0)
            {
                Console.WriteLine("Brak zada� do usuni�cia.");
                return;
            }

            Console.Write("Podaj imi�: ");
            string imie = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();

            if (kontrahent.Imi�.Equals(imie, StringComparison.OrdinalIgnoreCase) && kontrahent.Nazwisko.Equals(nazwisko, StringComparison.OrdinalIgnoreCase))
            {
                foreach (var zad in kontrahent.Zadania.ToList())
                {
                    Console.Write($"Czy chcesz usun�� zadanie '{zad.Nazwa}'? (t/n): ");
                    if (Console.ReadLine() == "t")
                    {
                        kontrahent.Zadania.Remove(zad);
                        Console.WriteLine("Zadanie usuni�te.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Nie znaleziono takiego kontrahenta.");
            }
        }

        static void PrzegladajZadania(Kontrahent kontrahent)
        {
            if (kontrahent.Zadania.Count == 0)
            {
                Console.WriteLine($"Brak zada� dla kontrahenta {kontrahent.Imi�} {kontrahent.Nazwisko}.");
                return;
            }

            foreach (var zad in kontrahent.Zadania)
            {
                Console.WriteLine($"Nazwa: {zad.Nazwa}, Opis: {zad.Opis}");
            }
        }
    }
}