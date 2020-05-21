using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestTeachingTipControl.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public Command ActionButtonCommand { get; set; }
        public Command CloseButtonCommand { get; set; }

        public MainPageViewModel()
        {
            Title = "MainPage";
            ActionButtonCommand = new Command(async () => await ExecuteActionButtonCommand());
            CloseButtonCommand = new Command(async () => await ExecuteCloseButtonCommand());
        }

        async Task ExecuteActionButtonCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                await Task.Delay(1);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        async Task ExecuteCloseButtonCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                await Task.Delay(1);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
