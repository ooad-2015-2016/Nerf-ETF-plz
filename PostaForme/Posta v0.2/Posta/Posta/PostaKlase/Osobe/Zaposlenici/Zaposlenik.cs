using Posta.PostaKlase.Zaposlenici;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta
{
    public class Zaposlenik : IZaposlenici
    {

       // public int ZaposlenikId { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime? datumRodjenja { get; set; }
        public DateTime? datumZaposljenja { get; set; }
        public string email { get; set; }
        public string brojTelefona { get; set; }
        public string adresa { get; set; }





        protected Zaposlenik () { }
        protected Zaposlenik (string ime, string prezime, string username, string password,  DateTime datumRodjenja, DateTime datumZaposljenja, string email, string brojTelefona, string adresa)
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
    }
}
