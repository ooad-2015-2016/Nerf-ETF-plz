using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaKlase.Osobe.Musterije
{
    public class PosiljalacFirma : Posiljalac
    {
        public string naziv { get; set; }
        public double popust { get; set; }

        public PosiljalacFirma() { }
        public PosiljalacFirma(string naziv, double popust, string brojTelefona) : base(brojTelefona)
        {
            this.naziv = naziv;
            this.popust = popust;
        }
    }
}
