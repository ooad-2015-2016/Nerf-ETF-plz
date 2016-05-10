using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta
{
    class Posiljka
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int posiljkaId { get; set; } // primary key u bazi //
        public Posiljalac posiljalac { get; set; }
        public Primalac primalac { get; set; }
        public VrstaPosiljke? vrsta { get; set; }
        public int? kolicina { get; set; }
        public bool? status { get; set; }

        public Posiljka() { }
        public Posiljka(Posiljalac posiljalac, Primalac primalac, VrstaPosiljke vrsta, int kolicina, bool status)
        {
            this.posiljalac = posiljalac;
            this.primalac = primalac;
            this.vrsta = vrsta;
            this.kolicina = kolicina;
            this.status = status;
        }
    }
}
