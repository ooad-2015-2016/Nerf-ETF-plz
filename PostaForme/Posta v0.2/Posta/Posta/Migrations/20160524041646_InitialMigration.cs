using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace PostaMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Login",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    password = table.Column(type: "TEXT", nullable: true),
                    username = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.ID);
                });
            migration.CreateTable(
                name: "Posiljaoaci",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    brojTelefona = table.Column(type: "TEXT", nullable: true),
                    ime = table.Column(type: "TEXT", nullable: true),
                    naziv = table.Column(type: "TEXT", nullable: true),
                    popust = table.Column(type: "REAL", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true),
                    tip = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posiljalac", x => x.ID);
                });
            migration.CreateTable(
                name: "Rejoni",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    naziv = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rejon", x => x.ID);
                });
            migration.CreateTable(
                name: "Vozila",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    boja = table.Column(type: "TEXT", nullable: true),
                    godinaProizvodnje = table.Column(type: "TEXT", nullable: true),
                    marka = table.Column(type: "TEXT", nullable: true),
                    model = table.Column(type: "TEXT", nullable: true),
                    volumen = table.Column(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozilo", x => x.ID);
                });
            migration.CreateTable(
                name: "Primaoci",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    
                    adresa = table.Column(type: "TEXT", nullable: true),
                    brojTelefona = table.Column(type: "TEXT", nullable: true),
                    ime = table.Column(type: "TEXT", nullable: true),
                    naziv = table.Column(type: "TEXT", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Primalac", x => x.ID);
                    
                });
            migration.CreateTable(
                name: "Zaposlenici",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    LoginID = table.Column(type: "INTEGER", nullable: false),
                    adresa = table.Column(type: "TEXT", nullable: true),
                    brojTelefona = table.Column(type: "TEXT", nullable: true),
                    brojVozacke = table.Column(type: "TEXT", nullable: true),
                    datumRodjenja = table.Column(type: "TEXT", nullable: true),
                    datumZaposljenja = table.Column(type: "TEXT", nullable: true),
                    email = table.Column(type: "TEXT", nullable: true),
                    ime = table.Column(type: "TEXT", nullable: true),
                    password = table.Column(type: "TEXT", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true),
                    tip = table.Column(type: "INTEGER", nullable: true),
                    username = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposlenik", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Zaposlenik_Login_LoginID",
                        columns: x => x.LoginID,
                        referencedTable: "Login",
                        referencedColumn: "ID");
                });
            migration.CreateTable(
                name: "Ulice",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    naziv = table.Column(type: "TEXT", nullable: true),
                    rejonID = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulica", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ulica_Rejon_rejonID",
                        columns: x => x.rejonID,
                        referencedTable: "Rejoni",
                        referencedColumn: "ID");
                });
            migration.CreateTable(
                name: "Dostave",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    datumIzdavanja = table.Column(type: "TEXT", nullable: true),
                    dostavljacID = table.Column(type: "INTEGER", nullable: false),
                    poslovodjaID = table.Column(type: "INTEGER", nullable: false),
                    voziloID = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dostava", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dostava_Zaposlenik_ZaposlenikID",
                        columns: x => x.ID,
                        referencedTable: "Zaposlenici",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Dostava_Primalac_dostavljacID",
                        columns: x => x.dostavljacID,
                        referencedTable: "Primaoci",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Dostava_Zaposlenik_poslovodjaID",
                        columns: x => x.poslovodjaID,
                        referencedTable: "Zaposlenici",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Dostava_Vozilo_voziloID",
                        columns: x => x.voziloID,
                        referencedTable: "Vozila",
                        referencedColumn: "ID");
                });
            migration.CreateTable(
                name: "Letci",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    zaposlenikID = table.Column(type: "INTEGER", nullable: true),
                    blagajnikID = table.Column(type: "INTEGER", nullable: false),
                    dostavaID = table.Column(type: "INTEGER", nullable: false),
                    kolicina = table.Column(type: "INTEGER", nullable: true),
                    krajnjiRok = table.Column(type: "TEXT", nullable: true),
                    naziv = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Letci", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Letci_Zaposlenik_ZaposlenikID",
                        columns: x => x.zaposlenikID,
                        referencedTable: "Zaposlenici",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Letci_Zaposlenik_blagajnikID",
                        columns: x => x.blagajnikID,
                        referencedTable: "Zaposlenici",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Letci_Dostava_dostavaID",
                        columns: x => x.dostavaID,
                        referencedTable: "Dostave",
                        referencedColumn: "ID");
                });
            migration.CreateTable(
                name: "Paketi",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    posiljalacID = table.Column(type: "INTEGER", nullable: false),
                    blagajnikID = table.Column(type: "INTEGER", nullable: false),
                    broj = table.Column(type: "INTEGER", nullable: true),
                    dostavaID = table.Column(type: "INTEGER", nullable: false),
                    krajnjiRok = table.Column(type: "TEXT", nullable: true),
                    masa = table.Column(type: "REAL", nullable: true),
                    primalacID = table.Column(type: "INTEGER", nullable: false),
                    ulicaID = table.Column(type: "INTEGER", nullable: false),
                    volumen = table.Column(type: "REAL", nullable: true),
                    status =  table.Column(type: "BOOLEAN", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paket", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Paket_Posiljalac_posiljalacID",
                        columns: x => x.posiljalacID,
                        referencedTable: "Posiljalaoci",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Paket_Dostava_dostavaID",
                        columns: x => x.dostavaID,
                        referencedTable: "Dostave",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Paket_Ulica_ulicaID",
                        columns: x => x.ulicaID,
                        referencedTable: "Ulice",
                        referencedColumn: "ID");
                });
            migration.CreateTable(
                name: "Pisma",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    PosiljalacID = table.Column(type: "INTEGER", nullable: false),
                    
                    blagajnikID = table.Column(type: "INTEGER", nullable: false),
                    broj = table.Column(type: "INTEGER", nullable: true),
                    dostavaID = table.Column(type: "INTEGER", nullable: false),
                    krajnjiRok = table.Column(type: "TEXT", nullable: true),
                    primalacID = table.Column(type: "INTEGER", nullable: false),
                    status = table.Column(type: "BOOLEAN", nullable: true),
                    ulicaID = table.Column(type: "INTEGER", nullable: false)
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pismo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pismo_Posiljalac_PosiljalacID",
                        columns: x => x.PosiljalacID,
                        referencedTable: "Posiljaoci",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Pismo_Dostava_dostavaID",
                        columns: x => x.dostavaID,
                        referencedTable: "Dostave",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Pismo_Ulica_ulicaID",
                        columns: x => x.ulicaID,
                        referencedTable: "Ulice",
                        referencedColumn: "ID");
                });
            migration.CreateTable(
                name: "UlicaZaLetke",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    letciID = table.Column(type: "INTEGER", nullable: true),
                    status = table.Column(type: "INTEGER", nullable: true),
                    ulicaID = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UlicaZaLetke", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UlicaZaLetke_Letci_letciID",
                        columns: x => x.letciID,
                        referencedTable: "Letci",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UlicaZaLetke_Ulica_ulicaID",
                        columns: x => x.ulicaID,
                        referencedTable: "Ulice",
                        referencedColumn: "ID");
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Paketi");
            migration.DropTable("Pisma");
            migration.DropTable("UlicaZaLetke");
            migration.DropTable("Posiljaoci");
            migration.DropTable("Letci");
            migration.DropTable("Ulice");
            migration.DropTable("Dostave");
            migration.DropTable("Rejoni");
            migration.DropTable("Zaposlenici");
            migration.DropTable("Primaoci");
            migration.DropTable("Vozila");
            migration.DropTable("Login");
        }
    }
}
