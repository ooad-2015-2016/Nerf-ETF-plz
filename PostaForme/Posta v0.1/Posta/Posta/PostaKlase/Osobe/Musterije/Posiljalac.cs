using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta
{
    class Posiljalac : Osoba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int posiljalacId { get; set; }
        public int? brojTelefona { get; set; }

        public Posiljalac() { }
        public Posiljalac(string ime, string prezime, DateTime datumRodjenja, int brojTelefona) : base(ime,prezime,datumRodjenja)
        {
            this.brojTelefona = brojTelefona;
        }
    }
}
