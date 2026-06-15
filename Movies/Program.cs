using System;

namespace Movies
{
    internal class Film
    {
        public string Titel { get; }
        public string Genre { get; }
        public int DuurInMinuten { get; }
        public int Leeftijdsgrens { get; }

        public Film(string titel, string genre, int duurInMinuten, int leeftijdsgrens)
        {
            Titel = titel;
            Genre = genre;
            DuurInMinuten = duurInMinuten;
            Leeftijdsgrens = leeftijdsgrens;
        }

        public void ToonInfo()
        {
            Console.WriteLine($"Titel: {Titel}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Duur: {DuurInMinuten} minuten");
            Console.WriteLine($"Leeftijdsgrens: {Leeftijdsgrens} jaar");
        }
    }

    internal static class Program
    {
        private static void Main()
        {
            Film film = new Film("De Avontuur", "Actie", 120, 12);
            film.ToonInfo();
        }
    }
}
