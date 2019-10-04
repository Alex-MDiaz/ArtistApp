using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ArtistApp.ViewModels
{
    class LoginViewModel
    {
        // Properties
        public string Email { get; set; }

        public string Password { get; set; }


        // Commands
        public ICommand SignIn
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if (String.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Please enter an email.",
                    "Ok");
                return;
            }

            if (String.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Please enter your password.",
                    "Ok");
                return;
            }
        }

        public ICommand Register { get; set; }
    }
}
