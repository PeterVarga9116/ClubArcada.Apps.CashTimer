using ClubArcada.Common;
using ClubArcada.Common.BusinessObjects.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public CashTable CashTable { get; set; }

        public AddTableDlg()
        {
            InitializeComponent();

            cbxGameType.ItemsSource = Enum.GetValues(typeof(eCashTableGameType)).Cast<eCashTableGameType>();
            CashTable = CashTable.New(App.CashGame.Id, App.User.Id, string.Empty, eCashTableGameType.NotSet);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CashTable.Name = cbxName.SelectionBoxItem.ToString();
            CashTable.GameTypeEnum = (eCashTableGameType)cbxGameType.SelectedValue;

            DialogResult = true;
        }

    }
}
