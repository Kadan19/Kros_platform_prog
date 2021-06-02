using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new App12.Page1();
            //MainPage = new App12._1();
            MainPage = new NavigationPage(new App12.Page1());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
