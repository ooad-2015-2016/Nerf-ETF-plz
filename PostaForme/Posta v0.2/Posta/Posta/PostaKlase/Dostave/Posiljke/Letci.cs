using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaKlase.Dostave.Posiljke
{
    public class Letci : Posiljka
    {
       // public int LetciId { get; set; } ovo mozda i ne treba
        public int? kolicina { get; set; }
        public List<string> ulice { get; set; }

        public Letci() { }
        public Letci(int kolicina,List<string> ulice, DateTime krajnjiRok, Posiljalac posiljalac) : base(krajnjiRok,posiljalac)
        {
            this.kolicina = kolicina;
            this.ulice = ulice;
        }
    }
}
