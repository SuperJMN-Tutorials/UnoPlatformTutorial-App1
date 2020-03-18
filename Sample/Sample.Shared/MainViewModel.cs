using System.Collections.ObjectModel;
using ReactiveUI;

namespace Sample.Shared
{
    public class MainViewModel : ReactiveObject
    {
        public MainViewModel()
        {
            Contacts = new ObservableCollection<ContactViewModel>()
            {
                new ContactViewModel()
                {
                    FirstName= "Pablo",
                    LastName = "Nieto",
                },
                new ContactViewModel()
                {
                    FirstName= "Rafa",
                    LastName = "Nadal",
                },
                new ContactViewModel()
                {
                    FirstName= "Robert",
                    LastName = "Martin",
                },
            };
        }

        public ObservableCollection<ContactViewModel> Contacts { get; }
    }
}