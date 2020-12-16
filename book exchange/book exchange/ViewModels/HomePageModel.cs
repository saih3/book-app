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
                new Event { Title = "Xamarin Forms Masterclass", Image = "book1pic.jpg", Venue = "Register Online", Duration = "07:30 UTC - 09:30 UTC", Date = new DateTime(2020, 6, 8), Description = "This masterclass was design to help you take your Xamarin Forms Development to the next level. Register here: https://bit.ly/2XbkoTG"},
                new Event { Title = "Training: WDC Solution", Image = "book1pic.jpg", Venue = "Zoom Meeting", Duration = "07:30 UTC - 09:30 UTC", Date = new DateTime(2020, 6, 9), Description = "Want to maximize your European vacation? Move through Europe with ease & discover how to travel around Europe by train with as little as possible."},
                new Event { Title = "World Dogs Championship", Image = "book1pic.jpg", Venue = "Virtual Challenge", Duration = "07:30 UTC - 09:30 UTC", Date = new DateTime(2020, 6, 10), Description = "A dog earns a championship with wins at a specified number of conformation shows, where a judge evaluates a dog's breed type and how closely the dog approaches the ideal represented in its breed's standard."},
                new Event { Title = "Book Review Conference", Image = "book1pic.jpg", Venue = "Online", Duration = "07:30 UTC - 09:30 UTC", Date = new DateTime(2020, 6, 11), Description = "And whether you are a publishing insider or simply a book nerd, you should be able to find something to suit you in this list of events in 2020."},
                new Event { Title = "Tea Ceremony", Image = "book1pic.jpg", Venue = "Virtual Meetup", Duration = "07:30 UTC - 09:30 UTC", Date = new DateTime(2020, 6, 12), Description = "The tea ceremony sees the simple task of preparing a drink for a guest elevated to an art form, an intricate series of movements performed in strict order."}
            };
        }
    }


    public class Event
    {
        public string Title { get; set; }
        public string Venue { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
    }
}