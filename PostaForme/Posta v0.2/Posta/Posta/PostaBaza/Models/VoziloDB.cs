using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaBaza.Models
{
    public class VoziloDB
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string model { get; set; }
        public string marka { get; set; }
        public string boja { get; set; }
        public DateTime? godinaProizvodnje { get; set; }
        public double volumen { get; set; }

        public virtual ICollection<DostavaDB> dostave { get; set; }
        

        public VoziloDB() { }
        public VoziloDB(string marka, string model, string boja, DateTime godinaProizvodnje, double volumen)
        {
            this.marka = marka;
            this.model = model;
            this.boja = boja;
            this.godinaProizvodnje = godinaProizvodnje;
            this.volumen = volumen;
        }
    }
}
