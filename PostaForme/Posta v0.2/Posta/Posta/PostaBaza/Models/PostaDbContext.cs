using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Posta.PostaBaza.Models
{
    class PostaDbContext : DbContext
    {

        public DbSet<Blagajnik> blagajnici { get; set; }
        public DbSet<Poslovodja> poslovodje { get; set; }
        public DbSet<Postar> postari { get; set; }
        public DbSet<Vozac> vozaci { get; set; }
        public DbSet<Osoba> zaposlenici { get; set; } // !!! trenutno koristi basegenerated primary key OsobaId, sto je lose, promjene ce biti updateovane cim naucim kako koristiti foreign keyeve
        public DbSet<Posiljalac> posiljaoci { get; set; }
        public DbSet<Primalac> primaoci { get; set; }
        public DbSet<Dostava> dostave { get; set; }
        public DbSet<Posiljka> posiljke { get; set; }







        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "PostaBaza.db";
            try
            {
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, databaseFilePath);
            }
            catch (InvalidOperationException) { }
            //C:\Users\bsehic1\AppData\Local\Packages\bab5b67d-2365-4547-a322-c2e89a36477e_73k0k8tnbg8ty\LocalState\
            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }

        

        

    }
}
