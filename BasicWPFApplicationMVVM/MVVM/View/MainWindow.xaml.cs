using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasicWPFApplicationMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.WorkArea.Height + 10;

        }

        private void MinimizeClicked(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        private void MaximizedClicked(object sender, RoutedEventArgs e)
        {
            this.MaxHeight = SystemParameters.WorkArea.Height + 10;
            if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
        }
        private void ClosedClicked(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            this.MaxHeight = SystemParameters.WorkArea.Height + 10;
            Point mousePosition = Mouse.GetPosition(Application.Current.MainWindow);
            Point startPoint = Application.Current.MainWindow.PointToScreen(mousePosition);

            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
                Left = startPoint.X - (ActualWidth / 2);
                Top = startPoint.Y - 10;
            }
            DragMove();
        }
    }
}
