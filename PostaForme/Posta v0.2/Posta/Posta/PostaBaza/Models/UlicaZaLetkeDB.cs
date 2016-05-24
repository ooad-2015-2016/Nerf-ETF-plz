using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaBaza.Models
{
    public class UlicaZaLetkeDB
    {

        [ForeignKey("ID")]
        public int ID { get; set; }
        public virtual UlicaDB ulica { get; set; }

        [ForeignKey("letakID")]
        public int letakID { get; set; }
        public virtual LetciDB letci { get; set; }

        public bool? status { get; set; }

        UlicaZaLetkeDB() { }
    }
}
