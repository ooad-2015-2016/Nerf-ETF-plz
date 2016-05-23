using Posta.PostaKlase.Osobe.Zaposlenici;
using Posta.PostaKlase.Zaposlenici;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta
{
    public class Postar : Dostavljac
    {
        public Postar() { }
        public Postar(string ime, string prezime, string username, string password, DateTime datumRodjenja, DateTime datumZaposljenja, string email, string brojTelefona, string adresa) : base(ime, prezime, username, password, datumRodjenja, datumZaposljenja, email, brojTelefona, adresa) { }


    }
}
