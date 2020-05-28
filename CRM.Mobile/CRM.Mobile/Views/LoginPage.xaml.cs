using CRM.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRM.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            this.BindingContext = new LoginViewModel();
            Email.Completed += Email_Completed;
            Password.Completed += Password_Completed;
        }

        private void Password_Completed(object sender, EventArgs e) {
            LoginViewModel vm = BindingContext as LoginViewModel;
            if (vm != null) {
                vm.ExecuteLoginCommand();
            }

        }

        private void Email_Completed(object sender, EventArgs e) {
            Password.Focus();
        }
    }
}