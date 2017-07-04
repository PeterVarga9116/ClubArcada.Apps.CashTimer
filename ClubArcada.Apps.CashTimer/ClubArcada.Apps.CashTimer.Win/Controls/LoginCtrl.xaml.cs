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

namespace ClubArcada.Apps.CashTimer.Win.Controls
{
    public partial class LoginCtrl : UserControl
    {
        public event RoutedEventHandler Login;

        public LoginCtrl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.User = new Common.BusinessObjects.DataClasses.User();

            if (Login != null)
                Login(this, new RoutedEventArgs());

        }
    }
}
