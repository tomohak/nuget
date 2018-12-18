using Plugin.FontIconControls;
using Plugin.FontIconControls.UWP.FontIconTabbedPage.Renderers;
using Windows.UI.Xaml.Markup;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(FontIconTabbedPage), typeof(FontIconTabbedPageRenderer))]
namespace Plugin.FontIconControls.UWP.FontIconTabbedPage.Renderers
{
    /// <summary>
    /// FontIconTabbedPageRenderer
    /// </summary>
    public class FontIconTabbedPageRenderer : TabbedPageRenderer
    {
        /// <summary>
        /// OnElementChanged
        /// </summary>
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var xamlStr = @"<DataTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' 
                            xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml' 
                            xmlns:local='using:Plugin.FontIconControls' 
                            xmlns:converters='using:Plugin.FontIconControls.UWP.FontIconTabbedPage.Converters'>
                            <StackPanel x:Name='TabbedPageHeaderPanel'>
                                <StackPanel.Resources>
                                    <converters:FileImageSourceToFontIconConverter x:Key='FileImageSourceToFontIconConverter'/>
                                </StackPanel.Resources>
                                <ContentPresenter Name='TabbedPageHeaderIcon' Content='{Binding Icon, Converter={StaticResource ResourceKey=FileImageSourceToFontIconConverter}}'/>
                                <TextBlock Name='TabbedPageHeaderTextBlock' Text='{Binding Title}' Style='{ThemeResource BodyTextBlockStyle}'/>
                            </StackPanel>
                        </DataTemplate>";

                var template = (Windows.UI.Xaml.DataTemplate)XamlReader.LoadWithInitialTemplateValidation(xamlStr);

                if (template != null)
                    Control.HeaderTemplate = template;
            }
        }
    }
}
