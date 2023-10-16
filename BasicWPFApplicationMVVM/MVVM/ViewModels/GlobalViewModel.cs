using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWPFApplicationMVVM.MVVM.ViewModels
{
    internal class GlobalViewModel : ViewModelBase
    {
        public static GlobalViewModel Instance { get; set; } = new GlobalViewModel();

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        private GlobalViewModel()
        {
        }
    }
}
