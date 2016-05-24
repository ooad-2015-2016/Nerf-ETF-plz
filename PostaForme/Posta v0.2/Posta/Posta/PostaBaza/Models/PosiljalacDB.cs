using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaBaza.Models
{
    public class PosiljalacDB
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string brojTelefona { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string naziv { get; set; }
        public double? popust { get; set; }

        public int tip { get; set; } // 1 je osoba 2 je firma



        public virtual ICollection<PaketDB> paketi { get; set; }
        public virtual ICollection<PismoDB> pisma { get; set; }


        public PosiljalacDB(string naziv, double popust, string brojTelefona)
        {
            this.brojTelefona = brojTelefona;
            this.naziv = naziv;
            this.popust = popust;
            this.ime = null;
            this.prezime = null;
        }



        public PosiljalacDB(string ime, string prezime, string brojTelefona)
        {
            this.brojTelefona = brojTelefona;
            this.ime = ime;
            this.prezime = prezime;
            this.naziv = null;
            this.popust = null;
        }
        
        public PosiljalacDB() { }
        
    }
}
