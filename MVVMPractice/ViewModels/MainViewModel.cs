using System;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace MVVMPractice.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _helloMessage;
        public string Name { get; set; }
        public string HelloMessage
        {
            get
            {
                return _helloMessage;
            }
            set
            {
                _helloMessage = value;

                OnPropertyChanged();
            }
        }
        public Command SayHelloCOmmand
        {
            get
            {
                return new Command(() =>
                {
                    HelloMessage = "Hello " + Name;
                });
            }
        }

        public MainViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberNameAttribute] string propertyName = null){
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
