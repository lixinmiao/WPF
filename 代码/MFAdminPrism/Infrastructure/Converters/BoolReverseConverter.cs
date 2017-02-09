/* ==============================================================================
 * 功能描述：BoolReverseConverter  
 * 创 建 者：lixinmiao
 * 创建日期：2017/2/6 8:58:18
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace Infrastructure
{
    /// <summary>
    /// BoolReverseConverter
    /// </summary>
    public class BoolReverseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           
            bool v = (bool)value;
            
            return !v;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}