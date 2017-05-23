using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Data;

namespace AP0 {
  [ValueConversion(typeof(double), typeof(int))]
  public class DoubleToIntConverter : IValueConverter {

    static public DoubleToIntConverter cnvInstance = new DoubleToIntConverter();

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
      if (value != null) {
        double db = (double)value;
        return (int)db;
      }
      return 0;
    
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
      throw new NotImplementedException();
    }
  }
}
