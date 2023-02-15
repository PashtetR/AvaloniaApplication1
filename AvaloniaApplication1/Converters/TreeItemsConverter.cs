using Avalonia.Data.Converters;
using AvaloniaApplication1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication1.Converters
{
     public class TreeItemsConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            Debug.WriteLine("TreeItemsConverter called");
            switch (value)
            {
                case Device device:
                    return new ObservableCollection<string>() { device.Name + "gr1", device.Name + "gr1" };
                case TagGroup tg:
                    return new ObservableCollection<string>() { tg.Name + "tag1", tg.Name + "tag1" };
            }
            return new ObservableCollection<string>() { "Converted device1", "Converted device2" }; ;
        }



        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
