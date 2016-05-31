using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaBaza.Models
{
    public class ZaposlenikDB
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime? datumRodjenja { get; set; }
        public DateTime? datumZaposljenja { get; set; }
        public string email { get; set; }
        public string brojTelefona { get; set; }
        public string adresa { get; set; }


        public int? tip { get; set; } // tip zaposlenika 1 je poslovodja, 2 blagajnik, 3 postar, 4 vozac
        public string brojVozacke { get; set; }// ovo je null za sve sem vozaca

        [ForeignKey("LoginID")]
        public int LoginID { get; set; }
        public virtual LoginDB login { get; set; }

        public virtual ICollection<PaketDB> paketi { get; set; }
        
        public virtual ICollection<PismoDB> pisma { get; set; }
        
        public virtual ICollection<LetciDB> letci { get; set; }
        public virtual ICollection<DostavaDB> dostave { get; set; }




        public ZaposlenikDB() { }
        public ZaposlenikDB(string ime, string prezime, string username, string password, DateTime datumRodjenja, DateTime datumZaposljenja, string email, string brojTelefona, string adresa)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.username = username;
            this.password = password;
            this.datumRodjenja = datumRodjenja;
            this.datumZaposljenja = datumZaposljenja;
            this.email = email;
            this.brojTelefona = brojTelefona;
            this.adresa = adresa;

        }

        public override string ToString()
        {
            return ime + " " + prezime;
        }
    }
}
