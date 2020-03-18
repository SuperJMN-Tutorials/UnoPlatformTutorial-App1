using System;
using System.Reactive;
using ReactiveUI;

namespace Sample.Shared
{
    public class ContactViewModel : ReactiveObject
    {
        private string firstName;
        private string lastName;

        public ContactViewModel(Action<ContactViewModel> deleteRequest)
        {
            DeleteCommand = ReactiveCommand.Create(() => deleteRequest(this));
        }

        public ReactiveCommand<Unit, Unit> DeleteCommand { get; }

        public string FirstName
        {
            get => firstName;
            set => this.RaiseAndSetIfChanged(ref firstName, value);
        }

        public string LastName
        {
            get => lastName;
            set => this.RaiseAndSetIfChanged(ref lastName, value);
        }
    }
}