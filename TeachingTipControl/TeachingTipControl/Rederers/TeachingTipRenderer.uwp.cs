using Microsoft.UI.Xaml.Controls;
using Plugin.TeachingTipControl;
using Plugin.TeachingTipControl.UWP.Renderers;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(TeachingTipControl), typeof(TeachingTipRenderer))]
namespace Plugin.TeachingTipControl.UWP.Renderers
{
    /// <summary>
    /// TeachingTipRenderer
    /// </summary>
    public class TeachingTipRenderer : ViewRenderer<Plugin.TeachingTipControl.TeachingTipControl, Microsoft.UI.Xaml.Controls.TeachingTip>
    {
        Microsoft.UI.Xaml.Controls.TeachingTip tip;

        /// <summary>
        /// OnElementChanged
        /// </summary>
        /// <param name="e"></param>
        protected override void OnElementChanged(ElementChangedEventArgs<Plugin.TeachingTipControl.TeachingTipControl> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    tip = new Microsoft.UI.Xaml.Controls.TeachingTip();

                    tip.Closed += (s, args) => 
                    {
                        var tip = s;
                        Element.IsOpen = false;
                    };

                    SetNativeControl(tip);
                }

                UpdateProperty();
            }
        }


        /// <summary>
        /// OnElementPropertyChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            
            UpdateProperty();
        }

        private void UpdateProperty()
        {
            tip.Title = Element.Title;
            tip.Subtitle = Element.Subtitle;
            tip.IsOpen = Element.IsOpen;
            tip.PreferredPlacement = (int)TeachingTipPlacementMode.Auto;
            tip.IsLightDismissEnabled = true;
            tip.TailVisibility = (Microsoft.UI.Xaml.Controls.TeachingTipTailVisibility)Element.TailVisibility;
            tip.ShouldConstrainToRootBounds = Element.ShouldConstrainToRootBounds;
            tip.PlacementMargin = new Windows.UI.Xaml.Thickness(Element.PlacementMargin.Left, Element.PlacementMargin.Top, Element.PlacementMargin.Right, Element.PlacementMargin.Bottom);
            tip.HeroContentPlacement = (Microsoft.UI.Xaml.Controls.TeachingTipHeroContentPlacementMode)Element.HeroContentPlacement;            

            if (Element.HeroContent != null)
            {
                IVisualElementRenderer renderer;
                var view = Element.HeroContent;
                Platform.SetRenderer(view, renderer = Platform.CreateRenderer(view));                
                var native = renderer.GetNativeElement();

                if (native is Windows.UI.Xaml.Controls.Image image)
                    tip.HeroContent = new Windows.UI.Xaml.Controls.Image() { Source = image.Source };
            }
            else
            {
                tip.HeroContent = null;
            }

            if (Element.Content != null)
            {
                IVisualElementRenderer renderer;
                var view = Element.Content;
                Platform.SetRenderer(view, renderer = Platform.CreateRenderer(view));
                var native = renderer.GetNativeElement();
                tip.Content = view;
            }
            else
            {
                tip.Content = null;
            }

            if (Element.IconSource != null)
            {
                var converter = new Plugin.FontIconControls.UWP.Converters.FileImageSourceToFontIconConverter();
                var source = converter.Convert(Element.IconSource, null, null, null);
                if (source is Windows.UI.Xaml.Controls.FontIcon fontIcon)
                    tip.IconSource = new Microsoft.UI.Xaml.Controls.FontIconSource() { FontFamily = fontIcon.FontFamily, Glyph = fontIcon.Glyph };
            }
            else
            {
                tip.IconSource = null;
            }

            tip.CloseButtonCommandParameter = Element.CloseButtonCommandParameter;
            tip.CloseButtonCommand = Element.CloseButtonCommand;
            tip.CloseButtonContent = Element.CloseButtonContent;
            tip.ActionButtonCommandParameter = Element.ActionButtonCommandParameter;
            tip.ActionButtonCommand = Element.ActionButtonCommand;
            tip.ActionButtonContent = Element.ActionButtonContent;

            Windows.UI.Xaml.FrameworkElement control = null;

            switch (Element.Target)
            {
                case Button button:
                    {
                        control = ((ButtonRenderer)button.EffectControlProvider)?.Control;
                        break;
                    }
                case Label label:
                    {
                        control = ((LabelRenderer)label.EffectControlProvider)?.Control;
                        break;
                    }
                case Image image:
                    {
                        control = ((ImageRenderer)image.EffectControlProvider)?.Control;
                        break;
                    }
                case null:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            if (control != null)
                tip.Target = control;
        }
    }
}
