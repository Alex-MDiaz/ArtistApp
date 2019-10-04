using System;
using System.Collections.Generic;
using System.Text;
using ArtistApp.ViewModels;


namespace ArtistApp.Infrastructure
{
    class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
