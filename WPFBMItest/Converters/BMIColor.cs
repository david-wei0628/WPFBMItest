using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;

namespace WPFBMItest.Converters
{
    [ValueConversion(typeof(double), typeof(Brush))]
    public class BMIColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return new SolidColorBrush(Colors.Black);
            var v = (double)value;
            if(v == 0) { return new SolidColorBrush(Colors.Black); }
            else if (v < 18.5) { return new SolidColorBrush(Colors.Blue); }
            else if(v > 24) { return new SolidColorBrush(Colors.Red); }
            else { return new SolidColorBrush(Colors.YellowGreen); }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
