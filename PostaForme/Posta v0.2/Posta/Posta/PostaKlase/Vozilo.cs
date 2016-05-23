using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaKlase
{
    public class Vozilo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int voziloId { get; set; }
        public string model { get; set; }
        public string marka { get; set; }
        public string boja { get; set; }
        public DateTime godinaProizvodnje { get; set; }
        public double volumen { get; set; }

        public Vozilo() { }
        public Vozilo(string marka, string model, string boja, DateTime godinaProizvodnje, double volumen)
        {
            this.marka = marka;
            this.model = model;
            this.boja = boja;
            this.godinaProizvodnje = godinaProizvodnje;
            this.volumen = volumen;
        }
    }
}
