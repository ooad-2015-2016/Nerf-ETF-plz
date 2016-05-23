using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaKlase.Dostave
{
    public class Posiljka
    {
        public DateTime? krajnjiRok { get; set; }
        public Posiljalac posiljalac { get; set; }
        public Posiljka() { }
        public Posiljka(DateTime krajnjiRok, Posiljalac posiljalac)
        {
            this.krajnjiRok = krajnjiRok;
            this.posiljalac = posiljalac;
        }
    }
}
