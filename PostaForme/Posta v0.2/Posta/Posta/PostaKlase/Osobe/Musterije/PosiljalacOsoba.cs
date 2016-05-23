using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaKlase.Osobe.Musterije
{
    public class PosiljalacOsoba : Posiljalac
    {
        public string ime { get; set; }
        public string prezime { get; set; }


        public PosiljalacOsoba() { }
        public PosiljalacOsoba(string ime, string prezime, string brojTelefona) : base(brojTelefona)
        {
            this.ime = ime;
            this.prezime = prezime;
        }
    }
}
