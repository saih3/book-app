/*using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace book_exchange.ViewModels
{
    public class HomePageModel : BaseViewModel
    {


        public HomePageModel()
        {
            Title = "Home";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }
        public ICommand OpenWebCommand { get; }
    }
}*/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace book_exchange.ViewModels
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public class HomePageModel : BaseViewModel
    {
        public HomePageModel()
        {
            MyEvents = GetEvents();

        }

        public ObservableCollection<Event> MyEvents { get; set; }

        private ObservableCollection<Event> GetEvents()
        {
            return new ObservableCollection<Event>
            {
                new Event { Title = "Introduction to Algorithms", Image = "book1pic.jpg", Author = "Thomas H. Cormen, Charles E. Leiserson, Ronald Rivest, Clifford Stein", Location = "On Campus", Date = new DateTime(2020, 6, 8), Description = "DM me if you want this book! I am available to give it to you from Monday to Friday right after common lunch. Preferably meet at Reamer."},
                new Event { Title = "Introduction to Algorithms", Image = "book1pic.jpg", Author = "Thomas H. Cormen, Charles E. Leiserson, Ronald Rivest, Clifford Stein", Location = "On Campus", Date = new DateTime(2020, 6, 8), Description = "DM me if you want this book! I am available to give it to you from Monday to Friday right after common lunch. Preferably meet at Reamer."},
                new Event { Title = "Introduction to Algorithms", Image = "book1pic.jpg", Author = "Thomas H. Cormen, Charles E. Leiserson, Ronald Rivest, Clifford Stein", Location = "On Campus", Date = new DateTime(2020, 6, 8), Description = "DM me if you want this book! I am available to give it to you from Monday to Friday right after common lunch. Preferably meet at Reamer."},
                new Event { Title = "Introduction to Algorithms", Image = "book1pic.jpg", Author = "Thomas H. Cormen, Charles E. Leiserson, Ronald Rivest, Clifford Stein", Location = "On Campus", Date = new DateTime(2020, 6, 8), Description = "DM me if you want this book! I am available to give it to you from Monday to Friday right after common lunch. Preferably meet at Reamer."},
                new Event { Title = "Introduction to Algorithms", Image = "book1pic.jpg", Author = "Thomas H. Cormen, Charles E. Leiserson, Ronald Rivest, Clifford Stein", Location = "On Campus", Date = new DateTime(2020, 6, 8), Description = "DM me if you want this book! I am available to give it to you from Monday to Friday right after common lunch. Preferably meet at Reamer."},
            };
        }

     
    }


  /*  public class Event
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
    }*/
}