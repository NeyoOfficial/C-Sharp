namespace Klienci_i_Kontrahenci_Wersja_Rozszerzona
{
    public class Kontrahent
    {
        public int ID { get; set; }
        public string Imię { get; set; } = string.Empty;
        public string Nazwisko { get; set; } = string.Empty;
        public List<Zadanie> Zadania { get; set; } = new List<Zadanie>();
    }
}