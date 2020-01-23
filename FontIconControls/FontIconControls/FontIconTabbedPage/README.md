## FontIconTabbedPage Control for UWP(Xamarin.Forms)

Custom TabbedPage control with FontIcon for UWP in Xamarin.Forms project.

![fonticontabbedpage uwp 2018_11_22 14_48_02](https://user-images.githubusercontent.com/45218829/48885451-bcb9ba80-ee6b-11e8-81bf-c2c9f982a5fd.png)

#### SETUP
* NuGet: https://www.nuget.org/packages/Plugin.FontIconControls [![NuGet](https://img.shields.io/nuget/v/Plugin.FontIconControls.svg?label=NuGet)](https://www.nuget.org/packages/Plugin.FontIconControls/)
* Install into Shared project(.Net Standard 2.0) and Platform(UWP) projects.

**Platform Support**

|Platform|Version|
| -------------------  | :------------------: |
|Windows 10 UWP|10.0.16299, 10.0.17134, 10.0.18362|

#### USAGE

Add the xmlns namespace to the MainPage.xaml in your Shared project:

```xml
xmlns:controls="clr-namespace:Plugin.FontIconControls;assembly=Plugin.FontIconControls"
```

Change the control from TabbedPage to FontIconTabbedPage:

* MainPage.xaml

```xml:MainPage.xaml
<?xml version="1.0" encoding="utf-8" ?>
<controls:FontIconTabbedPage xmlns="http://xamarin.com/schemas/2014/forms"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            xmlns:views="clr-namespace:Sample.Views"
            x:Class="Sample.Views.MainPage"
            xmlns:controls="clr-namespace:Plugin.FontIconControls;assembly=Plugin.FontIconControls">
...
</controls:FontIconTabbedPage>
```

* MainPage.xaml.cs

```C#:MainPage.xaml.cs
namespace Sample.Views
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
```

Add the Icon property value for UWP with Unicode point of [Segoe MDL2 icons](https://docs.microsoft.com/en-us/windows/uwp/design/style/segoe-ui-symbol-font):
* MainPage.xaml

```xml:MainPage.xaml
<NavigationPage Title="Browse">
    <NavigationPage.Icon>
        <OnPlatform x:TypeArguments="FileImageSource">
            <On Platform="UWP" Value="EA37"/>
            <On Platform="iOS" Value="tab_feed.png"/>
        </OnPlatform>
    </NavigationPage.Icon>
    <x:Arguments>
        <views:ItemsPage />
    </x:Arguments>
</NavigationPage>
```

#### LISENCE
MIT
