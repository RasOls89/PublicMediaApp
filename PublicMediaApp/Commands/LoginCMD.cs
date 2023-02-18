using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PublicMediaApp.ViewModels;
using BusinessLayer;
using System.Windows;

namespace PublicMediaApp.Commands
{
    public class LoginCMD : ICommand
    {
        private readonly LoginViewModel _loginModel;
        public UserController UC = new UserController();
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// String that hold what acess rights the loggedinuser has
        /// </summary>
        private string _acessRights;

        public LoginCMD(LoginViewModel _loginModel)
        {
            this._loginModel = _loginModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
                _acessRights = UserController.LoggedInUser.AcessRights;

            if (_acessRights == "System")//Admins
            {
                PublicMediaApp.Views.AdminMainMenuView adminMainMenu = new PublicMediaApp.Views.AdminMainMenuView();
                adminMainMenu.ShowDialog();
            }
            else if (_acessRights == "User")//Users
            {
                PublicMediaApp.Views.UserMainMenuView userMain = new PublicMediaApp.Views.UserMainMenuView();
                userMain.ShowDialog();
            }
        }
    }
}

    
