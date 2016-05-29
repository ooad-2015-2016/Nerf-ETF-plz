using Posta.PostaKlase.Dostave;
using Posta.PostaKlase.Osobe.Zaposlenici;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaKlase
{
    public class Izvjestaj
    {
        
        //public int izvjestajId { get; set; }
        public Dostavljac dostavljac { get; set; }
        public DateTime? datumIzdavanja { get; set; }
        public Poslovodja poslovodja { get; set; }
        public Vozilo vozilo { get; set; }
        public Dictionary<Posiljka,bool> status { get; set; }

        public Izvjestaj() { }
        public Izvjestaj(Dostavljac dostavljac, DateTime datumIzdavanja, Poslovodja poslovodja, Vozilo vozilo, Dictionary<Posiljka,bool> status)
        {
            this.dostavljac = dostavljac;
            this.datumIzdavanja = datumIzdavanja;
            this.poslovodja = poslovodja;
            this.vozilo = vozilo;
            this.status = status;
        }

    }
}
