using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta
{
    class Primalac : Osoba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int primalacId { get; set; }
        public int? telefon { get; set; }
        public string adresa { get; set; }

        public Primalac() { }
        public Primalac(string ime, string prezime, DateTime datumRodjenja,int telefon, string adresa) : base(ime,prezime,datumRodjenja)
        {
            this.telefon = telefon;
            this.adresa = adresa;
        }
    }
}
