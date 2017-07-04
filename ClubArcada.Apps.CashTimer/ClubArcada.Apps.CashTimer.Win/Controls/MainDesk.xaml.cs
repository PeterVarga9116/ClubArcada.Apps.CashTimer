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
using ClubArcada.Common.BusinessObjects.DataClasses;
using ClubArcada.Common;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ClubArcada.Apps.CashTimer.Win.DataClasses;

namespace ClubArcada.Apps.CashTimer.Win.Controls
{
    public partial class MainDesk : UserControl, INotifyPropertyChanged
    {
        private ObservableCollection<CashTable> _cashTables;
        public ObservableCollection<CashTable> CashTables
        {
            get
            {
                return _cashTables;
            }
            set
            {
                _cashTables = value;
                PropertyChanged.Raise(() => CashTables);
            }
        }

        private Guid _selectedCashTableId;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsAddPlayerEnabled { get { return CashTables.IsNotNull() && CashTables.Any(); } }

        public void Refresh()
        {
            PropertyChanged.Raise(() => IsAddPlayerEnabled);
            CashTables.ForEach(ct => ct.Refresh());
        }

        public MainDesk()
        {
            InitializeComponent();
            DataContext = this;
            CashTables = new ObservableCollection<CashTable>();
            CashTables.CollectionChanged += CashTables_CollectionChanged;
        }

        private void CashTables_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            PropertyChanged.Raise(() => CashTables);
            CashTables.ForEach(ct => ct.Refresh());
        }

        private void btnAddTalbe_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new Dialogs.AddTableDlg();
            dlg.ShowDialog();

            if(dlg.DialogResult.True())
            {
                CashTables.Add(CashTable.New(App.CashGame.Id, App.User.Id, "1", eCashTableGameType.Type02));
                Refresh();

                if(CashTables.Count() == 1)
                {
                    tabCtrlMain.SelectedIndex = 0;
                }
            }
        }

        private void btnAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            CashTables.First().CashPlayers.Add(new CashPlayerDto(App.User.Id, CashTables.First().Id, Guid.NewGuid()));
            Refresh();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedCashTableId = (e.AddedItems[0] as CashTable).Id;
        }
    }
}
