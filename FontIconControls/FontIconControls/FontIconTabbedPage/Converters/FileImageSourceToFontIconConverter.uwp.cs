using System;
using System.Globalization;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Plugin.FontIconControls.UWP.FontIconTabbedPage.Converters
{
    /// <summary>
    /// FileImageSourceToFontIconConverter
    /// </summary>
    public class FileImageSourceToFontIconConverter : IValueConverter
    {
        /// <summary>
        /// Convert
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is Xamarin.Forms.FileImageSource)
            {
                var point = (string)((Xamarin.Forms.FileImageSource)value);

                if (int.TryParse(point, NumberStyles.HexNumber, null, out int number))
                {
                    string s = Char.ConvertFromUtf32(number);
                    return new FontIcon() { FontFamily = new FontFamily("Segoe MDL2 Assets"), Glyph = s };
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
