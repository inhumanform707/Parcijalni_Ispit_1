using Ispit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobrodosli u aplikaciju za unos ucenika!");
            Console.WriteLine("Pritisnite bilo koju tipku za nastavak...");
            Console.ReadKey();
            Console.Clear();

            List<Ucenik> ucenici = new List<Ucenik>();

            for (byte i = 0; i < 3; i++)
            {
                Console.WriteLine($"Unesite podatke za {i + 1}. ucenika:");
                Console.Write("Ime: ");
                string ime = Console.ReadLine();
                Console.Write("Prezime: ");
                string prezime = Console.ReadLine();
                Console.Write("Datum rodjenja (dd.MM.yyyy): ");
                DateTime datumRodjenja = DateTime.Parse(Console.ReadLine());
                Console.Write("Prosjek: ");
                double prosjek = double.Parse(Console.ReadLine());
                Ucenik ucenik = new Ucenik(ime, prezime, datumRodjenja, prosjek);
                ucenici.Add(ucenik);

            }

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            foreach (Ucenik ucenik in ucenici)
            {
                Console.WriteLine("\nPodaci o uceniku:");
                ucenik.IspisDetaljaUcenika();
                ucenik.Starost();
                Console.Write("Prosjek: ");
                ucenik.IspisProsjeka();
                Console.WriteLine();
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Aplikacija je zavrsila sa radom. Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }
    }
}
