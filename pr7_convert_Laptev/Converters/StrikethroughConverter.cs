using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace pr7_convert_Laptev.Converters
{
    public class StrikethroughConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }

            try
            {
                double val = System.Convert.ToDouble(value);
                if (val > 0)
                {
                    return TextDecorations.Strikethrough;
                }
            }
            catch
            {
                return null;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
