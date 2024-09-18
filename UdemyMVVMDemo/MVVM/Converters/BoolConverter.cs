using System.Globalization;

namespace UdemyMVVMDemo.MVVM.Converters;

public class BoolConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var answer = value.ToString();
        if (answer == "Yes")
        {
            return true;
        }
        return false;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return null;
    }
}
