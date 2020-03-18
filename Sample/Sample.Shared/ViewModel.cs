using ReactiveUI;
using Uno.Extensions;

namespace Sample.Shared
{
    public class ViewModel : ReactiveObject
    {
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