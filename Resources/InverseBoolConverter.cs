﻿namespace ConvolutionImageProcessing.Resources {
    using System.Globalization;
    using System.Windows.Data;

    public class InverseBoolConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if(value is bool b) return !b;
            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            if(value is bool b) return !b;
            return true;
        }
    }
}
