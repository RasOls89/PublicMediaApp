using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace PublicMediaApp.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public PublicMedia_Controller Context { get; }
        public ViewModelBase() => Context = PublicMedia_Controller.Instance;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
    }
}
