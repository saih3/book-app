using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using book_exchange.Models;
using book_exchange.Services;

namespace book_exchange.ViewModels
{
    //[DesignTimeVisible(false)]
    public class ChatsViewModel : INotifyPropertyChanged
    {
        private List<Contact> contactsList;

        public List<Contact> ContactsList { get => contactsList; set { contactsList = value; OnPropertyChanged(); } }

        public ChatsViewModel()
        {
 
            var contactService = new ContactService();
            ContactsList = contactService.GetAllContact();
            //MyContacts = GetContacts();
            //Contacts = new ObservableCollection<Contact>
            //    ((IEnumerable<Contact>)Services.ContactService.GetAllContact());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //public ObservableCollection<Contact> MyContacts { get; set; }

        //private ObservableCollection<Contact> _contacts;
        //public ObservableCollection<Contact> Contacts
        //{
        //    get { return _contacts; }
        //    set { SetProperty(ref _contacts, value); }
        //}
    }
}
