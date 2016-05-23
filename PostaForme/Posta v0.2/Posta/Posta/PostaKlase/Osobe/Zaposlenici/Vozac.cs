using Posta.PostaKlase.Osobe.Zaposlenici;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta
{
    public class Vozac : Dostavljac
    {
        public string brojVozacke { get; set; }
        public Vozac() { }
        public Vozac(string ime, string prezime, string username, string password, DateTime datumRodjenja, DateTime datumZaposljenja, string email, string brojTelefona, string adresa, string brojVozacke) : base(ime, prezime, username, password, datumRodjenja, datumZaposljenja, email, brojTelefona, adresa)
        {
            this.brojVozacke = brojVozacke;
        }

    }
}
