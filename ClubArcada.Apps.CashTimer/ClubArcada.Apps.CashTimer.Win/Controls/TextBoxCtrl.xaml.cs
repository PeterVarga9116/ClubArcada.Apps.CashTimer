using ClubArcada.Common;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace ClubArcada.Apps.CashTimer.Win.Controls
{
    public partial class TextBoxCtrl : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public TextBoxCtrl()
        {
            InitializeComponent();
            DataContext = this;
        }

        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string),typeof(TextBoxCtrl), new FrameworkPropertyMetadata(string.Empty));

        public string Label
        {
            get
            {
                return (string)GetValue(LabelProperty);
            }
            set
            {
                SetValue(LabelProperty, value);
                PropertyChanged.Raise(() => Label);
            }
        }

    }
}
