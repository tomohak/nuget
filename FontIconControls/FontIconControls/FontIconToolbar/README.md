## FontIconToolbar for UWP(Xamarin.Forms)

Custom Toolbar control with FontIcon for UWP in Xamarin.Forms project.

![fonticontoolbar uwp 2018_11_27 9_20_23](https://user-images.githubusercontent.com/45218829/49050801-7330ed00-f228-11e8-9e00-77a336059b7d.png)

#### SETUP
* NuGet: https://www.nuget.org/packages/Plugin.FontIconControls [![NuGet](https://img.shields.io/nuget/v/Plugin.FontIconControls.svg?label=NuGet)](https://www.nuget.org/packages/Plugin.FontIconControls/)
* Install into Shared project(.Net Standard 2.0) and Platform(UWP) projects.

**Platform Support**

|Platform|Version|
| -------------------  | :------------------: |
|Windows 10 UWP|10.0.16299, 10.0.17134|

#### USAGE

Add the resource dictionary to App.xaml:

* App.xaml

```xml:App.xaml
<Application
    x:Class="Sample.UWP.App"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:Sample.UWP"
    RequestedTheme="Light">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="ms-appx:///Plugin.FontIconControls/Themes/Generic.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>

```

Add the Icon property value to ContentPage for UWP with Unicode point of [Segoe MDL2 icons](https://docs.microsoft.com/en-us/windows/uwp/design/style/segoe-ui-symbol-font):
* ItemsPage.xaml

```xml:ItemsPage.xaml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="Sample.Views.ItemsPage"
              Title="{Binding Title}"
             x:Name="BrowseItemsPage">
    <ContentPage.ToolbarItems>
        <ToolbarItem Text="Add" Clicked="AddItem_Clicked">
            <ToolbarItem.Icon>
                <OnPlatform x:TypeArguments="FileImageSource">
                    <On Platform="UWP" Value="E710"/>
                </OnPlatform>
            </ToolbarItem.Icon>
        </ToolbarItem>
    </ContentPage.ToolbarItems>
    <ContentPage.Content>
	...
    </ContentPage.Content>
</ContentPage>
```

#### LISENCE
MIT
