using System;
using System.Globalization;
using System.Linq;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Plugin.FontIconControls.UWP.FontIconToolbar.Converters
{
    /// <summary>
    /// BitmapIconToFontIconConverter
    /// </summary>
    public class BitmapIconToFontIconConverter : IValueConverter
    {
        /// <summary>
        /// Convert
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            // https://github.com/xamarin/Xamarin.Forms/blob/master/Xamarin.Forms.Platform.UAP/Platform.cs#L395
            // https://github.com/xamarin/Xamarin.Forms/blob/master/Xamarin.Forms.Platform.UAP/FileImageSourcePathConverter.cs
            if (value is BitmapIcon)
            {
                if (((BitmapIcon)value).UriSource.Segments.Count() > 1)
                {
                    var point = ((BitmapIcon)value).UriSource.Segments[1];

                    if (int.TryParse(point, NumberStyles.HexNumber, null, out int number))
                    {
                        string s = Char.ConvertFromUtf32(number);
                        return new FontIcon() { FontFamily = new FontFamily("Segoe MDL2 Assets"), Glyph = s };
                    }
                }
            }

            return value;
        }

        /// <summary>
        /// ConvertBack
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
