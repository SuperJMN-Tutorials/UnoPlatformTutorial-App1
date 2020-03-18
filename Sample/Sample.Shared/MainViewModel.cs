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
                CreateContact("Pablo", "Nieto"),
                CreateContact("Rafa", "Nadal"),
                CreateContact("Robert", "Martin"),
            };

            NewContactViewModel = new NewContactViewModel(Contacts, DeleteRequest);
        }

        private ContactViewModel CreateContact(string firstName, string secondName)
        {
            return new ContactViewModel(DeleteRequest)
            {
                FirstName = firstName,
                LastName = secondName,
            };
        }

        private void DeleteRequest(ContactViewModel toDelete)
        {
            Contacts.Remove(toDelete);
        }

        public NewContactViewModel NewContactViewModel { get; }

        public ObservableCollection<ContactViewModel> Contacts { get; }
    }
}