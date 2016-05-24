using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaKlase.Dostave.Posiljke
{
    public class Pismo : Posiljka
    {
//        public int PismoId { get; set; }
        public Primalac primalac { get; set; }
        public string adresa { get; set; }

        public Pismo() { }
        public Pismo(Primalac primalac, string adresa, DateTime krajnjiRok, Posiljalac posiljalac) : base(krajnjiRok,posiljalac)
        {
            this.primalac = primalac;
            this.adresa = adresa;

        }
    }
}
