using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaBaza.Models
{
    public class UlicaDB
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string naziv { get; set; }


        public int rejonID { get; set; }
        public virtual RejonDB rejon { get; set; }

        public virtual ICollection<PaketDB> paketi { get; set; }
        public virtual ICollection<PismoDB> pisma { get; set; }
        public virtual ICollection<UlicaZaLetkeDB> ulicezaletke { get; set; }


        public UlicaDB() { }
        public UlicaDB(string naziv) { this.naziv = naziv;  }
    }
}
