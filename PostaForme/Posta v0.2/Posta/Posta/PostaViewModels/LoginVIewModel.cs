using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Posta.PostaBaza.Models;
using System.ComponentModel;

namespace Posta.PostaViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {
        private List<ZaposlenikDB> Zaposlenici;
        private List<LoginDB> Logini;
        private string Username;
        private string Password;

        public string Un
        {
            get { return Username; }
            set
            {
                Username = value;
                OnPropertyChanged("Username");
            }
        }

        public string Pw
        {
            get { return Password; }
            set
            {
                Password = value;
                OnPropertyChanged("Password");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string str)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(str));
            }
        }

        public LoginViewModel()
        {
            using (var context = new PostaDBContext())
            {
                Zaposlenici = context.zaposlenici.ToList();
                Logini = context.login.ToList();
            }
        }

        public bool CheckLogin()
        {
            foreach (var o in Logini)
                if (o.username == Un && o.password == Pw) return true;
            return false;
        }

        public ZaposlenikDB GetCurrent()
        {
            if (CheckLogin())
                return Zaposlenici.Where(x => x.username == Un && x.password == Pw).FirstOrDefault();
            else return new ZaposlenikDB();
        }
    }
}
