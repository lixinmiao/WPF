﻿/* ==============================================================================
 * 功能描述：BoolReverseToVisibilityConverter  
 * 创 建 者：lixinmiao
 * 创建日期：2017/2/6 9:13:29
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace Infrastructure
{
    /// <summary>
    /// BoolReverseToVisibilityConverter
    /// </summary>
    public class BoolReverseToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool v = (bool)value;
            v = !v;
            if (v)
                return Visibility.Visible;
            else
                return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}