using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaBaza.Models
{
    public class PrimalacDB
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string brojTelefona { get; set; }
        public string adresa { get; set; }

        public string naziv { get; set; }

        public string ime { get; set; }
        public string prezime { get; set; }




        public virtual ICollection<PaketDB> paketi { get; set; }
        public virtual ICollection<PismoDB> pisma { get; set; }


        public PrimalacDB() { }
        public PrimalacDB(string naziv, string brojTelefona, string adresa)
        {
            this.naziv = naziv;
            this.brojTelefona = brojTelefona;
            this.adresa = adresa;
        }

        public PrimalacDB(string ime, string prezime, string brojTelefona, string adresa)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.brojTelefona = brojTelefona;
            this.adresa = adresa;
        }
    }
}
