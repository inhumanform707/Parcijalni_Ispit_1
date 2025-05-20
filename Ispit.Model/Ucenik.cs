using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Ucenik
    {
        #region Properties
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public double Prosjek { get; set; }
        #endregion

        #region Constructors
        public Ucenik(string ime, string prezime, DateTime datumRodjenja, double prosjek)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Prosjek = prosjek;
        }
        #endregion

        #region Methods
        public void Starost()
        {
            DateTime danas = DateTime.Now;
            int starost = danas.Year - DatumRodjenja.Year;
            Console.WriteLine($"Starost: {starost} godina");
        }

        public void IspisProsjeka()
        {
            if (Prosjek >= 1 && Prosjek <= 1.49)
            {
                Console.WriteLine("nedovoljan");
            }
            else if (Prosjek >= 1.5 && Prosjek <= 2.49)
            {
                Console.WriteLine("dovoljan");
            }
            else if (Prosjek >= 2.5 && Prosjek <= 3.49)
            {
                Console.WriteLine("dobar");
            }
            else if (Prosjek >= 3.5 && Prosjek <= 4.49)
            {
                Console.WriteLine("vrlo dobar");
            }
            else if (Prosjek >= 4.5 && Prosjek <= 5)
            {
                Console.WriteLine("odlican");
            }
        }

        public void IspisDetaljaUcenika()
        {
            Console.WriteLine($"Ime: {Ime}, Prezime: {Prezime}, Datum rođenja: {DatumRodjenja.ToShortDateString()}, Prosjek: {Prosjek}");
        }
        #endregion
    }
}
