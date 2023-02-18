using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Model;
using PublicMediaApp.Commands;

namespace PublicMediaApp.ViewModels
{
    public class LoginViewModel: ViewModelBase
    {

        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; OnPropertyChanged(); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }

        public ICommand LoginCMD { get; private set; }

        public LoginViewModel()
        {
            LoginCMD = new LoginCMD(this);

        }
        //public SecureString SecurePassword { private get; set; }

    }
}
