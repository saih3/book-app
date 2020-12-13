using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace book_exchange.ViewModels
{
    public class HomePageModel : BaseViewModel
    {
        public HomePageModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}