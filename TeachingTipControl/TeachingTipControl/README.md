## TeachingTipControl for UWP(Xamarin.Forms)

Custom TeachingTip congrol for UWP in Xamarin.Forms project.

#### SETUP
* NuGet: https://www.nuget.org/packages/Plugin.TeachingTipControl [![NuGet](https://img.shields.io/nuget/v/Plugin.TeachingTipControl.svg?label=NuGet)](https://www.nuget.org/packages/Plugin.TeachingTipControl/)
* Install into Shared project(.Net Standard 2.0) and Platform(UWP) projects.

**Platform Support**

|Platform|Version|
| -------------------  | :------------------: |
|Windows 10 UWP|10.0.18362|

#### USAGE

Add the xmlns namespace to ContentPage in your Shared project:

```xml
xmlns:controls="clr-namespace:Plugin.FontIconControls;assembly=Plugin.FontIconControls"
```

Add the TeachingTipControl to ContentPage:
* MainPage.xaml

```xml:MainPage.xaml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:d="http://xamarin.com/schemas/2014/forms/design"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
             xmlns:controls="clr-namespace:Plugin.TeachingTipControl;assembly=Plugin.TeachingTipControl"
             xmlns:vm="clr-namespace:TestTeachingTipControl.ViewModels"
             mc:Ignorable="d"
             x:Class="TestTeachingTipControl.MainPage">
    <ContentPage.BindingContext>
        <vm:MainPageViewModel />
    </ContentPage.BindingContext>
    <StackLayout>
        <!-- Place new controls here -->
        <Label x:Name="label1"
           Text="Welcome to Xamarin.Forms!" 
           HorizontalOptions="Center"
           VerticalOptions="CenterAndExpand" >
            <Label.GestureRecognizers>
                <TapGestureRecognizer Tapped="TapGestureRecognizer_Tapped"/>
            </Label.GestureRecognizers>
        </Label>

        <controls:TeachingTipControl x:Name="tip_label"
                              Title="title1"
                              Subtitle="subtile1"
                              Target="{x:Reference label1}"
                              TailVisibility="Visible"
                              ActionButtonCommand="{Binding ActionButtonCommand}"
                              CloseButtonCommand="{Binding CloseButtonCommand}"
                              ActionButtonContent="Action"
                              CloseButtonContent="Got it!">
            <controls:TeachingTipControl.HeroContent>
                <Image x:Name="image1" Source="Hero.jpg"/>
            </controls:TeachingTipControl.HeroContent>
            <controls:TeachingTipControl.Content>
                <Label Margin="0,16,0,0">Sample Content</Label>
            </controls:TeachingTipControl.Content>
            <controls:TeachingTipControl.IconSource>
                <OnPlatform x:TypeArguments="FileImageSource">
                    <On Platform="UWP" Value="EA37"/>
                </OnPlatform>
            </controls:TeachingTipControl.IconSource>
        </controls:TeachingTipControl>
    </StackLayout>
</ContentPage>
```

* MainPage.xaml.cs

```C#:MainPage.xaml.cs
public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            tip_label.IsOpen = !tip_label.IsOpen;
        }
    }
```

#### LISENCE
MIT
