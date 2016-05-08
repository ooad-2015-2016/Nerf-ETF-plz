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
                name: "Blagajnik",
                columns: table => new
                {
                    BlagajnikId = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    OsobaId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    adresa = table.Column(type: "TEXT", nullable: true),
                    datumRodjenja = table.Column(type: "TEXT", nullable: true),
                    datumZaposljenja = table.Column(type: "TEXT", nullable: true),
                    email = table.Column(type: "TEXT", nullable: true),
                    ime = table.Column(type: "TEXT", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true),
                    telefon = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blagajnik", x => x.BlagajnikId);
                });
            migration.CreateTable(
                name: "Osoba",
                columns: table => new
                {
                    OsobaId = table.Column(type: "INTEGER", nullable: false),
                      //  .Annotation("Sqlite:Autoincrement", true),
                    datumRodjenja = table.Column(type: "TEXT", nullable: true),
                    ime = table.Column(type: "TEXT", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba", x => x.OsobaId);
                });
            migration.CreateTable(
                name: "Posiljalac",
                columns: table => new
                {
                    posiljalacId = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    OsobaId = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    brojTelefona = table.Column(type: "INTEGER", nullable: true),
                    datumRodjenja = table.Column(type: "TEXT", nullable: true),
                    ime = table.Column(type: "TEXT", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posiljalac", x => x.posiljalacId);
                });
            migration.CreateTable(
                name: "Poslovodja",
                columns: table => new
                {
                    PoslovodjaId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    OsobaId = table.Column(type: "INTEGER", nullable: false),
                        // .Annotation("Sqlite:Autoincrement", true),
                    adresa = table.Column(type: "TEXT", nullable: true),
                    datumRodjenja = table.Column(type: "TEXT", nullable: true),
                    datumZaposljenja = table.Column(type: "TEXT", nullable: true),
                    email = table.Column(type: "TEXT", nullable: true),
                    ime = table.Column(type: "TEXT", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true),
                    telefon = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poslovodja", x => x.PoslovodjaId);
                });
            migration.CreateTable(
                name: "Postar",
                columns: table => new
                {
                    PostarId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    OsobaId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    adresa = table.Column(type: "TEXT", nullable: true),
                    datumRodjenja = table.Column(type: "TEXT", nullable: true),
                    datumZaposljenja = table.Column(type: "TEXT", nullable: true),
                    email = table.Column(type: "TEXT", nullable: true),
                    ime = table.Column(type: "TEXT", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true),
                    telefon = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postar", x => x.PostarId);
                });
            migration.CreateTable(
                name: "Primalac",
                columns: table => new
                {
                    primalacId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    OsobaId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    adresa = table.Column(type: "TEXT", nullable: true),
                    datumRodjenja = table.Column(type: "TEXT", nullable: true),
                    ime = table.Column(type: "TEXT", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true),
                    telefon = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Primalac", x => x.primalacId);
                });
            migration.CreateTable(
                name: "Vozac",
                columns: table => new
                {
                    VozacId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    OsobaId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    PostarId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    adresa = table.Column(type: "TEXT", nullable: true),
                    brojVozacke = table.Column(type: "TEXT", nullable: true),
                    datumRodjenja = table.Column(type: "TEXT", nullable: true),
                    datumZaposljenja = table.Column(type: "TEXT", nullable: true),
                    email = table.Column(type: "TEXT", nullable: true),
                    ime = table.Column(type: "TEXT", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true),
                    telefon = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozac", x => x.VozacId);
                });
            migration.CreateTable(
                name: "Dostava",
                columns: table => new
                {
                    DostavaId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    datumIzdavanja = table.Column(type: "TEXT", nullable: true),
                    dostavljacPostarId = table.Column(type: "INTEGER", nullable: true),
                    poslovodjaPoslovodjaId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dostava", x => x.DostavaId);
                    table.ForeignKey(
                        name: "FK_Dostava_Postar_dostavljacPostarId",
                        columns: x => x.dostavljacPostarId,
                        referencedTable: "Postar",
                        referencedColumn: "PostarId");
                    table.ForeignKey(
                        name: "FK_Dostava_Poslovodja_poslovodjaPoslovodjaId",
                        columns: x => x.poslovodjaPoslovodjaId,
                        referencedTable: "Poslovodja",
                        referencedColumn: "PoslovodjaId");
                });
            migration.CreateTable(
                name: "Posiljka",
                columns: table => new
                {
                    posiljkaId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    DostavaDostavaId = table.Column(type: "INTEGER", nullable: true),
                    kolicina = table.Column(type: "INTEGER", nullable: true),
                    posiljalacposiljalacId = table.Column(type: "INTEGER", nullable: true),
                    primalacprimalacId = table.Column(type: "INTEGER", nullable: true),
                    status = table.Column(type: "INTEGER", nullable: true),
                    vrsta = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posiljka", x => x.posiljkaId);
                    table.ForeignKey(
                        name: "FK_Posiljka_Dostava_DostavaDostavaId",
                        columns: x => x.DostavaDostavaId,
                        referencedTable: "Dostava",
                        referencedColumn: "DostavaId");
                    table.ForeignKey(
                        name: "FK_Posiljka_Posiljalac_posiljalacposiljalacId",
                        columns: x => x.posiljalacposiljalacId,
                        referencedTable: "Posiljalac",
                        referencedColumn: "posiljalacId");
                    table.ForeignKey(
                        name: "FK_Posiljka_Primalac_primalacprimalacId",
                        columns: x => x.primalacprimalacId,
                        referencedTable: "Primalac",
                        referencedColumn: "primalacId");
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Blagajnik");
            migration.DropTable("Osoba");
            migration.DropTable("Posiljka");
            migration.DropTable("Vozac");
            migration.DropTable("Dostava");
            migration.DropTable("Posiljalac");
            migration.DropTable("Primalac");
            migration.DropTable("Postar");
            migration.DropTable("Poslovodja");
        }
    }
}
