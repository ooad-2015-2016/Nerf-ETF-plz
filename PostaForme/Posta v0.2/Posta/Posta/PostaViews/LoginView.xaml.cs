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
using Posta.PostaViewModels;
using System.ComponentModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Posta.PostaViews
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginView : Page
    {
        private LoginViewModel viewModel;

        public string Username { get; set; }
        public string Password { get; set; }

        public LoginView()
        {
            this.InitializeComponent();
            viewModel = new LoginViewModel();
            this.DataContext = viewModel;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            ZaposlenikDB current = new ZaposlenikDB();
            current = viewModel.GetCurrent();
            listView.Items.Add(current.tip.ToString());
        }
    }
}
