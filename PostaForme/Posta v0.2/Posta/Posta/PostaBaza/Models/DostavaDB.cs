using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaBaza.Models
{
    public class DostavaDB
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime? datumIzdavanja { get; set; }

        [ForeignKey("dostavljacID")]
        public int dostavljacID { get; set; }
        public virtual PrimalacDB dostavljac { get; set; }

        [ForeignKey("poslovodjaID")]
        public int poslovodjaID { get; set; }
        public virtual PrimalacDB poslovodja { get; set; }

        [ForeignKey("voziloID")]
        public int voziloID { get; set; }
        public virtual VoziloDB vozilo { get; set; }

        public virtual ICollection<LetciDB> letci { get; set; }
        public virtual ICollection<PismoDB> pisma { get; set; }
        public virtual ICollection<PaketDB> paketi { get; set; }
        DostavaDB() { }
    }
}
