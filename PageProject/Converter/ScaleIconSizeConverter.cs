using System;
using System.Globalization;
using System.Windows.Data;

namespace PageProject.Converter
{
    public class ScaleIconSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            if (value is null) return 0;
            if (value is not double) return 0;
            if (parameter is null) return 0;
            var conteinerSize = (double)value;
            string Parameter =((string)parameter).Replace('.',',');
            bool ok = double.TryParse(Parameter,out double proportion);
            if (!ok) return 0;
            var iconsize = conteinerSize / proportion;
            return iconsize;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }



    }
}
