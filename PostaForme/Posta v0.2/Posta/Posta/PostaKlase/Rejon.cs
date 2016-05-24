using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaKlase
{
    public class Rejon
    {
       
       // public int rejonId { get; set; }
        public string naziv { get; set; }

        public Rejon() { }
        public Rejon(string naziv)
        {
            this.naziv = naziv;
        }
    }
}
