using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Plugin.TeachingTipControl
{
    /// <summary>
    /// TeachingTipControl
    /// </summary>
    public class TeachingTipControl : View
    {
        /// <summary>
        /// TitleProperty
        /// </summary>
        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(
                "Title", typeof(string), typeof(TeachingTipControl),
                defaultValue: default(string), propertyChanged: null);

        /// <summary>
        /// Title
        /// </summary>
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        /// <summary>
        /// SubtitleProperty
        /// </summary>
        public static readonly BindableProperty SubtitleProperty =
            BindableProperty.Create(
                "Subtitle", typeof(string), typeof(TeachingTipControl),
                defaultValue: default(string), propertyChanged: null);

        /// <summary>
        /// Subtitle
        /// </summary>
        public string Subtitle
        {
            get { return (string)GetValue(SubtitleProperty); }
            set { SetValue(SubtitleProperty, value); }
        }

        /// <summary>
        /// IsOpenProperty
        /// </summary>
        public static readonly BindableProperty IsOpenProperty =
            BindableProperty.Create(
                "IsOpen", typeof(bool), typeof(TeachingTipControl),
                defaultValue: false, propertyChanged: null);

        /// <summary>
        /// IsOpen
        /// </summary>
        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        /// <summary>
        /// TargetProperty
        /// </summary>
        public static readonly BindableProperty TargetProperty =
            BindableProperty.Create(
                "Target", typeof(object), typeof(TeachingTipControl),
                defaultValue: null, propertyChanged: null);

        /// <summary>
        /// Target
        /// </summary>
        public object Target
        {
            get { return (object)GetValue(TargetProperty); }
            set { SetValue(TargetProperty, value); }
        }

        /// <summary>
        /// IsLightDismissEnabledProperty
        /// </summary>
        public static readonly BindableProperty IsLightDismissEnabledProperty =
            BindableProperty.Create(
                "IsLightDismissEnabled", typeof(bool), typeof(TeachingTipControl),
                defaultValue: false, propertyChanged: null);

        /// <summary>
        /// IsLightDismissEnabled
        /// </summary>
        public bool IsLightDismissEnabled
        {
            get { return (bool)GetValue(IsLightDismissEnabledProperty); }
            set { SetValue(IsLightDismissEnabledProperty, value); }
        }

        /// <summary>
        /// PreferredPlacementProperty
        /// </summary>
        public static readonly BindableProperty PreferredPlacementProperty =
            BindableProperty.Create(
                "PreferredPlacement", typeof(TeachingTipPlacementMode), typeof(TeachingTipControl),
                defaultValue: TeachingTipPlacementMode.Auto, propertyChanged: null);

        /// <summary>
        /// PreferredPlacement
        /// </summary>
        public TeachingTipPlacementMode PreferredPlacement
        {
            get { return (TeachingTipPlacementMode)GetValue(PreferredPlacementProperty); }
            set { SetValue(PreferredPlacementProperty, value); }
        }

        /// <summary>
        /// TailVisibilityProperty
        /// </summary>
        public static readonly BindableProperty TailVisibilityProperty =
            BindableProperty.Create(
                "TailVisibility", typeof(TeachingTipTailVisibility), typeof(TeachingTipControl),
                defaultValue: TeachingTipTailVisibility.Auto, propertyChanged: null);

        /// <summary>
        /// TailVisibility
        /// </summary>
        public TeachingTipTailVisibility TailVisibility
        {
            get { return (TeachingTipTailVisibility)GetValue(TailVisibilityProperty); }
            set { SetValue(TailVisibilityProperty, value); }
        }

        /// <summary>
        /// ShouldConstrainToRootBoundsProperty
        /// </summary>
        public static readonly BindableProperty ShouldConstrainToRootBoundsProperty =
            BindableProperty.Create(
                "ShouldConstrainToRootBounds", typeof(bool), typeof(TeachingTipControl),
                defaultValue: false, propertyChanged: null);

        /// <summary>
        /// ShouldConstrainToRootBounds
        /// </summary>
        public bool ShouldConstrainToRootBounds
        {
            get { return (bool)GetValue(ShouldConstrainToRootBoundsProperty); }
            set { SetValue(ShouldConstrainToRootBoundsProperty, value); }
        }

        /// <summary>
        /// PlacementMarginProperty
        /// </summary>
        public static readonly BindableProperty PlacementMarginProperty =
            BindableProperty.Create(
                "PlacementMargin", typeof(Thickness), typeof(TeachingTipControl),
                defaultValue: new Thickness(), propertyChanged: null);

        /// <summary>
        /// PlacementMargin
        /// </summary>
        public Thickness PlacementMargin
        {
            get { return (Thickness)GetValue(PlacementMarginProperty); }
            set { SetValue(PlacementMarginProperty, value); }
        }

        /// <summary>
        /// HeroContentPlacementProperty
        /// </summary>
        public static readonly BindableProperty HeroContentPlacementProperty =
            BindableProperty.Create(
                "HeroContentPlacement", typeof(TeachingTipHeroContentPlacementMode), typeof(TeachingTipControl),
                defaultValue: TeachingTipHeroContentPlacementMode.Auto, propertyChanged: null);

        /// <summary>
        /// HeroContentPlacement
        /// </summary>
        public TeachingTipHeroContentPlacementMode HeroContentPlacement
        {
            get { return (TeachingTipHeroContentPlacementMode)GetValue(HeroContentPlacementProperty); }
            set { SetValue(HeroContentPlacementProperty, value); }
        }

        /// <summary>
        /// HeroContentProperty
        /// </summary>
        public static readonly BindableProperty HeroContentProperty =
            BindableProperty.Create(
                "HeroContent", typeof(View), typeof(TeachingTipControl),
                defaultValue: null, propertyChanged: null);

        /// <summary>
        /// HeroContent
        /// </summary>
        public View HeroContent
        {
            get { return (View)GetValue(HeroContentProperty); }
            set { SetValue(HeroContentProperty, value); }
        }

        /// <summary>
        /// ContentProperty
        /// </summary>
        public static readonly BindableProperty ContentProperty =
            BindableProperty.Create(
                "Content", typeof(View), typeof(TeachingTipControl),
                defaultValue: null, propertyChanged: null);

        /// <summary>
        /// Content
        /// </summary>
        public View Content
        {
            get { return (View)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        /// <summary>
        /// CloseButtonCommandParameterProperty
        /// </summary>
        public static readonly BindableProperty CloseButtonCommandParameterProperty =
            BindableProperty.Create(
                "CloseButtonCommandParameter", typeof(object), typeof(TeachingTipControl),
                defaultValue: null, propertyChanged: null);

        /// <summary>
        /// CloseButtonCommandParameter
        /// </summary>
        public object CloseButtonCommandParameter
        {
            get { return (object)GetValue(CloseButtonCommandParameterProperty); }
            set { SetValue(CloseButtonCommandParameterProperty, value); }
        }

        /// <summary>
        /// CloseButtonCommandProperty
        /// </summary>
        public static readonly BindableProperty CloseButtonCommandProperty =
            BindableProperty.Create(
                "CloseButtonCommand", typeof(ICommand), typeof(TeachingTipControl),
                defaultValue: null, propertyChanged: null);

        /// <summary>
        /// CloseButtonCommand
        /// </summary>
        public ICommand CloseButtonCommand
        {
            get { return (ICommand)GetValue(CloseButtonCommandProperty); }
            set { SetValue(CloseButtonCommandProperty, value); }
        }

        /// <summary>
        /// ActionButtonCommandParameterProperty
        /// </summary>
        public static readonly BindableProperty ActionButtonCommandParameterProperty =
            BindableProperty.Create(
                "ActionButtonCommandParameter", typeof(object), typeof(TeachingTipControl),
                defaultValue: null, propertyChanged: null);

        /// <summary>
        /// ActionButtonCommandParameter
        /// </summary>
        public object ActionButtonCommandParameter
        {
            get { return (object)GetValue(ActionButtonCommandParameterProperty); }
            set { SetValue(ActionButtonCommandParameterProperty, value); }
        }

        /// <summary>
        /// ActionButtonCommandProperty
        /// </summary>
        public static readonly BindableProperty ActionButtonCommandProperty =
            BindableProperty.Create(
                "ActionButtonCommand", typeof(ICommand), typeof(TeachingTipControl),
                defaultValue: null, propertyChanged: null);

        /// <summary>
        /// ActionButtonCommand
        /// </summary>
        public ICommand ActionButtonCommand
        {
            get { return (ICommand)GetValue(ActionButtonCommandProperty); }
            set { SetValue(ActionButtonCommandProperty, value); }
        }

        /// <summary>
        /// ActionButtonContentProperty
        /// </summary>
        public static readonly BindableProperty ActionButtonContentProperty =
           BindableProperty.Create(
               "ActionButtonContent", typeof(object), typeof(TeachingTipControl),
               defaultValue: null, propertyChanged: null);

        /// <summary>
        /// ActionButtonContent
        /// </summary>
        public object ActionButtonContent
        {
            get { return (object)GetValue(ActionButtonContentProperty); }
            set { SetValue(ActionButtonContentProperty, value); }
        }

        /// <summary>
        /// CloseButtonContentProperty
        /// </summary>
        public static readonly BindableProperty CloseButtonContentProperty =
                   BindableProperty.Create(
                       "CloseButtonContent", typeof(object), typeof(TeachingTipControl),
                       defaultValue: null, propertyChanged: null);

        /// <summary>
        /// CloseButtonContent
        /// </summary>
        public object CloseButtonContent
        {
            get { return (object)GetValue(CloseButtonContentProperty); }
            set { SetValue(CloseButtonContentProperty, value); }
        }

        /// <summary>
        /// IconSourceProperty
        /// </summary>
        public static readonly BindableProperty IconSourceProperty =
                  BindableProperty.Create(
                      "IconSource", typeof(FileImageSource), typeof(TeachingTipControl),
                      defaultValue: null, propertyChanged: null);

        /// <summary>
        /// IconSource
        /// </summary>
        public FileImageSource IconSource
        {
            get { return (FileImageSource)GetValue(IconSourceProperty); }
            set { SetValue(IconSourceProperty, value); }
        }
    }

    /// <summary>
    /// TeachingTipHeroContentPlacementMode
    /// </summary>
    public enum TeachingTipHeroContentPlacementMode
    {
        /// <summary>
        /// Auto
        /// </summary>
        Auto = 0,
        /// <summary>
        /// Top
        /// </summary>
        Top = 1,
        /// <summary>
        /// Bottom
        /// </summary>
        Bottom = 2
    }

    /// <summary>
    /// TeachingTipTailVisibility
    /// </summary>
    public enum TeachingTipTailVisibility
    {
        /// <summary>
        /// Auto
        /// </summary>
        Auto = 0,
        /// <summary>
        /// Visible
        /// </summary>
        Visible = 1,
        /// <summary>
        /// Collapsed
        /// </summary>
        Collapsed = 2
    }

    /// <summary>
    /// TeachingTipPlacementMode
    /// </summary>
    public enum TeachingTipPlacementMode
    {
        /// <summary>
        /// 
        /// </summary>
        Auto = 0,
        /// <summary>
        /// 
        /// </summary>
        Top = 1,
        /// <summary>
        /// 
        /// </summary>
        Bottom = 2,
        /// <summary>
        /// 
        /// </summary>
        Left = 3,
        /// <summary>
        /// 
        /// </summary>
        Right = 4,
        /// <summary>
        /// 
        /// </summary>
        TopRight = 5,
        /// <summary>
        /// 
        /// </summary>
        TopLeft = 6,
        /// <summary>
        /// 
        /// </summary>
        BottomRight = 7,
        /// <summary>
        /// 
        /// </summary>
        BottomLeft = 8,
        /// <summary>
        /// 
        /// </summary>
        LeftTop = 9,
        /// <summary>
        /// 
        /// </summary>
        LeftBottom = 10,
        /// <summary>
        /// 
        /// </summary>
        RightTop = 11,
        /// <summary>
        /// 
        /// </summary>
        RightBottom = 12,
        /// <summary>
        /// 
        /// </summary>
        Center = 13
    }
}
