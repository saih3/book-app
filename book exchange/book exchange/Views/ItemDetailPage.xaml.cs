using book_exchange.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace book_exchange.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}