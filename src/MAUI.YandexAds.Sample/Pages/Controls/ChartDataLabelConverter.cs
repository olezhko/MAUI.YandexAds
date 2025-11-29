using MAUI.YandexAds.Sample.Models;
using System;
using System.Globalization;

namespace MAUI.YandexAds.Sample.Pages.Controls
{
    public class ChartDataLabelConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is CategoryChartData categoryData && parameter is string parameterValue)
            {
                if (string.Equals(parameterValue, "title", StringComparison.OrdinalIgnoreCase))
                {
                    return categoryData.Title;
                }

                if (string.Equals(parameterValue, "count", StringComparison.OrdinalIgnoreCase))
                {
                    return categoryData.Count.ToString();
                }

                return value?.ToString();
            }

            return value?.ToString();
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
