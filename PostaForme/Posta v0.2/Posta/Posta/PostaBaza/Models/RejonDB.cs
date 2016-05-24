using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaBaza.Models
{
    public class RejonDB
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string naziv { get; set; }

        public virtual ICollection<UlicaDB> Ulice { get; set; }



        public RejonDB() { }
        public RejonDB(string naziv) { this.naziv = naziv; }
    }
}
