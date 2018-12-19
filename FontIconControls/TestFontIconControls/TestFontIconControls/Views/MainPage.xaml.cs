using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestFontIconControls.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : Plugin.FontIconControls.FontIconTabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}