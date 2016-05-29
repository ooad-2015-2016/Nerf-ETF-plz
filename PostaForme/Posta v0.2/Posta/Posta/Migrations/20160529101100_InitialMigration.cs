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
                name: "LoginDB",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    password = table.Column(type: "TEXT", nullable: true),
                    username = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginDB", x => x.ID);
                });
            migration.CreateTable(
                name: "PosiljalacDB",
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
                    table.PrimaryKey("PK_PosiljalacDB", x => x.ID);
                });
            migration.CreateTable(
                name: "PrimalacDB",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    adresa = table.Column(type: "TEXT", nullable: true),
                    brojTelefona = table.Column(type: "TEXT", nullable: true),
                    ime = table.Column(type: "TEXT", nullable: true),
                    naziv = table.Column(type: "TEXT", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimalacDB", x => x.ID);
                });
            migration.CreateTable(
                name: "RejonDB",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    naziv = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RejonDB", x => x.ID);
                });
            migration.CreateTable(
                name: "VoziloDB",
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
                    table.PrimaryKey("PK_VoziloDB", x => x.ID);
                });
            migration.CreateTable(
                name: "ZaposlenikDB",
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
                    table.PrimaryKey("PK_ZaposlenikDB", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ZaposlenikDB_LoginDB_LoginID",
                        columns: x => x.LoginID,
                        referencedTable: "LoginDB",
                        referencedColumn: "ID");
                });
            migration.CreateTable(
                name: "UlicaDB",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                     //   .Annotation("Sqlite:Autoincrement", true),
                    naziv = table.Column(type: "TEXT", nullable: true),
                    rejonID = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UlicaDB", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UlicaDB_RejonDB_rejonID",
                        columns: x => x.rejonID,
                        referencedTable: "RejonDB",
                        referencedColumn: "ID");
                });
            migration.CreateTable(
                name: "DostavaDB",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    ZaposlenikDBID = table.Column(type: "INTEGER", nullable: true),
                    datumIzdavanja = table.Column(type: "TEXT", nullable: true),
                    dostavljacID = table.Column(type: "INTEGER", nullable: false),
                    poslovodjaID = table.Column(type: "INTEGER", nullable: false),
                    voziloID = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DostavaDB", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DostavaDB_ZaposlenikDB_ZaposlenikDBID",
                        columns: x => x.ZaposlenikDBID,
                        referencedTable: "ZaposlenikDB",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DostavaDB_PrimalacDB_dostavljacID",
                        columns: x => x.dostavljacID,
                        referencedTable: "PrimalacDB",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DostavaDB_PrimalacDB_poslovodjaID",
                        columns: x => x.poslovodjaID,
                        referencedTable: "PrimalacDB",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DostavaDB_VoziloDB_voziloID",
                        columns: x => x.voziloID,
                        referencedTable: "VoziloDB",
                        referencedColumn: "ID");
                });
            migration.CreateTable(
                name: "LetciDB",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    ZaposlenikDBID = table.Column(type: "INTEGER", nullable: true),
                    blagajnikID = table.Column(type: "INTEGER", nullable: false),
                    dostavaID = table.Column(type: "INTEGER", nullable: false),
                    kolicina = table.Column(type: "INTEGER", nullable: true),
                    krajnjiRok = table.Column(type: "TEXT", nullable: true),
                    naziv = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LetciDB", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LetciDB_ZaposlenikDB_ZaposlenikDBID",
                        columns: x => x.ZaposlenikDBID,
                        referencedTable: "ZaposlenikDB",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_LetciDB_PrimalacDB_blagajnikID",
                        columns: x => x.blagajnikID,
                        referencedTable: "PrimalacDB",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_LetciDB_DostavaDB_dostavaID",
                        columns: x => x.dostavaID,
                        referencedTable: "DostavaDB",
                        referencedColumn: "ID");
                });
            migration.CreateTable(
                name: "PaketDB",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                    //    .Annotation("Sqlite:Autoincrement", true),
                    PosiljalacID = table.Column(type: "INTEGER", nullable: false),
                    ZaposlenikDBID = table.Column(type: "INTEGER", nullable: true),
                    blagajnikID = table.Column(type: "INTEGER", nullable: false),
                    broj = table.Column(type: "INTEGER", nullable: true),
                    dostavaID = table.Column(type: "INTEGER", nullable: false),
                    krajnjiRok = table.Column(type: "TEXT", nullable: true),
                    masa = table.Column(type: "REAL", nullable: true),
                    primalacID = table.Column(type: "INTEGER", nullable: false),
                    status = table.Column(type: "INTEGER", nullable: true),
                    ulicaID = table.Column(type: "INTEGER", nullable: false),
                    volumen = table.Column(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaketDB", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PaketDB_PosiljalacDB_PosiljalacID",
                        columns: x => x.PosiljalacID,
                        referencedTable: "PosiljalacDB",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PaketDB_ZaposlenikDB_ZaposlenikDBID",
                        columns: x => x.ZaposlenikDBID,
                        referencedTable: "ZaposlenikDB",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PaketDB_DostavaDB_dostavaID",
                        columns: x => x.dostavaID,
                        referencedTable: "DostavaDB",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PaketDB_UlicaDB_ulicaID",
                        columns: x => x.ulicaID,
                        referencedTable: "UlicaDB",
                        referencedColumn: "ID");
                });
            migration.CreateTable(
                name: "PismoDB",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                     //   .Annotation("Sqlite:Autoincrement", true),
                    PosiljalacID = table.Column(type: "INTEGER", nullable: false),
                    ZaposlenikDBID = table.Column(type: "INTEGER", nullable: true),
                    blagajnikID = table.Column(type: "INTEGER", nullable: false),
                    broj = table.Column(type: "INTEGER", nullable: true),
                    dostavaID = table.Column(type: "INTEGER", nullable: false),
                    krajnjiRok = table.Column(type: "TEXT", nullable: true),
                    primalacID = table.Column(type: "INTEGER", nullable: false),
                    status = table.Column(type: "INTEGER", nullable: true),
                    ulicaID = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PismoDB", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PismoDB_PosiljalacDB_PosiljalacID",
                        columns: x => x.PosiljalacID,
                        referencedTable: "PosiljalacDB",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PismoDB_ZaposlenikDB_ZaposlenikDBID",
                        columns: x => x.ZaposlenikDBID,
                        referencedTable: "ZaposlenikDB",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PismoDB_DostavaDB_dostavaID",
                        columns: x => x.dostavaID,
                        referencedTable: "DostavaDB",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PismoDB_UlicaDB_ulicaID",
                        columns: x => x.ulicaID,
                        referencedTable: "UlicaDB",
                        referencedColumn: "ID");
                });
            migration.CreateTable(
                name: "UlicaZaLetkeDB",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                    //    .Annotation("Sqlite:Autoincrement", true),
                    letakID = table.Column(type: "INTEGER", nullable: false),
                    letciID = table.Column(type: "INTEGER", nullable: true),
                    status = table.Column(type: "INTEGER", nullable: true),
                    ulicaID = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UlicaZaLetkeDB", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UlicaZaLetkeDB_LetciDB_letciID",
                        columns: x => x.letciID,
                        referencedTable: "LetciDB",
                        referencedColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UlicaZaLetkeDB_UlicaDB_ulicaID",
                        columns: x => x.ulicaID,
                        referencedTable: "UlicaDB",
                        referencedColumn: "ID");
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("PaketDB");
            migration.DropTable("PismoDB");
            migration.DropTable("UlicaZaLetkeDB");
            migration.DropTable("PosiljalacDB");
            migration.DropTable("LetciDB");
            migration.DropTable("UlicaDB");
            migration.DropTable("DostavaDB");
            migration.DropTable("RejonDB");
            migration.DropTable("ZaposlenikDB");
            migration.DropTable("PrimalacDB");
            migration.DropTable("VoziloDB");
            migration.DropTable("LoginDB");
        }
    }
}
