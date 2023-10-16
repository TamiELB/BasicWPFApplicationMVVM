using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWPFApplicationMVVM.MVVM.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        public GlobalViewModel Global { get; } = GlobalViewModel.Instance;
        // View logid (for changing view) // 

        // Declaring bindable View //
        // !!! bindable view is in GlobalViewModel !!! //

        // End of declaring View //
        public Command ShowDashBoard { get; }
        public Command ShowProducts { get; }
        public Command ShowOrders { get; }
        public Command ShowEvents { get; }
        public Command ShowCategories { get; }
        public Command ShowFinance { get; }
        public Command ShowSettings { get; }
        // End of view logic //

        public MainViewModel()
        {
            Global.CurrentView = new DashBoardViewModel();

            Title = "WPF / MVVM";
            Subtitle = "free to use";

            Global.CurrentView = new DashBoardViewModel();
            ShowDashBoard = new Command(o => { Global.CurrentView = new DashBoardViewModel(); });
            ShowProducts = new Command(o => { Global.CurrentView = new ProductsViewModel(); });
            ShowOrders = new Command(o => { Global.CurrentView = new OrdersViewModel(); });
            ShowEvents = new Command(o => { Global.CurrentView = new EventsViewModel(); });
            ShowCategories = new Command(o => { Global.CurrentView = new CategoriesViewModel(); });
            ShowFinance = new Command(o => { Global.CurrentView = new FinanceViewModel(); });
            ShowSettings = new Command(o => { Global.CurrentView = new SettingsViewModel(); });

        }

    }
}
