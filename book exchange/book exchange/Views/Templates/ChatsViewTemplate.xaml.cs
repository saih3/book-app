﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace book_exchange.Views.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatsViewTemplate : ContentView
    {
        public ChatsViewTemplate()
        {
            InitializeComponent();
        }
        //private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    var imageSender = (CachedImage)sender;
        //    await Navigation.PushPopupAsync(new ChatProfileSelectionPopupView(imageSender.Source));

        //}
    }
}