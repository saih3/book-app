using book_exchange.Services;
using book_exchange.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace book_exchange
{
    public partial class App : Application
    {
        public static string User = "Mia";
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Expander_Experimental" });
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
