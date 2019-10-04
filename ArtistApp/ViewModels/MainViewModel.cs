using System;
using System.Collections.Generic;
using System.Text;

namespace ArtistApp.ViewModels
{
    class MainViewModel
    {
        // LoginViewModel
        public LoginViewModel Login { get; set; }

        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
    }
}
