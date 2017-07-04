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

namespace ClubArcada.Apps.CashTimer.Win
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            App.User = new Common.BusinessObjects.DataClasses.User();
            App.CashGame = new Common.BusinessObjects.DataClasses.CashGame();

            var loginCtrl = new Controls.LoginCtrl();
            loginCtrl.Login += LoginCtrl_Login;

            gridMainWindow.Children.Add(loginCtrl);
        }

        private void LoginCtrl_Login(object sender, RoutedEventArgs e)
        {
            gridMainWindow.Children.Clear();
            gridMainWindow.Children.Add(new Controls.MainDesk());
        }
    }
}
