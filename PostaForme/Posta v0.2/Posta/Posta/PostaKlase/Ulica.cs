using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaKlase
{
    public class Ulica
    {
        
        //public int ulicaId { get; set; }
        public string naziv { get; set; }

        public Ulica() { }
        public Ulica(string naziv)
        {
            this.naziv = naziv;
        }
    }
}
