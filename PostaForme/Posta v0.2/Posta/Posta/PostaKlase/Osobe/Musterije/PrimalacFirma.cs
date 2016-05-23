using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaKlase.Osobe.Musterije
{
    public class PrimalacFirma : Primalac  
    {
        public string naziv { get; set; }

        public PrimalacFirma() { }
        public PrimalacFirma(string naziv, string brojTelefona, string adresa) : base(brojTelefona ,adresa)
        {
            this.naziv = naziv;
        }
    }
}
