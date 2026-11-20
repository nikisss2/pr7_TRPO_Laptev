using System;
using System.Globalization;
using System.Windows.Data;

namespace pr7_convert_Laptev.Converters
{
    public class DiscountConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return "";
            }


            try
            {
                double val = System.Convert.ToDouble(value);
                double percent = val * 100;
                return percent.ToString();
            }
            catch
            {
                return "";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return 0;
            }


            try
            {
                double val = System.Convert.ToDouble(value);
                return val / 100.0;
            }
            catch
            {
                return 0;
            }
        }
    }
}
