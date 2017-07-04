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
using System.Windows.Shapes;

namespace ClubArcada.Apps.CashTimer.Win.Dialogs
{
    /// <summary>
    /// Interaction logic for AddTableDlg.xaml
    /// </summary>
    public partial class AddTableDlg : Window
    {
        public AddTableDlg()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
        
    }
}
