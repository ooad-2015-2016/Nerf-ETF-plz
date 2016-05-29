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

                ZaDostavuListView.ItemsSource = context.login;
            }


        }

        private void IsporucenoButton_Click(object sender, RoutedEventArgs e)
        {
            IsporuceneListView.Items.Add(ZaDostavuListView.SelectedItem);
        }
    }
}
