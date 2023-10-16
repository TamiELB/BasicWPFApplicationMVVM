using System;
using System.Globalization;
using System.Windows.Data;

namespace BasicWPFApplicationMVVM.Converter
{
    public class CutoffConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((double)value) > Cutoff;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public int Cutoff { get; set; }
    }
}
