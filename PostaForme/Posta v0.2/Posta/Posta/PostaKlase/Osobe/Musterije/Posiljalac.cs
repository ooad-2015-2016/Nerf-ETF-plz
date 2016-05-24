using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta
{
    public class Posiljalac
    {
       
        //public int posiljalacId { get; set; }
        public string brojTelefona { get; set; }

        public Posiljalac() { }
        public Posiljalac(string brojTelefona)
        {
            this.brojTelefona = brojTelefona;
        }
    }
}
