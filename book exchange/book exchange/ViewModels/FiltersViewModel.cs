using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using book_exchange.Models;
using book_exchange.Services.Filters;

namespace book_exchange.ViewModels
{
    public class FiltersViewModel : INotifyPropertyChanged
    {
        private List<Subject> subjectList;
        public List<Subject> SubjectsList { get => subjectList; set { subjectList = value; OnPropertyChanged(); } }

        public FiltersViewModel()
        {
            var subjectFilterService = new SubjectFilterService();
            SubjectsList = subjectFilterService.GetAllSubjects();
        }
       
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
