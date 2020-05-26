using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace CRM.Mobile.ViewModels {
    public class AboutViewModel : BaseViewModel {
        public AboutViewModel() {
            Title = "About";
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://galac.com/")));
        }

        public ICommand OpenWebCommand { get; }
    }
}