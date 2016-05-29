using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaBaza.Models
{
    public class PismoDB
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public DateTime? krajnjiRok { get; set; }


        [ForeignKey("posiljalacID")]
        public int PosiljalacID { get; set; }
        public virtual PosiljalacDB posiljalac { get; set; }

        [ForeignKey("primalacID")]
        public int primalacID { get; set; }
        public virtual PrimalacDB primalac { get; set; }

        [ForeignKey("ulicaID")]
        public int ulicaID { get; set; }
        public virtual UlicaDB ulica { get; set; }
        public int? broj { get; set; }

        [ForeignKey("dostavaID")]
        public int dostavaID { get; set; }
        public virtual DostavaDB dostava { get; set; }

        [ForeignKey("blagajnikID")]
        public int blagajnikID { get; set; }
        public virtual PrimalacDB blagajnik { get; set; }

        public bool? status { get; set; }

        public PismoDB() { }

    }
}
