using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Data;
using System.Globalization;

namespace Stockness.Core
{
    public class PriceDeltaColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double && value != null)
            {
                if ( (double)value >=0)
                {
                    return new SolidColorBrush(Color.FromArgb(200, 107, 214, 121));
                }
                return new SolidColorBrush(Color.FromArgb(200, 245, 103, 32));
            }
            else
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
