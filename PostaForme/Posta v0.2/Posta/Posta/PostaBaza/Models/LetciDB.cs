using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaBaza.Models
{
    public class LetciDB
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string naziv { get; set; }
        public int? kolicina { get; set; }
        public DateTime? krajnjiRok { get; set; }

        [ForeignKey("dostavaID")]
        public int dostavaID { get; set; }
        public virtual DostavaDB dostava { get; set; }

        [ForeignKey("blagajnikID")]
        public int blagajnikID { get; set; }
        public virtual PrimalacDB blagajnik { get; set; }

        public virtual ICollection<UlicaZaLetkeDB> uliceZaLetke { get; set; }
        public LetciDB() { }
    }
}
