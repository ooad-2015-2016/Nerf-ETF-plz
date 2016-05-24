using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaBaza.Models
{
    public class LoginDB
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public virtual ICollection<ZaposlenikDB> zaposlenici { get; set; }
    }
}
