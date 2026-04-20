using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Lab20_Binding
{
    public class StringToFontFamilyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string fontName)
                return new FontFamily(fontName);
            return new FontFamily("Arial");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is FontFamily ff)
                return ff.Source;
            return "Arial";
        }
    }
}