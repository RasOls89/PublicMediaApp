using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicMediaApp.ViewModels;
using BusinessLayer;
using System.Windows;
using System.Windows.Input;

namespace PublicMediaApp.Commands
{
    public class AddUserCMD: ICommand
    {
        private readonly AdminMainMenuViewModel _adminModel;
        public UserController UC = new UserController();

        public event EventHandler CanExecuteChanged;

        public AddUserCMD(AdminMainMenuViewModel _adminModel)
        {
            this._adminModel = _adminModel;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (_adminModel.NewUserName != null)
            {
                UC.CreateUser(_adminModel.NewUserFName, _adminModel.NewUserLName, _adminModel.NewUserName, _adminModel.NewUserPass, _adminModel.NewUserRole, _adminModel.NewUserAcR);
                MessageBox.Show("Du har lagt till en ny användare", "Information");
            }
            else
            {
                MessageBox.Show("Det var något felaktigt med de uppgifter du lade in", "Fel");
            }
        }
    }
}
