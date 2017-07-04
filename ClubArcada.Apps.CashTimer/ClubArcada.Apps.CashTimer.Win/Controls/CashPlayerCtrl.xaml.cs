using ClubArcada.Common;
using ClubArcada.Common.BusinessObjects.DataClasses;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ClubArcada.Apps.CashTimer.Win.Controls
{
    public partial class CashPlayerCtrl : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private CashPlayer _cashPlayer;
        public CashPlayer CashPlayer
        {
            get
            {
                return _cashPlayer;
            }
            set
            {
                _cashPlayer = value;
                PropertyChanged.Raise(() => CashPlayer);
            }
        }

        public CashTable CashTable { get; set; }

        public string PlayPauseButtonContent { get { return CashPlayer.IsRunning ? "Pause" : "Start"; } }

        public void Refresh()
        {
            PropertyChanged.Raise(() => PlayPauseButtonContent);
        }

        private DispatcherTimer _timer;

        public CashPlayerCtrl(CashPlayer cashPlayer)
        {
            InitializeComponent();
            DataContext = this;
            CashPlayer = cashPlayer;

            _timer = new DispatcherTimer();
            _timer.Interval = new System.TimeSpan(0, 0, 1);
            _timer.Tick += _timer_Tick;
        }

        private void _timer_Tick(object sender, System.EventArgs e)
        {
            if (CashPlayer.IsNotNull() && CashPlayer.IsRunning)
            {
                CashPlayer.Points = CashPlayer.Points + (CashTable.GameType + 1);
            }
        }

        private void btnStartStop_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if(CashPlayer.IsRunning)
            {
                CashPlayer.SetPaused();
            }
            else
            {
                CashPlayer.SetRunning();
            }
            Refresh();
        }
    }
}
