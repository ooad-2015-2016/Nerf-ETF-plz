using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaKlase.Dostave.Posiljke
{
    public class Paket : Posiljka
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PosiljkaId { get; set; }
        public Primalac primalac { get; set; }
        public double? masa { get; set; }
        public double? volumen { get; set; }
        public string adresa { get; set; }


        public Paket() { }
        public Paket(Primalac primalac, double masa, double volumen, string adresa, DateTime krajnjiRok, Posiljalac posiljalac) : base(krajnjiRok, posiljalac)
        {
            this.primalac = primalac;
            this.masa = masa;
            this.volumen = volumen;
            this.adresa = adresa;
        }
    }
}
