using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Posta.PostaBaza.Models;

namespace Posta.PostaBaza
{
    class DataSource
    {
        #region Korisnici

        private static List<LoginDB> _login = new List<LoginDB>()
        {
            new LoginDB()
            {
                ID = 0,
                username = "admin",
                password = "admin"
            },
            new LoginDB()
            {
                ID = 1,
                username = "poslovodja",
                password = "poslovodja"
            },
            new LoginDB()
            {
                ID = 2,
                username = "blagajnik",
                password = "blagajnik"
            },
            new LoginDB()
            {
                ID = 3,
                username = "postar",
                password = "postar"
            },
            new LoginDB()
            {
                ID = 4,
                username = "vozac",
                password = "vozac"
            }
        };

        public static List<ZaposlenikDB> _zaposlenici = new List<ZaposlenikDB>()
        {
            new ZaposlenikDB()
            {
                ime = "admin",
                prezime = "admin",
                username = "admin",
                password = "admin",
                tip = 0
            },
            new ZaposlenikDB()
            {
                ime = "poslovodja",
                prezime = "poslovodja",
                username = "poslovodja",
                password = "poslovodja",
                tip = 1
            },
            new ZaposlenikDB()
            {
                ime = "blagajnik",
                prezime = "blagajnik",
                username = "blagajnik",
                password = "blagajnik",
                tip = 2
            },
            new ZaposlenikDB()
            {
                ime = "postar",
                prezime = "postar",
                username = "postar",
                password = "postar",
                tip = 3
            },
            new ZaposlenikDB()
            {
                ime = "vozac",
                prezime = "vozac",
                username = "vozac",
                password = "vozac",
                tip = 4
            }
        };
            
           

        public static bool ProvjeraLogina(string username, string password)
        {
            foreach(var o in _login)
            {
                if (o.username == username && o.password == password) return true;
            }
            return false;
        }

        public static ZaposlenikDB Login(string username, string password)
        {
            foreach(var o in _zaposlenici)
            {
                if (o.username == username && o.password == password) return o;
            }
            return new ZaposlenikDB();
        }

        public DataSource()
        {
            ZaposlenikDB admin = _zaposlenici.Where(x => x.username == "admin").FirstOrDefault();
            ZaposlenikDB poslovodja = _zaposlenici.Where(x => x.username == "poslovodja").FirstOrDefault();
            ZaposlenikDB blagajnik = _zaposlenici.Where(x => x.username == "blagajnik").FirstOrDefault();
            ZaposlenikDB postar = _zaposlenici.Where(x => x.username == "postar").FirstOrDefault();
            ZaposlenikDB vozac = _zaposlenici.Where(x => x.username == "vozac").FirstOrDefault();

            using (var context = new PostaDBContext())
            {
                foreach (var o in _zaposlenici)
                    context.zaposlenici.Add(o);
                //context.SaveChanges();
            }
        }

        #endregion
    }
}
