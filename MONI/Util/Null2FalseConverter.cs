﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MONI.Util
{
  public class Null2FalseConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
      return value != null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
      return null;
    }
  }
}