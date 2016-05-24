﻿using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Posta.PostaBaza.Models
{
    public class PostaDBContext : DbContext
    {
        DbSet<ZaposlenikDB> zaposlenici { get; set; }
        DbSet<VoziloDB> vozila { get; set; }
        DbSet<PosiljalacDB> posiljaoci { get; set; }
        DbSet<PrimalacDB> primaoci { get; set; }
        DbSet<LoginDB> login { get; set; }
        DbSet<UlicaDB> ulice { get; set; }
        DbSet<RejonDB> rejoni { get; set; }
        DbSet<PaketDB> paketi { get; set; }
        DbSet<PismoDB> pisma { get; set; }
        DbSet<LetciDB> letci { get; set; }
        DbSet<UlicaZaLetkeDB> uliceZaLetke { get; set; }
        DbSet<DostavaDB> dostave { get; set; }

        /// ovdje fali jos izvjestaji ali bilo je prekrizeno na papiru


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "PostaBazaPodataka.db";
            try
            {
                //za tačnu putanju gdje se nalazi baza uraditi ovdje debug i procitati Path
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, databaseFilePath);
            }
            catch (InvalidOperationException) { }
            //Sqlite baza
            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }
        // C:\Users\bsehic1\AppData\Local\Packages\bab5b67d-2365-4547-a322-c2e89a36477e_73k0k8tnbg8ty\LocalState\


    }
}
