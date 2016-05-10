using Posta.PostaKlase.Zaposlenici;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta
{
    class Poslovodja : Osoba, IZaposlenici
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PoslovodjaId { get; set; }
        public DateTime? datumZaposljenja { get; set; }
        public int? telefon { get; set; }
        public string email { get; set; }
        public string adresa { get; set; }

        public Poslovodja() { }
        public Poslovodja(string ime,string prezime,DateTime datumRodjenja,DateTime datumZaposljenja,int telefon,string email,string adresa) : base(ime,prezime,datumRodjenja)
        {
            this.datumZaposljenja = datumZaposljenja;
            this.email = email;
            this.telefon = telefon;
            this.adresa = adresa;
        }
        
    }
}
