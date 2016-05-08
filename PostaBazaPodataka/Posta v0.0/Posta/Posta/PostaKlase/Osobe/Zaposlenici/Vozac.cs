using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta
{
    class Vozac : Postar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? VozacId { get; set; }
        public string brojVozacke { get; set; }
        public Vozac() { }
        public Vozac(string ime, string prezime, DateTime datumRodjenja, DateTime datumZaposljenja, int telefon, string email, string adresa,string brojVozacke) : base(ime,prezime,datumRodjenja,datumZaposljenja,telefon,email,adresa)
        {
            this.brojVozacke = brojVozacke;
        }
    }
}
