using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Blagajnik
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlagajnikPocetni : Page
    {


        public BlagajnikPocetni()
        {
            this.InitializeComponent();

        }

        private void PismoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            DodatneInformacijeFrame.Navigate(typeof(PismoFrame),null);
        }

        private void PaketRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            DodatneInformacijeFrame.Navigate(typeof(PaketFrame), null);
        }

        private void LetciRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            DodatneInformacijeFrame.Navigate(typeof(LetciFrame), null);
        }

        private async void PrintajButton_Click(object sender, RoutedEventArgs e)
        {
            List<string> podaciZaRacun = new List<string>();
            podaciZaRacun.Add("Posiljalac : " + NazivTextBox.Text + " \r\n");
            podaciZaRacun.Add("Krajnji rok isporuke : " + KrajnjiRokIsporukeCalenderDatePicker.Date.ToString() + " \r\n");
            podaciZaRacun.Add("Popust : " + PopustTextBox.Text + "\r\n");
            


            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile racunSF = await storageFolder.CreateFileAsync("privremeniRacun.txt", CreationCollisionOption.ReplaceExisting);

            var stream = await racunSF.OpenAsync(FileAccessMode.ReadWrite);

            // string racunFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path);
            // C:\Users\bsehic1\AppData\Local\Packages\32739ef1-3a23-412a-8885-1bf93e9b939e_73k0k8tnbg8ty\LocalState

            

            


            if ((bool)PismoRadioButton.IsChecked)
            {
                podaciZaRacun.Add("Tip posiljke : Pismo \r\n");

                PismoFrame pf = (PismoFrame)DodatneInformacijeFrame.Content;
                if (pf != null)
                {
                    Grid grid = (Grid)pf.Content;
                    TextBox PrimalacTB = (TextBox)grid.Children.Cast<TextBox>().Where(x => x.Name == "PrimalacTextBox").FirstOrDefault();
                    podaciZaRacun.Add("Primalac : " + PrimalacTB.Text + "\r\n");
                    TextBox AdresaTB = (TextBox)grid.Children.Cast<TextBox>().Where(x => x.Name == "AdresaTextBox").FirstOrDefault();
                    podaciZaRacun.Add("Adresa : " + AdresaTB.Text + "\r\n");
                    
                }

            }

            if ((bool)PaketRadioButton.IsChecked)
            {
                podaciZaRacun.Add("Tip posiljke : Paket \r\n");

                PaketFrame pf = (PaketFrame)DodatneInformacijeFrame.Content;
                if (pf != null)
                {
                    Grid grid = (Grid)pf.Content;
                    TextBox PrimalacTB = (TextBox)grid.Children.Cast<TextBox>().Where(x => x.Name == "PrimalacTextBox").FirstOrDefault();
                    podaciZaRacun.Add("Primalac : " + PrimalacTB.Text + "\r\n");
                    TextBox AdresaTB = (TextBox)grid.Children.Cast<TextBox>().Where(x => x.Name == "AdresaTextBox").FirstOrDefault();
                    podaciZaRacun.Add("Adresa : " + AdresaTB.Text + "\r\n");

                    TextBox MasaTB = (TextBox)grid.Children.Cast<TextBox>().Where(x => x.Name == "MasaTextBox").FirstOrDefault();
                    podaciZaRacun.Add("Masa : " + MasaTB.Text + "\r\n");
                    TextBox VolumenTB = (TextBox)grid.Children.Cast<TextBox>().Where(x => x.Name == "VolumenTextBox").FirstOrDefault();
                    podaciZaRacun.Add("Volumen : " + AdresaTB.Text + "\r\n");

                }

            }

            if ((bool)LetciRadioButton.IsChecked)
            {
                podaciZaRacun.Add("Tip posiljke : Letci \r\n");

                LetciFrame pf = (LetciFrame)DodatneInformacijeFrame.Content;
                if (pf != null)
                {
                    Grid grid = (Grid)pf.Content;
                    TextBox KolicinaTB = (TextBox)grid.Children.Cast<TextBox>().Where(x => x.Name == "KolicinaTextBox").FirstOrDefault();
                    podaciZaRacun.Add("Kolicina : " + KolicinaTB.Text + "\r\n");
                    
                }

            }











            using (var outputStream = stream.GetOutputStreamAt(0))
            {
                using (var dataWriter = new Windows.Storage.Streams.DataWriter(outputStream))
                {

                    for (int i = 0; i < podaciZaRacun.Count; i++)
                    {
                        dataWriter.WriteString(podaciZaRacun.ElementAt(i));
                        
                    }
                    await dataWriter.StoreAsync();
                    await outputStream.FlushAsync();
                }
            }
            stream.Dispose();









        }
    }
}
