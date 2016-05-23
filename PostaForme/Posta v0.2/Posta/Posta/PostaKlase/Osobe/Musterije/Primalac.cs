using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta
{
    public class Primalac
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int primalacId { get; set; }
        public string brojTelefona { get; set; }
        public string adresa { get; set; }

        public Primalac() { }
        public Primalac(string brojTelefona, string adresa)
        {
            this.brojTelefona = brojTelefona;
            this.adresa = adresa;
        }
    }
}
