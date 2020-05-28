using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CRM.Mobile.ViewModels {
    public class AboutViewModel : BaseViewModel {
        public AboutViewModel() {
            Title = "About";
            OpenWebCommand = new Command(() => Launcher.OpenAsync(new Uri("https://galac.com/")));
        }

        public ICommand OpenWebCommand { get; }
    }
}