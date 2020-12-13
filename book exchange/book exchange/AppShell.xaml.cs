using book_exchange.ViewModels;
using book_exchange.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace book_exchange
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
