using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta
{
    class Dostava
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DostavaId { get; set; }
        public List<Posiljka> listaPosiljaka { get; set; }
        public List<bool> listaStatusa { get; set; }
        public Postar dostavljac { get; set; }
        public Poslovodja poslovodja { get; set; }
        public DateTime? datumIzdavanja { get; set; }

        public Dostava() { }
        public Dostava(List<Posiljka> listaPosiljaka, List<bool> listaStatusa, Postar dostavljac, Poslovodja poslovodja, DateTime datumIzdavanja)
        {
            this.listaPosiljaka = listaPosiljaka;
            this.listaStatusa = listaStatusa;
            this.dostavljac = dostavljac;
            this.poslovodja = poslovodja;
            this.datumIzdavanja = datumIzdavanja;
        }
    }
}
