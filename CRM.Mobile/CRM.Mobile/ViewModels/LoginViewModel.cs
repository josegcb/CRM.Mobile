using CRM.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XF.Material.Forms.UI.Dialogs;

namespace CRM.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel {
        public Action DisplayInvalidLoginPrompt;
        public Action LoginSusses;
        private string _Email;
        private string _Password;
        
        public string Email {
            get { return _Email; }
            set { SetProperty(ref _Email, value); }
        }
        public string Password {
            get { return _Password; }
            set { SetProperty(ref _Password, value); }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel() {
            Email = "j@j.com";
            Password = "123qwe";
            LoginCommand = new Command(async() => await ExecuteLoginCommand(), CanExecuteLoginCommand);
        }

        public bool CanExecuteLoginCommand() {
            return true;
        }
        async public Task ExecuteLoginCommand() {
            bool vResult = false;
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password)) {
                 await MaterialDialog.Instance.AlertAsync(message: "This is an alert dialog.");
            } else {
                using (await MaterialDialog.Instance.LoadingDialogAsync(message: "Something is running2")) {
                    await Task.Delay(5000);// Represents a task that is running.
                    vResult = false;
                }

                //var loadingDialog = MaterialDialog.Instance.LoadingDialogAsync(message: "Something is running1");                
                ////vResult = CRMApi.Login(new Login() { usernameOrEmailAddress = Email, password = Password });                
                //vResult =Task.Run(() => Task.Delay(5000)).IsCompleted; // Represents a task that is running.
                if (vResult) {
                    await MaterialDialog.Instance.AlertAsync(message: "This is an alert dialog.");
                    //    //App.NavigationService.SetMainPage("Main", "Home");
                    } else {
                    //    loadingDialog.Wait();
                        await MaterialDialog.Instance.AlertAsync(message: "Login faild");
                    }
                }
        }
    }
}
