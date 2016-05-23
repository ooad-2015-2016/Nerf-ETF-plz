using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaKlase.Osobe.Musterije
{
    public class PrimalacOsoba : Primalac
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        

        public PrimalacOsoba() { }
        public PrimalacOsoba(string ime, string prezime, string brojTelefona, string adresa) : base(brojTelefona,adresa)
        {
            this.ime = ime;
            this.prezime = prezime;
        }
    }
}
