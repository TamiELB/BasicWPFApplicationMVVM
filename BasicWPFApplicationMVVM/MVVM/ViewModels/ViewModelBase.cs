using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWPFApplicationMVVM.MVVM.ViewModels
{
    internal class ViewModelBase : ObservableObject
    {
        private string? title = string.Empty;

        private string? subtitle = string.Empty;
        public string? Title
        {
            get
            {
                return title;
            }
            set
            {
                SetProperty(ref title, value, nameof(Title));
            }
        }

        public string? Subtitle
        {
            get
            {
                return subtitle;
            }
            set
            {
                SetProperty(ref subtitle, value, nameof(Subtitle));
            }
        }
    }
}
