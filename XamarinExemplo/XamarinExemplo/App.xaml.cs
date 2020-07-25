using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinExemplo.Views;

namespace XamarinExemplo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Page1();
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
