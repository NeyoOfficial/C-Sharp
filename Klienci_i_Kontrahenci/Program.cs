using System;
using System.Collections.Generic;

namespace Klienci_i_Kontrahenci
{
    class Program
    {
        class Zadanie
        {
            public int ID { get; set; } 
            public string Nazwa { get; set; }
            public string Opis { get; set; } 
            public bool Ukończone { get; set; } 
        }
        class Klienci
        {
            public int ID { get; set; } 
            public string Imię { set; get; }
            public string Nazwisko { set; get; }
            public List<Zadanie> Zadanie { get; set; } = new List<Zadanie>();
        }
        class Kontrahent
        {
            public int ID { get; set; }
            public string Imię { get; set; }
            public string Nazwisko { get; set; }
            public List<Zadanie> Zadanie { get; set; } = new List<Zadanie>();
        }
        static void Main(string[] args)
        {
            Klienci klient1 = new Klienci { Imię = "Marcin" };
            Klienci klient2 = new Klienci { Imię = "Kamil" };
            Klienci klient3 = new Klienci { Imię = "Mateusz" };

            Kontrahent kontrahent1 = new Kontrahent { Imię = "Ania" };
            Kontrahent kontrahent2 = new Kontrahent { Imię = "Maciek" };
            Kontrahent kontrahent3 = new Kontrahent { Imię = "Julia" };

            Zadanie zadanie1 = new Zadanie { Nazwa = "Zadanie_1", Opis = "Export do Belgii" };
            Zadanie zadanie2 = new Zadanie { Nazwa = "Zadanie_2", Opis = "Export do Czech" };
            Zadanie zadanie3 = new Zadanie { Nazwa = "Zadanie_3", Opis = "Import do Polski" };
            Zadanie zadanie4 = new Zadanie { Nazwa = "Zadanie_4", Opis = "Import do Polski" };

            klient1.Zadanie.Add(zadanie1);
            klient3.Zadanie.Add(zadanie2);
            kontrahent2.Zadanie.Add(zadanie3);
            kontrahent3.Zadanie.Add(zadanie4);

            Console.WriteLine("Zadanie dla Marcina:");
            foreach (var Zadanie in klient1.Zadanie)
            {
                Console.WriteLine($"Nazwa: {Zadanie.Nazwa}, Opis: {Zadanie.Opis}, Ukończone: {Zadanie.Ukończone = false}");
                   
            }
            Console.WriteLine("Zadanie dla Mateusza:");
            foreach (var Zadanie in klient3.Zadanie)
            {
                Console.WriteLine($"Nazwa: {Zadanie.Nazwa}, Opis: {Zadanie.Opis}, Ukończone: {Zadanie.Ukończone = false}");
            }

            Console.WriteLine("Zadanie dla Maćka:");
            foreach (var Zadanie in kontrahent2.Zadanie)
            {
                Console.WriteLine($"Nazwa: {Zadanie.Nazwa}, Opis: {Zadanie.Opis}, Ukończone: {Zadanie.Ukończone = true}");
            }

            Console.WriteLine("Zadanie dla Julii:");
            foreach (var Zadanie in kontrahent3.Zadanie)
            {
                Console.WriteLine($"Nazwa: {Zadanie.Nazwa}, Opis: {Zadanie.Opis}, Ukończone: {Zadanie.Ukończone = true}");
            }
            Console.ReadLine();
        }
    }
}