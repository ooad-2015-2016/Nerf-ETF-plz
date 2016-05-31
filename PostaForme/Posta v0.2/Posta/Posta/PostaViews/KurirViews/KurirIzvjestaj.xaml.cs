using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Posta.PostaBaza.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Posta.PostaViews.KurirViews
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class KurirIzvjestaj : Page
    {
        public KurirIzvjestaj()
        {
            this.InitializeComponent();
            using (var context = new PostaDBContext())
            {                
                var InitList = context.login.ToList();
                foreach (var o in InitList)
                {
                    ZaDostavuListView.Items.Add(o);
                }

                var loginVozac = new LoginDB()
                {
                    username = "vozac",
                    password = "vozac"
                };
                context.login.Add(loginVozac);
                context.SaveChanges();
            }
        }

        private void IsporucenoButton_Click(object sender, RoutedEventArgs e)
        {
            if(SelectAllCheckBox.IsChecked == true)
            {
                foreach(var o in ZaDostavuListView.Items)
                {
                    IsporuceneListView.Items.Add(o);
                    ZaDostavuListView.Items.Remove(o);
                }
            }
            else if (ZaDostavuListView.SelectedIndex != -1)
            {
                IsporuceneListView.Items.Add(ZaDostavuListView.SelectedItem);
                ZaDostavuListView.Items.Remove(ZaDostavuListView.SelectedItem);
            }
        }

        private void NeisporucenoButton_Click(object sender, RoutedEventArgs e)
        {
            if(IsporuceneListView.SelectedIndex != -1)
            {
                ZaDostavuListView.Items.Add(IsporuceneListView.SelectedItem);
                IsporuceneListView.Items.Remove(IsporuceneListView.SelectedItem);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
