using System;
using System.Collections.Generic;
using System.Linq;

namespace Klienci_i_Kontrahenci_Wersja_Rozszerzona
{
    class Program
    {
        static void Main(string[] args)
        {
            Kontrahent kontrahent1 = new Kontrahent { ID = 1, Imiê = "Ania", Nazwisko = "Kowalska", Zadania = new List<Zadanie>() };
            Kontrahent kontrahent2 = new Kontrahent { ID = 2, Imiê = "Maciek", Nazwisko = "Nowak", Zadania = new List<Zadanie>() };
            Kontrahent kontrahent3 = new Kontrahent { ID = 3, Imiê = "Julia", Nazwisko = "Wiœniewska", Zadania = new List<Zadanie>() };

            while (true)
            {
                Console.WriteLine("Wybierz opcjê:");
                Console.WriteLine("1. Dodaj zadanie");
                Console.WriteLine("2. Usuñ zadanie");
                Console.WriteLine("3. Przegl¹daj zadania");
                Console.Write("WprowadŸ opcjê: ");
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
                        Console.WriteLine("B³êdna opcja");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void DodajZadanie(Kontrahent kontrahent)
        {
            Console.Write("Podaj imiê: ");
            string imie = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();

            if (kontrahent.Imiê.Equals(imie, StringComparison.OrdinalIgnoreCase) && kontrahent.Nazwisko.Equals(nazwisko, StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Podaj nazwê zadania: ");
                string nazwa = Console.ReadLine();
                Console.Write("Podaj opis: ");
                string opis = Console.ReadLine();

                Zadanie zadanie = new Zadanie { Nazwa = nazwa ?? string.Empty, Opis = opis ?? string.Empty };
                kontrahent.Zadania.Add(zadanie);
                Console.WriteLine("Zadanie dodane pomyœlnie.");
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
                Console.WriteLine("Brak zadañ do usuniêcia.");
                return;
            }

            Console.Write("Podaj imiê: ");
            string imie = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();

            if (kontrahent.Imiê.Equals(imie, StringComparison.OrdinalIgnoreCase) && kontrahent.Nazwisko.Equals(nazwisko, StringComparison.OrdinalIgnoreCase))
            {
                foreach (var zad in kontrahent.Zadania.ToList())
                {
                    Console.Write($"Czy chcesz usun¹æ zadanie '{zad.Nazwa}'? (t/n): ");
                    if (Console.ReadLine() == "t")
                    {
                        kontrahent.Zadania.Remove(zad);
                        Console.WriteLine("Zadanie usuniête.");
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
                Console.WriteLine($"Brak zadañ dla kontrahenta {kontrahent.Imiê} {kontrahent.Nazwisko}.");
                return;
            }

            foreach (var zad in kontrahent.Zadania)
            {
                Console.WriteLine($"Nazwa: {zad.Nazwa}, Opis: {zad.Opis}");
            }
        }
    }
}