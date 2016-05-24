using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Posta.PostaBaza.Models;

namespace PostaMigrations
{
    [ContextType(typeof(PostaDBContext))]
    partial class PostaDBContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("Posta.PostaBaza.Models.DostavaDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ZaposlenikDBID");

                    b.Property<DateTime?>("datumIzdavanja");

                    b.Property<int>("dostavljacID");

                    b.Property<int>("poslovodjaID");

                    b.Property<int>("voziloID");

                    b.Key("ID");
                });

            builder.Entity("Posta.PostaBaza.Models.LetciDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ZaposlenikDBID");

                    b.Property<int>("blagajnikID");

                    b.Property<int>("dostavaID");

                    b.Property<int?>("kolicina");

                    b.Property<DateTime?>("krajnjiRok");

                    b.Property<string>("naziv");

                    b.Key("ID");
                });

            builder.Entity("Posta.PostaBaza.Models.LoginDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("password");

                    b.Property<string>("username");

                    b.Key("ID");
                });

            builder.Entity("Posta.PostaBaza.Models.PaketDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PosiljalacID");

                    b.Property<int?>("ZaposlenikDBID");

                    b.Property<int>("blagajnikID");

                    b.Property<int?>("broj");

                    b.Property<int>("dostavaID");

                    b.Property<DateTime?>("krajnjiRok");

                    b.Property<double?>("masa");

                    b.Property<int>("primalacID");

                    b.Property<int>("ulicaID");

                    b.Property<double?>("volumen");

                    b.Key("ID");
                });

            builder.Entity("Posta.PostaBaza.Models.PismoDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PosiljalacID");

                    b.Property<int?>("ZaposlenikDBID");

                    b.Property<int>("blagajnikID");

                    b.Property<int?>("broj");

                    b.Property<int>("dostavaID");

                    b.Property<DateTime?>("krajnjiRok");

                    b.Property<int>("primalacID");

                    b.Property<int>("ulicaID");

                    b.Key("ID");
                });

            builder.Entity("Posta.PostaBaza.Models.PosiljalacDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("brojTelefona");

                    b.Property<string>("ime");

                    b.Property<string>("naziv");

                    b.Property<double?>("popust");

                    b.Property<string>("prezime");

                    b.Property<int>("tip");

                    b.Key("ID");
                });

            builder.Entity("Posta.PostaBaza.Models.PrimalacDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LoginDBID");

                    b.Property<string>("adresa");

                    b.Property<string>("brojTelefona");

                    b.Property<string>("ime");

                    b.Property<string>("naziv");

                    b.Property<string>("prezime");

                    b.Key("ID");
                });

            builder.Entity("Posta.PostaBaza.Models.RejonDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("naziv");

                    b.Key("ID");
                });

            builder.Entity("Posta.PostaBaza.Models.UlicaDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("naziv");

                    b.Property<int>("rejonID");

                    b.Key("ID");
                });

            builder.Entity("Posta.PostaBaza.Models.UlicaZaLetkeDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("letakID");

                    b.Property<int?>("letciID");

                    b.Property<bool?>("status");

                    b.Property<int?>("ulicaID");

                    b.Key("ID");
                });

            builder.Entity("Posta.PostaBaza.Models.VoziloDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("boja");

                    b.Property<DateTime?>("godinaProizvodnje");

                    b.Property<string>("marka");

                    b.Property<string>("model");

                    b.Property<double>("volumen");

                    b.Key("ID");
                });

            builder.Entity("Posta.PostaBaza.Models.ZaposlenikDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LoginDBID");

                    b.Property<string>("adresa");

                    b.Property<string>("brojTelefona");

                    b.Property<string>("brojVozacke");

                    b.Property<DateTime?>("datumRodjenja");

                    b.Property<DateTime?>("datumZaposljenja");

                    b.Property<string>("email");

                    b.Property<string>("ime");

                    b.Property<string>("password");

                    b.Property<string>("prezime");

                    b.Property<int?>("tip");

                    b.Property<string>("username");

                    b.Key("ID");
                });

            builder.Entity("Posta.PostaBaza.Models.DostavaDB", b =>
                {
                    b.Reference("Posta.PostaBaza.Models.ZaposlenikDB")
                        .InverseCollection()
                        .ForeignKey("ZaposlenikDBID");

                    b.Reference("Posta.PostaBaza.Models.PrimalacDB")
                        .InverseCollection()
                        .ForeignKey("dostavljacID");

                    b.Reference("Posta.PostaBaza.Models.PrimalacDB")
                        .InverseCollection()
                        .ForeignKey("poslovodjaID");

                    b.Reference("Posta.PostaBaza.Models.VoziloDB")
                        .InverseCollection()
                        .ForeignKey("voziloID");
                });

            builder.Entity("Posta.PostaBaza.Models.LetciDB", b =>
                {
                    b.Reference("Posta.PostaBaza.Models.ZaposlenikDB")
                        .InverseCollection()
                        .ForeignKey("ZaposlenikDBID");

                    b.Reference("Posta.PostaBaza.Models.PrimalacDB")
                        .InverseCollection()
                        .ForeignKey("blagajnikID");

                    b.Reference("Posta.PostaBaza.Models.DostavaDB")
                        .InverseCollection()
                        .ForeignKey("dostavaID");
                });

            builder.Entity("Posta.PostaBaza.Models.PaketDB", b =>
                {
                    b.Reference("Posta.PostaBaza.Models.PosiljalacDB")
                        .InverseCollection()
                        .ForeignKey("PosiljalacID");

                    b.Reference("Posta.PostaBaza.Models.ZaposlenikDB")
                        .InverseCollection()
                        .ForeignKey("ZaposlenikDBID");

                    b.Reference("Posta.PostaBaza.Models.DostavaDB")
                        .InverseCollection()
                        .ForeignKey("dostavaID");

                    b.Reference("Posta.PostaBaza.Models.UlicaDB")
                        .InverseCollection()
                        .ForeignKey("ulicaID");
                });

            builder.Entity("Posta.PostaBaza.Models.PismoDB", b =>
                {
                    b.Reference("Posta.PostaBaza.Models.PosiljalacDB")
                        .InverseCollection()
                        .ForeignKey("PosiljalacID");

                    b.Reference("Posta.PostaBaza.Models.ZaposlenikDB")
                        .InverseCollection()
                        .ForeignKey("ZaposlenikDBID");

                    b.Reference("Posta.PostaBaza.Models.DostavaDB")
                        .InverseCollection()
                        .ForeignKey("dostavaID");

                    b.Reference("Posta.PostaBaza.Models.UlicaDB")
                        .InverseCollection()
                        .ForeignKey("ulicaID");
                });

            builder.Entity("Posta.PostaBaza.Models.PrimalacDB", b =>
                {
                    b.Reference("Posta.PostaBaza.Models.LoginDB")
                        .InverseCollection()
                        .ForeignKey("LoginDBID");
                });

            builder.Entity("Posta.PostaBaza.Models.UlicaDB", b =>
                {
                    b.Reference("Posta.PostaBaza.Models.RejonDB")
                        .InverseCollection()
                        .ForeignKey("rejonID");
                });

            builder.Entity("Posta.PostaBaza.Models.UlicaZaLetkeDB", b =>
                {
                    b.Reference("Posta.PostaBaza.Models.LetciDB")
                        .InverseCollection()
                        .ForeignKey("letciID");

                    b.Reference("Posta.PostaBaza.Models.UlicaDB")
                        .InverseCollection()
                        .ForeignKey("ulicaID");
                });

            builder.Entity("Posta.PostaBaza.Models.ZaposlenikDB", b =>
                {
                    b.Reference("Posta.PostaBaza.Models.LoginDB")
                        .InverseCollection()
                        .ForeignKey("LoginDBID");
                });
        }
    }
}
