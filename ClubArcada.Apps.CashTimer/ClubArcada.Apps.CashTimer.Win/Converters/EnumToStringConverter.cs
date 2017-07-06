using ClubArcada.Common;
using System;
using System.Globalization;
using System.Windows.Data;

namespace ClubArcada.Apps.CashTimer.Win.Converters
{
    public class EnumToStringConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((eCashTableGameType)value).GetDescription();
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new Exception();
        }

        #endregion
    }
}
