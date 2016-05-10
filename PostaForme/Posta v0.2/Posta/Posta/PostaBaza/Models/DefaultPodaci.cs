using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posta.PostaBaza.Models
{
    class DefaultPodaci
    {
        public static void Initialize(PostaDbContext context)
        {
            // context.saveChanhges he zakomentarisan u svakoj

            #region ZAPOSLENICI
  
            
            #region POSLOVODJE

            if (!context.poslovodje.Any())
            {
                context.poslovodje.AddRange(
                new Poslovodja()
                {
                    ime = "",
                    prezime = "",
                    email = "",
                    adresa = "",
                    telefon = null,
                    datumRodjenja = null,
                    datumZaposljenja = null,
                }
                );
                //context.SaveChanges();
            }



            #endregion            
            #region BLAGAJNICI
            if (!context.blagajnici.Any())
            {
                context.blagajnici.AddRange(
                new Blagajnik()
                {
                    ime = "",
                    prezime = "",
                    email = "",
                    adresa = "",
                    telefon = null,
                    datumRodjenja = null,
                    datumZaposljenja = null,
                }
                );
                //context.SaveChanges();
            }




            #endregion

            #region POSTARI
            if (!context.postari.Any())
            {
                context.postari.AddRange(
                new Postar()
                {
                    ime = "",
                    prezime = "",
                    email = "",
                    adresa = "",
                    telefon = null,
                    datumRodjenja = null,
                    datumZaposljenja = null,
                }
                );
                //context.SaveChanges();
            }




            #endregion

            #region VOZACI            if (!context.vozaci.Any())
            {
                context.vozaci.AddRange(
                new Vozac()
                {
                    ime = "",
                    prezime = "",
                    email = "",
                    adresa = "",
                    telefon = null,
                    datumRodjenja = null,
                    datumZaposljenja = null,
                    brojVozacke = null,
                }
                );
      //          context.SaveChanges();
            }
            #endregion

            #endregion

            #region MUSTERIJE

            #region POSILJALAC

            if (!context.posiljaoci.Any())
            {
                context.posiljaoci.AddRange(
                new Posiljalac()
                {
                    ime = "",
                    prezime = "",
                    datumRodjenja = null,
                    brojTelefona = null
                }
                );
   //             context.SaveChanges();
            }

            #endregion

            #region PRIMALAC

            if (!context.primaoci.Any())
            {
                context.primaoci.AddRange(
                new Primalac()
                {
                    ime = "",
                    prezime = "",
                    datumRodjenja = null,
                    telefon = null,
                    adresa = ""
                }
                );
     //           context.SaveChanges();
            }
            #endregion

            #endregion

            #region DOSTAVE

            if (!context.dostave.Any())
            {
                context.dostave.AddRange(
                new Dostava()
                {
                    listaPosiljaka = null,
                    listaStatusa = null,
                    poslovodja = null,
                    dostavljac = null,
                    datumIzdavanja = null,
                }
                );
          //      context.SaveChanges();
            }

            #endregion

            #region POSILJKE

            if (!context.posiljke.Any())
            {
                context.posiljke.AddRange(
                new Posiljka()
                {
                    posiljalac = null,
                    primalac = null,
                    vrsta = null,
                    kolicina = null,
                    status = null
                }
                );
//                context.SaveChanges();
            }

            #endregion

        }
    }
}
