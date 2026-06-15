using System;

namespace Movies
{
    internal class Film
    {
        public string Titel { get; }
        public string Genre { get; }
        public int DuurInMinuten { get; }

        public Film(string titel, string genre, int duurInMinuten)
        {
            Titel = titel;
            Genre = genre;
            DuurInMinuten = duurInMinuten;
        }

        public void ToonInfo()
        {
            Console.WriteLine($"De titel van de film is {Titel}.");
            Console.WriteLine($"Het genre van de film is {Genre}.");
            Console.WriteLine($"De film duurt {DuurInMinuten} minuten.");
        }
    }

    internal static class Program
    {
        private static void Main()
        {
            Film film = new Film("De Avontuur", "Actie", 120);
            film.ToonInfo();
        }
    }
}
