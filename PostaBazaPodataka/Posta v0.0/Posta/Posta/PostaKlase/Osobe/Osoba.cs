using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta
{
    class Osoba
    {
        /// <summary>
        /// Upozorenje:
        /// Ovaj OsobaId je poprilicno beskorisan i bit ce izbrisan cim skontam kako se primary key sa druge tabele stavlja u tebelu zaposlenici
        /// Takodjer ovo databasegenerated ne treba
        /// </summary>

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OsobaId { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime? datumRodjenja { get; set; }

        protected Osoba() { }
        protected Osoba(string ime, string prezime, DateTime datumRodjenja)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
        }
    }
}
