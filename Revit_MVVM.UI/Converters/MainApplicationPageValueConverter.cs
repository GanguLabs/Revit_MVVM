using Revit_MVVM.Core;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Revit_MVVM.UI
{
    internal class MainApplicationPageValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ApplicationPageType)value)
            {
                case ApplicationPageType.Family:
                    return new FamilyPage();
                case ApplicationPageType.Preferences:
                    return new PreferencesPage();
                default:
                    return new FamilyPage();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
