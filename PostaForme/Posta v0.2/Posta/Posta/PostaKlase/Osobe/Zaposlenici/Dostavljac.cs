using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaKlase.Osobe.Zaposlenici
{
    public class Dostavljac : Zaposlenik
    {
        
        public Dostavljac() { }
        public Dostavljac(string ime, string prezime, string username, string password, DateTime datumRodjenja, DateTime datumZaposljenja, string email, string brojTelefona, string adresa) : base(ime, prezime, username, password, datumRodjenja, datumZaposljenja, email, brojTelefona, adresa) { }

    }
}
