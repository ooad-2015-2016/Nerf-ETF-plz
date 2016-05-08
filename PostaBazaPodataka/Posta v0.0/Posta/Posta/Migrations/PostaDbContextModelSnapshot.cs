using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Posta.PostaBaza.Models;

namespace PostaMigrations
{
    [ContextType(typeof(PostaDbContext))]
    partial class PostaDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("Posta.Blagajnik", b =>
                {
                    b.Property<int>("BlagajnikId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OsobaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("adresa");

                    b.Property<DateTime?>("datumRodjenja");

                    b.Property<DateTime?>("datumZaposljenja");

                    b.Property<string>("email");

                    b.Property<string>("ime");

                    b.Property<string>("prezime");

                    b.Property<int?>("telefon");

                    b.Key("BlagajnikId");
                });

            builder.Entity("Posta.Dostava", b =>
                {
                    b.Property<int>("DostavaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("datumIzdavanja");

                    b.Property<int?>("dostavljacPostarId");

                    b.Property<int?>("poslovodjaPoslovodjaId");

                    b.Key("DostavaId");
                });

            builder.Entity("Posta.Osoba", b =>
                {
                    b.Property<int>("OsobaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("datumRodjenja");

                    b.Property<string>("ime");

                    b.Property<string>("prezime");

                    b.Key("OsobaId");
                });

            builder.Entity("Posta.Posiljalac", b =>
                {
                    b.Property<int>("posiljalacId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OsobaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("brojTelefona");

                    b.Property<DateTime?>("datumRodjenja");

                    b.Property<string>("ime");

                    b.Property<string>("prezime");

                    b.Key("posiljalacId");
                });

            builder.Entity("Posta.Posiljka", b =>
                {
                    b.Property<int>("posiljkaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DostavaDostavaId");

                    b.Property<int?>("kolicina");

                    b.Property<int?>("posiljalacposiljalacId");

                    b.Property<int?>("primalacprimalacId");

                    b.Property<bool?>("status");

                    b.Property<int?>("vrsta");

                    b.Key("posiljkaId");
                });

            builder.Entity("Posta.Poslovodja", b =>
                {
                    b.Property<int>("PoslovodjaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OsobaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("adresa");

                    b.Property<DateTime?>("datumRodjenja");

                    b.Property<DateTime?>("datumZaposljenja");

                    b.Property<string>("email");

                    b.Property<string>("ime");

                    b.Property<string>("prezime");

                    b.Property<int?>("telefon");

                    b.Key("PoslovodjaId");
                });

            builder.Entity("Posta.Postar", b =>
                {
                    b.Property<int>("PostarId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OsobaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("adresa");

                    b.Property<DateTime?>("datumRodjenja");

                    b.Property<DateTime?>("datumZaposljenja");

                    b.Property<string>("email");

                    b.Property<string>("ime");

                    b.Property<string>("prezime");

                    b.Property<int?>("telefon");

                    b.Key("PostarId");
                });

            builder.Entity("Posta.Primalac", b =>
                {
                    b.Property<int>("primalacId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OsobaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("adresa");

                    b.Property<DateTime?>("datumRodjenja");

                    b.Property<string>("ime");

                    b.Property<string>("prezime");

                    b.Property<int?>("telefon");

                    b.Key("primalacId");
                });

            builder.Entity("Posta.Vozac", b =>
                {
                    b.Property<int?>("VozacId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OsobaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PostarId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("adresa");

                    b.Property<string>("brojVozacke");

                    b.Property<DateTime?>("datumRodjenja");

                    b.Property<DateTime?>("datumZaposljenja");

                    b.Property<string>("email");

                    b.Property<string>("ime");

                    b.Property<string>("prezime");

                    b.Property<int?>("telefon");

                    b.Key("VozacId");
                });

            builder.Entity("Posta.Dostava", b =>
                {
                    b.Reference("Posta.Postar")
                        .InverseCollection()
                        .ForeignKey("dostavljacPostarId");

                    b.Reference("Posta.Poslovodja")
                        .InverseCollection()
                        .ForeignKey("poslovodjaPoslovodjaId");
                });

            builder.Entity("Posta.Posiljka", b =>
                {
                    b.Reference("Posta.Dostava")
                        .InverseCollection()
                        .ForeignKey("DostavaDostavaId");

                    b.Reference("Posta.Posiljalac")
                        .InverseCollection()
                        .ForeignKey("posiljalacposiljalacId");

                    b.Reference("Posta.Primalac")
                        .InverseCollection()
                        .ForeignKey("primalacprimalacId");
                });
        }
    }
}
