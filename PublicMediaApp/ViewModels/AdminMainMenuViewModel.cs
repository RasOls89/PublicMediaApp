using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using BusinessLayer;
using PublicMediaApp.Commands;
using System.Windows.Input;

namespace PublicMediaApp.ViewModels
{
    public class AdminMainMenuViewModel
    {

        public AdminMainMenuViewModel()
        {
            AddUserCMD = new AddUserCMD(this);
        }

        public string NewUserName { get; set; }
        public string NewUserPass { get; set; }
        public string NewUserRole { get; set; }
        public string NewUserFName { get; set; }
        public string NewUserLName { get; set; }
        public string NewUserAcR { get; set; }

        public ICommand AddUserCMD { get; private set; }

                    
    }
}
