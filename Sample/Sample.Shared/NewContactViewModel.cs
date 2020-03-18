using System;
using System.Collections.ObjectModel;
using System.Reactive;
using ReactiveUI;
using Uno.Extensions;

namespace Sample.Shared
{
    public class NewContactViewModel : ReactiveObject
    {
        public NewContactViewModel(ObservableCollection<ContactViewModel> contacts)
        {
            var isValid = this
                .WhenAnyValue(model => model.FirstName, model => model.LastName, (fn, sn) => new[] { fn, sn }
                    .None(string.IsNullOrWhiteSpace));

            Add = ReactiveCommand.Create(() => contacts.Add(new ContactViewModel
            {
                FirstName = FirstName,
                LastName = LastName,
            }), isValid);

            Add.Subscribe(_ => Reset());
        }

        private void Reset()
        {
            FirstName = "";
            LastName = "";
        }

        public ReactiveCommand<Unit, Unit> Add { get; }

        private string firstName;
        private string lastName;

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