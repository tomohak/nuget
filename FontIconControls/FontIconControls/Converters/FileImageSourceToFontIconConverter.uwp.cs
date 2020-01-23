using System;
using System.Globalization;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Plugin.FontIconControls.UWP.Converters
{
    /// <summary>
    /// FileImageSourceToFontIconConverter
    /// </summary>
    public class FileImageSourceToFontIconConverter : DependencyObject, IValueConverter
    {
        public object BindableParameter
        {
            get { return (object)GetValue(BindableParameterProperty); }
            set { SetValue(BindableParameterProperty, value); }
        }

        public static readonly DependencyProperty BindableParameterProperty =
            DependencyProperty.Register(nameof(BindableParameter), typeof(object), typeof(FileImageSourceToFontIconConverter), new PropertyMetadata(null));
        
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
            else if (value is string && BindableParameter is Xamarin.Forms.ToolbarItem toolbarItem)
            {
                var point = ((Xamarin.Forms.FileImageSource)toolbarItem.IconImageSource)?.File;

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
