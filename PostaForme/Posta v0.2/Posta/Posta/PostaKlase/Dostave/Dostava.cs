using Posta.PostaKlase;
using Posta.PostaKlase.Dostave;
using Posta.PostaKlase.Osobe.Zaposlenici;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta
{
    public class Dostava
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DostavaId { get; set; }
        public List<Posiljka> posiljke { get; set; }
        public Dostavljac dostavljac { get; set; }
        public Poslovodja poslovodja { get; set; }
        public Vozilo vozilo {get;set;}
        public DateTime? datumIzdavanja { get; set; }

        public Dostava() { }
        public Dostava(List<Posiljka> posiljke, Dostavljac dostavljac, Poslovodja poslovodja, DateTime datumIzdavanja, Vozilo vozilo)
        {
            this.posiljke = posiljke;
            this.dostavljac = dostavljac;
            this.poslovodja = poslovodja;
            this.datumIzdavanja = datumIzdavanja;
            this.vozilo = vozilo;
        }
    }
}
