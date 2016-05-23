using Posta.PostaKlase.Osobe.Musterije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaKlase
{
    public class Posta
    {
        public List<Zaposlenik> zaposlenici { get; set; }
        public List<Izvjestaj> izvjestaji { get; set; }
        public List<PosiljalacFirma> firme { get; set; }
        public List<Dostava> aktivneDostave { get; set; }
        public List<Vozilo> vozila { get; set; }


        public Posta() { }

    }
}
