using Posta.PostaKlase.Zaposlenici;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta
{
    class Blagajnik : Osoba, IZaposlenici
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlagajnikId { get; set; }
        public DateTime? datumZaposljenja { get; set; }
        public int? telefon { get; set; }
        public string email { get; set; }
        public string adresa { get; set; }

        public Blagajnik() { }
        public Blagajnik(string ime, string prezime, DateTime datumRodjenja, DateTime datumZaposljenja, int telefon, string email, string adresa) : base(ime,prezime,datumRodjenja)
        {
            this.datumZaposljenja = datumZaposljenja;
            this.email = email;
            this.telefon = telefon;
            this.adresa = adresa;
        }

    }
}
